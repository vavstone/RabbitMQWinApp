using RabbitMQCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitMQWinApp
{
    public partial class Form1 : Form
    {
        MQWorker worker;

        const string btStartStopTextToStart = "Запустить получение сообщений";
        const string btStartStopTextToStop = "Остановить получение сообщений";
        
        bool serverPrmsChanged;

        string PathApi
        {
            get { return $"http://{tbServerName.Text}:{tbAdminPort.Text}/api/"; }
        }
        string PathGetExchanges
        {
            get { return $"{PathApi}exchanges"; }
        }
        string PathGetQueues
        {
            get { return $"{PathApi}queues"; }
        }
        string PathGetBindigns
        {
            get { return $"{PathApi}bindings"; }
        }
        string AdminUserName
        {
            get { return tbAdminUserName.Text; }
        }
        string AdminPassword
        {
            get { return tbAdminPassword.Text; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbServerName.TextChanged += tbServerPrms_TextChanged;
            tbVirtualHost.TextChanged += tbServerPrms_TextChanged;
            tbPort.TextChanged += tbServerPrms_TextChanged;
            tbUserName.TextChanged += tbServerPrms_TextChanged;
            tbPassword.TextChanged += tbServerPrms_TextChanged;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (worker != null)
                worker.Dispose();
        }

        void CreateWorker()
        {
            if (worker != null)
                worker.Dispose();
            int? port = null;
            if (!string.IsNullOrWhiteSpace(tbPort.Text))
                port = int.Parse(tbPort.Text);
            worker = new MQWorker(tbServerName.Text, port, tbVirtualHost.Text, tbUserName.Text, tbPassword.Text);
        }

        private void tbServerPrms_TextChanged(object sender, EventArgs e)
        {
            serverPrmsChanged = true;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (worker == null || serverPrmsChanged) CreateWorker();
                var res = worker.SendMessage(tbMessage.Text, cbExchange.Text, tbRoutingKey.Text, cbPersistent.Checked);
                if (string.IsNullOrWhiteSpace(res))
                    res = "Cообщение отправлено";
                SetResult($"{DateTime.Now.ToString("HH:mm:ss")}. " + res, false);
            }
            catch (Exception ex)
            {
                SetResult($"{DateTime.Now.ToString("HH:mm:ss")}. " + ex.Message, true);
            }
        }

        private void btStartStop_Click(object sender, EventArgs e)
        {
            var toStart = btStartStop.Text == btStartStopTextToStart ? true : false;
            btStartStop.Text = toStart ? btStartStopTextToStop : btStartStopTextToStart;
            int? port = null;
            if (!string.IsNullOrWhiteSpace(tbPort.Text))
                port = int.Parse(tbPort.Text);
            try
            {
                if (worker != null)
                {
                    worker.MessageReceivedEvent -= Worker_MessageReceivedEvent;
                }
                if (toStart)
                {
                    worker = new MQWorker(tbServerName.Text, port, tbVirtualHost.Text, tbUserName.Text, tbPassword.Text);
                    worker.MessageReceivedEvent += Worker_MessageReceivedEvent;
                    worker.StartRecievingMessages(cbQueue.Text, cbUseTempQueue.Checked);
                    SetResult($"{DateTime.Now.ToString("HH:mm:ss")}. Запущено получение сообщений", false);
                }
                else
                {
                    worker.StopReceivingMessages();
                    worker.Dispose();
                    worker = null;
                    SetResult($"{DateTime.Now.ToString("HH:mm:ss")}. Остановлено получение сообщений", false);
                }
            }
            catch (Exception ex)
            {
                SetResult(ex.Message, true);
            }
        }

        void SetResult(string message, bool isError)
        {
            var lblResult = statusStrip.Items[0] as ToolStripStatusLabel;
            lblResult.Text = message;
        }

        private void Worker_MessageReceivedEvent(object sender, MQReceivedEventArgs e)
        {
            Invoke(new Action(() => AddReceivedMessage(e.Message)));
        }

        void AddReceivedMessage(string message)
        {
            tbMessages.Text += message;
            tbMessages.Text += Environment.NewLine;
            tbMessages.Text += "----------------------------------------------------";
            tbMessages.Text += Environment.NewLine;
        }

        private async void btGetServerConfig_Click(object sender, EventArgs e)
        {
            await GetServerConfig();            
        }

        async Task GetServerConfig()
        {
            var taskGetExchanges = await MQWorker.GetMQObjectsListAsync<MQExchange>(PathGetExchanges, AdminUserName, AdminPassword);
            dgExchanges.DataSource = taskGetExchanges;
            var taskGetQueues = await MQWorker.GetMQObjectsListAsync<MQQueue>(PathGetQueues, AdminUserName, AdminPassword);
            dgQueues.DataSource = taskGetQueues;
            var taskGetBindings = await MQWorker.GetMQObjectsListAsync<MQBinding>(PathGetBindigns, AdminUserName, AdminPassword);
            dgBindings.DataSource = taskGetBindings;

            cbExchanges.DataSource = taskGetExchanges;
            cbExchanges.DisplayMember = "Name";

            cbQueues.DataSource = taskGetQueues;
            cbQueues.DisplayMember = "Name";

            cbQueue.DataSource = taskGetQueues;
            cbQueue.DisplayMember = "Name";

            cbExchange.DataSource = taskGetExchanges;
            cbExchange.DisplayMember = "Name";
        }

        private async void btCreateExchange_Click(object sender, EventArgs e)
        {
            if (worker == null)
                CreateWorker();
            MQExchangeTypes exchangeType;
            if (rbExchangeDirect.Checked) exchangeType = MQExchangeTypes.direct;
            else if (rbExchangeFanout.Checked) exchangeType = MQExchangeTypes.fanout;
            else if (rbExchangeHeaders.Checked) exchangeType = MQExchangeTypes.headers;
            else exchangeType = MQExchangeTypes.topic;
            worker.CreateExchange(tbNewExchange.Text, exchangeType, cbExchangeDurable.Checked, cbExchangeAutoDelete.Checked);
            await GetServerConfig();
        }

        private async void btCreateQueue_Click(object sender, EventArgs e)
        {
            if (worker == null)
                CreateWorker();
            worker.CreateQueue(tbNewQueue.Text, cbQueueDurable.Checked, cbQueueExclusive.Checked, cbQueueAutoDelete.Checked);
            await GetServerConfig();
        }

        private async void btCreateBinding_Click(object sender, EventArgs e)
        {
            if (worker == null)
                CreateWorker();
            worker.BindQueue(cbQueues.Text, cbExchanges.Text, tbBindingRoutingKey.Text);
            await GetServerConfig();
        }

        private void dg_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    var dg = sender as DataGridView;
                    dg.CurrentCell = dgExchanges.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dg.Rows[e.RowIndex].Selected = true;
                    dg.Focus();
                }
                catch (Exception ex) { }
            }
        }

        private async void dgContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                var item = e.ClickedItem;
                if (item.Text == "Удалить")
                {
                    var gridName = ((sender as ContextMenuStrip).SourceControl as DataGridView).Name;
                    switch (gridName)
                    {
                        case "dgExchanges":
                            var exchangeName = dgExchanges.SelectedRows[0].Cells[0].Value.ToString();
                            var vHost = dgExchanges.SelectedRows[0].Cells[1].Value.ToString().Replace("/", "%2f");
                            if (MessageBox.Show(null, $"Удалить exchange {exchangeName}?","Подтверждение удаления", 
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning,  MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                var result = await MQWorker.DeleteMQObject($"{PathGetExchanges}/{vHost}/{exchangeName}", AdminUserName, AdminPassword);
                                MessageBox.Show(result);
                                await GetServerConfig();
                            }
                            break;
                        case "dgQueues":
                            var queueName = dgQueues.SelectedRows[0].Cells[0].Value.ToString();
                            vHost = dgQueues.SelectedRows[0].Cells[1].Value.ToString().Replace("/", "%2f");
                            if (MessageBox.Show(null, $"Удалить queue {queueName}?", "Подтверждение удаления",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                var result = await MQWorker.DeleteMQObject($"{PathGetQueues}/{vHost}/{queueName}", AdminUserName, AdminPassword);
                                MessageBox.Show(result);
                                await GetServerConfig();
                            }
                            break;
                        case "dgBindings":
                            exchangeName = dgBindings.SelectedRows[0].Cells[0].Value.ToString();
                            vHost = dgBindings.SelectedRows[0].Cells[1].Value.ToString().Replace("/", "%2f");
                            queueName = dgBindings.SelectedRows[0].Cells[2].Value.ToString();
                            var routingKey = dgBindings.SelectedRows[0].Cells[4].Value.ToString();
                            if (MessageBox.Show(null, $"Удалить binding {exchangeName}/{queueName} с routingKey {routingKey}?", "Подтверждение удаления",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                if (string.IsNullOrWhiteSpace(routingKey)) routingKey = "~";
                                if (string.IsNullOrWhiteSpace(exchangeName)) exchangeName = "~";
                                var result = await MQWorker.DeleteMQObject($"{PathGetBindigns}/{vHost}/e/{exchangeName}/q/{queueName}/{routingKey}", AdminUserName, AdminPassword);
                                MessageBox.Show(result);
                                await GetServerConfig();
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)  { }
        }
    }
}
