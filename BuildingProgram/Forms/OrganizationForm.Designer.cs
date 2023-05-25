namespace BuildingProgram.Forms
{
    partial class OrganizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizationForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_OrgName = new System.Windows.Forms.Label();
            this.lb_ObjectsNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_TotalSum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reportTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btn_Search = new Krypton.Toolkit.KryptonButton();
            this.tb_Search = new Krypton.Toolkit.KryptonTextBox();
            this.btn_ChangeOrg = new Krypton.Toolkit.KryptonButton();
            this.btn_AddOrg = new Krypton.Toolkit.KryptonButton();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(206, 69);
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
            this.dataGridView1.Size = new System.Drawing.Size(576, 328);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Дата окончания последнего объекта:";
            this.label1.Visible = false;
            // 
            // lb_OrgName
            // 
            this.lb_OrgName.AutoSize = true;
            this.lb_OrgName.Location = new System.Drawing.Point(424, 412);
            this.lb_OrgName.Name = "lb_OrgName";
            this.lb_OrgName.Size = new System.Drawing.Size(0, 15);
            this.lb_OrgName.TabIndex = 16;
            this.lb_OrgName.Visible = false;
            // 
            // lb_ObjectsNum
            // 
            this.lb_ObjectsNum.AutoSize = true;
            this.lb_ObjectsNum.Location = new System.Drawing.Point(340, 437);
            this.lb_ObjectsNum.Name = "lb_ObjectsNum";
            this.lb_ObjectsNum.Size = new System.Drawing.Size(0, 15);
            this.lb_ObjectsNum.TabIndex = 18;
            this.lb_ObjectsNum.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Количество объектов:";
            this.label3.Visible = false;
            // 
            // lb_TotalSum
            // 
            this.lb_TotalSum.AutoSize = true;
            this.lb_TotalSum.Location = new System.Drawing.Point(372, 463);
            this.lb_TotalSum.Name = "lb_TotalSum";
            this.lb_TotalSum.Size = new System.Drawing.Size(0, 15);
            this.lb_TotalSum.TabIndex = 20;
            this.lb_TotalSum.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Общая стоимость участков:";
            this.label4.Visible = false;
            // 
            // reportTimer
            // 
            this.reportTimer.Interval = 10;
            this.reportTimer.Tick += new System.EventHandler(this.reportTimer_Tick);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
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
            this.sideBar.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.menuPicture);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 81);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Меню";
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
            // btn_Search
            // 
            this.btn_Search.CornerRoundingRadius = 5F;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Location = new System.Drawing.Point(343, 34);
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
            this.btn_Search.TabIndex = 23;
            this.btn_Search.Values.Text = "Поиск";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click_1);
            // 
            // tb_Search
            // 
            this.tb_Search.CueHint.Color1 = System.Drawing.Color.White;
            this.tb_Search.CueHint.CueHintText = "Введите адрес или номер объекта";
            this.tb_Search.CueHint.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Search.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tb_Search.Location = new System.Drawing.Point(405, 32);
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
            this.tb_Search.TabIndex = 22;
            // 
            // btn_ChangeOrg
            // 
            this.btn_ChangeOrg.CornerRoundingRadius = 5F;
            this.btn_ChangeOrg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangeOrg.Enabled = false;
            this.btn_ChangeOrg.Location = new System.Drawing.Point(686, 504);
            this.btn_ChangeOrg.Name = "btn_ChangeOrg";
            this.btn_ChangeOrg.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_ChangeOrg.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_ChangeOrg.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeOrg.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeOrg.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChangeOrg.OverrideDefault.Border.Width = 2;
            this.btn_ChangeOrg.Size = new System.Drawing.Size(109, 71);
            this.btn_ChangeOrg.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_ChangeOrg.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_ChangeOrg.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChangeOrg.StateCommon.Border.Rounding = 5F;
            this.btn_ChangeOrg.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ChangeOrg.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ChangeOrg.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ChangeOrg.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.btn_ChangeOrg.StateDisabled.Back.Color1 = System.Drawing.Color.LightGray;
            this.btn_ChangeOrg.StateDisabled.Back.Color2 = System.Drawing.Color.LightGray;
            this.btn_ChangeOrg.StateDisabled.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_ChangeOrg.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_ChangeOrg.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_ChangeOrg.StateNormal.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeOrg.StateNormal.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeOrg.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChangeOrg.StateNormal.Border.Width = 2;
            this.btn_ChangeOrg.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_ChangeOrg.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_ChangeOrg.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_ChangeOrg.StatePressed.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeOrg.StatePressed.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeOrg.StatePressed.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeOrg.StatePressed.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeOrg.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChangeOrg.StatePressed.Border.Width = 2;
            this.btn_ChangeOrg.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_ChangeOrg.StateTracking.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeOrg.StateTracking.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChangeOrg.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_ChangeOrg.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_ChangeOrg.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChangeOrg.StateTracking.Border.Rounding = 5F;
            this.btn_ChangeOrg.StateTracking.Border.Width = 2;
            this.btn_ChangeOrg.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_ChangeOrg.TabIndex = 27;
            this.btn_ChangeOrg.Values.Text = "Изменить \r\nорганизацию";
            this.btn_ChangeOrg.Visible = false;
            this.btn_ChangeOrg.Click += new System.EventHandler(this.btn_ChangeOrg_Click_1);
            // 
            // btn_AddOrg
            // 
            this.btn_AddOrg.CornerRoundingRadius = 5F;
            this.btn_AddOrg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddOrg.Location = new System.Drawing.Point(686, 425);
            this.btn_AddOrg.Name = "btn_AddOrg";
            this.btn_AddOrg.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_AddOrg.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_AddOrg.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddOrg.OverrideDefault.Border.Width = 2;
            this.btn_AddOrg.Size = new System.Drawing.Size(109, 73);
            this.btn_AddOrg.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_AddOrg.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_AddOrg.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddOrg.StateCommon.Border.Rounding = 5F;
            this.btn_AddOrg.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_AddOrg.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_AddOrg.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddOrg.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.btn_AddOrg.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_AddOrg.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_AddOrg.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_AddOrg.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_AddOrg.StateNormal.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.StateNormal.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddOrg.StateNormal.Border.Width = 2;
            this.btn_AddOrg.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_AddOrg.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_AddOrg.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_AddOrg.StatePressed.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.StatePressed.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.StatePressed.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.StatePressed.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddOrg.StatePressed.Border.Width = 2;
            this.btn_AddOrg.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_AddOrg.StateTracking.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.StateTracking.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_AddOrg.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_AddOrg.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddOrg.StateTracking.Border.Rounding = 5F;
            this.btn_AddOrg.StateTracking.Border.Width = 2;
            this.btn_AddOrg.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_AddOrg.TabIndex = 26;
            this.btn_AddOrg.Values.Text = "Добавить\r\nорганизацию";
            this.btn_AddOrg.Visible = false;
            this.btn_AddOrg.Click += new System.EventHandler(this.btn_AddOrg_Click_1);
            // 
            // OrganizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 544);
            this.Controls.Add(this.btn_ChangeOrg);
            this.Controls.Add(this.btn_AddOrg);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.lb_TotalSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_ObjectsNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_OrgName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrganizationForm";
            this.Text = "Организации";
            this.Load += new System.EventHandler(this.OrganizationForm_Load);
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
        private Label label1;
        private Label lb_OrgName;
        private Label lb_ObjectsNum;
        private Label label3;
        private Label lb_TotalSum;
        private Label label4;
        private System.Windows.Forms.Timer reportTimer;
        private System.Windows.Forms.Timer sidebarTimer;
        private FlowLayoutPanel sideBar;
        private Panel panel1;
        private Label label2;
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
        private Krypton.Toolkit.KryptonButton btn_Search;
        private Krypton.Toolkit.KryptonTextBox tb_Search;
        private Krypton.Toolkit.KryptonButton btn_ChangeOrg;
        private Krypton.Toolkit.KryptonButton btn_AddOrg;
    }
}