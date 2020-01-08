namespace MP_Tool
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdSunixQuery = new System.Windows.Forms.DataGridView();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConn = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnNexusDb = new System.Windows.Forms.RadioButton();
            this.rbtnFoxProDB = new System.Windows.Forms.RadioButton();
            this.txtQuery = new System.Windows.Forms.RichTextBox();
            this.lblrowsEffected = new System.Windows.Forms.Label();
            this.rbtnSqlServerDB = new System.Windows.Forms.RadioButton();
            this.chkSingle = new System.Windows.Forms.CheckBox();
            this.chkMulti = new System.Windows.Forms.CheckBox();
            this.lblQueryExTime = new System.Windows.Forms.Label();
            this.lblQueryExecutionTime = new System.Windows.Forms.Label();
            this.tabQueryCommander = new System.Windows.Forms.TabControl();
            this.tabVMMaintainer = new System.Windows.Forms.TabPage();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.rchtxtOutput = new System.Windows.Forms.RichTextBox();
            this.txtInsatnceId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbInterBaseDB = new System.Windows.Forms.RadioButton();
            this.rFireBirdDB = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tabDownLoadFileFromS3 = new System.Windows.Forms.TabPage();
            this.rAlconReminders = new System.Windows.Forms.RadioButton();
            this.rEasyRecall = new System.Windows.Forms.RadioButton();
            this.lblpatientCount = new System.Windows.Forms.Label();
            this.lnkFile = new System.Windows.Forms.LinkLabel();
            this.rtxtFileData = new System.Windows.Forms.RichTextBox();
            this.btndwnFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFileKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBucketName = new System.Windows.Forms.TextBox();
            this.tabOthers = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnCheckDotNetVersion = new System.Windows.Forms.Button();
            this.chkdevsyncchs = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdSunixQuery)).BeginInit();
            this.tabQueryCommander.SuspendLayout();
            this.tabVMMaintainer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabDownLoadFileFromS3.SuspendLayout();
            this.tabOthers.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdSunixQuery
            // 
            this.grdSunixQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSunixQuery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdSunixQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSunixQuery.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdSunixQuery.Location = new System.Drawing.Point(26, 519);
            this.grdSunixQuery.Name = "grdSunixQuery";
            this.grdSunixQuery.Size = new System.Drawing.Size(1412, 184);
            this.grdSunixQuery.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(1443, 93);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(90, 190);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(1443, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 187);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type your query:";
            // 
            // txtConn
            // 
            this.txtConn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConn.Location = new System.Drawing.Point(121, 52);
            this.txtConn.Name = "txtConn";
            this.txtConn.Size = new System.Drawing.Size(1308, 31);
            this.txtConn.TabIndex = 5;
            this.txtConn.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Connection String";
            // 
            // rbtnNexusDb
            // 
            this.rbtnNexusDb.AutoSize = true;
            this.rbtnNexusDb.Location = new System.Drawing.Point(212, 6);
            this.rbtnNexusDb.Name = "rbtnNexusDb";
            this.rbtnNexusDb.Size = new System.Drawing.Size(73, 17);
            this.rbtnNexusDb.TabIndex = 7;
            this.rbtnNexusDb.TabStop = true;
            this.rbtnNexusDb.Text = "Nexus DB";
            this.rbtnNexusDb.UseVisualStyleBackColor = true;
            this.rbtnNexusDb.CheckedChanged += new System.EventHandler(this.rOptomteDb_CheckedChanged);
            // 
            // rbtnFoxProDB
            // 
            this.rbtnFoxProDB.AutoSize = true;
            this.rbtnFoxProDB.Location = new System.Drawing.Point(130, 6);
            this.rbtnFoxProDB.Name = "rbtnFoxProDB";
            this.rbtnFoxProDB.Size = new System.Drawing.Size(76, 17);
            this.rbtnFoxProDB.TabIndex = 8;
            this.rbtnFoxProDB.TabStop = true;
            this.rbtnFoxProDB.Text = "FoxPro DB";
            this.rbtnFoxProDB.UseVisualStyleBackColor = true;
            this.rbtnFoxProDB.CheckedChanged += new System.EventHandler(this.RSunixDb_CheckedChanged);
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.ForeColor = System.Drawing.Color.Blue;
            this.txtQuery.Location = new System.Drawing.Point(27, 113);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(1411, 386);
            this.txtQuery.TabIndex = 9;
            this.txtQuery.Text = "";
            // 
            // lblrowsEffected
            // 
            this.lblrowsEffected.AutoSize = true;
            this.lblrowsEffected.Location = new System.Drawing.Point(30, 502);
            this.lblrowsEffected.Name = "lblrowsEffected";
            this.lblrowsEffected.Size = new System.Drawing.Size(80, 13);
            this.lblrowsEffected.TabIndex = 10;
            this.lblrowsEffected.Text = "Rows Effected:";
            // 
            // rbtnSqlServerDB
            // 
            this.rbtnSqlServerDB.AutoSize = true;
            this.rbtnSqlServerDB.Location = new System.Drawing.Point(291, 6);
            this.rbtnSqlServerDB.Name = "rbtnSqlServerDB";
            this.rbtnSqlServerDB.Size = new System.Drawing.Size(98, 17);
            this.rbtnSqlServerDB.TabIndex = 11;
            this.rbtnSqlServerDB.TabStop = true;
            this.rbtnSqlServerDB.Text = "SQL Server DB";
            this.rbtnSqlServerDB.UseVisualStyleBackColor = true;
            this.rbtnSqlServerDB.CheckedChanged += new System.EventHandler(this.rbtnSqlServer_CheckedChanged);
            // 
            // chkSingle
            // 
            this.chkSingle.AutoSize = true;
            this.chkSingle.Location = new System.Drawing.Point(130, 29);
            this.chkSingle.Name = "chkSingle";
            this.chkSingle.Size = new System.Drawing.Size(92, 17);
            this.chkSingle.TabIndex = 14;
            this.chkSingle.Text = "Single Branch";
            this.chkSingle.UseVisualStyleBackColor = true;
            this.chkSingle.CheckedChanged += new System.EventHandler(this.chkSingle_CheckedChanged);
            // 
            // chkMulti
            // 
            this.chkMulti.AutoSize = true;
            this.chkMulti.Location = new System.Drawing.Point(226, 29);
            this.chkMulti.Name = "chkMulti";
            this.chkMulti.Size = new System.Drawing.Size(85, 17);
            this.chkMulti.TabIndex = 15;
            this.chkMulti.Text = "Multi Branch";
            this.chkMulti.UseVisualStyleBackColor = true;
            this.chkMulti.CheckedChanged += new System.EventHandler(this.chkMulti_CheckedChanged);
            // 
            // lblQueryExTime
            // 
            this.lblQueryExTime.AutoSize = true;
            this.lblQueryExTime.Location = new System.Drawing.Point(231, 574);
            this.lblQueryExTime.Name = "lblQueryExTime";
            this.lblQueryExTime.Size = new System.Drawing.Size(13, 13);
            this.lblQueryExTime.TabIndex = 16;
            this.lblQueryExTime.Text = "0";
            // 
            // lblQueryExecutionTime
            // 
            this.lblQueryExecutionTime.AutoSize = true;
            this.lblQueryExecutionTime.Location = new System.Drawing.Point(286, 503);
            this.lblQueryExecutionTime.Name = "lblQueryExecutionTime";
            this.lblQueryExecutionTime.Size = new System.Drawing.Size(117, 13);
            this.lblQueryExecutionTime.TabIndex = 17;
            this.lblQueryExecutionTime.Text = "Query Execution Time :";
            // 
            // tabQueryCommander
            // 
            this.tabQueryCommander.Controls.Add(this.tabVMMaintainer);
            this.tabQueryCommander.Controls.Add(this.tabPage1);
            this.tabQueryCommander.Controls.Add(this.tabDownLoadFileFromS3);
            this.tabQueryCommander.Controls.Add(this.tabOthers);
            this.tabQueryCommander.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQueryCommander.Location = new System.Drawing.Point(4, 2);
            this.tabQueryCommander.Name = "tabQueryCommander";
            this.tabQueryCommander.SelectedIndex = 0;
            this.tabQueryCommander.Size = new System.Drawing.Size(1544, 725);
            this.tabQueryCommander.TabIndex = 18;
            // 
            // tabVMMaintainer
            // 
            this.tabVMMaintainer.Controls.Add(this.btnStopAll);
            this.tabVMMaintainer.Controls.Add(this.chkdevsyncchs);
            this.tabVMMaintainer.Controls.Add(this.btnStop);
            this.tabVMMaintainer.Controls.Add(this.rchtxtOutput);
            this.tabVMMaintainer.Controls.Add(this.txtInsatnceId);
            this.tabVMMaintainer.Controls.Add(this.label4);
            this.tabVMMaintainer.Controls.Add(this.btnStart);
            this.tabVMMaintainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVMMaintainer.Location = new System.Drawing.Point(4, 22);
            this.tabVMMaintainer.Name = "tabVMMaintainer";
            this.tabVMMaintainer.Padding = new System.Windows.Forms.Padding(3);
            this.tabVMMaintainer.Size = new System.Drawing.Size(1536, 699);
            this.tabVMMaintainer.TabIndex = 1;
            this.tabVMMaintainer.Text = "VM Maintainer";
            this.tabVMMaintainer.UseVisualStyleBackColor = true;
            // 
            // btnStopAll
            // 
            this.btnStopAll.BackColor = System.Drawing.Color.DarkRed;
            this.btnStopAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStopAll.Location = new System.Drawing.Point(938, 650);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(105, 28);
            this.btnStopAll.TabIndex = 90;
            this.btnStopAll.Text = "Stop All";
            this.btnStopAll.UseVisualStyleBackColor = false;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(534, 315);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 23);
            this.btnStop.TabIndex = 50;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // rchtxtOutput
            // 
            this.rchtxtOutput.Location = new System.Drawing.Point(24, 344);
            this.rchtxtOutput.Name = "rchtxtOutput";
            this.rchtxtOutput.Size = new System.Drawing.Size(1019, 300);
            this.rchtxtOutput.TabIndex = 49;
            this.rchtxtOutput.Text = "";
            // 
            // txtInsatnceId
            // 
            this.txtInsatnceId.Location = new System.Drawing.Point(111, 316);
            this.txtInsatnceId.Name = "txtInsatnceId";
            this.txtInsatnceId.Size = new System.Drawing.Size(309, 20);
            this.txtInsatnceId.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "VM Instance ID";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(426, 315);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 23);
            this.btnStart.TabIndex = 46;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rbInterBaseDB);
            this.tabPage1.Controls.Add(this.rFireBirdDB);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtQuery);
            this.tabPage1.Controls.Add(this.lblQueryExecutionTime);
            this.tabPage1.Controls.Add(this.chkMulti);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chkSingle);
            this.tabPage1.Controls.Add(this.txtConn);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnRun);
            this.tabPage1.Controls.Add(this.rbtnNexusDb);
            this.tabPage1.Controls.Add(this.lblrowsEffected);
            this.tabPage1.Controls.Add(this.rbtnSqlServerDB);
            this.tabPage1.Controls.Add(this.rbtnFoxProDB);
            this.tabPage1.Controls.Add(this.grdSunixQuery);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1536, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Query Commander";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbInterBaseDB
            // 
            this.rbInterBaseDB.AutoSize = true;
            this.rbInterBaseDB.Location = new System.Drawing.Point(479, 6);
            this.rbInterBaseDB.Name = "rbInterBaseDB";
            this.rbInterBaseDB.Size = new System.Drawing.Size(88, 17);
            this.rbInterBaseDB.TabIndex = 20;
            this.rbInterBaseDB.TabStop = true;
            this.rbInterBaseDB.Text = "InterBase DB";
            this.rbInterBaseDB.UseVisualStyleBackColor = true;
            this.rbInterBaseDB.CheckedChanged += new System.EventHandler(this.rbInterBaseDB_CheckedChanged);
            // 
            // rFireBirdDB
            // 
            this.rFireBirdDB.AutoSize = true;
            this.rFireBirdDB.Location = new System.Drawing.Point(395, 6);
            this.rFireBirdDB.Name = "rFireBirdDB";
            this.rFireBirdDB.Size = new System.Drawing.Size(78, 17);
            this.rFireBirdDB.TabIndex = 19;
            this.rFireBirdDB.TabStop = true;
            this.rFireBirdDB.Text = "FireBird DB";
            this.rFireBirdDB.UseVisualStyleBackColor = true;
            this.rFireBirdDB.CheckedChanged += new System.EventHandler(this.check_FireBirdDB_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1222, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabDownLoadFileFromS3
            // 
            this.tabDownLoadFileFromS3.Controls.Add(this.rAlconReminders);
            this.tabDownLoadFileFromS3.Controls.Add(this.rEasyRecall);
            this.tabDownLoadFileFromS3.Controls.Add(this.lblpatientCount);
            this.tabDownLoadFileFromS3.Controls.Add(this.lnkFile);
            this.tabDownLoadFileFromS3.Controls.Add(this.rtxtFileData);
            this.tabDownLoadFileFromS3.Controls.Add(this.btndwnFile);
            this.tabDownLoadFileFromS3.Controls.Add(this.label5);
            this.tabDownLoadFileFromS3.Controls.Add(this.tbFileKey);
            this.tabDownLoadFileFromS3.Controls.Add(this.label7);
            this.tabDownLoadFileFromS3.Controls.Add(this.tbBucketName);
            this.tabDownLoadFileFromS3.Location = new System.Drawing.Point(4, 22);
            this.tabDownLoadFileFromS3.Name = "tabDownLoadFileFromS3";
            this.tabDownLoadFileFromS3.Size = new System.Drawing.Size(1536, 699);
            this.tabDownLoadFileFromS3.TabIndex = 2;
            this.tabDownLoadFileFromS3.Text = "Down Load File From S3";
            this.tabDownLoadFileFromS3.UseVisualStyleBackColor = true;
            // 
            // rAlconReminders
            // 
            this.rAlconReminders.AutoSize = true;
            this.rAlconReminders.Location = new System.Drawing.Point(301, 18);
            this.rAlconReminders.Name = "rAlconReminders";
            this.rAlconReminders.Size = new System.Drawing.Size(105, 17);
            this.rAlconReminders.TabIndex = 21;
            this.rAlconReminders.TabStop = true;
            this.rAlconReminders.Text = "Alcon Reminders";
            this.rAlconReminders.UseVisualStyleBackColor = true;
            this.rAlconReminders.CheckedChanged += new System.EventHandler(this.rAlconReminders_CheckedChanged);
            // 
            // rEasyRecall
            // 
            this.rEasyRecall.AutoSize = true;
            this.rEasyRecall.Location = new System.Drawing.Point(175, 18);
            this.rEasyRecall.Name = "rEasyRecall";
            this.rEasyRecall.Size = new System.Drawing.Size(83, 17);
            this.rEasyRecall.TabIndex = 20;
            this.rEasyRecall.TabStop = true;
            this.rEasyRecall.Text = "EasyRecalls";
            this.rEasyRecall.UseVisualStyleBackColor = true;
            this.rEasyRecall.CheckedChanged += new System.EventHandler(this.rEasyRecall_CheckedChanged);
            // 
            // lblpatientCount
            // 
            this.lblpatientCount.AutoSize = true;
            this.lblpatientCount.Location = new System.Drawing.Point(32, 154);
            this.lblpatientCount.Name = "lblpatientCount";
            this.lblpatientCount.Size = new System.Drawing.Size(94, 13);
            this.lblpatientCount.TabIndex = 19;
            this.lblpatientCount.Text = "Patient(s) Count: 0";
            // 
            // lnkFile
            // 
            this.lnkFile.AutoSize = true;
            this.lnkFile.Location = new System.Drawing.Point(344, 126);
            this.lnkFile.Name = "lnkFile";
            this.lnkFile.Size = new System.Drawing.Size(54, 13);
            this.lnkFile.TabIndex = 18;
            this.lnkFile.TabStop = true;
            this.lnkFile.Text = "File Name";
            this.lnkFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFile_LinkClicked);
            // 
            // rtxtFileData
            // 
            this.rtxtFileData.Location = new System.Drawing.Point(25, 170);
            this.rtxtFileData.Name = "rtxtFileData";
            this.rtxtFileData.Size = new System.Drawing.Size(1482, 473);
            this.rtxtFileData.TabIndex = 15;
            this.rtxtFileData.Text = "";
            // 
            // btndwnFile
            // 
            this.btndwnFile.Location = new System.Drawing.Point(217, 115);
            this.btndwnFile.Name = "btndwnFile";
            this.btndwnFile.Size = new System.Drawing.Size(82, 35);
            this.btndwnFile.TabIndex = 14;
            this.btndwnFile.Text = "DownloadFile";
            this.btndwnFile.UseVisualStyleBackColor = true;
            this.btndwnFile.Click += new System.EventHandler(this.btndwnFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "FileKey";
            // 
            // tbFileKey
            // 
            this.tbFileKey.Location = new System.Drawing.Point(247, 73);
            this.tbFileKey.Name = "tbFileKey";
            this.tbFileKey.Size = new System.Drawing.Size(324, 20);
            this.tbFileKey.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "BucketName";
            // 
            // tbBucketName
            // 
            this.tbBucketName.Location = new System.Drawing.Point(247, 51);
            this.tbBucketName.Name = "tbBucketName";
            this.tbBucketName.Size = new System.Drawing.Size(324, 20);
            this.tbBucketName.TabIndex = 8;
            // 
            // tabOthers
            // 
            this.tabOthers.Controls.Add(this.richTextBox2);
            this.tabOthers.Controls.Add(this.btnCheckDotNetVersion);
            this.tabOthers.Location = new System.Drawing.Point(4, 22);
            this.tabOthers.Name = "tabOthers";
            this.tabOthers.Size = new System.Drawing.Size(1536, 699);
            this.tabOthers.TabIndex = 3;
            this.tabOthers.Text = "Other Commands";
            this.tabOthers.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(16, 33);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(722, 339);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // btnCheckDotNetVersion
            // 
            this.btnCheckDotNetVersion.Location = new System.Drawing.Point(744, 33);
            this.btnCheckDotNetVersion.Name = "btnCheckDotNetVersion";
            this.btnCheckDotNetVersion.Size = new System.Drawing.Size(179, 40);
            this.btnCheckDotNetVersion.TabIndex = 0;
            this.btnCheckDotNetVersion.Text = "Check Dot Net Version";
            this.btnCheckDotNetVersion.UseVisualStyleBackColor = true;
            this.btnCheckDotNetVersion.Click += new System.EventHandler(this.btnCheckDotNetVersion_Click);
            // 
            // chkdevsyncchs
            // 
            this.chkdevsyncchs.AutoSize = true;
            this.chkdevsyncchs.Location = new System.Drawing.Point(22, 180);
            this.chkdevsyncchs.Name = "chkdevsyncchs";
            this.chkdevsyncchs.Size = new System.Drawing.Size(48, 17);
            this.chkdevsyncchs.TabIndex = 51;
            this.chkdevsyncchs.Text = "CHS";
            this.chkdevsyncchs.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 730);
            this.Controls.Add(this.tabQueryCommander);
            this.Controls.Add(this.lblQueryExTime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = " MP Tool ";
            ((System.ComponentModel.ISupportInitialize)(this.grdSunixQuery)).EndInit();
            this.tabQueryCommander.ResumeLayout(false);
            this.tabVMMaintainer.ResumeLayout(false);
            this.tabVMMaintainer.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabDownLoadFileFromS3.ResumeLayout(false);
            this.tabDownLoadFileFromS3.PerformLayout();
            this.tabOthers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSunixQuery;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtConn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnNexusDb;
        private System.Windows.Forms.RadioButton rbtnFoxProDB;
        private System.Windows.Forms.RichTextBox txtQuery;
        private System.Windows.Forms.Label lblrowsEffected;
        private System.Windows.Forms.RadioButton rbtnSqlServerDB;
        private System.Windows.Forms.CheckBox chkSingle;
        private System.Windows.Forms.CheckBox chkMulti;
        private System.Windows.Forms.Label lblQueryExTime;
        private System.Windows.Forms.Label lblQueryExecutionTime;
        private System.Windows.Forms.TabControl tabQueryCommander;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabVMMaintainer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RichTextBox rchtxtOutput;
        private System.Windows.Forms.TextBox txtInsatnceId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TabPage tabDownLoadFileFromS3;
        private System.Windows.Forms.TabPage tabOthers;
        private System.Windows.Forms.RichTextBox rtxtFileData;
        private System.Windows.Forms.Button btndwnFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFileKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBucketName;
        private System.Windows.Forms.Button btnCheckDotNetVersion;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.LinkLabel lnkFile;
        private System.Windows.Forms.Label lblpatientCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rFireBirdDB;
        private System.Windows.Forms.RadioButton rAlconReminders;
        private System.Windows.Forms.RadioButton rEasyRecall;
        private System.Windows.Forms.RadioButton rbInterBaseDB;
        private System.Windows.Forms.Button btnStopAll;
        private System.Windows.Forms.CheckBox chkdevsyncchs;
    }
}

