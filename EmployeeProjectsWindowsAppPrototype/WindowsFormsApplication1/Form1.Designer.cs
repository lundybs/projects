namespace WindowsFormsApplication1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerEPH = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEPHHours = new System.Windows.Forms.ComboBox();
            this.comboBoxEPHProjectID = new System.Windows.Forms.ComboBox();
            this.comboBoxEPHEmplyeeID = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeProjectHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEPHNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeEPHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEPHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addENNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPNNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutEmployeeProjectsManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEPH = new System.Windows.Forms.TabPage();
            this.dataGridViewEmployeeHours = new System.Windows.Forms.DataGridView();
            this.tabPageEN = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtModifyEmployeeName = new System.Windows.Forms.TextBox();
            this.btnEmployeeDataModify = new System.Windows.Forms.Button();
            this.radioButtonDeleteEmployee = new System.Windows.Forms.RadioButton();
            this.radioButtonModifiyEmployee = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxENName = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.txtEmployeeAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewEmployeeName = new System.Windows.Forms.DataGridView();
            this.tabPagePN = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtUpdateProjectDesc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUpdateProjectID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonDeleteProjectID = new System.Windows.Forms.RadioButton();
            this.radioButtonUptdateProjectID = new System.Windows.Forms.RadioButton();
            this.comboBoxPNProjectID = new System.Windows.Forms.ComboBox();
            this.btnModifyProjectID = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtAddProjectID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNewProjectID = new System.Windows.Forms.Button();
            this.dataGridViewProjectID = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAddProjectDesc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageEPH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeHours)).BeginInit();
            this.tabPageEN.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeName)).BeginInit();
            this.tabPagePN.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectID)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerEPH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxEPHHours);
            this.groupBox1.Controls.Add(this.comboBoxEPHProjectID);
            this.groupBox1.Controls.Add(this.comboBoxEPHEmplyeeID);
            this.groupBox1.Location = new System.Drawing.Point(746, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Entry";
            // 
            // dateTimePickerEPH
            // 
            this.dateTimePickerEPH.Location = new System.Drawing.Point(98, 99);
            this.dateTimePickerEPH.Name = "dateTimePickerEPH";
            this.dateTimePickerEPH.Size = new System.Drawing.Size(274, 22);
            this.dateTimePickerEPH.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Project ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee ID";
            // 
            // comboBoxEPHHours
            // 
            this.comboBoxEPHHours.FormattingEnabled = true;
            this.comboBoxEPHHours.Location = new System.Drawing.Point(98, 137);
            this.comboBoxEPHHours.Name = "comboBoxEPHHours";
            this.comboBoxEPHHours.Size = new System.Drawing.Size(274, 24);
            this.comboBoxEPHHours.TabIndex = 3;
            // 
            // comboBoxEPHProjectID
            // 
            this.comboBoxEPHProjectID.FormattingEnabled = true;
            this.comboBoxEPHProjectID.Location = new System.Drawing.Point(98, 59);
            this.comboBoxEPHProjectID.Name = "comboBoxEPHProjectID";
            this.comboBoxEPHProjectID.Size = new System.Drawing.Size(274, 24);
            this.comboBoxEPHProjectID.TabIndex = 1;
            // 
            // comboBoxEPHEmplyeeID
            // 
            this.comboBoxEPHEmplyeeID.FormattingEnabled = true;
            this.comboBoxEPHEmplyeeID.Location = new System.Drawing.Point(98, 21);
            this.comboBoxEPHEmplyeeID.Name = "comboBoxEPHEmplyeeID";
            this.comboBoxEPHEmplyeeID.Size = new System.Drawing.Size(274, 24);
            this.comboBoxEPHEmplyeeID.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonDelete);
            this.groupBox2.Controls.Add(this.radioButtonUpdate);
            this.groupBox2.Controls.Add(this.radioButtonAdd);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Location = new System.Drawing.Point(746, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(7, 78);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(120, 21);
            this.radioButtonDelete.TabIndex = 3;
            this.radioButtonDelete.TabStop = true;
            this.radioButtonDelete.Text = "Delete Record";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(7, 50);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(125, 21);
            this.radioButtonUpdate.TabIndex = 2;
            this.radioButtonUpdate.TabStop = true;
            this.radioButtonUpdate.Text = "Update Record";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(7, 22);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(135, 21);
            this.radioButtonAdd.TabIndex = 1;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "Add New Record";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(215, 22);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(131, 77);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1178, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshDataToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // refreshDataToolStripMenuItem
            // 
            this.refreshDataToolStripMenuItem.Name = "refreshDataToolStripMenuItem";
            this.refreshDataToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.refreshDataToolStripMenuItem.Text = "&Refresh Data";
            this.refreshDataToolStripMenuItem.Click += new System.EventHandler(this.refreshDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(169, 26);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeProjectHoursToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.projectToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "E&dit";
            // 
            // employeeProjectHoursToolStripMenuItem
            // 
            this.employeeProjectHoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEPHNewToolStripMenuItem,
            this.changeEPHToolStripMenuItem,
            this.deleteEPHToolStripMenuItem});
            this.employeeProjectHoursToolStripMenuItem.Name = "employeeProjectHoursToolStripMenuItem";
            this.employeeProjectHoursToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.employeeProjectHoursToolStripMenuItem.Text = "Employee &Project Hours";
            // 
            // addEPHNewToolStripMenuItem
            // 
            this.addEPHNewToolStripMenuItem.Name = "addEPHNewToolStripMenuItem";
            this.addEPHNewToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.addEPHNewToolStripMenuItem.Text = "Add &New";
            this.addEPHNewToolStripMenuItem.Click += new System.EventHandler(this.addEPHNewToolStripMenuItem_Click);
            // 
            // changeEPHToolStripMenuItem
            // 
            this.changeEPHToolStripMenuItem.Name = "changeEPHToolStripMenuItem";
            this.changeEPHToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.changeEPHToolStripMenuItem.Text = "&Change";
            this.changeEPHToolStripMenuItem.Click += new System.EventHandler(this.changeEPHToolStripMenuItem_Click);
            // 
            // deleteEPHToolStripMenuItem
            // 
            this.deleteEPHToolStripMenuItem.Name = "deleteEPHToolStripMenuItem";
            this.deleteEPHToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.deleteEPHToolStripMenuItem.Text = "&Delete";
            this.deleteEPHToolStripMenuItem.Click += new System.EventHandler(this.deleteEPHToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addENNewToolStripMenuItem,
            this.changeENToolStripMenuItem,
            this.deleteENToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.employeeToolStripMenuItem.Text = "&Employee";
            // 
            // addENNewToolStripMenuItem
            // 
            this.addENNewToolStripMenuItem.Name = "addENNewToolStripMenuItem";
            this.addENNewToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.addENNewToolStripMenuItem.Text = "Add &New";
            this.addENNewToolStripMenuItem.Click += new System.EventHandler(this.addENNewToolStripMenuItem_Click);
            // 
            // changeENToolStripMenuItem
            // 
            this.changeENToolStripMenuItem.Name = "changeENToolStripMenuItem";
            this.changeENToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.changeENToolStripMenuItem.Text = "&Change";
            this.changeENToolStripMenuItem.Click += new System.EventHandler(this.changeENToolStripMenuItem_Click);
            // 
            // deleteENToolStripMenuItem
            // 
            this.deleteENToolStripMenuItem.Name = "deleteENToolStripMenuItem";
            this.deleteENToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.deleteENToolStripMenuItem.Text = "&Delete";
            this.deleteENToolStripMenuItem.Click += new System.EventHandler(this.deleteENToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPNNewToolStripMenuItem,
            this.changePNToolStripMenuItem,
            this.deletePNToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.projectToolStripMenuItem.Text = "P&roject";
            // 
            // addPNNewToolStripMenuItem
            // 
            this.addPNNewToolStripMenuItem.Name = "addPNNewToolStripMenuItem";
            this.addPNNewToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.addPNNewToolStripMenuItem.Text = "Add &New";
            this.addPNNewToolStripMenuItem.Click += new System.EventHandler(this.addPNNewToolStripMenuItem_Click);
            // 
            // changePNToolStripMenuItem
            // 
            this.changePNToolStripMenuItem.Name = "changePNToolStripMenuItem";
            this.changePNToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.changePNToolStripMenuItem.Text = "&Change";
            this.changePNToolStripMenuItem.Click += new System.EventHandler(this.changePNToolStripMenuItem_Click);
            // 
            // deletePNToolStripMenuItem
            // 
            this.deletePNToolStripMenuItem.Name = "deletePNToolStripMenuItem";
            this.deletePNToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.deletePNToolStripMenuItem.Text = "&Delete";
            this.deletePNToolStripMenuItem.Click += new System.EventHandler(this.deletePNToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutEmployeeProjectsManagerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(314, 26);
            this.helpToolStripMenuItem1.Text = "He&lp";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.manualToolStripMenuItem.Text = "&Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // aboutEmployeeProjectsManagerToolStripMenuItem
            // 
            this.aboutEmployeeProjectsManagerToolStripMenuItem.Name = "aboutEmployeeProjectsManagerToolStripMenuItem";
            this.aboutEmployeeProjectsManagerToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.aboutEmployeeProjectsManagerToolStripMenuItem.Text = "&About Employee Projects Manager";
            this.aboutEmployeeProjectsManagerToolStripMenuItem.Click += new System.EventHandler(this.aboutEmployeeProjectsManagerToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1178, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 20);
            this.toolStripStatusLabel1.Text = "Ready...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEPH);
            this.tabControl1.Controls.Add(this.tabPageEN);
            this.tabControl1.Controls.Add(this.tabPagePN);
            this.tabControl1.Location = new System.Drawing.Point(19, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1151, 393);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageEPH
            // 
            this.tabPageEPH.Controls.Add(this.dataGridViewEmployeeHours);
            this.tabPageEPH.Controls.Add(this.groupBox1);
            this.tabPageEPH.Controls.Add(this.groupBox2);
            this.tabPageEPH.Location = new System.Drawing.Point(4, 25);
            this.tabPageEPH.Name = "tabPageEPH";
            this.tabPageEPH.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEPH.Size = new System.Drawing.Size(1143, 364);
            this.tabPageEPH.TabIndex = 0;
            this.tabPageEPH.Text = "Employee Project Hours ";
            this.tabPageEPH.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmployeeHours
            // 
            this.dataGridViewEmployeeHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeHours.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewEmployeeHours.Name = "dataGridViewEmployeeHours";
            this.dataGridViewEmployeeHours.RowTemplate.Height = 24;
            this.dataGridViewEmployeeHours.Size = new System.Drawing.Size(716, 338);
            this.dataGridViewEmployeeHours.TabIndex = 2;
            // 
            // tabPageEN
            // 
            this.tabPageEN.Controls.Add(this.groupBox4);
            this.tabPageEN.Controls.Add(this.groupBox3);
            this.tabPageEN.Controls.Add(this.dataGridViewEmployeeName);
            this.tabPageEN.Location = new System.Drawing.Point(4, 25);
            this.tabPageEN.Name = "tabPageEN";
            this.tabPageEN.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEN.Size = new System.Drawing.Size(1143, 364);
            this.tabPageEN.TabIndex = 1;
            this.tabPageEN.Text = "Employee Names";
            this.tabPageEN.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtModifyEmployeeName);
            this.groupBox4.Controls.Add(this.btnEmployeeDataModify);
            this.groupBox4.Controls.Add(this.radioButtonDeleteEmployee);
            this.groupBox4.Controls.Add(this.radioButtonModifiyEmployee);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.comboBoxENName);
            this.groupBox4.Location = new System.Drawing.Point(815, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 185);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Modify Employee Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Modify Employee Name";
            // 
            // txtModifyEmployeeName
            // 
            this.txtModifyEmployeeName.Location = new System.Drawing.Point(168, 59);
            this.txtModifyEmployeeName.Name = "txtModifyEmployeeName";
            this.txtModifyEmployeeName.Size = new System.Drawing.Size(147, 22);
            this.txtModifyEmployeeName.TabIndex = 5;
            // 
            // btnEmployeeDataModify
            // 
            this.btnEmployeeDataModify.Location = new System.Drawing.Point(58, 148);
            this.btnEmployeeDataModify.Name = "btnEmployeeDataModify";
            this.btnEmployeeDataModify.Size = new System.Drawing.Size(168, 31);
            this.btnEmployeeDataModify.TabIndex = 4;
            this.btnEmployeeDataModify.Text = "Modify Employee Data";
            this.btnEmployeeDataModify.UseVisualStyleBackColor = true;
            this.btnEmployeeDataModify.Click += new System.EventHandler(this.btnEmployeeDataModify_Click);
            // 
            // radioButtonDeleteEmployee
            // 
            this.radioButtonDeleteEmployee.AutoSize = true;
            this.radioButtonDeleteEmployee.Location = new System.Drawing.Point(14, 121);
            this.radioButtonDeleteEmployee.Name = "radioButtonDeleteEmployee";
            this.radioButtonDeleteEmployee.Size = new System.Drawing.Size(170, 21);
            this.radioButtonDeleteEmployee.TabIndex = 3;
            this.radioButtonDeleteEmployee.TabStop = true;
            this.radioButtonDeleteEmployee.Text = "Delete Employee Data";
            this.radioButtonDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // radioButtonModifiyEmployee
            // 
            this.radioButtonModifiyEmployee.AutoSize = true;
            this.radioButtonModifiyEmployee.Location = new System.Drawing.Point(14, 94);
            this.radioButtonModifiyEmployee.Name = "radioButtonModifiyEmployee";
            this.radioButtonModifiyEmployee.Size = new System.Drawing.Size(175, 21);
            this.radioButtonModifiyEmployee.TabIndex = 2;
            this.radioButtonModifiyEmployee.TabStop = true;
            this.radioButtonModifiyEmployee.Text = "Update Employee Data";
            this.radioButtonModifiyEmployee.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Employee Name";
            // 
            // comboBoxENName
            // 
            this.comboBoxENName.FormattingEnabled = true;
            this.comboBoxENName.Location = new System.Drawing.Point(128, 28);
            this.comboBoxENName.Name = "comboBoxENName";
            this.comboBoxENName.Size = new System.Drawing.Size(187, 24);
            this.comboBoxENName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddEmployee);
            this.groupBox3.Controls.Add(this.txtEmployeeAdd);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(810, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 130);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New Employee Name";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(68, 69);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(199, 42);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add New Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // txtEmployeeAdd
            // 
            this.txtEmployeeAdd.Location = new System.Drawing.Point(123, 41);
            this.txtEmployeeAdd.Name = "txtEmployeeAdd";
            this.txtEmployeeAdd.Size = new System.Drawing.Size(198, 22);
            this.txtEmployeeAdd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Employee Name";
            // 
            // dataGridViewEmployeeName
            // 
            this.dataGridViewEmployeeName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeName.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewEmployeeName.Name = "dataGridViewEmployeeName";
            this.dataGridViewEmployeeName.RowTemplate.Height = 24;
            this.dataGridViewEmployeeName.Size = new System.Drawing.Size(798, 352);
            this.dataGridViewEmployeeName.TabIndex = 0;
            // 
            // tabPagePN
            // 
            this.tabPagePN.Controls.Add(this.groupBox6);
            this.tabPagePN.Controls.Add(this.groupBox5);
            this.tabPagePN.Controls.Add(this.dataGridViewProjectID);
            this.tabPagePN.Location = new System.Drawing.Point(4, 25);
            this.tabPagePN.Name = "tabPagePN";
            this.tabPagePN.Size = new System.Drawing.Size(1143, 364);
            this.tabPagePN.TabIndex = 2;
            this.tabPagePN.Text = "Project Names";
            this.tabPagePN.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtUpdateProjectDesc);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txtUpdateProjectID);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.radioButtonDeleteProjectID);
            this.groupBox6.Controls.Add(this.radioButtonUptdateProjectID);
            this.groupBox6.Controls.Add(this.comboBoxPNProjectID);
            this.groupBox6.Controls.Add(this.btnModifyProjectID);
            this.groupBox6.Location = new System.Drawing.Point(795, 160);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(345, 195);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Modify Project ID";
            // 
            // txtUpdateProjectDesc
            // 
            this.txtUpdateProjectDesc.Location = new System.Drawing.Point(132, 90);
            this.txtUpdateProjectDesc.Name = "txtUpdateProjectDesc";
            this.txtUpdateProjectDesc.Size = new System.Drawing.Size(207, 22);
            this.txtUpdateProjectDesc.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "New Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "New Project ID";
            // 
            // txtUpdateProjectID
            // 
            this.txtUpdateProjectID.Location = new System.Drawing.Point(132, 61);
            this.txtUpdateProjectID.Name = "txtUpdateProjectID";
            this.txtUpdateProjectID.Size = new System.Drawing.Size(207, 22);
            this.txtUpdateProjectID.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Current Project ID";
            // 
            // radioButtonDeleteProjectID
            // 
            this.radioButtonDeleteProjectID.AutoSize = true;
            this.radioButtonDeleteProjectID.Location = new System.Drawing.Point(184, 120);
            this.radioButtonDeleteProjectID.Name = "radioButtonDeleteProjectID";
            this.radioButtonDeleteProjectID.Size = new System.Drawing.Size(135, 21);
            this.radioButtonDeleteProjectID.TabIndex = 3;
            this.radioButtonDeleteProjectID.TabStop = true;
            this.radioButtonDeleteProjectID.Text = "Delete Project ID";
            this.radioButtonDeleteProjectID.UseVisualStyleBackColor = true;
            // 
            // radioButtonUptdateProjectID
            // 
            this.radioButtonUptdateProjectID.AutoSize = true;
            this.radioButtonUptdateProjectID.Location = new System.Drawing.Point(38, 120);
            this.radioButtonUptdateProjectID.Name = "radioButtonUptdateProjectID";
            this.radioButtonUptdateProjectID.Size = new System.Drawing.Size(140, 21);
            this.radioButtonUptdateProjectID.TabIndex = 2;
            this.radioButtonUptdateProjectID.TabStop = true;
            this.radioButtonUptdateProjectID.Text = "Update Project ID";
            this.radioButtonUptdateProjectID.UseVisualStyleBackColor = true;
            // 
            // comboBoxPNProjectID
            // 
            this.comboBoxPNProjectID.FormattingEnabled = true;
            this.comboBoxPNProjectID.Location = new System.Drawing.Point(132, 31);
            this.comboBoxPNProjectID.Name = "comboBoxPNProjectID";
            this.comboBoxPNProjectID.Size = new System.Drawing.Size(207, 24);
            this.comboBoxPNProjectID.TabIndex = 1;
            // 
            // btnModifyProjectID
            // 
            this.btnModifyProjectID.Location = new System.Drawing.Point(38, 147);
            this.btnModifyProjectID.Name = "btnModifyProjectID";
            this.btnModifyProjectID.Size = new System.Drawing.Size(216, 39);
            this.btnModifyProjectID.TabIndex = 0;
            this.btnModifyProjectID.Text = "Modify Project ID";
            this.btnModifyProjectID.UseVisualStyleBackColor = true;
            this.btnModifyProjectID.Click += new System.EventHandler(this.btnModifyProjectID_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtAddProjectDesc);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtAddProjectID);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.btnNewProjectID);
            this.groupBox5.Location = new System.Drawing.Point(795, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 141);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "New Project ID";
            // 
            // txtAddProjectID
            // 
            this.txtAddProjectID.Location = new System.Drawing.Point(111, 21);
            this.txtAddProjectID.Name = "txtAddProjectID";
            this.txtAddProjectID.Size = new System.Drawing.Size(228, 22);
            this.txtAddProjectID.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Project ID";
            // 
            // btnNewProjectID
            // 
            this.btnNewProjectID.Location = new System.Drawing.Point(39, 79);
            this.btnNewProjectID.Name = "btnNewProjectID";
            this.btnNewProjectID.Size = new System.Drawing.Size(236, 44);
            this.btnNewProjectID.TabIndex = 0;
            this.btnNewProjectID.Text = "New Project ID";
            this.btnNewProjectID.UseVisualStyleBackColor = true;
            this.btnNewProjectID.Click += new System.EventHandler(this.btnNewProjectID_Click);
            // 
            // dataGridViewProjectID
            // 
            this.dataGridViewProjectID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjectID.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProjectID.Name = "dataGridViewProjectID";
            this.dataGridViewProjectID.RowTemplate.Height = 24;
            this.dataGridViewProjectID.Size = new System.Drawing.Size(786, 358);
            this.dataGridViewProjectID.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Description";
            // 
            // txtAddProjectDesc
            // 
            this.txtAddProjectDesc.Location = new System.Drawing.Point(111, 49);
            this.txtAddProjectDesc.Name = "txtAddProjectDesc";
            this.txtAddProjectDesc.Size = new System.Drawing.Size(228, 22);
            this.txtAddProjectDesc.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 477);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageEPH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeHours)).EndInit();
            this.tabPageEN.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeName)).EndInit();
            this.tabPagePN.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEPH;
        private System.Windows.Forms.TabPage tabPageEN;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeProjectHoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEPHNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeEPHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEPHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addENNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPNNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutEmployeeProjectsManagerToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewEmployeeHours;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage tabPagePN;
        private System.Windows.Forms.ComboBox comboBoxEPHEmplyeeID;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEPHHours;
        private System.Windows.Forms.ComboBox comboBoxEPHProjectID;
        private System.Windows.Forms.DateTimePicker dateTimePickerEPH;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonDeleteEmployee;
        private System.Windows.Forms.RadioButton radioButtonModifiyEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxENName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox txtEmployeeAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewEmployeeName;
        private System.Windows.Forms.Button btnEmployeeDataModify;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUpdateProjectID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonDeleteProjectID;
        private System.Windows.Forms.RadioButton radioButtonUptdateProjectID;
        private System.Windows.Forms.ComboBox comboBoxPNProjectID;
        private System.Windows.Forms.Button btnModifyProjectID;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtAddProjectID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNewProjectID;
        private System.Windows.Forms.DataGridView dataGridViewProjectID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtModifyEmployeeName;
        private System.Windows.Forms.TextBox txtUpdateProjectDesc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAddProjectDesc;
        private System.Windows.Forms.Label label12;
    }
}

