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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.земельныеУчасткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строительныеКомпанииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЗемельнымУчасткамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поСтроительнымКомпаниямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btn_AddNote = new System.Windows.Forms.Button();
            this.btn_DeleteNote = new System.Windows.Forms.Button();
            this.btn_ChangeNote = new System.Windows.Forms.Button();
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.земельныеУчасткиToolStripMenuItem,
            this.xToolStripMenuItem,
            this.строительныеКомпанииToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(876, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 34);
            this.toolStripMenuItem1.Text = "Объекты";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(92, 34);
            this.toolStripMenuItem2.Text = "Организации";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // земельныеУчасткиToolStripMenuItem
            // 
            this.земельныеУчасткиToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.земельныеУчасткиToolStripMenuItem.Name = "земельныеУчасткиToolStripMenuItem";
            this.земельныеУчасткиToolStripMenuItem.Size = new System.Drawing.Size(128, 34);
            this.земельныеУчасткиToolStripMenuItem.Text = "Земельные участки";
            this.земельныеУчасткиToolStripMenuItem.Click += new System.EventHandler(this.земельныеУчасткиToolStripMenuItem_Click);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(26, 34);
            this.xToolStripMenuItem.Text = "X";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // строительныеКомпанииToolStripMenuItem
            // 
            this.строительныеКомпанииToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.строительныеКомпанииToolStripMenuItem.Name = "строительныеКомпанииToolStripMenuItem";
            this.строительныеКомпанииToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.строительныеКомпанииToolStripMenuItem.Text = "Строительные компании";
            this.строительныеКомпанииToolStripMenuItem.Click += new System.EventHandler(this.строительныеКомпанииToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поЗемельнымУчасткамToolStripMenuItem,
            this.поСтроительнымКомпаниямToolStripMenuItem});
            this.отчетыToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 34);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // поЗемельнымУчасткамToolStripMenuItem
            // 
            this.поЗемельнымУчасткамToolStripMenuItem.Name = "поЗемельнымУчасткамToolStripMenuItem";
            this.поЗемельнымУчасткамToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.поЗемельнымУчасткамToolStripMenuItem.Text = "По земельным участкам";
            this.поЗемельнымУчасткамToolStripMenuItem.Click += new System.EventHandler(this.поЗемельнымУчасткамToolStripMenuItem_Click);
            // 
            // поСтроительнымКомпаниямToolStripMenuItem
            // 
            this.поСтроительнымКомпаниямToolStripMenuItem.Name = "поСтроительнымКомпаниямToolStripMenuItem";
            this.поСтроительнымКомпаниямToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.поСтроительнымКомпаниямToolStripMenuItem.Text = "По строительным компаниям";
            this.поСтроительнымКомпаниямToolStripMenuItem.Click += new System.EventHandler(this.поСтроительнымКомпаниямToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(353, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Документ объекта";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Список заметок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(510, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Название:";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(510, 188);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(164, 15);
            this.lb_Name.TabIndex = 8;
            this.lb_Name.Text = "Жилой комплекс “River Park”";
            // 
            // lb_BuildingCompany
            // 
            this.lb_BuildingCompany.AutoSize = true;
            this.lb_BuildingCompany.Location = new System.Drawing.Point(510, 230);
            this.lb_BuildingCompany.Name = "lb_BuildingCompany";
            this.lb_BuildingCompany.Size = new System.Drawing.Size(81, 15);
            this.lb_BuildingCompany.TabIndex = 10;
            this.lb_BuildingCompany.Text = "Ферро-Строй";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(510, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Строительная компания:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Группа 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(510, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Контроль выполняет:";
            // 
            // lb_IsBuildingPermit
            // 
            this.lb_IsBuildingPermit.AutoSize = true;
            this.lb_IsBuildingPermit.Location = new System.Drawing.Point(706, 123);
            this.lb_IsBuildingPermit.Name = "lb_IsBuildingPermit";
            this.lb_IsBuildingPermit.Size = new System.Drawing.Size(21, 15);
            this.lb_IsBuildingPermit.TabIndex = 14;
            this.lb_IsBuildingPermit.Text = "Да";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(706, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Разрешена ли стройка:";
            // 
            // btn_AddNote
            // 
            this.btn_AddNote.BackColor = System.Drawing.Color.Black;
            this.btn_AddNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNote.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AddNote.ForeColor = System.Drawing.Color.White;
            this.btn_AddNote.Location = new System.Drawing.Point(61, 540);
            this.btn_AddNote.Name = "btn_AddNote";
            this.btn_AddNote.Size = new System.Drawing.Size(75, 42);
            this.btn_AddNote.TabIndex = 15;
            this.btn_AddNote.Text = "Добавить заметку";
            this.btn_AddNote.UseVisualStyleBackColor = false;
            this.btn_AddNote.Click += new System.EventHandler(this.btn_AddNote_Click);
            // 
            // btn_DeleteNote
            // 
            this.btn_DeleteNote.BackColor = System.Drawing.Color.Black;
            this.btn_DeleteNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteNote.Enabled = false;
            this.btn_DeleteNote.FlatAppearance.BorderSize = 0;
            this.btn_DeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteNote.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DeleteNote.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteNote.Location = new System.Drawing.Point(153, 540);
            this.btn_DeleteNote.Name = "btn_DeleteNote";
            this.btn_DeleteNote.Size = new System.Drawing.Size(75, 42);
            this.btn_DeleteNote.TabIndex = 16;
            this.btn_DeleteNote.Text = "Удалить заметку";
            this.btn_DeleteNote.UseVisualStyleBackColor = false;
            this.btn_DeleteNote.Click += new System.EventHandler(this.btn_DeleteNote_Click);
            // 
            // btn_ChangeNote
            // 
            this.btn_ChangeNote.BackColor = System.Drawing.Color.Black;
            this.btn_ChangeNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangeNote.Enabled = false;
            this.btn_ChangeNote.FlatAppearance.BorderSize = 0;
            this.btn_ChangeNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeNote.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ChangeNote.ForeColor = System.Drawing.Color.White;
            this.btn_ChangeNote.Location = new System.Drawing.Point(244, 540);
            this.btn_ChangeNote.Name = "btn_ChangeNote";
            this.btn_ChangeNote.Size = new System.Drawing.Size(75, 42);
            this.btn_ChangeNote.TabIndex = 17;
            this.btn_ChangeNote.Text = "Изменить заметку";
            this.btn_ChangeNote.UseVisualStyleBackColor = false;
            this.btn_ChangeNote.Click += new System.EventHandler(this.btn_ChangeNote_Click);
            // 
            // lb_objectNum
            // 
            this.lb_objectNum.AutoSize = true;
            this.lb_objectNum.Location = new System.Drawing.Point(510, 123);
            this.lb_objectNum.Name = "lb_objectNum";
            this.lb_objectNum.Size = new System.Drawing.Size(31, 15);
            this.lb_objectNum.TabIndex = 19;
            this.lb_objectNum.Text = "1000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(510, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Номер объекта:";
            // 
            // lb_BuildingStatus
            // 
            this.lb_BuildingStatus.AutoSize = true;
            this.lb_BuildingStatus.Location = new System.Drawing.Point(706, 156);
            this.lb_BuildingStatus.Name = "lb_BuildingStatus";
            this.lb_BuildingStatus.Size = new System.Drawing.Size(57, 15);
            this.lb_BuildingStatus.TabIndex = 21;
            this.lb_BuildingStatus.Text = "Строится";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(706, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 15);
            this.label14.TabIndex = 20;
            this.label14.Text = "Статус:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(706, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 15);
            this.label15.TabIndex = 23;
            this.label15.Text = "начало плановое:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(706, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "Даты строительства:";
            // 
            // lb_DateStartPlan
            // 
            this.lb_DateStartPlan.AutoSize = true;
            this.lb_DateStartPlan.Location = new System.Drawing.Point(706, 203);
            this.lb_DateStartPlan.Name = "lb_DateStartPlan";
            this.lb_DateStartPlan.Size = new System.Drawing.Size(61, 15);
            this.lb_DateStartPlan.TabIndex = 24;
            this.lb_DateStartPlan.Text = "01.06.2023";
            // 
            // lb_DateStartFact
            // 
            this.lb_DateStartFact.AutoSize = true;
            this.lb_DateStartFact.Location = new System.Drawing.Point(706, 233);
            this.lb_DateStartFact.Name = "lb_DateStartFact";
            this.lb_DateStartFact.Size = new System.Drawing.Size(61, 15);
            this.lb_DateStartFact.TabIndex = 26;
            this.lb_DateStartFact.Text = "01.06.2023";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(706, 218);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 15);
            this.label19.TabIndex = 25;
            this.label19.Text = "начало фактическое:";
            // 
            // lb_EndDate
            // 
            this.lb_EndDate.AutoSize = true;
            this.lb_EndDate.Location = new System.Drawing.Point(706, 263);
            this.lb_EndDate.Name = "lb_EndDate";
            this.lb_EndDate.Size = new System.Drawing.Size(61, 15);
            this.lb_EndDate.TabIndex = 28;
            this.lb_EndDate.Text = "01.06.2023";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(706, 248);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 15);
            this.label21.TabIndex = 27;
            this.label21.Text = "сдача объекта:";
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Location = new System.Drawing.Point(510, 156);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(103, 15);
            this.lb_Address.TabIndex = 30;
            this.lb_Address.Text = "Проспект Мира 1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(510, 141);
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
            this.btn_InfoLand.Location = new System.Drawing.Point(509, 305);
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
            this.btn_ObjectOrg.Location = new System.Drawing.Point(612, 305);
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
            this.btn_Smeta.Location = new System.Drawing.Point(732, 305);
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
            this.dataGridView1.Location = new System.Drawing.Point(61, 363);
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
            // ObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 590);
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
            this.Controls.Add(this.btn_ChangeNote);
            this.Controls.Add(this.btn_DeleteNote);
            this.Controls.Add(this.btn_AddNote);
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
            this.Controls.Add(this.menuStrip1);
            this.Name = "ObjectForm";
            this.Text = " Объект";
            this.Load += new System.EventHandler(this.ObjectForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem земельныеУчасткиToolStripMenuItem;
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
        private Button btn_AddNote;
        private Button btn_DeleteNote;
        private Button btn_ChangeNote;
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
        private ToolStripMenuItem xToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem строительныеКомпанииToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
        private ToolStripMenuItem поЗемельнымУчасткамToolStripMenuItem;
        private ToolStripMenuItem поСтроительнымКомпаниямToolStripMenuItem;
    }
}