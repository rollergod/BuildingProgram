using BuildingProgram.Controls;

namespace BuildingProgram.Forms
{
    partial class AddNewObject
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_ChosePhoto = new System.Windows.Forms.Button();
            this.btn_AddObject = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.dtp_StartPlan = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartFact = new System.Windows.Forms.DateTimePicker();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.cb_buildingPermit = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_buildingEnded = new System.Windows.Forms.CheckBox();
            this.cb_buildingStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_ObjectNum = new BuildingProgram.Controls.CustomTextBox();
            this.tb_ObjectName = new BuildingProgram.Controls.CustomTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_isBuildingChecked = new System.Windows.Forms.CheckBox();
            this.cb_Land = new System.Windows.Forms.ComboBox();
            this.cb_Organization = new System.Windows.Forms.ComboBox();
            this.cb_BuildingCompany = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.земельныеУчасткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строительныеКомпанииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЗемельнымУчасткамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поСтроительнымКомпаниямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(258, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добавление нового объекта";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(457, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 186);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(57, 241);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(152, 20);
            this.label23.TabIndex = 49;
            this.label23.Text = "Даты строительства:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(58, 336);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 15);
            this.label21.TabIndex = 47;
            this.label21.Text = "Сдача объекта:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(58, 303);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 15);
            this.label19.TabIndex = 45;
            this.label19.Text = "Начало фактическое:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(58, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 15);
            this.label15.TabIndex = 43;
            this.label15.Text = "Начало плановое:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(58, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 39;
            this.label11.Text = "Номер объекта:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(58, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "Данные об объекте:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(58, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Организация:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(58, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Зайдествованные организации:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Земельные участок:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(59, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Наименование:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(58, 469);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(183, 19);
            this.label17.TabIndex = 53;
            this.label17.Text = "Выбор земельного участка:";
            // 
            // btn_ChosePhoto
            // 
            this.btn_ChosePhoto.BackColor = System.Drawing.Color.Black;
            this.btn_ChosePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChosePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChosePhoto.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ChosePhoto.ForeColor = System.Drawing.Color.White;
            this.btn_ChosePhoto.Location = new System.Drawing.Point(525, 328);
            this.btn_ChosePhoto.Name = "btn_ChosePhoto";
            this.btn_ChosePhoto.Size = new System.Drawing.Size(101, 30);
            this.btn_ChosePhoto.TabIndex = 54;
            this.btn_ChosePhoto.Text = "Выбор фото";
            this.btn_ChosePhoto.UseVisualStyleBackColor = false;
            this.btn_ChosePhoto.Click += new System.EventHandler(this.btn_ChosePhoto_Click);
            // 
            // btn_AddObject
            // 
            this.btn_AddObject.BackColor = System.Drawing.Color.Black;
            this.btn_AddObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddObject.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddObject.ForeColor = System.Drawing.Color.White;
            this.btn_AddObject.Location = new System.Drawing.Point(471, 384);
            this.btn_AddObject.Name = "btn_AddObject";
            this.btn_AddObject.Size = new System.Drawing.Size(78, 38);
            this.btn_AddObject.TabIndex = 55;
            this.btn_AddObject.Text = "Добавить объект";
            this.btn_AddObject.UseVisualStyleBackColor = false;
            this.btn_AddObject.Click += new System.EventHandler(this.btn_AddObject_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Black;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(596, 384);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(78, 38);
            this.btn_Exit.TabIndex = 56;
            this.btn_Exit.Text = "Выход";
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // dtp_StartPlan
            // 
            this.dtp_StartPlan.Location = new System.Drawing.Point(170, 264);
            this.dtp_StartPlan.Name = "dtp_StartPlan";
            this.dtp_StartPlan.Size = new System.Drawing.Size(203, 23);
            this.dtp_StartPlan.TabIndex = 60;
            // 
            // dtp_StartFact
            // 
            this.dtp_StartFact.Location = new System.Drawing.Point(186, 297);
            this.dtp_StartFact.Name = "dtp_StartFact";
            this.dtp_StartFact.Size = new System.Drawing.Size(187, 23);
            this.dtp_StartFact.TabIndex = 61;
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(158, 335);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(215, 23);
            this.dtp_EndDate.TabIndex = 62;
            // 
            // cb_buildingPermit
            // 
            this.cb_buildingPermit.AutoSize = true;
            this.cb_buildingPermit.Location = new System.Drawing.Point(186, 366);
            this.cb_buildingPermit.Name = "cb_buildingPermit";
            this.cb_buildingPermit.Size = new System.Drawing.Size(15, 14);
            this.cb_buildingPermit.TabIndex = 63;
            this.cb_buildingPermit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(58, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 64;
            this.label5.Text = "Разрешена стройка:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(58, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 15);
            this.label8.TabIndex = 66;
            this.label8.Text = "Закончена стройка:";
            // 
            // cb_buildingEnded
            // 
            this.cb_buildingEnded.AutoSize = true;
            this.cb_buildingEnded.Location = new System.Drawing.Point(186, 385);
            this.cb_buildingEnded.Name = "cb_buildingEnded";
            this.cb_buildingEnded.Size = new System.Drawing.Size(15, 14);
            this.cb_buildingEnded.TabIndex = 65;
            this.cb_buildingEnded.UseVisualStyleBackColor = true;
            // 
            // cb_buildingStatus
            // 
            this.cb_buildingStatus.FormattingEnabled = true;
            this.cb_buildingStatus.Items.AddRange(new object[] {
            "строится",
            "сдан под заселение",
            "подготовка участка"});
            this.cb_buildingStatus.Location = new System.Drawing.Point(159, 408);
            this.cb_buildingStatus.Name = "cb_buildingStatus";
            this.cb_buildingStatus.Size = new System.Drawing.Size(175, 23);
            this.cb_buildingStatus.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(60, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 68;
            this.label9.Text = "Статус стройки:";
            // 
            // tb_ObjectNum
            // 
            this.tb_ObjectNum.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ObjectNum.BorderColor = System.Drawing.Color.Black;
            this.tb_ObjectNum.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_ObjectNum.BorderSize = 2;
            this.tb_ObjectNum.Location = new System.Drawing.Point(158, 144);
            this.tb_ObjectNum.Margin = new System.Windows.Forms.Padding(0);
            this.tb_ObjectNum.Multiline = false;
            this.tb_ObjectNum.Name = "tb_ObjectNum";
            this.tb_ObjectNum.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_ObjectNum.Size = new System.Drawing.Size(250, 21);
            this.tb_ObjectNum.TabIndex = 69;
            this.tb_ObjectNum.Texts = "";
            this.tb_ObjectNum.UnderlinedStyle = true;
            // 
            // tb_ObjectName
            // 
            this.tb_ObjectName.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ObjectName.BorderColor = System.Drawing.Color.Black;
            this.tb_ObjectName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_ObjectName.BorderSize = 2;
            this.tb_ObjectName.Location = new System.Drawing.Point(158, 171);
            this.tb_ObjectName.Margin = new System.Windows.Forms.Padding(0);
            this.tb_ObjectName.Multiline = false;
            this.tb_ObjectName.Name = "tb_ObjectName";
            this.tb_ObjectName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_ObjectName.Size = new System.Drawing.Size(250, 21);
            this.tb_ObjectName.TabIndex = 71;
            this.tb_ObjectName.Texts = "";
            this.tb_ObjectName.UnderlinedStyle = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(216, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 15);
            this.label10.TabIndex = 73;
            this.label10.Text = "Проверена стройка:";
            // 
            // cb_isBuildingChecked
            // 
            this.cb_isBuildingChecked.AutoSize = true;
            this.cb_isBuildingChecked.Location = new System.Drawing.Point(340, 367);
            this.cb_isBuildingChecked.Name = "cb_isBuildingChecked";
            this.cb_isBuildingChecked.Size = new System.Drawing.Size(15, 14);
            this.cb_isBuildingChecked.TabIndex = 72;
            this.cb_isBuildingChecked.UseVisualStyleBackColor = true;
            // 
            // cb_Land
            // 
            this.cb_Land.FormattingEnabled = true;
            this.cb_Land.Items.AddRange(new object[] {
            "строится",
            "сдан под заселение"});
            this.cb_Land.Location = new System.Drawing.Point(247, 469);
            this.cb_Land.Name = "cb_Land";
            this.cb_Land.Size = new System.Drawing.Size(175, 23);
            this.cb_Land.TabIndex = 76;
            this.cb_Land.Text = "Нет свободных земельных участков";
            // 
            // cb_Organization
            // 
            this.cb_Organization.FormattingEnabled = true;
            this.cb_Organization.Items.AddRange(new object[] {
            "строится",
            "сдан под заселение"});
            this.cb_Organization.Location = new System.Drawing.Point(273, 513);
            this.cb_Organization.Name = "cb_Organization";
            this.cb_Organization.Size = new System.Drawing.Size(149, 23);
            this.cb_Organization.TabIndex = 77;
            // 
            // cb_BuildingCompany
            // 
            this.cb_BuildingCompany.FormattingEnabled = true;
            this.cb_BuildingCompany.Items.AddRange(new object[] {
            "строится",
            "сдан под заселение"});
            this.cb_BuildingCompany.Location = new System.Drawing.Point(596, 514);
            this.cb_BuildingCompany.Name = "cb_BuildingCompany";
            this.cb_BuildingCompany.Size = new System.Drawing.Size(149, 23);
            this.cb_BuildingCompany.TabIndex = 80;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(427, 515);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 19);
            this.label13.TabIndex = 78;
            this.label13.Text = "Строительная компания:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.земельныеУчасткиToolStripMenuItem,
            this.xToolStripMenuItem,
            this.строительныеКомпанииToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(756, 38);
            this.menuStrip1.TabIndex = 81;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 34);
            this.toolStripMenuItem1.Text = "Объекты";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(92, 34);
            this.toolStripMenuItem2.Text = "Организации";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(65, 34);
            this.toolStripMenuItem3.Text = "Справка";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click_1);
            // 
            // земельныеУчасткиToolStripMenuItem
            // 
            this.земельныеУчасткиToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.земельныеУчасткиToolStripMenuItem.Name = "земельныеУчасткиToolStripMenuItem";
            this.земельныеУчасткиToolStripMenuItem.Size = new System.Drawing.Size(128, 34);
            this.земельныеУчасткиToolStripMenuItem.Text = "Земельные участки";
            this.земельныеУчасткиToolStripMenuItem.Click += new System.EventHandler(this.земельныеУчасткиToolStripMenuItem_Click_1);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(26, 34);
            this.xToolStripMenuItem.Text = "X";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click_1);
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
            this.отчетыToolStripMenuItem.BackColor = System.Drawing.Color.Black;
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
            // AddNewObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 552);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cb_BuildingCompany);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cb_Organization);
            this.Controls.Add(this.cb_Land);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_isBuildingChecked);
            this.Controls.Add(this.tb_ObjectName);
            this.Controls.Add(this.tb_ObjectNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_buildingStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_buildingEnded);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_buildingPermit);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.dtp_StartFact);
            this.Controls.Add(this.dtp_StartPlan);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_AddObject);
            this.Controls.Add(this.btn_ChosePhoto);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddNewObject";
            this.Text = "Добавление объекта";
            this.Load += new System.EventHandler(this.AddNewObject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Label label23;
        private Label label21;
        private Label label19;
        private Label label15;
        private Label label11;
        private Label label12;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label17;
        private Button btn_ChosePhoto;
        private Button btn_AddObject;
        private Button btn_Exit;
        private Controls.CustomTextBox customTextBox2;
        private Controls.CustomTextBox customTextBox1;
        private Controls.CustomTextBox customTextBox3;
        private Controls.CustomTextBox customTextBox4;
        private Controls.CustomTextBox customTextBox5;
        private Controls.CustomTextBox customTextBox6;
        private DateTimePicker dtp_StartPlan;
        private DateTimePicker dtp_StartFact;
        private DateTimePicker dtp_EndDate;
        private CheckBox cb_buildingPermit;
        private Label label5;
        private Label label8;
        private CheckBox cb_buildingEnded;
        private ComboBox cb_buildingStatus;
        private Label label9;
        private CustomTextBox tb_ObjectNum;
        private CustomTextBox tb_ObjectName;
        private Label label10;
        private CheckBox cb_isBuildingChecked;
        private ComboBox cb_Land;
        private ComboBox cb_Organization;
        private ComboBox cb_BuildingCompany;
        private Label label13;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem земельныеУчасткиToolStripMenuItem;
        private ToolStripMenuItem xToolStripMenuItem;
        private ToolStripMenuItem строительныеКомпанииToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
        private ToolStripMenuItem поЗемельнымУчасткамToolStripMenuItem;
        private ToolStripMenuItem поСтроительнымКомпаниямToolStripMenuItem;
    }
}