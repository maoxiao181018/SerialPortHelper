﻿namespace SerialPostTool
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSerial1 = new System.Windows.Forms.GroupBox();
            this.btnSerialPortSwitch1 = new System.Windows.Forms.Button();
            this.cbParity1 = new System.Windows.Forms.ComboBox();
            this.cbStop1 = new System.Windows.Forms.ComboBox();
            this.cbBaudRate1 = new System.Windows.Forms.ComboBox();
            this.cbDataBits1 = new System.Windows.Forms.ComboBox();
            this.cbSerial1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxSerial2 = new System.Windows.Forms.GroupBox();
            this.btnSerialPortSwitch2 = new System.Windows.Forms.Button();
            this.cbParity2 = new System.Windows.Forms.ComboBox();
            this.cbStop2 = new System.Windows.Forms.ComboBox();
            this.cbBaudRate2 = new System.Windows.Forms.ComboBox();
            this.cbDataBits2 = new System.Windows.Forms.ComboBox();
            this.cbSerial2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupSerialReceived = new System.Windows.Forms.GroupBox();
            this.richTextInfo = new System.Windows.Forms.RichTextBox();
            this.btnInfoConfig = new System.Windows.Forms.Button();
            this.btnInfoClear = new System.Windows.Forms.Button();
            this.chkShowTime = new System.Windows.Forms.CheckBox();
            this.chkShowSend = new System.Windows.Forms.CheckBox();
            this.chkShowSerial = new System.Windows.Forms.CheckBox();
            this.splitSerialWrite = new System.Windows.Forms.SplitContainer();
            this.groupSerialWrite1 = new System.Windows.Forms.GroupBox();
            this.chkSerialWriteLoop1 = new System.Windows.Forms.CheckBox();
            this.txtSerialWriteInterval1 = new System.Windows.Forms.TextBox();
            this.labMs = new System.Windows.Forms.Label();
            this.cbWriteFormat1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSerialWrite1 = new System.Windows.Forms.ComboBox();
            this.btnSerialWriteConfig1 = new System.Windows.Forms.Button();
            this.btnSerialWrite1 = new System.Windows.Forms.Button();
            this.txtSerialWrite1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSerialWriteLoop2 = new System.Windows.Forms.CheckBox();
            this.txtSerialWriteInterval2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbWriteFormat2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbSerialWrite2 = new System.Windows.Forms.ComboBox();
            this.btnSerialWriteConfig2 = new System.Windows.Forms.Button();
            this.btnSerialWrite2 = new System.Windows.Forms.Button();
            this.txtSerialWrite2 = new System.Windows.Forms.TextBox();
            this.groupBoxSerial1.SuspendLayout();
            this.groupBoxSerial2.SuspendLayout();
            this.groupSerialReceived.SuspendLayout();
            this.splitSerialWrite.Panel1.SuspendLayout();
            this.splitSerialWrite.Panel2.SuspendLayout();
            this.splitSerialWrite.SuspendLayout();
            this.groupSerialWrite1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSerial1
            // 
            this.groupBoxSerial1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSerial1.Controls.Add(this.btnSerialPortSwitch1);
            this.groupBoxSerial1.Controls.Add(this.cbParity1);
            this.groupBoxSerial1.Controls.Add(this.cbStop1);
            this.groupBoxSerial1.Controls.Add(this.cbBaudRate1);
            this.groupBoxSerial1.Controls.Add(this.cbDataBits1);
            this.groupBoxSerial1.Controls.Add(this.cbSerial1);
            this.groupBoxSerial1.Controls.Add(this.label5);
            this.groupBoxSerial1.Controls.Add(this.label4);
            this.groupBoxSerial1.Controls.Add(this.label3);
            this.groupBoxSerial1.Controls.Add(this.label2);
            this.groupBoxSerial1.Controls.Add(this.label6);
            this.groupBoxSerial1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxSerial1.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSerial1.Name = "groupBoxSerial1";
            this.groupBoxSerial1.Size = new System.Drawing.Size(164, 254);
            this.groupBoxSerial1.TabIndex = 0;
            this.groupBoxSerial1.TabStop = false;
            this.groupBoxSerial1.Text = "串口配置1";
            // 
            // btnSerialPortSwitch1
            // 
            this.btnSerialPortSwitch1.Location = new System.Drawing.Point(16, 205);
            this.btnSerialPortSwitch1.Name = "btnSerialPortSwitch1";
            this.btnSerialPortSwitch1.Size = new System.Drawing.Size(131, 39);
            this.btnSerialPortSwitch1.TabIndex = 20;
            this.btnSerialPortSwitch1.Tag = "1";
            this.btnSerialPortSwitch1.Text = "打开串口";
            this.btnSerialPortSwitch1.UseVisualStyleBackColor = true;
            this.btnSerialPortSwitch1.Click += new System.EventHandler(this.btnSerialPortSwitch_Click);
            // 
            // cbParity1
            // 
            this.cbParity1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbParity1.FormattingEnabled = true;
            this.cbParity1.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.cbParity1.Location = new System.Drawing.Point(75, 170);
            this.cbParity1.Margin = new System.Windows.Forms.Padding(2);
            this.cbParity1.Name = "cbParity1";
            this.cbParity1.Size = new System.Drawing.Size(72, 25);
            this.cbParity1.TabIndex = 19;
            // 
            // cbStop1
            // 
            this.cbStop1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStop1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbStop1.FormattingEnabled = true;
            this.cbStop1.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStop1.Location = new System.Drawing.Point(75, 134);
            this.cbStop1.Margin = new System.Windows.Forms.Padding(2);
            this.cbStop1.Name = "cbStop1";
            this.cbStop1.Size = new System.Drawing.Size(72, 25);
            this.cbStop1.TabIndex = 18;
            // 
            // cbBaudRate1
            // 
            this.cbBaudRate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBaudRate1.FormattingEnabled = true;
            this.cbBaudRate1.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "115200",
            "128000"});
            this.cbBaudRate1.Location = new System.Drawing.Point(75, 62);
            this.cbBaudRate1.Margin = new System.Windows.Forms.Padding(2);
            this.cbBaudRate1.Name = "cbBaudRate1";
            this.cbBaudRate1.Size = new System.Drawing.Size(72, 25);
            this.cbBaudRate1.TabIndex = 17;
            // 
            // cbDataBits1
            // 
            this.cbDataBits1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbDataBits1.FormattingEnabled = true;
            this.cbDataBits1.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits1.Location = new System.Drawing.Point(75, 98);
            this.cbDataBits1.Margin = new System.Windows.Forms.Padding(2);
            this.cbDataBits1.Name = "cbDataBits1";
            this.cbDataBits1.Size = new System.Drawing.Size(72, 25);
            this.cbDataBits1.TabIndex = 16;
            // 
            // cbSerial1
            // 
            this.cbSerial1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerial1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSerial1.FormattingEnabled = true;
            this.cbSerial1.Location = new System.Drawing.Point(75, 26);
            this.cbSerial1.Margin = new System.Windows.Forms.Padding(2);
            this.cbSerial1.Name = "cbSerial1";
            this.cbSerial1.Size = new System.Drawing.Size(72, 25);
            this.cbSerial1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "检验位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "停止位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "数据位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "波特率：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "端口号：";
            // 
            // groupBoxSerial2
            // 
            this.groupBoxSerial2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSerial2.Controls.Add(this.btnSerialPortSwitch2);
            this.groupBoxSerial2.Controls.Add(this.cbParity2);
            this.groupBoxSerial2.Controls.Add(this.cbStop2);
            this.groupBoxSerial2.Controls.Add(this.cbBaudRate2);
            this.groupBoxSerial2.Controls.Add(this.cbDataBits2);
            this.groupBoxSerial2.Controls.Add(this.cbSerial2);
            this.groupBoxSerial2.Controls.Add(this.label1);
            this.groupBoxSerial2.Controls.Add(this.label7);
            this.groupBoxSerial2.Controls.Add(this.label8);
            this.groupBoxSerial2.Controls.Add(this.label9);
            this.groupBoxSerial2.Controls.Add(this.label10);
            this.groupBoxSerial2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxSerial2.Location = new System.Drawing.Point(578, 12);
            this.groupBoxSerial2.Name = "groupBoxSerial2";
            this.groupBoxSerial2.Size = new System.Drawing.Size(164, 254);
            this.groupBoxSerial2.TabIndex = 1;
            this.groupBoxSerial2.TabStop = false;
            this.groupBoxSerial2.Text = "串口配置2";
            // 
            // btnSerialPortSwitch2
            // 
            this.btnSerialPortSwitch2.Location = new System.Drawing.Point(16, 205);
            this.btnSerialPortSwitch2.Name = "btnSerialPortSwitch2";
            this.btnSerialPortSwitch2.Size = new System.Drawing.Size(131, 39);
            this.btnSerialPortSwitch2.TabIndex = 20;
            this.btnSerialPortSwitch2.Tag = "2";
            this.btnSerialPortSwitch2.Text = "打开串口";
            this.btnSerialPortSwitch2.UseVisualStyleBackColor = true;
            this.btnSerialPortSwitch2.Click += new System.EventHandler(this.btnSerialPortSwitch_Click);
            // 
            // cbParity2
            // 
            this.cbParity2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbParity2.FormattingEnabled = true;
            this.cbParity2.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.cbParity2.Location = new System.Drawing.Point(75, 170);
            this.cbParity2.Margin = new System.Windows.Forms.Padding(2);
            this.cbParity2.Name = "cbParity2";
            this.cbParity2.Size = new System.Drawing.Size(72, 25);
            this.cbParity2.TabIndex = 19;
            // 
            // cbStop2
            // 
            this.cbStop2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStop2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbStop2.FormattingEnabled = true;
            this.cbStop2.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStop2.Location = new System.Drawing.Point(75, 134);
            this.cbStop2.Margin = new System.Windows.Forms.Padding(2);
            this.cbStop2.Name = "cbStop2";
            this.cbStop2.Size = new System.Drawing.Size(72, 25);
            this.cbStop2.TabIndex = 18;
            // 
            // cbBaudRate2
            // 
            this.cbBaudRate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBaudRate2.FormattingEnabled = true;
            this.cbBaudRate2.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "115200",
            "128000"});
            this.cbBaudRate2.Location = new System.Drawing.Point(75, 62);
            this.cbBaudRate2.Margin = new System.Windows.Forms.Padding(2);
            this.cbBaudRate2.Name = "cbBaudRate2";
            this.cbBaudRate2.Size = new System.Drawing.Size(72, 25);
            this.cbBaudRate2.TabIndex = 17;
            // 
            // cbDataBits2
            // 
            this.cbDataBits2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbDataBits2.FormattingEnabled = true;
            this.cbDataBits2.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits2.Location = new System.Drawing.Point(75, 98);
            this.cbDataBits2.Margin = new System.Windows.Forms.Padding(2);
            this.cbDataBits2.Name = "cbDataBits2";
            this.cbDataBits2.Size = new System.Drawing.Size(72, 25);
            this.cbDataBits2.TabIndex = 16;
            // 
            // cbSerial2
            // 
            this.cbSerial2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerial2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSerial2.FormattingEnabled = true;
            this.cbSerial2.Location = new System.Drawing.Point(75, 26);
            this.cbSerial2.Margin = new System.Windows.Forms.Padding(2);
            this.cbSerial2.Name = "cbSerial2";
            this.cbSerial2.Size = new System.Drawing.Size(72, 25);
            this.cbSerial2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "检验位：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "停止位：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "数据位：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "波特率：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "端口号：";
            // 
            // groupSerialReceived
            // 
            this.groupSerialReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSerialReceived.Controls.Add(this.richTextInfo);
            this.groupSerialReceived.Controls.Add(this.btnInfoConfig);
            this.groupSerialReceived.Controls.Add(this.btnInfoClear);
            this.groupSerialReceived.Controls.Add(this.chkShowTime);
            this.groupSerialReceived.Controls.Add(this.chkShowSend);
            this.groupSerialReceived.Controls.Add(this.chkShowSerial);
            this.groupSerialReceived.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupSerialReceived.Location = new System.Drawing.Point(182, 12);
            this.groupSerialReceived.Name = "groupSerialReceived";
            this.groupSerialReceived.Size = new System.Drawing.Size(390, 254);
            this.groupSerialReceived.TabIndex = 2;
            this.groupSerialReceived.TabStop = false;
            this.groupSerialReceived.Text = "信息显示";
            // 
            // richTextInfo
            // 
            this.richTextInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextInfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextInfo.Location = new System.Drawing.Point(6, 22);
            this.richTextInfo.Name = "richTextInfo";
            this.richTextInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextInfo.Size = new System.Drawing.Size(378, 199);
            this.richTextInfo.TabIndex = 4;
            this.richTextInfo.Text = "";
            this.richTextInfo.VScroll += new System.EventHandler(this.richTextInfo_VScroll);
            this.richTextInfo.SizeChanged += new System.EventHandler(this.richTextInfo_SizeChanged);
            this.richTextInfo.TextChanged += new System.EventHandler(this.richTextInfo_TextChanged);
            // 
            // btnInfoConfig
            // 
            this.btnInfoConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoConfig.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInfoConfig.Location = new System.Drawing.Point(309, 225);
            this.btnInfoConfig.Name = "btnInfoConfig";
            this.btnInfoConfig.Size = new System.Drawing.Size(75, 23);
            this.btnInfoConfig.TabIndex = 3;
            this.btnInfoConfig.Text = "更多设置";
            this.btnInfoConfig.UseVisualStyleBackColor = true;
            // 
            // btnInfoClear
            // 
            this.btnInfoClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoClear.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInfoClear.Location = new System.Drawing.Point(255, 225);
            this.btnInfoClear.Name = "btnInfoClear";
            this.btnInfoClear.Size = new System.Drawing.Size(48, 23);
            this.btnInfoClear.TabIndex = 3;
            this.btnInfoClear.Text = "清空";
            this.btnInfoClear.UseVisualStyleBackColor = true;
            this.btnInfoClear.Click += new System.EventHandler(this.btnInfoClear_Click);
            // 
            // chkShowTime
            // 
            this.chkShowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowTime.AutoSize = true;
            this.chkShowTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkShowTime.Location = new System.Drawing.Point(168, 227);
            this.chkShowTime.Name = "chkShowTime";
            this.chkShowTime.Size = new System.Drawing.Size(75, 21);
            this.chkShowTime.TabIndex = 2;
            this.chkShowTime.Text = "显示时间";
            this.chkShowTime.UseVisualStyleBackColor = true;
            // 
            // chkShowSend
            // 
            this.chkShowSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowSend.AutoSize = true;
            this.chkShowSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkShowSend.Location = new System.Drawing.Point(87, 227);
            this.chkShowSend.Name = "chkShowSend";
            this.chkShowSend.Size = new System.Drawing.Size(75, 21);
            this.chkShowSend.TabIndex = 2;
            this.chkShowSend.Text = "显示发送";
            this.chkShowSend.UseVisualStyleBackColor = true;
            // 
            // chkShowSerial
            // 
            this.chkShowSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowSerial.AutoSize = true;
            this.chkShowSerial.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkShowSerial.Location = new System.Drawing.Point(6, 227);
            this.chkShowSerial.Name = "chkShowSerial";
            this.chkShowSerial.Size = new System.Drawing.Size(75, 21);
            this.chkShowSerial.TabIndex = 2;
            this.chkShowSerial.Text = "显示串口";
            this.chkShowSerial.UseVisualStyleBackColor = true;
            // 
            // splitSerialWrite
            // 
            this.splitSerialWrite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitSerialWrite.IsSplitterFixed = true;
            this.splitSerialWrite.Location = new System.Drawing.Point(12, 272);
            this.splitSerialWrite.Name = "splitSerialWrite";
            // 
            // splitSerialWrite.Panel1
            // 
            this.splitSerialWrite.Panel1.Controls.Add(this.groupSerialWrite1);
            // 
            // splitSerialWrite.Panel2
            // 
            this.splitSerialWrite.Panel2.Controls.Add(this.groupBox1);
            this.splitSerialWrite.Size = new System.Drawing.Size(730, 168);
            this.splitSerialWrite.SplitterDistance = 365;
            this.splitSerialWrite.TabIndex = 3;
            // 
            // groupSerialWrite1
            // 
            this.groupSerialWrite1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSerialWrite1.Controls.Add(this.chkSerialWriteLoop1);
            this.groupSerialWrite1.Controls.Add(this.txtSerialWriteInterval1);
            this.groupSerialWrite1.Controls.Add(this.labMs);
            this.groupSerialWrite1.Controls.Add(this.cbWriteFormat1);
            this.groupSerialWrite1.Controls.Add(this.label11);
            this.groupSerialWrite1.Controls.Add(this.cbSerialWrite1);
            this.groupSerialWrite1.Controls.Add(this.btnSerialWriteConfig1);
            this.groupSerialWrite1.Controls.Add(this.btnSerialWrite1);
            this.groupSerialWrite1.Controls.Add(this.txtSerialWrite1);
            this.groupSerialWrite1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupSerialWrite1.Location = new System.Drawing.Point(0, 0);
            this.groupSerialWrite1.Name = "groupSerialWrite1";
            this.groupSerialWrite1.Size = new System.Drawing.Size(362, 165);
            this.groupSerialWrite1.TabIndex = 0;
            this.groupSerialWrite1.TabStop = false;
            this.groupSerialWrite1.Text = "数据发送1";
            // 
            // chkSerialWriteLoop1
            // 
            this.chkSerialWriteLoop1.AutoSize = true;
            this.chkSerialWriteLoop1.Location = new System.Drawing.Point(176, 134);
            this.chkSerialWriteLoop1.Name = "chkSerialWriteLoop1";
            this.chkSerialWriteLoop1.Size = new System.Drawing.Size(93, 25);
            this.chkSerialWriteLoop1.TabIndex = 8;
            this.chkSerialWriteLoop1.Text = "定时发送";
            this.chkSerialWriteLoop1.UseVisualStyleBackColor = true;
            // 
            // txtSerialWriteInterval1
            // 
            this.txtSerialWriteInterval1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.txtSerialWriteInterval1.Location = new System.Drawing.Point(270, 132);
            this.txtSerialWriteInterval1.Name = "txtSerialWriteInterval1";
            this.txtSerialWriteInterval1.Size = new System.Drawing.Size(57, 26);
            this.txtSerialWriteInterval1.TabIndex = 7;
            // 
            // labMs
            // 
            this.labMs.AutoSize = true;
            this.labMs.Location = new System.Drawing.Point(325, 135);
            this.labMs.Name = "labMs";
            this.labMs.Size = new System.Drawing.Size(32, 21);
            this.labMs.TabIndex = 9;
            this.labMs.Text = "ms";
            // 
            // cbWriteFormat1
            // 
            this.cbWriteFormat1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWriteFormat1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbWriteFormat1.FormattingEnabled = true;
            this.cbWriteFormat1.Items.AddRange(new object[] {
            "自动",
            "字符串",
            "十六进制"});
            this.cbWriteFormat1.Location = new System.Drawing.Point(85, 132);
            this.cbWriteFormat1.Name = "cbWriteFormat1";
            this.cbWriteFormat1.Size = new System.Drawing.Size(79, 28);
            this.cbWriteFormat1.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "发送方式：";
            // 
            // cbSerialWrite1
            // 
            this.cbSerialWrite1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSerialWrite1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerialWrite1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.cbSerialWrite1.FormattingEnabled = true;
            this.cbSerialWrite1.Location = new System.Drawing.Point(85, 97);
            this.cbSerialWrite1.Name = "cbSerialWrite1";
            this.cbSerialWrite1.Size = new System.Drawing.Size(193, 28);
            this.cbSerialWrite1.TabIndex = 4;
            // 
            // btnSerialWriteConfig1
            // 
            this.btnSerialWriteConfig1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSerialWriteConfig1.Location = new System.Drawing.Point(6, 97);
            this.btnSerialWriteConfig1.Name = "btnSerialWriteConfig1";
            this.btnSerialWriteConfig1.Size = new System.Drawing.Size(73, 31);
            this.btnSerialWriteConfig1.TabIndex = 3;
            this.btnSerialWriteConfig1.Text = "快捷管理";
            this.btnSerialWriteConfig1.UseVisualStyleBackColor = true;
            // 
            // btnSerialWrite1
            // 
            this.btnSerialWrite1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerialWrite1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSerialWrite1.Location = new System.Drawing.Point(284, 95);
            this.btnSerialWrite1.Name = "btnSerialWrite1";
            this.btnSerialWrite1.Size = new System.Drawing.Size(72, 31);
            this.btnSerialWrite1.TabIndex = 3;
            this.btnSerialWrite1.Tag = "1";
            this.btnSerialWrite1.Text = "发送";
            this.btnSerialWrite1.UseVisualStyleBackColor = true;
            this.btnSerialWrite1.Click += new System.EventHandler(this.btnSerialWrite_Click);
            // 
            // txtSerialWrite1
            // 
            this.txtSerialWrite1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerialWrite1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSerialWrite1.Location = new System.Drawing.Point(6, 26);
            this.txtSerialWrite1.Multiline = true;
            this.txtSerialWrite1.Name = "txtSerialWrite1";
            this.txtSerialWrite1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSerialWrite1.Size = new System.Drawing.Size(350, 63);
            this.txtSerialWrite1.TabIndex = 2;
            this.txtSerialWrite1.Tag = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkSerialWriteLoop2);
            this.groupBox1.Controls.Add(this.txtSerialWriteInterval2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbWriteFormat2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbSerialWrite2);
            this.groupBox1.Controls.Add(this.btnSerialWriteConfig2);
            this.groupBox1.Controls.Add(this.btnSerialWrite2);
            this.groupBox1.Controls.Add(this.txtSerialWrite2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据发送2";
            // 
            // chkSerialWriteLoop2
            // 
            this.chkSerialWriteLoop2.AutoSize = true;
            this.chkSerialWriteLoop2.Location = new System.Drawing.Point(176, 134);
            this.chkSerialWriteLoop2.Name = "chkSerialWriteLoop2";
            this.chkSerialWriteLoop2.Size = new System.Drawing.Size(93, 25);
            this.chkSerialWriteLoop2.TabIndex = 8;
            this.chkSerialWriteLoop2.Text = "定时发送";
            this.chkSerialWriteLoop2.UseVisualStyleBackColor = true;
            // 
            // txtSerialWriteInterval2
            // 
            this.txtSerialWriteInterval2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.txtSerialWriteInterval2.Location = new System.Drawing.Point(270, 132);
            this.txtSerialWriteInterval2.Name = "txtSerialWriteInterval2";
            this.txtSerialWriteInterval2.Size = new System.Drawing.Size(57, 26);
            this.txtSerialWriteInterval2.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(325, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 21);
            this.label12.TabIndex = 9;
            this.label12.Text = "ms";
            // 
            // cbWriteFormat2
            // 
            this.cbWriteFormat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWriteFormat2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbWriteFormat2.FormattingEnabled = true;
            this.cbWriteFormat2.Items.AddRange(new object[] {
            "自动",
            "字符串",
            "十六进制"});
            this.cbWriteFormat2.Location = new System.Drawing.Point(85, 132);
            this.cbWriteFormat2.Name = "cbWriteFormat2";
            this.cbWriteFormat2.Size = new System.Drawing.Size(79, 28);
            this.cbWriteFormat2.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 21);
            this.label13.TabIndex = 5;
            this.label13.Text = "发送方式：";
            // 
            // cbSerialWrite2
            // 
            this.cbSerialWrite2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSerialWrite2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerialWrite2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.cbSerialWrite2.FormattingEnabled = true;
            this.cbSerialWrite2.Location = new System.Drawing.Point(85, 97);
            this.cbSerialWrite2.Name = "cbSerialWrite2";
            this.cbSerialWrite2.Size = new System.Drawing.Size(189, 28);
            this.cbSerialWrite2.TabIndex = 4;
            // 
            // btnSerialWriteConfig2
            // 
            this.btnSerialWriteConfig2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSerialWriteConfig2.Location = new System.Drawing.Point(6, 97);
            this.btnSerialWriteConfig2.Name = "btnSerialWriteConfig2";
            this.btnSerialWriteConfig2.Size = new System.Drawing.Size(73, 31);
            this.btnSerialWriteConfig2.TabIndex = 3;
            this.btnSerialWriteConfig2.Text = "快捷管理";
            this.btnSerialWriteConfig2.UseVisualStyleBackColor = true;
            // 
            // btnSerialWrite2
            // 
            this.btnSerialWrite2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerialWrite2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSerialWrite2.Location = new System.Drawing.Point(280, 95);
            this.btnSerialWrite2.Name = "btnSerialWrite2";
            this.btnSerialWrite2.Size = new System.Drawing.Size(72, 31);
            this.btnSerialWrite2.TabIndex = 3;
            this.btnSerialWrite2.Tag = "2";
            this.btnSerialWrite2.Text = "发送";
            this.btnSerialWrite2.UseVisualStyleBackColor = true;
            this.btnSerialWrite2.Click += new System.EventHandler(this.btnSerialWrite_Click);
            // 
            // txtSerialWrite2
            // 
            this.txtSerialWrite2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerialWrite2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSerialWrite2.Location = new System.Drawing.Point(6, 26);
            this.txtSerialWrite2.Multiline = true;
            this.txtSerialWrite2.Name = "txtSerialWrite2";
            this.txtSerialWrite2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSerialWrite2.Size = new System.Drawing.Size(346, 63);
            this.txtSerialWrite2.TabIndex = 2;
            this.txtSerialWrite2.Tag = "2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 452);
            this.Controls.Add(this.splitSerialWrite);
            this.Controls.Add(this.groupSerialReceived);
            this.Controls.Add(this.groupBoxSerial2);
            this.Controls.Add(this.groupBoxSerial1);
            this.MinimumSize = new System.Drawing.Size(770, 491);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口调试工具";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBoxSerial1.ResumeLayout(false);
            this.groupBoxSerial1.PerformLayout();
            this.groupBoxSerial2.ResumeLayout(false);
            this.groupBoxSerial2.PerformLayout();
            this.groupSerialReceived.ResumeLayout(false);
            this.groupSerialReceived.PerformLayout();
            this.splitSerialWrite.Panel1.ResumeLayout(false);
            this.splitSerialWrite.Panel2.ResumeLayout(false);
            this.splitSerialWrite.ResumeLayout(false);
            this.groupSerialWrite1.ResumeLayout(false);
            this.groupSerialWrite1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSerial1;
        private System.Windows.Forms.ComboBox cbParity1;
        private System.Windows.Forms.ComboBox cbStop1;
        private System.Windows.Forms.ComboBox cbBaudRate1;
        private System.Windows.Forms.ComboBox cbDataBits1;
        private System.Windows.Forms.ComboBox cbSerial1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSerialPortSwitch1;
        private System.Windows.Forms.GroupBox groupBoxSerial2;
        private System.Windows.Forms.Button btnSerialPortSwitch2;
        private System.Windows.Forms.ComboBox cbParity2;
        private System.Windows.Forms.ComboBox cbStop2;
        private System.Windows.Forms.ComboBox cbBaudRate2;
        private System.Windows.Forms.ComboBox cbDataBits2;
        private System.Windows.Forms.ComboBox cbSerial2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupSerialReceived;
        private System.Windows.Forms.SplitContainer splitSerialWrite;
        private System.Windows.Forms.GroupBox groupSerialWrite1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSerialWrite1;
        private System.Windows.Forms.Button btnSerialWriteConfig1;
        private System.Windows.Forms.Button btnSerialWrite1;
        private System.Windows.Forms.TextBox txtSerialWrite1;
        private System.Windows.Forms.ComboBox cbWriteFormat1;
        private System.Windows.Forms.CheckBox chkSerialWriteLoop1;
        private System.Windows.Forms.TextBox txtSerialWriteInterval1;
        private System.Windows.Forms.Label labMs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSerialWriteLoop2;
        private System.Windows.Forms.TextBox txtSerialWriteInterval2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbWriteFormat2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbSerialWrite2;
        private System.Windows.Forms.Button btnSerialWriteConfig2;
        private System.Windows.Forms.Button btnSerialWrite2;
        private System.Windows.Forms.TextBox txtSerialWrite2;
        private System.Windows.Forms.Button btnInfoConfig;
        private System.Windows.Forms.Button btnInfoClear;
        private System.Windows.Forms.CheckBox chkShowTime;
        private System.Windows.Forms.CheckBox chkShowSend;
        private System.Windows.Forms.CheckBox chkShowSerial;
        private System.Windows.Forms.RichTextBox richTextInfo;
    }
}

