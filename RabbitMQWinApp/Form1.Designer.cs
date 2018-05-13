namespace RabbitMQWinApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbVirtualHost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.tbServerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btSend = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbExchange = new System.Windows.Forms.ComboBox();
            this.tbRoutingKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPersistent = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btStartStop = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbMessages = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbQueue = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbUseTempQueue = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.dgQueues = new System.Windows.Forms.DataGridView();
            this.dgContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgBindings = new System.Windows.Forms.DataGridView();
            this.dgExchanges = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.tbAdminPort = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbAdminPassword = new System.Windows.Forms.TextBox();
            this.tbAdminUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btCreateBinding = new System.Windows.Forms.Button();
            this.tbBindingRoutingKey = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbQueues = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbExchanges = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btCreateQueue = new System.Windows.Forms.Button();
            this.cbQueueExclusive = new System.Windows.Forms.CheckBox();
            this.cbQueueDurable = new System.Windows.Forms.CheckBox();
            this.cbQueueAutoDelete = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbNewQueue = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNewExchange = new System.Windows.Forms.TextBox();
            this.cbExchangeDurable = new System.Windows.Forms.CheckBox();
            this.cbExchangeAutoDelete = new System.Windows.Forms.CheckBox();
            this.btCreateExchange = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbExchangeHeaders = new System.Windows.Forms.RadioButton();
            this.rbExchangeDirect = new System.Windows.Forms.RadioButton();
            this.rbExchangeTopic = new System.Windows.Forms.RadioButton();
            this.rbExchangeFanout = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.btGetServerConfig = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQueues)).BeginInit();
            this.dgContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBindings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExchanges)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbVirtualHost
            // 
            this.tbVirtualHost.Location = new System.Drawing.Point(426, 11);
            this.tbVirtualHost.Name = "tbVirtualHost";
            this.tbVirtualHost.Size = new System.Drawing.Size(130, 20);
            this.tbVirtualHost.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Виртуальный хост";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(795, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Пользователь";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(848, 11);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(129, 20);
            this.tbPassword.TabIndex = 26;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(652, 11);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(135, 20);
            this.tbUserName.TabIndex = 25;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(242, 11);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(69, 20);
            this.tbPort.TabIndex = 24;
            this.tbPort.Text = "5672";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(202, 11);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(32, 13);
            this.lblPort.TabIndex = 23;
            this.lblPort.Text = "Порт";
            // 
            // tbServerName
            // 
            this.tbServerName.Location = new System.Drawing.Point(79, 11);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(115, 20);
            this.tbServerName.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "IP сервера";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1169, 593);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1161, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отправка";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btSend);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 533);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1155, 31);
            this.panel5.TabIndex = 29;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(5, 5);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(153, 23);
            this.btSend.TabIndex = 19;
            this.btSend.Text = "Отправить сообщение";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbMessage);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1155, 479);
            this.panel4.TabIndex = 28;
            // 
            // tbMessage
            // 
            this.tbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMessage.Location = new System.Drawing.Point(0, 0);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(1155, 479);
            this.tbMessage.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbExchange);
            this.panel3.Controls.Add(this.tbRoutingKey);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbPersistent);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1155, 82);
            this.panel3.TabIndex = 27;
            // 
            // cbExchange
            // 
            this.cbExchange.FormattingEnabled = true;
            this.cbExchange.Location = new System.Drawing.Point(105, 9);
            this.cbExchange.Name = "cbExchange";
            this.cbExchange.Size = new System.Drawing.Size(268, 21);
            this.cbExchange.TabIndex = 27;
            // 
            // tbRoutingKey
            // 
            this.tbRoutingKey.Location = new System.Drawing.Point(105, 35);
            this.tbRoutingKey.Name = "tbRoutingKey";
            this.tbRoutingKey.Size = new System.Drawing.Size(268, 20);
            this.tbRoutingKey.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Текст сообщения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Обмен (exchange)";
            // 
            // cbPersistent
            // 
            this.cbPersistent.AutoSize = true;
            this.cbPersistent.Location = new System.Drawing.Point(392, 12);
            this.cbPersistent.Name = "cbPersistent";
            this.cbPersistent.Size = new System.Drawing.Size(233, 17);
            this.cbPersistent.TabIndex = 25;
            this.cbPersistent.Text = "Хранить в постоянной памяти (persistent)";
            this.cbPersistent.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Routing Key";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.panel8);
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1161, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Получение";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btStartStop);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(3, 534);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1155, 30);
            this.panel8.TabIndex = 41;
            // 
            // btStartStop
            // 
            this.btStartStop.Location = new System.Drawing.Point(5, 3);
            this.btStartStop.Name = "btStartStop";
            this.btStartStop.Size = new System.Drawing.Size(195, 23);
            this.btStartStop.TabIndex = 34;
            this.btStartStop.Text = "Запустить получение сообщений";
            this.btStartStop.UseVisualStyleBackColor = true;
            this.btStartStop.Click += new System.EventHandler(this.btStartStop_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbMessages);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 69);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1155, 495);
            this.panel7.TabIndex = 40;
            // 
            // tbMessages
            // 
            this.tbMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMessages.Location = new System.Drawing.Point(0, 0);
            this.tbMessages.Multiline = true;
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessages.Size = new System.Drawing.Size(1155, 495);
            this.tbMessages.TabIndex = 32;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbQueue);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.cbUseTempQueue);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1155, 66);
            this.panel6.TabIndex = 39;
            // 
            // cbQueue
            // 
            this.cbQueue.FormattingEnabled = true;
            this.cbQueue.Location = new System.Drawing.Point(100, 8);
            this.cbQueue.Name = "cbQueue";
            this.cbQueue.Size = new System.Drawing.Size(240, 21);
            this.cbQueue.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Очередь (queue)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Сообщения";
            // 
            // cbUseTempQueue
            // 
            this.cbUseTempQueue.AutoSize = true;
            this.cbUseTempQueue.Location = new System.Drawing.Point(384, 11);
            this.cbUseTempQueue.Name = "cbUseTempQueue";
            this.cbUseTempQueue.Size = new System.Drawing.Size(203, 17);
            this.cbUseTempQueue.TabIndex = 38;
            this.cbUseTempQueue.Text = "Использовать временную очередь";
            this.cbUseTempQueue.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 35;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Controls.Add(this.panel9);
            this.tabPage3.Controls.Add(this.panel10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1161, 567);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Настройка сервера";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgQueues, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgBindings, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgExchanges, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1155, 314);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(772, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Связи (bindings)";
            // 
            // dgQueues
            // 
            this.dgQueues.AllowUserToAddRows = false;
            this.dgQueues.AllowUserToDeleteRows = false;
            this.dgQueues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQueues.ContextMenuStrip = this.dgContextMenu;
            this.dgQueues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgQueues.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgQueues.Location = new System.Drawing.Point(387, 18);
            this.dgQueues.Name = "dgQueues";
            this.dgQueues.ReadOnly = true;
            this.dgQueues.Size = new System.Drawing.Size(379, 293);
            this.dgQueues.TabIndex = 2;
            this.dgQueues.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_CellMouseDown);
            // 
            // dgContextMenu
            // 
            this.dgContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDeleteItem});
            this.dgContextMenu.Name = "dgContextMenu";
            this.dgContextMenu.Size = new System.Drawing.Size(119, 26);
            this.dgContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dgContextMenu_ItemClicked);
            // 
            // miDeleteItem
            // 
            this.miDeleteItem.Name = "miDeleteItem";
            this.miDeleteItem.Size = new System.Drawing.Size(118, 22);
            this.miDeleteItem.Text = "Удалить";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(387, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Очереди (queues)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Exchanges";
            // 
            // dgBindings
            // 
            this.dgBindings.AllowUserToAddRows = false;
            this.dgBindings.AllowUserToDeleteRows = false;
            this.dgBindings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBindings.ContextMenuStrip = this.dgContextMenu;
            this.dgBindings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBindings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgBindings.Location = new System.Drawing.Point(772, 18);
            this.dgBindings.Name = "dgBindings";
            this.dgBindings.ReadOnly = true;
            this.dgBindings.Size = new System.Drawing.Size(380, 293);
            this.dgBindings.TabIndex = 5;
            this.dgBindings.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_CellMouseDown);
            // 
            // dgExchanges
            // 
            this.dgExchanges.AllowUserToAddRows = false;
            this.dgExchanges.AllowUserToDeleteRows = false;
            this.dgExchanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExchanges.ContextMenuStrip = this.dgContextMenu;
            this.dgExchanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgExchanges.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgExchanges.Location = new System.Drawing.Point(3, 18);
            this.dgExchanges.Name = "dgExchanges";
            this.dgExchanges.ReadOnly = true;
            this.dgExchanges.Size = new System.Drawing.Size(378, 293);
            this.dgExchanges.TabIndex = 0;
            this.dgExchanges.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_CellMouseDown);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label16);
            this.panel9.Controls.Add(this.tbAdminPort);
            this.panel9.Controls.Add(this.label15);
            this.panel9.Controls.Add(this.tbAdminPassword);
            this.panel9.Controls.Add(this.tbAdminUserName);
            this.panel9.Controls.Add(this.label13);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1155, 34);
            this.panel9.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Порт админки";
            // 
            // tbAdminPort
            // 
            this.tbAdminPort.Location = new System.Drawing.Point(89, 3);
            this.tbAdminPort.Name = "tbAdminPort";
            this.tbAdminPort.Size = new System.Drawing.Size(45, 20);
            this.tbAdminPort.TabIndex = 32;
            this.tbAdminPort.Text = "15672";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(152, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Пользователь (админ)";
            // 
            // tbAdminPassword
            // 
            this.tbAdminPassword.Location = new System.Drawing.Point(492, 4);
            this.tbAdminPassword.Name = "tbAdminPassword";
            this.tbAdminPassword.Size = new System.Drawing.Size(130, 20);
            this.tbAdminPassword.TabIndex = 37;
            // 
            // tbAdminUserName
            // 
            this.tbAdminUserName.Location = new System.Drawing.Point(295, 3);
            this.tbAdminUserName.Name = "tbAdminUserName";
            this.tbAdminUserName.Size = new System.Drawing.Size(69, 20);
            this.tbAdminUserName.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(386, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Пароль (админ)";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.groupBox4);
            this.panel10.Controls.Add(this.groupBox3);
            this.panel10.Controls.Add(this.groupBox2);
            this.panel10.Controls.Add(this.btGetServerConfig);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(3, 351);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1155, 213);
            this.panel10.TabIndex = 39;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightGray;
            this.groupBox4.Controls.Add(this.btCreateBinding);
            this.groupBox4.Controls.Add(this.tbBindingRoutingKey);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.cbQueues);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.cbExchanges);
            this.groupBox4.Location = new System.Drawing.Point(596, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 165);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "New binding";
            // 
            // btCreateBinding
            // 
            this.btCreateBinding.Location = new System.Drawing.Point(6, 136);
            this.btCreateBinding.Name = "btCreateBinding";
            this.btCreateBinding.Size = new System.Drawing.Size(139, 23);
            this.btCreateBinding.TabIndex = 17;
            this.btCreateBinding.Text = "Создать Binding";
            this.btCreateBinding.UseVisualStyleBackColor = true;
            this.btCreateBinding.Click += new System.EventHandler(this.btCreateBinding_Click);
            // 
            // tbBindingRoutingKey
            // 
            this.tbBindingRoutingKey.Location = new System.Drawing.Point(6, 110);
            this.tbBindingRoutingKey.Name = "tbBindingRoutingKey";
            this.tbBindingRoutingKey.Size = new System.Drawing.Size(264, 20);
            this.tbBindingRoutingKey.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Routing key";
            // 
            // cbQueues
            // 
            this.cbQueues.FormattingEnabled = true;
            this.cbQueues.Location = new System.Drawing.Point(6, 70);
            this.cbQueues.Name = "cbQueues";
            this.cbQueues.Size = new System.Drawing.Size(264, 21);
            this.cbQueues.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Queue";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Exchange";
            // 
            // cbExchanges
            // 
            this.cbExchanges.FormattingEnabled = true;
            this.cbExchanges.Location = new System.Drawing.Point(6, 33);
            this.cbExchanges.Name = "cbExchanges";
            this.cbExchanges.Size = new System.Drawing.Size(264, 21);
            this.cbExchanges.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.btCreateQueue);
            this.groupBox3.Controls.Add(this.cbQueueExclusive);
            this.groupBox3.Controls.Add(this.cbQueueDurable);
            this.groupBox3.Controls.Add(this.cbQueueAutoDelete);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.tbNewQueue);
            this.groupBox3.Location = new System.Drawing.Point(265, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 165);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New queue";
            // 
            // btCreateQueue
            // 
            this.btCreateQueue.Location = new System.Drawing.Point(9, 136);
            this.btCreateQueue.Name = "btCreateQueue";
            this.btCreateQueue.Size = new System.Drawing.Size(139, 23);
            this.btCreateQueue.TabIndex = 16;
            this.btCreateQueue.Text = "Создать Queue";
            this.btCreateQueue.UseVisualStyleBackColor = true;
            this.btCreateQueue.Click += new System.EventHandler(this.btCreateQueue_Click);
            // 
            // cbQueueExclusive
            // 
            this.cbQueueExclusive.AutoSize = true;
            this.cbQueueExclusive.Location = new System.Drawing.Point(125, 63);
            this.cbQueueExclusive.Name = "cbQueueExclusive";
            this.cbQueueExclusive.Size = new System.Drawing.Size(71, 17);
            this.cbQueueExclusive.TabIndex = 15;
            this.cbQueueExclusive.Text = "Exclusive";
            this.cbQueueExclusive.UseVisualStyleBackColor = true;
            // 
            // cbQueueDurable
            // 
            this.cbQueueDurable.AutoSize = true;
            this.cbQueueDurable.Location = new System.Drawing.Point(125, 17);
            this.cbQueueDurable.Name = "cbQueueDurable";
            this.cbQueueDurable.Size = new System.Drawing.Size(63, 17);
            this.cbQueueDurable.TabIndex = 13;
            this.cbQueueDurable.Text = "Durable";
            this.cbQueueDurable.UseVisualStyleBackColor = true;
            // 
            // cbQueueAutoDelete
            // 
            this.cbQueueAutoDelete.AutoSize = true;
            this.cbQueueAutoDelete.Location = new System.Drawing.Point(125, 40);
            this.cbQueueAutoDelete.Name = "cbQueueAutoDelete";
            this.cbQueueAutoDelete.Size = new System.Drawing.Size(82, 17);
            this.cbQueueAutoDelete.TabIndex = 14;
            this.cbQueueAutoDelete.Text = "Auto Delete";
            this.cbQueueAutoDelete.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Название";
            // 
            // tbNewQueue
            // 
            this.tbNewQueue.Location = new System.Drawing.Point(8, 32);
            this.tbNewQueue.Name = "tbNewQueue";
            this.tbNewQueue.Size = new System.Drawing.Size(100, 20);
            this.tbNewQueue.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.tbNewExchange);
            this.groupBox2.Controls.Add(this.cbExchangeDurable);
            this.groupBox2.Controls.Add(this.cbExchangeAutoDelete);
            this.groupBox2.Controls.Add(this.btCreateExchange);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 168);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New exchange";
            // 
            // tbNewExchange
            // 
            this.tbNewExchange.Location = new System.Drawing.Point(7, 35);
            this.tbNewExchange.Name = "tbNewExchange";
            this.tbNewExchange.Size = new System.Drawing.Size(131, 20);
            this.tbNewExchange.TabIndex = 13;
            // 
            // cbExchangeDurable
            // 
            this.cbExchangeDurable.AutoSize = true;
            this.cbExchangeDurable.Location = new System.Drawing.Point(158, 19);
            this.cbExchangeDurable.Name = "cbExchangeDurable";
            this.cbExchangeDurable.Size = new System.Drawing.Size(63, 17);
            this.cbExchangeDurable.TabIndex = 11;
            this.cbExchangeDurable.Text = "Durable";
            this.cbExchangeDurable.UseVisualStyleBackColor = true;
            // 
            // cbExchangeAutoDelete
            // 
            this.cbExchangeAutoDelete.AutoSize = true;
            this.cbExchangeAutoDelete.Location = new System.Drawing.Point(158, 42);
            this.cbExchangeAutoDelete.Name = "cbExchangeAutoDelete";
            this.cbExchangeAutoDelete.Size = new System.Drawing.Size(82, 17);
            this.cbExchangeAutoDelete.TabIndex = 12;
            this.cbExchangeAutoDelete.Text = "Auto Delete";
            this.cbExchangeAutoDelete.UseVisualStyleBackColor = true;
            // 
            // btCreateExchange
            // 
            this.btCreateExchange.Location = new System.Drawing.Point(4, 139);
            this.btCreateExchange.Name = "btCreateExchange";
            this.btCreateExchange.Size = new System.Drawing.Size(139, 23);
            this.btCreateExchange.TabIndex = 7;
            this.btCreateExchange.Text = "Создать Exchange";
            this.btCreateExchange.UseVisualStyleBackColor = true;
            this.btCreateExchange.Click += new System.EventHandler(this.btCreateExchange_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbExchangeHeaders);
            this.groupBox1.Controls.Add(this.rbExchangeDirect);
            this.groupBox1.Controls.Add(this.rbExchangeTopic);
            this.groupBox1.Controls.Add(this.rbExchangeFanout);
            this.groupBox1.Location = new System.Drawing.Point(1, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 70);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип";
            // 
            // rbExchangeHeaders
            // 
            this.rbExchangeHeaders.AutoSize = true;
            this.rbExchangeHeaders.Location = new System.Drawing.Point(10, 42);
            this.rbExchangeHeaders.Name = "rbExchangeHeaders";
            this.rbExchangeHeaders.Size = new System.Drawing.Size(63, 17);
            this.rbExchangeHeaders.TabIndex = 3;
            this.rbExchangeHeaders.Text = "headers";
            this.rbExchangeHeaders.UseVisualStyleBackColor = true;
            // 
            // rbExchangeDirect
            // 
            this.rbExchangeDirect.AutoSize = true;
            this.rbExchangeDirect.Checked = true;
            this.rbExchangeDirect.Location = new System.Drawing.Point(10, 19);
            this.rbExchangeDirect.Name = "rbExchangeDirect";
            this.rbExchangeDirect.Size = new System.Drawing.Size(51, 17);
            this.rbExchangeDirect.TabIndex = 2;
            this.rbExchangeDirect.TabStop = true;
            this.rbExchangeDirect.Text = "direct";
            this.rbExchangeDirect.UseVisualStyleBackColor = true;
            // 
            // rbExchangeTopic
            // 
            this.rbExchangeTopic.AutoSize = true;
            this.rbExchangeTopic.Location = new System.Drawing.Point(94, 42);
            this.rbExchangeTopic.Name = "rbExchangeTopic";
            this.rbExchangeTopic.Size = new System.Drawing.Size(48, 17);
            this.rbExchangeTopic.TabIndex = 1;
            this.rbExchangeTopic.Text = "topic";
            this.rbExchangeTopic.UseVisualStyleBackColor = true;
            // 
            // rbExchangeFanout
            // 
            this.rbExchangeFanout.AutoSize = true;
            this.rbExchangeFanout.Location = new System.Drawing.Point(94, 19);
            this.rbExchangeFanout.Name = "rbExchangeFanout";
            this.rbExchangeFanout.Size = new System.Drawing.Size(55, 17);
            this.rbExchangeFanout.TabIndex = 0;
            this.rbExchangeFanout.Text = "fanout";
            this.rbExchangeFanout.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Название";
            // 
            // btGetServerConfig
            // 
            this.btGetServerConfig.Location = new System.Drawing.Point(5, 186);
            this.btGetServerConfig.Name = "btGetServerConfig";
            this.btGetServerConfig.Size = new System.Drawing.Size(161, 23);
            this.btGetServerConfig.TabIndex = 4;
            this.btGetServerConfig.Text = "Обновить конфигурацию";
            this.btGetServerConfig.UseVisualStyleBackColor = true;
            this.btGetServerConfig.Click += new System.EventHandler(this.btGetServerConfig_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 632);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1169, 22);
            this.statusStrip.TabIndex = 32;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbPort);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbServerName);
            this.panel1.Controls.Add(this.tbVirtualHost);
            this.panel1.Controls.Add(this.lblPort);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbUserName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 39);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1169, 593);
            this.panel2.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 654);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RabbitMQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQueues)).EndInit();
            this.dgContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBindings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExchanges)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVirtualHost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox tbServerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbPersistent;
        private System.Windows.Forms.TextBox tbRoutingKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.CheckBox cbUseTempQueue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btStartStop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMessages;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btGetServerConfig;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgExchanges;
        private System.Windows.Forms.TextBox tbAdminPassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbAdminUserName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbAdminPort;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgBindings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgQueues;
        private System.Windows.Forms.CheckBox cbExchangeAutoDelete;
        private System.Windows.Forms.CheckBox cbExchangeDurable;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbExchangeHeaders;
        private System.Windows.Forms.RadioButton rbExchangeDirect;
        private System.Windows.Forms.RadioButton rbExchangeTopic;
        private System.Windows.Forms.RadioButton rbExchangeFanout;
        private System.Windows.Forms.Button btCreateExchange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbNewQueue;
        private System.Windows.Forms.Button btCreateQueue;
        private System.Windows.Forms.CheckBox cbQueueExclusive;
        private System.Windows.Forms.CheckBox cbQueueDurable;
        private System.Windows.Forms.CheckBox cbQueueAutoDelete;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbBindingRoutingKey;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbQueues;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbExchanges;
        private System.Windows.Forms.Button btCreateBinding;
        private System.Windows.Forms.ContextMenuStrip dgContextMenu;
        private System.Windows.Forms.ToolStripMenuItem miDeleteItem;
        private System.Windows.Forms.TextBox tbNewExchange;
        private System.Windows.Forms.ComboBox cbExchange;
        private System.Windows.Forms.ComboBox cbQueue;
    }
}

