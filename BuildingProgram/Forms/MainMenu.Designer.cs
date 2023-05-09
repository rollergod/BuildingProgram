namespace BuildingProgram.Forms
{
    partial class MainMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_IsBuildingEnded = new System.Windows.Forms.CheckBox();
            this.cb_IsCheckedObject = new System.Windows.Forms.CheckBox();
            this.cb_OnlyOne = new System.Windows.Forms.CheckBox();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btn_AddObject = new Krypton.Toolkit.KryptonButton();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.btn_ChangeBtn = new Krypton.Toolkit.KryptonButton();
            this.btn_AboutObject = new Krypton.Toolkit.KryptonButton();
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.tb_Search = new Krypton.Toolkit.KryptonTextBox();
            this.btn_Search = new Krypton.Toolkit.KryptonButton();
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
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(183, 78);
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
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(576, 380);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cb_IsBuildingEnded
            // 
            this.cb_IsBuildingEnded.AutoSize = true;
            this.cb_IsBuildingEnded.Location = new System.Drawing.Point(628, 50);
            this.cb_IsBuildingEnded.Name = "cb_IsBuildingEnded";
            this.cb_IsBuildingEnded.Size = new System.Drawing.Size(132, 19);
            this.cb_IsBuildingEnded.TabIndex = 7;
            this.cb_IsBuildingEnded.Text = "Закончена стройка";
            this.cb_IsBuildingEnded.UseVisualStyleBackColor = true;
            this.cb_IsBuildingEnded.CheckedChanged += new System.EventHandler(this.cb_IsBuildingEnded_CheckedChanged);
            // 
            // cb_IsCheckedObject
            // 
            this.cb_IsCheckedObject.AutoSize = true;
            this.cb_IsCheckedObject.Location = new System.Drawing.Point(500, 50);
            this.cb_IsCheckedObject.Name = "cb_IsCheckedObject";
            this.cb_IsCheckedObject.Size = new System.Drawing.Size(122, 19);
            this.cb_IsCheckedObject.TabIndex = 8;
            this.cb_IsCheckedObject.Text = "Объект проверен";
            this.cb_IsCheckedObject.UseVisualStyleBackColor = true;
            this.cb_IsCheckedObject.CheckedChanged += new System.EventHandler(this.cb_IsCheckedObject_CheckedChanged);
            // 
            // cb_OnlyOne
            // 
            this.cb_OnlyOne.AutoSize = true;
            this.cb_OnlyOne.Checked = true;
            this.cb_OnlyOne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_OnlyOne.Location = new System.Drawing.Point(500, 22);
            this.cb_OnlyOne.Name = "cb_OnlyOne";
            this.cb_OnlyOne.Size = new System.Drawing.Size(213, 19);
            this.cb_OnlyOne.TabIndex = 9;
            this.cb_OnlyOne.Text = "Отображать только свои объекты";
            this.cb_OnlyOne.UseVisualStyleBackColor = true;
            this.cb_OnlyOne.CheckedChanged += new System.EventHandler(this.cb_OnlyOne_CheckedChanged);
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
            this.sideBar.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuPicture);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Меню";
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
            // btn_AddObject
            // 
            this.btn_AddObject.CornerRoundingRadius = 5F;
            this.btn_AddObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddObject.Location = new System.Drawing.Point(266, 467);
            this.btn_AddObject.Name = "btn_AddObject";
            this.btn_AddObject.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_AddObject.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_AddObject.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddObject.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddObject.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddObject.OverrideDefault.Border.Width = 2;
            this.btn_AddObject.Size = new System.Drawing.Size(123, 48);
            this.btn_AddObject.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_AddObject.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_AddObject.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddObject.StateCommon.Border.Rounding = 5F;
            this.btn_AddObject.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_AddObject.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_AddObject.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddObject.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.btn_AddObject.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_AddObject.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_AddObject.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_AddObject.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_AddObject.StateNormal.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddObject.StateNormal.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddObject.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddObject.StateNormal.Border.Width = 2;
            this.btn_AddObject.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_AddObject.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_AddObject.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_AddObject.StatePressed.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddObject.StatePressed.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddObject.StatePressed.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddObject.StatePressed.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddObject.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddObject.StatePressed.Border.Width = 2;
            this.btn_AddObject.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_AddObject.StateTracking.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddObject.StateTracking.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddObject.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_AddObject.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_AddObject.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddObject.StateTracking.Border.Rounding = 5F;
            this.btn_AddObject.StateTracking.Border.Width = 2;
            this.btn_AddObject.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_AddObject.TabIndex = 15;
            this.btn_AddObject.Values.Text = "Добавить \r\nобъект";
            this.btn_AddObject.Click += new System.EventHandler(this.btn_AddObject_Click);
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // btn_ChangeBtn
            // 
            this.btn_ChangeBtn.CornerRoundingRadius = 5F;
            this.btn_ChangeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangeBtn.Enabled = false;
            this.btn_ChangeBtn.Location = new System.Drawing.Point(413, 467);
            this.btn_ChangeBtn.Name = "btn_ChangeBtn";
            this.btn_ChangeBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_ChangeBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_ChangeBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeBtn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChangeBtn.OverrideDefault.Border.Width = 2;
            this.btn_ChangeBtn.Size = new System.Drawing.Size(123, 48);
            this.btn_ChangeBtn.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_ChangeBtn.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_ChangeBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChangeBtn.StateCommon.Border.Rounding = 5F;
            this.btn_ChangeBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ChangeBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ChangeBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ChangeBtn.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.btn_ChangeBtn.StateDisabled.Back.Color1 = System.Drawing.Color.LightGray;
            this.btn_ChangeBtn.StateDisabled.Back.Color2 = System.Drawing.Color.LightGray;
            this.btn_ChangeBtn.StateDisabled.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_ChangeBtn.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_ChangeBtn.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_ChangeBtn.StateNormal.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeBtn.StateNormal.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeBtn.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChangeBtn.StateNormal.Border.Width = 2;
            this.btn_ChangeBtn.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_ChangeBtn.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_ChangeBtn.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_ChangeBtn.StatePressed.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeBtn.StatePressed.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeBtn.StatePressed.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeBtn.StatePressed.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeBtn.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChangeBtn.StatePressed.Border.Width = 2;
            this.btn_ChangeBtn.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_ChangeBtn.StateTracking.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeBtn.StateTracking.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeBtn.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_ChangeBtn.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_ChangeBtn.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChangeBtn.StateTracking.Border.Rounding = 5F;
            this.btn_ChangeBtn.StateTracking.Border.Width = 2;
            this.btn_ChangeBtn.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_ChangeBtn.TabIndex = 16;
            this.btn_ChangeBtn.Values.Text = "Изменить \r\nобъект";
            this.btn_ChangeBtn.Click += new System.EventHandler(this.btn_ChangeBtn_Click);
            // 
            // btn_AboutObject
            // 
            this.btn_AboutObject.CornerRoundingRadius = 5F;
            this.btn_AboutObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AboutObject.Enabled = false;
            this.btn_AboutObject.Location = new System.Drawing.Point(567, 467);
            this.btn_AboutObject.Name = "btn_AboutObject";
            this.btn_AboutObject.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_AboutObject.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_AboutObject.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AboutObject.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AboutObject.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AboutObject.OverrideDefault.Border.Width = 2;
            this.btn_AboutObject.Size = new System.Drawing.Size(123, 48);
            this.btn_AboutObject.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_AboutObject.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_AboutObject.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AboutObject.StateCommon.Border.Rounding = 5F;
            this.btn_AboutObject.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_AboutObject.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_AboutObject.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AboutObject.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.btn_AboutObject.StateDisabled.Back.Color1 = System.Drawing.Color.LightGray;
            this.btn_AboutObject.StateDisabled.Back.Color2 = System.Drawing.Color.LightGray;
            this.btn_AboutObject.StateDisabled.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_AboutObject.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_AboutObject.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_AboutObject.StateNormal.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AboutObject.StateNormal.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AboutObject.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AboutObject.StateNormal.Border.Width = 2;
            this.btn_AboutObject.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_AboutObject.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_AboutObject.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_AboutObject.StatePressed.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AboutObject.StatePressed.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AboutObject.StatePressed.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AboutObject.StatePressed.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AboutObject.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AboutObject.StatePressed.Border.Width = 2;
            this.btn_AboutObject.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_AboutObject.StateTracking.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AboutObject.StateTracking.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AboutObject.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_AboutObject.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_AboutObject.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AboutObject.StateTracking.Border.Rounding = 5F;
            this.btn_AboutObject.StateTracking.Border.Width = 2;
            this.btn_AboutObject.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_AboutObject.TabIndex = 17;
            this.btn_AboutObject.Values.Text = "Подробная \r\nинформация";
            this.btn_AboutObject.Click += new System.EventHandler(this.btn_AboutObject_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.CueHint.Color1 = System.Drawing.Color.White;
            this.tb_Search.CueHint.CueHintText = "Введите адрес или номер объекта";
            this.tb_Search.CueHint.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Search.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tb_Search.Location = new System.Drawing.Point(245, 40);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(244, 31);
            this.tb_Search.StateCommon.Back.Color1 = System.Drawing.Color.Gray;
            this.tb_Search.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.tb_Search.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.tb_Search.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tb_Search.StateCommon.Border.Rounding = 5F;
            this.tb_Search.StateCommon.Border.Width = 1;
            this.tb_Search.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.tb_Search.StateCommon.Content.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Search.TabIndex = 18;
            // 
            // btn_Search
            // 
            this.btn_Search.CornerRoundingRadius = 5F;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Location = new System.Drawing.Point(183, 42);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.OverrideDefault.Back.Color1 = System.Drawing.Color.Black;
            this.btn_Search.OverrideDefault.Back.Color2 = System.Drawing.Color.Black;
            this.btn_Search.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btn_Search.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btn_Search.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Search.Size = new System.Drawing.Size(53, 28);
            this.btn_Search.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.btn_Search.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.btn_Search.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Search.StateCommon.Border.Rounding = 5F;
            this.btn_Search.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Search.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Search.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.btn_Search.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Search.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Search.StateNormal.Back.Color1 = System.Drawing.Color.Black;
            this.btn_Search.StateNormal.Back.Color2 = System.Drawing.Color.Black;
            this.btn_Search.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.btn_Search.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.btn_Search.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Search.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Search.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Search.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_Search.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.btn_Search.StatePressed.Back.Color2 = System.Drawing.Color.Black;
            this.btn_Search.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btn_Search.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btn_Search.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Search.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_Search.StateTracking.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_Search.StateTracking.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_Search.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btn_Search.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btn_Search.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Search.StateTracking.Border.Rounding = 5F;
            this.btn_Search.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_Search.TabIndex = 19;
            this.btn_Search.Values.Text = "Поиск";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 522);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.btn_AboutObject);
            this.Controls.Add(this.btn_ChangeBtn);
            this.Controls.Add(this.btn_AddObject);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.cb_OnlyOne);
            this.Controls.Add(this.cb_IsCheckedObject);
            this.Controls.Add(this.cb_IsBuildingEnded);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainMenu_Load);
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
        private DataGridView dataGridView1;
        private CheckBox cb_IsBuildingEnded;
        private CheckBox cb_IsCheckedObject;
        private CheckBox cb_OnlyOne;
        private FlowLayoutPanel sideBar;
        private Panel panel1;
        private Label label1;
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
        private Krypton.Toolkit.KryptonButton btn_AddObject;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private Krypton.Toolkit.KryptonButton btn_ChangeBtn;
        private Krypton.Toolkit.KryptonButton btn_AboutObject;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonTextBox tb_Search;
        private Krypton.Toolkit.KryptonButton btn_Search;
    }
}