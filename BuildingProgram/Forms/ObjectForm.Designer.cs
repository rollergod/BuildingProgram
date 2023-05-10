namespace BuildingProgram.Forms
{
    partial class ObjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_BuildingCompany = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_IsBuildingPermit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_objectNum = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_BuildingStatus = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_DateStartPlan = new System.Windows.Forms.Label();
            this.lb_DateStartFact = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lb_EndDate = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_InfoLand = new System.Windows.Forms.Button();
            this.btn_ObjectOrg = new System.Windows.Forms.Button();
            this.btn_Smeta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.menuPicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ObjectForm = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_OrgForm = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_LandForm = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_BuildingCompanyForm = new System.Windows.Forms.Button();
            this.reportContainer = new System.Windows.Forms.Panel();
            this.btn_BuildingCompanyRep = new System.Windows.Forms.Button();
            this.btn_RepForm = new System.Windows.Forms.Button();
            this.btn_ReportForm = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.reportTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_DeleteNote = new Krypton.Toolkit.KryptonButton();
            this.btn_ChangeNote = new Krypton.Toolkit.KryptonButton();
            this.btn_AddNote = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.sideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.reportContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(481, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Документ объекта";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Список заметок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(638, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Название:";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(638, 125);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(168, 15);
            this.lb_Name.TabIndex = 8;
            this.lb_Name.Text = "Жилой комплекс “River Park”";
            // 
            // lb_BuildingCompany
            // 
            this.lb_BuildingCompany.AutoSize = true;
            this.lb_BuildingCompany.Location = new System.Drawing.Point(638, 167);
            this.lb_BuildingCompany.Name = "lb_BuildingCompany";
            this.lb_BuildingCompany.Size = new System.Drawing.Size(82, 15);
            this.lb_BuildingCompany.TabIndex = 10;
            this.lb_BuildingCompany.Text = "Ферро-Строй";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(638, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Строительная компания:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(638, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Группа 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(638, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Контроль выполняет:";
            // 
            // lb_IsBuildingPermit
            // 
            this.lb_IsBuildingPermit.AutoSize = true;
            this.lb_IsBuildingPermit.Location = new System.Drawing.Point(834, 60);
            this.lb_IsBuildingPermit.Name = "lb_IsBuildingPermit";
            this.lb_IsBuildingPermit.Size = new System.Drawing.Size(21, 15);
            this.lb_IsBuildingPermit.TabIndex = 14;
            this.lb_IsBuildingPermit.Text = "Да";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(834, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Разрешена ли стройка:";
            // 
            // lb_objectNum
            // 
            this.lb_objectNum.AutoSize = true;
            this.lb_objectNum.Location = new System.Drawing.Point(638, 60);
            this.lb_objectNum.Name = "lb_objectNum";
            this.lb_objectNum.Size = new System.Drawing.Size(31, 15);
            this.lb_objectNum.TabIndex = 19;
            this.lb_objectNum.Text = "1000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(638, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Номер объекта:";
            // 
            // lb_BuildingStatus
            // 
            this.lb_BuildingStatus.AutoSize = true;
            this.lb_BuildingStatus.Location = new System.Drawing.Point(834, 93);
            this.lb_BuildingStatus.Name = "lb_BuildingStatus";
            this.lb_BuildingStatus.Size = new System.Drawing.Size(58, 15);
            this.lb_BuildingStatus.TabIndex = 21;
            this.lb_BuildingStatus.Text = "Строится";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(834, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 15);
            this.label14.TabIndex = 20;
            this.label14.Text = "Статус:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(834, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 15);
            this.label15.TabIndex = 23;
            this.label15.Text = "начало плановое:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(834, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "Даты строительства:";
            // 
            // lb_DateStartPlan
            // 
            this.lb_DateStartPlan.AutoSize = true;
            this.lb_DateStartPlan.Location = new System.Drawing.Point(834, 140);
            this.lb_DateStartPlan.Name = "lb_DateStartPlan";
            this.lb_DateStartPlan.Size = new System.Drawing.Size(61, 15);
            this.lb_DateStartPlan.TabIndex = 24;
            this.lb_DateStartPlan.Text = "01.06.2023";
            // 
            // lb_DateStartFact
            // 
            this.lb_DateStartFact.AutoSize = true;
            this.lb_DateStartFact.Location = new System.Drawing.Point(834, 170);
            this.lb_DateStartFact.Name = "lb_DateStartFact";
            this.lb_DateStartFact.Size = new System.Drawing.Size(61, 15);
            this.lb_DateStartFact.TabIndex = 26;
            this.lb_DateStartFact.Text = "01.06.2023";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(834, 155);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 15);
            this.label19.TabIndex = 25;
            this.label19.Text = "начало фактическое:";
            // 
            // lb_EndDate
            // 
            this.lb_EndDate.AutoSize = true;
            this.lb_EndDate.Location = new System.Drawing.Point(834, 200);
            this.lb_EndDate.Name = "lb_EndDate";
            this.lb_EndDate.Size = new System.Drawing.Size(61, 15);
            this.lb_EndDate.TabIndex = 28;
            this.lb_EndDate.Text = "01.06.2023";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(834, 185);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 15);
            this.label21.TabIndex = 27;
            this.label21.Text = "сдача объекта:";
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Location = new System.Drawing.Point(638, 93);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(103, 15);
            this.lb_Address.TabIndex = 30;
            this.lb_Address.Text = "Проспект Мира 1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(638, 78);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 15);
            this.label23.TabIndex = 29;
            this.label23.Text = "Адрес:";
            // 
            // btn_InfoLand
            // 
            this.btn_InfoLand.BackColor = System.Drawing.Color.Black;
            this.btn_InfoLand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InfoLand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InfoLand.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_InfoLand.ForeColor = System.Drawing.Color.White;
            this.btn_InfoLand.Location = new System.Drawing.Point(637, 242);
            this.btn_InfoLand.Name = "btn_InfoLand";
            this.btn_InfoLand.Size = new System.Drawing.Size(97, 52);
            this.btn_InfoLand.TabIndex = 31;
            this.btn_InfoLand.Text = "Информация о земельном участке";
            this.btn_InfoLand.UseVisualStyleBackColor = false;
            // 
            // btn_ObjectOrg
            // 
            this.btn_ObjectOrg.BackColor = System.Drawing.Color.Black;
            this.btn_ObjectOrg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ObjectOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ObjectOrg.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ObjectOrg.ForeColor = System.Drawing.Color.White;
            this.btn_ObjectOrg.Location = new System.Drawing.Point(740, 242);
            this.btn_ObjectOrg.Name = "btn_ObjectOrg";
            this.btn_ObjectOrg.Size = new System.Drawing.Size(114, 52);
            this.btn_ObjectOrg.TabIndex = 32;
            this.btn_ObjectOrg.Text = "Задействованные организации";
            this.btn_ObjectOrg.UseVisualStyleBackColor = false;
            // 
            // btn_Smeta
            // 
            this.btn_Smeta.BackColor = System.Drawing.Color.Black;
            this.btn_Smeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Smeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Smeta.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Smeta.ForeColor = System.Drawing.Color.White;
            this.btn_Smeta.Location = new System.Drawing.Point(860, 242);
            this.btn_Smeta.Name = "btn_Smeta";
            this.btn_Smeta.Size = new System.Drawing.Size(95, 52);
            this.btn_Smeta.TabIndex = 33;
            this.btn_Smeta.Text = "Смета объекта";
            this.btn_Smeta.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(189, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(767, 171);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.DarkOrange;
            this.sideBar.Controls.Add(this.panel1);
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.Controls.Add(this.panel4);
            this.sideBar.Controls.Add(this.panel5);
            this.sideBar.Controls.Add(this.reportContainer);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(183, 550);
            this.sideBar.MinimumSize = new System.Drawing.Size(55, 550);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(55, 550);
            this.sideBar.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.menuPicture);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 81);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(62, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Меню";
            // 
            // menuPicture
            // 
            this.menuPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuPicture.Image = ((System.Drawing.Image)(resources.GetObject("menuPicture.Image")));
            this.menuPicture.Location = new System.Drawing.Point(0, 42);
            this.menuPicture.Name = "menuPicture";
            this.menuPicture.Size = new System.Drawing.Size(41, 35);
            this.menuPicture.TabIndex = 0;
            this.menuPicture.TabStop = false;
            this.menuPicture.Click += new System.EventHandler(this.menuPicture_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ObjectForm);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 59);
            this.panel2.TabIndex = 2;
            // 
            // btn_ObjectForm
            // 
            this.btn_ObjectForm.FlatAppearance.BorderSize = 0;
            this.btn_ObjectForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ObjectForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ObjectForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ObjectForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_ObjectForm.Image")));
            this.btn_ObjectForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ObjectForm.Location = new System.Drawing.Point(-25, 5);
            this.btn_ObjectForm.Name = "btn_ObjectForm";
            this.btn_ObjectForm.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_ObjectForm.Size = new System.Drawing.Size(267, 51);
            this.btn_ObjectForm.TabIndex = 1;
            this.btn_ObjectForm.Text = "                Объекты";
            this.btn_ObjectForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ObjectForm.UseVisualStyleBackColor = true;
            this.btn_ObjectForm.Click += new System.EventHandler(this.btn_ObjectForm_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_OrgForm);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(3, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 59);
            this.panel3.TabIndex = 3;
            // 
            // btn_OrgForm
            // 
            this.btn_OrgForm.FlatAppearance.BorderSize = 0;
            this.btn_OrgForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OrgForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_OrgForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_OrgForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_OrgForm.Image")));
            this.btn_OrgForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OrgForm.Location = new System.Drawing.Point(-25, 5);
            this.btn_OrgForm.Name = "btn_OrgForm";
            this.btn_OrgForm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_OrgForm.Size = new System.Drawing.Size(267, 51);
            this.btn_OrgForm.TabIndex = 1;
            this.btn_OrgForm.Text = "                 Организации";
            this.btn_OrgForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OrgForm.UseVisualStyleBackColor = true;
            this.btn_OrgForm.Click += new System.EventHandler(this.btn_OrgForm_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_LandForm);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(3, 220);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 59);
            this.panel4.TabIndex = 4;
            // 
            // btn_LandForm
            // 
            this.btn_LandForm.FlatAppearance.BorderSize = 0;
            this.btn_LandForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LandForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LandForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_LandForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_LandForm.Image")));
            this.btn_LandForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LandForm.Location = new System.Drawing.Point(-25, 5);
            this.btn_LandForm.Name = "btn_LandForm";
            this.btn_LandForm.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_LandForm.Size = new System.Drawing.Size(246, 51);
            this.btn_LandForm.TabIndex = 1;
            this.btn_LandForm.Text = "               Земельные \r\n               участки";
            this.btn_LandForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LandForm.UseVisualStyleBackColor = true;
            this.btn_LandForm.Click += new System.EventHandler(this.btn_LandForm_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_BuildingCompanyForm);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(3, 285);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 59);
            this.panel5.TabIndex = 5;
            // 
            // btn_BuildingCompanyForm
            // 
            this.btn_BuildingCompanyForm.FlatAppearance.BorderSize = 0;
            this.btn_BuildingCompanyForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuildingCompanyForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_BuildingCompanyForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_BuildingCompanyForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuildingCompanyForm.Image")));
            this.btn_BuildingCompanyForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BuildingCompanyForm.Location = new System.Drawing.Point(-25, 5);
            this.btn_BuildingCompanyForm.Name = "btn_BuildingCompanyForm";
            this.btn_BuildingCompanyForm.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_BuildingCompanyForm.Size = new System.Drawing.Size(236, 51);
            this.btn_BuildingCompanyForm.TabIndex = 1;
            this.btn_BuildingCompanyForm.Text = "               Строительные \r\n               компании";
            this.btn_BuildingCompanyForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BuildingCompanyForm.UseVisualStyleBackColor = true;
            this.btn_BuildingCompanyForm.Click += new System.EventHandler(this.btn_BuildingCompanyForm_Click);
            // 
            // reportContainer
            // 
            this.reportContainer.Controls.Add(this.btn_BuildingCompanyRep);
            this.reportContainer.Controls.Add(this.btn_RepForm);
            this.reportContainer.Controls.Add(this.btn_ReportForm);
            this.reportContainer.ForeColor = System.Drawing.Color.White;
            this.reportContainer.Location = new System.Drawing.Point(3, 350);
            this.reportContainer.MaximumSize = new System.Drawing.Size(197, 168);
            this.reportContainer.MinimumSize = new System.Drawing.Size(197, 59);
            this.reportContainer.Name = "reportContainer";
            this.reportContainer.Size = new System.Drawing.Size(197, 59);
            this.reportContainer.TabIndex = 6;
            // 
            // btn_BuildingCompanyRep
            // 
            this.btn_BuildingCompanyRep.FlatAppearance.BorderSize = 0;
            this.btn_BuildingCompanyRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuildingCompanyRep.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_BuildingCompanyRep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_BuildingCompanyRep.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuildingCompanyRep.Image")));
            this.btn_BuildingCompanyRep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BuildingCompanyRep.Location = new System.Drawing.Point(-14, 114);
            this.btn_BuildingCompanyRep.Name = "btn_BuildingCompanyRep";
            this.btn_BuildingCompanyRep.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_BuildingCompanyRep.Size = new System.Drawing.Size(246, 51);
            this.btn_BuildingCompanyRep.TabIndex = 3;
            this.btn_BuildingCompanyRep.Text = "             По строительным \r\n             компаниям\r\n";
            this.btn_BuildingCompanyRep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BuildingCompanyRep.UseVisualStyleBackColor = true;
            this.btn_BuildingCompanyRep.Click += new System.EventHandler(this.btn_BuildingCompanyRep_Click);
            // 
            // btn_RepForm
            // 
            this.btn_RepForm.FlatAppearance.BorderSize = 0;
            this.btn_RepForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RepForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_RepForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_RepForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_RepForm.Image")));
            this.btn_RepForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RepForm.Location = new System.Drawing.Point(-14, 62);
            this.btn_RepForm.Name = "btn_RepForm";
            this.btn_RepForm.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_RepForm.Size = new System.Drawing.Size(246, 51);
            this.btn_RepForm.TabIndex = 2;
            this.btn_RepForm.Text = "             По земельным \r\n             участкам";
            this.btn_RepForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RepForm.UseVisualStyleBackColor = true;
            this.btn_RepForm.Click += new System.EventHandler(this.btn_RepForm_Click);
            // 
            // btn_ReportForm
            // 
            this.btn_ReportForm.FlatAppearance.BorderSize = 0;
            this.btn_ReportForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReportForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ReportForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ReportForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_ReportForm.Image")));
            this.btn_ReportForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ReportForm.Location = new System.Drawing.Point(-25, 5);
            this.btn_ReportForm.Name = "btn_ReportForm";
            this.btn_ReportForm.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_ReportForm.Size = new System.Drawing.Size(246, 51);
            this.btn_ReportForm.TabIndex = 1;
            this.btn_ReportForm.Text = "                Отчеты";
            this.btn_ReportForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ReportForm.UseVisualStyleBackColor = true;
            this.btn_ReportForm.Click += new System.EventHandler(this.btn_ReportForm_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // reportTimer
            // 
            this.reportTimer.Interval = 10;
            this.reportTimer.Tick += new System.EventHandler(this.reportTimer_Tick);
            // 
            // btn_DeleteNote
            // 
            this.btn_DeleteNote.CornerRoundingRadius = 5F;
            this.btn_DeleteNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteNote.Enabled = false;
            this.btn_DeleteNote.Location = new System.Drawing.Point(490, 477);
            this.btn_DeleteNote.Name = "btn_DeleteNote";
            this.btn_DeleteNote.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_DeleteNote.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_DeleteNote.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_DeleteNote.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_DeleteNote.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_DeleteNote.OverrideDefault.Border.Width = 2;
            this.btn_DeleteNote.Size = new System.Drawing.Size(130, 48);
            this.btn_DeleteNote.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_DeleteNote.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_DeleteNote.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_DeleteNote.StateCommon.Border.Rounding = 5F;
            this.btn_DeleteNote.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_DeleteNote.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_DeleteNote.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DeleteNote.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.btn_DeleteNote.StateDisabled.Back.Color1 = System.Drawing.Color.LightGray;
            this.btn_DeleteNote.StateDisabled.Back.Color2 = System.Drawing.Color.LightGray;
            this.btn_DeleteNote.StateDisabled.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_DeleteNote.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_DeleteNote.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_DeleteNote.StateNormal.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_DeleteNote.StateNormal.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_DeleteNote.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_DeleteNote.StateNormal.Border.Width = 2;
            this.btn_DeleteNote.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_DeleteNote.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_DeleteNote.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_DeleteNote.StatePressed.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_DeleteNote.StatePressed.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_DeleteNote.StatePressed.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_DeleteNote.StatePressed.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_DeleteNote.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_DeleteNote.StatePressed.Border.Width = 2;
            this.btn_DeleteNote.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_DeleteNote.StateTracking.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_DeleteNote.StateTracking.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_DeleteNote.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_DeleteNote.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_DeleteNote.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_DeleteNote.StateTracking.Border.Rounding = 5F;
            this.btn_DeleteNote.StateTracking.Border.Width = 2;
            this.btn_DeleteNote.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_DeleteNote.TabIndex = 38;
            this.btn_DeleteNote.Values.Text = "Удалить \r\nзаметку";
            this.btn_DeleteNote.Click += new System.EventHandler(this.btn_DeleteNote_Click_1);
            // 
            // btn_ChangeNote
            // 
            this.btn_ChangeNote.CornerRoundingRadius = 5F;
            this.btn_ChangeNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangeNote.Enabled = false;
            this.btn_ChangeNote.Location = new System.Drawing.Point(336, 477);
            this.btn_ChangeNote.Name = "btn_ChangeNote";
            this.btn_ChangeNote.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_ChangeNote.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_ChangeNote.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeNote.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeNote.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChangeNote.OverrideDefault.Border.Width = 2;
            this.btn_ChangeNote.Size = new System.Drawing.Size(123, 48);
            this.btn_ChangeNote.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_ChangeNote.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_ChangeNote.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChangeNote.StateCommon.Border.Rounding = 5F;
            this.btn_ChangeNote.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ChangeNote.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ChangeNote.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ChangeNote.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.btn_ChangeNote.StateDisabled.Back.Color1 = System.Drawing.Color.LightGray;
            this.btn_ChangeNote.StateDisabled.Back.Color2 = System.Drawing.Color.LightGray;
            this.btn_ChangeNote.StateDisabled.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_ChangeNote.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_ChangeNote.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_ChangeNote.StateNormal.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeNote.StateNormal.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeNote.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChangeNote.StateNormal.Border.Width = 2;
            this.btn_ChangeNote.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_ChangeNote.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_ChangeNote.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_ChangeNote.StatePressed.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeNote.StatePressed.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeNote.StatePressed.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeNote.StatePressed.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeNote.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChangeNote.StatePressed.Border.Width = 2;
            this.btn_ChangeNote.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_ChangeNote.StateTracking.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeNote.StateTracking.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeNote.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_ChangeNote.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_ChangeNote.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChangeNote.StateTracking.Border.Rounding = 5F;
            this.btn_ChangeNote.StateTracking.Border.Width = 2;
            this.btn_ChangeNote.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_ChangeNote.TabIndex = 37;
            this.btn_ChangeNote.Values.Text = "Изменить \r\nзаметку";
            this.btn_ChangeNote.Click += new System.EventHandler(this.btn_ChangeNote_Click_1);
            // 
            // btn_AddNote
            // 
            this.btn_AddNote.CornerRoundingRadius = 5F;
            this.btn_AddNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddNote.Location = new System.Drawing.Point(189, 477);
            this.btn_AddNote.Name = "btn_AddNote";
            this.btn_AddNote.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_AddNote.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_AddNote.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddNote.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddNote.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddNote.OverrideDefault.Border.Width = 2;
            this.btn_AddNote.Size = new System.Drawing.Size(123, 48);
            this.btn_AddNote.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_AddNote.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_AddNote.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddNote.StateCommon.Border.Rounding = 5F;
            this.btn_AddNote.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_AddNote.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_AddNote.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddNote.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.btn_AddNote.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_AddNote.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_AddNote.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_AddNote.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_AddNote.StateNormal.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddNote.StateNormal.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddNote.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddNote.StateNormal.Border.Width = 2;
            this.btn_AddNote.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_AddNote.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_AddNote.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_AddNote.StatePressed.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddNote.StatePressed.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddNote.StatePressed.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddNote.StatePressed.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddNote.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddNote.StatePressed.Border.Width = 2;
            this.btn_AddNote.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_AddNote.StateTracking.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddNote.StateTracking.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddNote.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_AddNote.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_AddNote.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddNote.StateTracking.Border.Rounding = 5F;
            this.btn_AddNote.StateTracking.Border.Width = 2;
            this.btn_AddNote.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_AddNote.TabIndex = 36;
            this.btn_AddNote.Values.Text = "Добавить \r\nзаметку";
            this.btn_AddNote.Click += new System.EventHandler(this.btn_AddNote_Click_1);
            // 
            // ObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 543);
            this.Controls.Add(this.btn_DeleteNote);
            this.Controls.Add(this.btn_ChangeNote);
            this.Controls.Add(this.btn_AddNote);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Smeta);
            this.Controls.Add(this.btn_ObjectOrg);
            this.Controls.Add(this.btn_InfoLand);
            this.Controls.Add(this.lb_Address);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lb_EndDate);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lb_DateStartFact);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lb_DateStartPlan);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lb_BuildingStatus);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lb_objectNum);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb_IsBuildingPermit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_BuildingCompany);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "ObjectForm";
            this.Text = " Объект";
            this.Load += new System.EventHandler(this.ObjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.reportContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label lb_Name;
        private Label lb_BuildingCompany;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lb_IsBuildingPermit;
        private Label label10;
        private Label lb_objectNum;
        private Label label12;
        private Label lb_BuildingStatus;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label lb_DateStartPlan;
        private Label lb_DateStartFact;
        private Label label19;
        private Label lb_EndDate;
        private Label label21;
        private Label lb_Address;
        private Label label23;
        private Button btn_InfoLand;
        private Button btn_ObjectOrg;
        private Button btn_Smeta;
        private DataGridView dataGridView1;
        private FlowLayoutPanel sideBar;
        private Panel panel1;
        private Label label4;
        private PictureBox menuPicture;
        private Panel panel2;
        private Button btn_ObjectForm;
        private Panel panel3;
        private Button btn_OrgForm;
        private Panel panel4;
        private Button btn_LandForm;
        private Panel panel5;
        private Button btn_BuildingCompanyForm;
        private Panel reportContainer;
        private Button btn_BuildingCompanyRep;
        private Button btn_RepForm;
        private Button btn_ReportForm;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Timer reportTimer;
        private Krypton.Toolkit.KryptonButton btn_DeleteNote;
        private Krypton.Toolkit.KryptonButton btn_ChangeNote;
        private Krypton.Toolkit.KryptonButton btn_AddNote;
    }
}