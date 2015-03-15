namespace Payroll
{
    partial class Payroll_Application
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMainDashboard = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRunChecksForCurrentPayPeriod = new System.Windows.Forms.Button();
            this.buttonPrepareForNextPayPeriod = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTotalRegisteredEmployees = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEmployeeDatabase = new System.Windows.Forms.TabPage();
            this.dataGridViewEmployeeDatabase = new System.Windows.Forms.DataGridView();
            this.tabEmployeeAccountDetail = new System.Windows.Forms.TabPage();
            this.buttonEmployeeAccountDetailSaveChanges = new System.Windows.Forms.Button();
            this.groupBoxAccountDetail = new System.Windows.Forms.GroupBox();
            this.textBoxAccountDetailHoursWorked = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.comboBoxAccountDetailCheckRunStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxAccountDetailEmploymentStatus = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.labelAccountDetailEmployeeID = new System.Windows.Forms.Label();
            this.textBoxAccountDetailFederalTaxPercent = new System.Windows.Forms.TextBox();
            this.textBoxAccountDetailMedicareTaxPercent = new System.Windows.Forms.TextBox();
            this.textBoxAccountDetailSocialSecurityTaxPercent = new System.Windows.Forms.TextBox();
            this.textBoxAccountDetailStateTaxPercent = new System.Windows.Forms.TextBox();
            this.textBoxAccountDetailVacationDaysAllowedPerYear = new System.Windows.Forms.TextBox();
            this.textBoxAccountDetailSickDaysAllowedPerYear = new System.Windows.Forms.TextBox();
            this.textBoxAccountDetailHourlyRate = new System.Windows.Forms.TextBox();
            this.textBoxAccountDetailOccupation = new System.Windows.Forms.TextBox();
            this.textBoxAccountDetailJoinDate = new System.Windows.Forms.TextBox();
            this.textBoxAccountDetailEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxAccountDetailMedicareTaxWithheld = new System.Windows.Forms.TextBox();
            this.textBoxAccountDetailSocialSecurityTaxWithheld = new System.Windows.Forms.TextBox();
            this.textBoxAccountDetailStateTaxWithheld = new System.Windows.Forms.TextBox();
            this.textBoxAccountDetailFederalTaxWithheld = new System.Windows.Forms.TextBox();
            this.textBoxAccountDetailAccruedSickDays = new System.Windows.Forms.TextBox();
            this.textBoxAccountDetailAccruedVacationDays = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabEmployeeAccountRegistration = new System.Windows.Forms.TabPage();
            this.buttonRegisterNewEmployee = new System.Windows.Forms.Button();
            this.groupBoxRegistrationFields = new System.Windows.Forms.GroupBox();
            this.textBoxRegistrationSocialSecurityTaxPercentWithheld = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationMedicareTaxPercentWithheld = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationStateTaxPercentWithheld = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationFederalTaxPercentWithheld = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationSickDaysAllowedPerYear = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationVacationDaysAllowedPerYear = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationHourlyRate = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationOccupation = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationJoinDate = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationEmployeeName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.approveCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeAccountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabMainDashboard.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabEmployeeDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeDatabase)).BeginInit();
            this.tabEmployeeAccountDetail.SuspendLayout();
            this.groupBoxAccountDetail.SuspendLayout();
            this.tabEmployeeAccountRegistration.SuspendLayout();
            this.groupBoxRegistrationFields.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabMainDashboard);
            this.tabControl1.Controls.Add(this.tabEmployeeDatabase);
            this.tabControl1.Controls.Add(this.tabEmployeeAccountDetail);
            this.tabControl1.Controls.Add(this.tabEmployeeAccountRegistration);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 423);
            this.tabControl1.TabIndex = 1;
            // 
            // tabMainDashboard
            // 
            this.tabMainDashboard.Controls.Add(this.button2);
            this.tabMainDashboard.Controls.Add(this.button1);
            this.tabMainDashboard.Controls.Add(this.buttonRunChecksForCurrentPayPeriod);
            this.tabMainDashboard.Controls.Add(this.buttonPrepareForNextPayPeriod);
            this.tabMainDashboard.Controls.Add(this.groupBox1);
            this.tabMainDashboard.Location = new System.Drawing.Point(4, 22);
            this.tabMainDashboard.Name = "tabMainDashboard";
            this.tabMainDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainDashboard.Size = new System.Drawing.Size(652, 397);
            this.tabMainDashboard.TabIndex = 0;
            this.tabMainDashboard.Text = "Main Dashboard";
            this.tabMainDashboard.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 55);
            this.button2.TabIndex = 4;
            this.button2.Text = "Mail Out W-2s";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.unimplementedButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear Annual Tax Accruements";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.unimplementedButton_Click);
            // 
            // buttonRunChecksForCurrentPayPeriod
            // 
            this.buttonRunChecksForCurrentPayPeriod.Location = new System.Drawing.Point(494, 240);
            this.buttonRunChecksForCurrentPayPeriod.Name = "buttonRunChecksForCurrentPayPeriod";
            this.buttonRunChecksForCurrentPayPeriod.Size = new System.Drawing.Size(129, 55);
            this.buttonRunChecksForCurrentPayPeriod.TabIndex = 2;
            this.buttonRunChecksForCurrentPayPeriod.Text = "Approve Check Run For All Employees";
            this.buttonRunChecksForCurrentPayPeriod.UseVisualStyleBackColor = true;
            this.buttonRunChecksForCurrentPayPeriod.Click += new System.EventHandler(this.buttonRunChecksForCurrentPayPeriod_Click);
            // 
            // buttonPrepareForNextPayPeriod
            // 
            this.buttonPrepareForNextPayPeriod.Location = new System.Drawing.Point(494, 315);
            this.buttonPrepareForNextPayPeriod.Name = "buttonPrepareForNextPayPeriod";
            this.buttonPrepareForNextPayPeriod.Size = new System.Drawing.Size(129, 55);
            this.buttonPrepareForNextPayPeriod.TabIndex = 1;
            this.buttonPrepareForNextPayPeriod.Text = "Prepare For Next Pay Period";
            this.buttonPrepareForNextPayPeriod.UseVisualStyleBackColor = true;
            this.buttonPrepareForNextPayPeriod.Click += new System.EventHandler(this.buttonPrepareForNextPayPeriod_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTotalRegisteredEmployees);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // labelTotalRegisteredEmployees
            // 
            this.labelTotalRegisteredEmployees.AutoSize = true;
            this.labelTotalRegisteredEmployees.Location = new System.Drawing.Point(184, 20);
            this.labelTotalRegisteredEmployees.Name = "labelTotalRegisteredEmployees";
            this.labelTotalRegisteredEmployees.Size = new System.Drawing.Size(10, 13);
            this.labelTotalRegisteredEmployees.TabIndex = 2;
            this.labelTotalRegisteredEmployees.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Registered Employees: ";
            // 
            // tabEmployeeDatabase
            // 
            this.tabEmployeeDatabase.Controls.Add(this.dataGridViewEmployeeDatabase);
            this.tabEmployeeDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabEmployeeDatabase.Name = "tabEmployeeDatabase";
            this.tabEmployeeDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployeeDatabase.Size = new System.Drawing.Size(652, 397);
            this.tabEmployeeDatabase.TabIndex = 1;
            this.tabEmployeeDatabase.Text = "Employee Database";
            this.tabEmployeeDatabase.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmployeeDatabase
            // 
            this.dataGridViewEmployeeDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployeeDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewEmployeeDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeDatabase.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewEmployeeDatabase.Name = "dataGridViewEmployeeDatabase";
            this.dataGridViewEmployeeDatabase.ReadOnly = true;
            this.dataGridViewEmployeeDatabase.Size = new System.Drawing.Size(640, 385);
            this.dataGridViewEmployeeDatabase.TabIndex = 0;
            this.dataGridViewEmployeeDatabase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewEmployeeDatabase_MouseClick);
            // 
            // tabEmployeeAccountDetail
            // 
            this.tabEmployeeAccountDetail.Controls.Add(this.buttonEmployeeAccountDetailSaveChanges);
            this.tabEmployeeAccountDetail.Controls.Add(this.groupBoxAccountDetail);
            this.tabEmployeeAccountDetail.Location = new System.Drawing.Point(4, 22);
            this.tabEmployeeAccountDetail.Name = "tabEmployeeAccountDetail";
            this.tabEmployeeAccountDetail.Size = new System.Drawing.Size(652, 397);
            this.tabEmployeeAccountDetail.TabIndex = 2;
            this.tabEmployeeAccountDetail.Text = "Employee Account Detail";
            this.tabEmployeeAccountDetail.UseVisualStyleBackColor = true;
            // 
            // buttonEmployeeAccountDetailSaveChanges
            // 
            this.buttonEmployeeAccountDetailSaveChanges.Location = new System.Drawing.Point(469, 308);
            this.buttonEmployeeAccountDetailSaveChanges.Name = "buttonEmployeeAccountDetailSaveChanges";
            this.buttonEmployeeAccountDetailSaveChanges.Size = new System.Drawing.Size(160, 77);
            this.buttonEmployeeAccountDetailSaveChanges.TabIndex = 2;
            this.buttonEmployeeAccountDetailSaveChanges.Text = "Save Changes";
            this.buttonEmployeeAccountDetailSaveChanges.UseVisualStyleBackColor = true;
            this.buttonEmployeeAccountDetailSaveChanges.Click += new System.EventHandler(this.buttonEmployeeAccountDetailSaveChanges_Click);
            // 
            // groupBoxAccountDetail
            // 
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailHoursWorked);
            this.groupBoxAccountDetail.Controls.Add(this.label35);
            this.groupBoxAccountDetail.Controls.Add(this.comboBoxAccountDetailCheckRunStatus);
            this.groupBoxAccountDetail.Controls.Add(this.comboBoxAccountDetailEmploymentStatus);
            this.groupBoxAccountDetail.Controls.Add(this.label32);
            this.groupBoxAccountDetail.Controls.Add(this.labelAccountDetailEmployeeID);
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailFederalTaxPercent);
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailMedicareTaxPercent);
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailSocialSecurityTaxPercent);
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailStateTaxPercent);
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailVacationDaysAllowedPerYear);
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailSickDaysAllowedPerYear);
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailHourlyRate);
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailOccupation);
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailJoinDate);
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailEmployeeName);
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailMedicareTaxWithheld);
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailSocialSecurityTaxWithheld);
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailStateTaxWithheld);
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailFederalTaxWithheld);
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailAccruedSickDays);
            this.groupBoxAccountDetail.Controls.Add(this.textBoxAccountDetailAccruedVacationDays);
            this.groupBoxAccountDetail.Controls.Add(this.label25);
            this.groupBoxAccountDetail.Controls.Add(this.label26);
            this.groupBoxAccountDetail.Controls.Add(this.label27);
            this.groupBoxAccountDetail.Controls.Add(this.label28);
            this.groupBoxAccountDetail.Controls.Add(this.label29);
            this.groupBoxAccountDetail.Controls.Add(this.label30);
            this.groupBoxAccountDetail.Controls.Add(this.label24);
            this.groupBoxAccountDetail.Controls.Add(this.label23);
            this.groupBoxAccountDetail.Controls.Add(this.label13);
            this.groupBoxAccountDetail.Controls.Add(this.label14);
            this.groupBoxAccountDetail.Controls.Add(this.label15);
            this.groupBoxAccountDetail.Controls.Add(this.label16);
            this.groupBoxAccountDetail.Controls.Add(this.label17);
            this.groupBoxAccountDetail.Controls.Add(this.label18);
            this.groupBoxAccountDetail.Controls.Add(this.label19);
            this.groupBoxAccountDetail.Controls.Add(this.label20);
            this.groupBoxAccountDetail.Controls.Add(this.label21);
            this.groupBoxAccountDetail.Controls.Add(this.label22);
            this.groupBoxAccountDetail.Location = new System.Drawing.Point(3, 11);
            this.groupBoxAccountDetail.Name = "groupBoxAccountDetail";
            this.groupBoxAccountDetail.Size = new System.Drawing.Size(626, 291);
            this.groupBoxAccountDetail.TabIndex = 1;
            this.groupBoxAccountDetail.TabStop = false;
            this.groupBoxAccountDetail.Text = "Account Detail";
            // 
            // textBoxAccountDetailHoursWorked
            // 
            this.textBoxAccountDetailHoursWorked.Location = new System.Drawing.Point(520, 100);
            this.textBoxAccountDetailHoursWorked.Name = "textBoxAccountDetailHoursWorked";
            this.textBoxAccountDetailHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailHoursWorked.TabIndex = 51;
            this.textBoxAccountDetailHoursWorked.Tag = "Numerical";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(329, 103);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(79, 13);
            this.label35.TabIndex = 50;
            this.label35.Text = "Hours Worked:";
            // 
            // comboBoxAccountDetailCheckRunStatus
            // 
            this.comboBoxAccountDetailCheckRunStatus.FormattingEnabled = true;
            this.comboBoxAccountDetailCheckRunStatus.Items.AddRange(new object[] {
            "Pending",
            "Approved"});
            this.comboBoxAccountDetailCheckRunStatus.Location = new System.Drawing.Point(520, 75);
            this.comboBoxAccountDetailCheckRunStatus.Name = "comboBoxAccountDetailCheckRunStatus";
            this.comboBoxAccountDetailCheckRunStatus.Size = new System.Drawing.Size(100, 21);
            this.comboBoxAccountDetailCheckRunStatus.TabIndex = 49;
            // 
            // comboBoxAccountDetailEmploymentStatus
            // 
            this.comboBoxAccountDetailEmploymentStatus.FormattingEnabled = true;
            this.comboBoxAccountDetailEmploymentStatus.Items.AddRange(new object[] {
            "Current",
            "Former"});
            this.comboBoxAccountDetailEmploymentStatus.Location = new System.Drawing.Point(520, 50);
            this.comboBoxAccountDetailEmploymentStatus.Name = "comboBoxAccountDetailEmploymentStatus";
            this.comboBoxAccountDetailEmploymentStatus.Size = new System.Drawing.Size(100, 21);
            this.comboBoxAccountDetailEmploymentStatus.TabIndex = 48;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(330, 78);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(100, 13);
            this.label32.TabIndex = 47;
            this.label32.Text = "Check Run Status: ";
            // 
            // labelAccountDetailEmployeeID
            // 
            this.labelAccountDetailEmployeeID.AutoSize = true;
            this.labelAccountDetailEmployeeID.Location = new System.Drawing.Point(599, 32);
            this.labelAccountDetailEmployeeID.Name = "labelAccountDetailEmployeeID";
            this.labelAccountDetailEmployeeID.Size = new System.Drawing.Size(21, 13);
            this.labelAccountDetailEmployeeID.TabIndex = 46;
            this.labelAccountDetailEmployeeID.Text = "ID ";
            // 
            // textBoxAccountDetailFederalTaxPercent
            // 
            this.textBoxAccountDetailFederalTaxPercent.Location = new System.Drawing.Point(215, 172);
            this.textBoxAccountDetailFederalTaxPercent.Name = "textBoxAccountDetailFederalTaxPercent";
            this.textBoxAccountDetailFederalTaxPercent.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailFederalTaxPercent.TabIndex = 45;
            this.textBoxAccountDetailFederalTaxPercent.Tag = "Numerical";
            // 
            // textBoxAccountDetailMedicareTaxPercent
            // 
            this.textBoxAccountDetailMedicareTaxPercent.Location = new System.Drawing.Point(215, 220);
            this.textBoxAccountDetailMedicareTaxPercent.Name = "textBoxAccountDetailMedicareTaxPercent";
            this.textBoxAccountDetailMedicareTaxPercent.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailMedicareTaxPercent.TabIndex = 44;
            this.textBoxAccountDetailMedicareTaxPercent.Tag = "Numerical";
            // 
            // textBoxAccountDetailSocialSecurityTaxPercent
            // 
            this.textBoxAccountDetailSocialSecurityTaxPercent.Location = new System.Drawing.Point(215, 244);
            this.textBoxAccountDetailSocialSecurityTaxPercent.Name = "textBoxAccountDetailSocialSecurityTaxPercent";
            this.textBoxAccountDetailSocialSecurityTaxPercent.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailSocialSecurityTaxPercent.TabIndex = 43;
            this.textBoxAccountDetailSocialSecurityTaxPercent.Tag = "Numerical";
            // 
            // textBoxAccountDetailStateTaxPercent
            // 
            this.textBoxAccountDetailStateTaxPercent.Location = new System.Drawing.Point(215, 196);
            this.textBoxAccountDetailStateTaxPercent.Name = "textBoxAccountDetailStateTaxPercent";
            this.textBoxAccountDetailStateTaxPercent.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailStateTaxPercent.TabIndex = 42;
            this.textBoxAccountDetailStateTaxPercent.Tag = "Numerical";
            // 
            // textBoxAccountDetailVacationDaysAllowedPerYear
            // 
            this.textBoxAccountDetailVacationDaysAllowedPerYear.Location = new System.Drawing.Point(215, 124);
            this.textBoxAccountDetailVacationDaysAllowedPerYear.Name = "textBoxAccountDetailVacationDaysAllowedPerYear";
            this.textBoxAccountDetailVacationDaysAllowedPerYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailVacationDaysAllowedPerYear.TabIndex = 41;
            this.textBoxAccountDetailVacationDaysAllowedPerYear.Tag = "Numerical";
            // 
            // textBoxAccountDetailSickDaysAllowedPerYear
            // 
            this.textBoxAccountDetailSickDaysAllowedPerYear.Location = new System.Drawing.Point(215, 148);
            this.textBoxAccountDetailSickDaysAllowedPerYear.Name = "textBoxAccountDetailSickDaysAllowedPerYear";
            this.textBoxAccountDetailSickDaysAllowedPerYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailSickDaysAllowedPerYear.TabIndex = 40;
            this.textBoxAccountDetailSickDaysAllowedPerYear.Tag = "Numerical";
            // 
            // textBoxAccountDetailHourlyRate
            // 
            this.textBoxAccountDetailHourlyRate.Location = new System.Drawing.Point(215, 100);
            this.textBoxAccountDetailHourlyRate.Name = "textBoxAccountDetailHourlyRate";
            this.textBoxAccountDetailHourlyRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailHourlyRate.TabIndex = 39;
            this.textBoxAccountDetailHourlyRate.Tag = "Numerical";
            // 
            // textBoxAccountDetailOccupation
            // 
            this.textBoxAccountDetailOccupation.Location = new System.Drawing.Point(215, 76);
            this.textBoxAccountDetailOccupation.Name = "textBoxAccountDetailOccupation";
            this.textBoxAccountDetailOccupation.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailOccupation.TabIndex = 38;
            // 
            // textBoxAccountDetailJoinDate
            // 
            this.textBoxAccountDetailJoinDate.Location = new System.Drawing.Point(215, 52);
            this.textBoxAccountDetailJoinDate.Name = "textBoxAccountDetailJoinDate";
            this.textBoxAccountDetailJoinDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailJoinDate.TabIndex = 37;
            this.textBoxAccountDetailJoinDate.Tag = "DateTime";
            // 
            // textBoxAccountDetailEmployeeName
            // 
            this.textBoxAccountDetailEmployeeName.Location = new System.Drawing.Point(215, 28);
            this.textBoxAccountDetailEmployeeName.Name = "textBoxAccountDetailEmployeeName";
            this.textBoxAccountDetailEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailEmployeeName.TabIndex = 36;
            // 
            // textBoxAccountDetailMedicareTaxWithheld
            // 
            this.textBoxAccountDetailMedicareTaxWithheld.Location = new System.Drawing.Point(520, 220);
            this.textBoxAccountDetailMedicareTaxWithheld.Name = "textBoxAccountDetailMedicareTaxWithheld";
            this.textBoxAccountDetailMedicareTaxWithheld.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailMedicareTaxWithheld.TabIndex = 33;
            this.textBoxAccountDetailMedicareTaxWithheld.Tag = "Numerical";
            // 
            // textBoxAccountDetailSocialSecurityTaxWithheld
            // 
            this.textBoxAccountDetailSocialSecurityTaxWithheld.Location = new System.Drawing.Point(520, 244);
            this.textBoxAccountDetailSocialSecurityTaxWithheld.Name = "textBoxAccountDetailSocialSecurityTaxWithheld";
            this.textBoxAccountDetailSocialSecurityTaxWithheld.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailSocialSecurityTaxWithheld.TabIndex = 32;
            this.textBoxAccountDetailSocialSecurityTaxWithheld.Tag = "Numerical";
            // 
            // textBoxAccountDetailStateTaxWithheld
            // 
            this.textBoxAccountDetailStateTaxWithheld.Location = new System.Drawing.Point(520, 196);
            this.textBoxAccountDetailStateTaxWithheld.Name = "textBoxAccountDetailStateTaxWithheld";
            this.textBoxAccountDetailStateTaxWithheld.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailStateTaxWithheld.TabIndex = 31;
            this.textBoxAccountDetailStateTaxWithheld.Tag = "Numerical";
            // 
            // textBoxAccountDetailFederalTaxWithheld
            // 
            this.textBoxAccountDetailFederalTaxWithheld.Location = new System.Drawing.Point(520, 172);
            this.textBoxAccountDetailFederalTaxWithheld.Name = "textBoxAccountDetailFederalTaxWithheld";
            this.textBoxAccountDetailFederalTaxWithheld.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailFederalTaxWithheld.TabIndex = 30;
            this.textBoxAccountDetailFederalTaxWithheld.Tag = "Numerical";
            // 
            // textBoxAccountDetailAccruedSickDays
            // 
            this.textBoxAccountDetailAccruedSickDays.Location = new System.Drawing.Point(520, 148);
            this.textBoxAccountDetailAccruedSickDays.Name = "textBoxAccountDetailAccruedSickDays";
            this.textBoxAccountDetailAccruedSickDays.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailAccruedSickDays.TabIndex = 29;
            this.textBoxAccountDetailAccruedSickDays.Tag = "Numerical";
            // 
            // textBoxAccountDetailAccruedVacationDays
            // 
            this.textBoxAccountDetailAccruedVacationDays.Location = new System.Drawing.Point(520, 124);
            this.textBoxAccountDetailAccruedVacationDays.Name = "textBoxAccountDetailAccruedVacationDays";
            this.textBoxAccountDetailAccruedVacationDays.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountDetailAccruedVacationDays.TabIndex = 28;
            this.textBoxAccountDetailAccruedVacationDays.Tag = "Numerical";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(329, 247);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(149, 13);
            this.label25.TabIndex = 27;
            this.label25.Text = "Social Security Tax Withheld: ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(329, 151);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(101, 13);
            this.label26.TabIndex = 26;
            this.label26.Text = "Accrued Sick Days:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(330, 175);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(114, 13);
            this.label27.TabIndex = 25;
            this.label27.Text = "Federal Tax Withheld: ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(329, 199);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(104, 13);
            this.label28.TabIndex = 24;
            this.label28.Text = "State Tax Withheld: ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(329, 223);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(123, 13);
            this.label29.TabIndex = 23;
            this.label29.Text = "Medicare Tax Withheld: ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(330, 127);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(122, 13);
            this.label30.TabIndex = 22;
            this.label30.Text = "Accrued Vacation Days:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(329, 55);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 13);
            this.label24.TabIndex = 21;
            this.label24.Text = "Employment Status:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(329, 31);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 13);
            this.label23.TabIndex = 20;
            this.label23.Text = "Employee ID: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Social Security Tax Percent: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Sick Days Allowed Per Year";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Federal Tax Percent: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "State Tax Percent: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 222);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Medicare Tax Percent: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Hourly Rate:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 126);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(160, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Vacation Days Allowed Per Year";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Occupation:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Join Date:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Employee Name: ";
            // 
            // tabEmployeeAccountRegistration
            // 
            this.tabEmployeeAccountRegistration.Controls.Add(this.buttonRegisterNewEmployee);
            this.tabEmployeeAccountRegistration.Controls.Add(this.groupBoxRegistrationFields);
            this.tabEmployeeAccountRegistration.Location = new System.Drawing.Point(4, 22);
            this.tabEmployeeAccountRegistration.Name = "tabEmployeeAccountRegistration";
            this.tabEmployeeAccountRegistration.Size = new System.Drawing.Size(652, 397);
            this.tabEmployeeAccountRegistration.TabIndex = 3;
            this.tabEmployeeAccountRegistration.Text = "Employee Account Registration";
            this.tabEmployeeAccountRegistration.UseVisualStyleBackColor = true;
            // 
            // buttonRegisterNewEmployee
            // 
            this.buttonRegisterNewEmployee.Location = new System.Drawing.Point(473, 296);
            this.buttonRegisterNewEmployee.Name = "buttonRegisterNewEmployee";
            this.buttonRegisterNewEmployee.Size = new System.Drawing.Size(165, 97);
            this.buttonRegisterNewEmployee.TabIndex = 1;
            this.buttonRegisterNewEmployee.Text = "Register New Employee";
            this.buttonRegisterNewEmployee.UseVisualStyleBackColor = true;
            this.buttonRegisterNewEmployee.Click += new System.EventHandler(this.buttonRegisterNewEmployee_Click);
            // 
            // groupBoxRegistrationFields
            // 
            this.groupBoxRegistrationFields.Controls.Add(this.textBoxRegistrationSocialSecurityTaxPercentWithheld);
            this.groupBoxRegistrationFields.Controls.Add(this.textBoxRegistrationMedicareTaxPercentWithheld);
            this.groupBoxRegistrationFields.Controls.Add(this.textBoxRegistrationStateTaxPercentWithheld);
            this.groupBoxRegistrationFields.Controls.Add(this.textBoxRegistrationFederalTaxPercentWithheld);
            this.groupBoxRegistrationFields.Controls.Add(this.textBoxRegistrationSickDaysAllowedPerYear);
            this.groupBoxRegistrationFields.Controls.Add(this.textBoxRegistrationVacationDaysAllowedPerYear);
            this.groupBoxRegistrationFields.Controls.Add(this.textBoxRegistrationHourlyRate);
            this.groupBoxRegistrationFields.Controls.Add(this.textBoxRegistrationOccupation);
            this.groupBoxRegistrationFields.Controls.Add(this.textBoxRegistrationJoinDate);
            this.groupBoxRegistrationFields.Controls.Add(this.textBoxRegistrationEmployeeName);
            this.groupBoxRegistrationFields.Controls.Add(this.label12);
            this.groupBoxRegistrationFields.Controls.Add(this.label11);
            this.groupBoxRegistrationFields.Controls.Add(this.label10);
            this.groupBoxRegistrationFields.Controls.Add(this.label9);
            this.groupBoxRegistrationFields.Controls.Add(this.label8);
            this.groupBoxRegistrationFields.Controls.Add(this.label7);
            this.groupBoxRegistrationFields.Controls.Add(this.label6);
            this.groupBoxRegistrationFields.Controls.Add(this.label5);
            this.groupBoxRegistrationFields.Controls.Add(this.label4);
            this.groupBoxRegistrationFields.Controls.Add(this.label3);
            this.groupBoxRegistrationFields.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRegistrationFields.Name = "groupBoxRegistrationFields";
            this.groupBoxRegistrationFields.Size = new System.Drawing.Size(626, 278);
            this.groupBoxRegistrationFields.TabIndex = 0;
            this.groupBoxRegistrationFields.TabStop = false;
            this.groupBoxRegistrationFields.Text = "Registration Fields";
            // 
            // textBoxRegistrationSocialSecurityTaxPercentWithheld
            // 
            this.textBoxRegistrationSocialSecurityTaxPercentWithheld.Location = new System.Drawing.Point(205, 246);
            this.textBoxRegistrationSocialSecurityTaxPercentWithheld.Name = "textBoxRegistrationSocialSecurityTaxPercentWithheld";
            this.textBoxRegistrationSocialSecurityTaxPercentWithheld.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationSocialSecurityTaxPercentWithheld.TabIndex = 19;
            this.textBoxRegistrationSocialSecurityTaxPercentWithheld.Tag = "Numerical";
            // 
            // textBoxRegistrationMedicareTaxPercentWithheld
            // 
            this.textBoxRegistrationMedicareTaxPercentWithheld.Location = new System.Drawing.Point(205, 221);
            this.textBoxRegistrationMedicareTaxPercentWithheld.Name = "textBoxRegistrationMedicareTaxPercentWithheld";
            this.textBoxRegistrationMedicareTaxPercentWithheld.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationMedicareTaxPercentWithheld.TabIndex = 18;
            this.textBoxRegistrationMedicareTaxPercentWithheld.Tag = "Numerical";
            // 
            // textBoxRegistrationStateTaxPercentWithheld
            // 
            this.textBoxRegistrationStateTaxPercentWithheld.Location = new System.Drawing.Point(205, 196);
            this.textBoxRegistrationStateTaxPercentWithheld.Name = "textBoxRegistrationStateTaxPercentWithheld";
            this.textBoxRegistrationStateTaxPercentWithheld.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationStateTaxPercentWithheld.TabIndex = 17;
            this.textBoxRegistrationStateTaxPercentWithheld.Tag = "Numerical";
            // 
            // textBoxRegistrationFederalTaxPercentWithheld
            // 
            this.textBoxRegistrationFederalTaxPercentWithheld.Location = new System.Drawing.Point(205, 171);
            this.textBoxRegistrationFederalTaxPercentWithheld.Name = "textBoxRegistrationFederalTaxPercentWithheld";
            this.textBoxRegistrationFederalTaxPercentWithheld.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationFederalTaxPercentWithheld.TabIndex = 16;
            this.textBoxRegistrationFederalTaxPercentWithheld.Tag = "Numerical";
            // 
            // textBoxRegistrationSickDaysAllowedPerYear
            // 
            this.textBoxRegistrationSickDaysAllowedPerYear.Location = new System.Drawing.Point(205, 146);
            this.textBoxRegistrationSickDaysAllowedPerYear.Name = "textBoxRegistrationSickDaysAllowedPerYear";
            this.textBoxRegistrationSickDaysAllowedPerYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationSickDaysAllowedPerYear.TabIndex = 15;
            this.textBoxRegistrationSickDaysAllowedPerYear.Tag = "Numerical";
            // 
            // textBoxRegistrationVacationDaysAllowedPerYear
            // 
            this.textBoxRegistrationVacationDaysAllowedPerYear.Location = new System.Drawing.Point(205, 121);
            this.textBoxRegistrationVacationDaysAllowedPerYear.Name = "textBoxRegistrationVacationDaysAllowedPerYear";
            this.textBoxRegistrationVacationDaysAllowedPerYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationVacationDaysAllowedPerYear.TabIndex = 14;
            this.textBoxRegistrationVacationDaysAllowedPerYear.Tag = "Numerical";
            // 
            // textBoxRegistrationHourlyRate
            // 
            this.textBoxRegistrationHourlyRate.Location = new System.Drawing.Point(205, 96);
            this.textBoxRegistrationHourlyRate.Name = "textBoxRegistrationHourlyRate";
            this.textBoxRegistrationHourlyRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationHourlyRate.TabIndex = 13;
            this.textBoxRegistrationHourlyRate.Tag = "Numerical";
            // 
            // textBoxRegistrationOccupation
            // 
            this.textBoxRegistrationOccupation.Location = new System.Drawing.Point(205, 71);
            this.textBoxRegistrationOccupation.Name = "textBoxRegistrationOccupation";
            this.textBoxRegistrationOccupation.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationOccupation.TabIndex = 12;
            // 
            // textBoxRegistrationJoinDate
            // 
            this.textBoxRegistrationJoinDate.Location = new System.Drawing.Point(205, 46);
            this.textBoxRegistrationJoinDate.Name = "textBoxRegistrationJoinDate";
            this.textBoxRegistrationJoinDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationJoinDate.TabIndex = 11;
            this.textBoxRegistrationJoinDate.Tag = "DateTime";
            // 
            // textBoxRegistrationEmployeeName
            // 
            this.textBoxRegistrationEmployeeName.Location = new System.Drawing.Point(205, 21);
            this.textBoxRegistrationEmployeeName.Name = "textBoxRegistrationEmployeeName";
            this.textBoxRegistrationEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationEmployeeName.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Social Security Tax Percent:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Sick Days Allowed Per Year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Federal Tax Percent:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "State Tax Percent:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Medicare Tax Percent:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hourly Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Vacation Days Allowed Per Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Occupation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Join Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Employee Name: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approveCheckToolStripMenuItem,
            this.editEmployeeAccountDetailsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 48);
            // 
            // approveCheckToolStripMenuItem
            // 
            this.approveCheckToolStripMenuItem.Name = "approveCheckToolStripMenuItem";
            this.approveCheckToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.approveCheckToolStripMenuItem.Text = "Change Check Run Status";
            this.approveCheckToolStripMenuItem.Click += new System.EventHandler(this.changeCheckRunStatusToolStripMenuItem_Click);
            // 
            // editEmployeeAccountDetailsToolStripMenuItem
            // 
            this.editEmployeeAccountDetailsToolStripMenuItem.Name = "editEmployeeAccountDetailsToolStripMenuItem";
            this.editEmployeeAccountDetailsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.editEmployeeAccountDetailsToolStripMenuItem.Text = "Edit Employee Account Details";
            this.editEmployeeAccountDetailsToolStripMenuItem.Click += new System.EventHandler(this.editEmployeeAccountDetailsToolStripMenuItem_Click);
            // 
            // Payroll_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Payroll_Application";
            this.Text = "Payroll Application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabMainDashboard.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabEmployeeDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeDatabase)).EndInit();
            this.tabEmployeeAccountDetail.ResumeLayout(false);
            this.groupBoxAccountDetail.ResumeLayout(false);
            this.groupBoxAccountDetail.PerformLayout();
            this.tabEmployeeAccountRegistration.ResumeLayout(false);
            this.groupBoxRegistrationFields.ResumeLayout(false);
            this.groupBoxRegistrationFields.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMainDashboard;
        private System.Windows.Forms.TabPage tabEmployeeDatabase;
        private System.Windows.Forms.TabPage tabEmployeeAccountDetail;
        private System.Windows.Forms.TabPage tabEmployeeAccountRegistration;
        private System.Windows.Forms.Button buttonRunChecksForCurrentPayPeriod;
        private System.Windows.Forms.Button buttonPrepareForNextPayPeriod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxRegistrationFields;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRegisterNewEmployee;
        private System.Windows.Forms.TextBox textBoxRegistrationSocialSecurityTaxPercentWithheld;
        private System.Windows.Forms.TextBox textBoxRegistrationMedicareTaxPercentWithheld;
        private System.Windows.Forms.TextBox textBoxRegistrationStateTaxPercentWithheld;
        private System.Windows.Forms.TextBox textBoxRegistrationFederalTaxPercentWithheld;
        private System.Windows.Forms.TextBox textBoxRegistrationSickDaysAllowedPerYear;
        private System.Windows.Forms.TextBox textBoxRegistrationVacationDaysAllowedPerYear;
        private System.Windows.Forms.TextBox textBoxRegistrationHourlyRate;
        private System.Windows.Forms.TextBox textBoxRegistrationOccupation;
        private System.Windows.Forms.TextBox textBoxRegistrationJoinDate;
        private System.Windows.Forms.TextBox textBoxRegistrationEmployeeName;
        private System.Windows.Forms.Button buttonEmployeeAccountDetailSaveChanges;
        private System.Windows.Forms.GroupBox groupBoxAccountDetail;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxAccountDetailFederalTaxPercent;
        private System.Windows.Forms.TextBox textBoxAccountDetailMedicareTaxPercent;
        private System.Windows.Forms.TextBox textBoxAccountDetailSocialSecurityTaxPercent;
        private System.Windows.Forms.TextBox textBoxAccountDetailStateTaxPercent;
        private System.Windows.Forms.TextBox textBoxAccountDetailVacationDaysAllowedPerYear;
        private System.Windows.Forms.TextBox textBoxAccountDetailSickDaysAllowedPerYear;
        private System.Windows.Forms.TextBox textBoxAccountDetailHourlyRate;
        private System.Windows.Forms.TextBox textBoxAccountDetailOccupation;
        private System.Windows.Forms.TextBox textBoxAccountDetailJoinDate;
        private System.Windows.Forms.TextBox textBoxAccountDetailEmployeeName;
        private System.Windows.Forms.TextBox textBoxAccountDetailMedicareTaxWithheld;
        private System.Windows.Forms.TextBox textBoxAccountDetailSocialSecurityTaxWithheld;
        private System.Windows.Forms.TextBox textBoxAccountDetailStateTaxWithheld;
        private System.Windows.Forms.TextBox textBoxAccountDetailFederalTaxWithheld;
        private System.Windows.Forms.TextBox textBoxAccountDetailAccruedSickDays;
        private System.Windows.Forms.TextBox textBoxAccountDetailAccruedVacationDays;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label labelAccountDetailEmployeeID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTotalRegisteredEmployees;
        private System.Windows.Forms.ComboBox comboBoxAccountDetailCheckRunStatus;
        private System.Windows.Forms.ComboBox comboBoxAccountDetailEmploymentStatus;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBoxAccountDetailHoursWorked;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DataGridView dataGridViewEmployeeDatabase;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem approveCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeAccountDetailsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

