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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
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
            this.cb_BuildingCompany = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_LandOrg = new System.Windows.Forms.Label();
            this.btn_AddObject = new Krypton.Toolkit.KryptonButton();
            this.btn_Exit = new Krypton.Toolkit.KryptonButton();
            this.btn_ChosePhoto = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(253, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добавление нового объекта";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(452, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 186);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(52, 210);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(152, 20);
            this.label23.TabIndex = 49;
            this.label23.Text = "Даты строительства:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(53, 305);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 15);
            this.label21.TabIndex = 47;
            this.label21.Text = "Сдача объекта:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(53, 272);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 15);
            this.label19.TabIndex = 45;
            this.label19.Text = "Начало фактическое:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(53, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 15);
            this.label15.TabIndex = 43;
            this.label15.Text = "Начало плановое:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(53, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 39;
            this.label11.Text = "Номер объекта:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(53, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "Данные об объекте:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Земельные участок:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Наименование:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(53, 438);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(183, 19);
            this.label17.TabIndex = 53;
            this.label17.Text = "Выбор земельного участка:";
            // 
            // dtp_StartPlan
            // 
            this.dtp_StartPlan.Location = new System.Drawing.Point(165, 233);
            this.dtp_StartPlan.Name = "dtp_StartPlan";
            this.dtp_StartPlan.Size = new System.Drawing.Size(203, 23);
            this.dtp_StartPlan.TabIndex = 60;
            // 
            // dtp_StartFact
            // 
            this.dtp_StartFact.Location = new System.Drawing.Point(181, 266);
            this.dtp_StartFact.Name = "dtp_StartFact";
            this.dtp_StartFact.Size = new System.Drawing.Size(187, 23);
            this.dtp_StartFact.TabIndex = 61;
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(153, 304);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(215, 23);
            this.dtp_EndDate.TabIndex = 62;
            // 
            // cb_buildingPermit
            // 
            this.cb_buildingPermit.AutoSize = true;
            this.cb_buildingPermit.Location = new System.Drawing.Point(181, 335);
            this.cb_buildingPermit.Name = "cb_buildingPermit";
            this.cb_buildingPermit.Size = new System.Drawing.Size(15, 14);
            this.cb_buildingPermit.TabIndex = 63;
            this.cb_buildingPermit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 64;
            this.label5.Text = "Разрешена стройка:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(53, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 15);
            this.label8.TabIndex = 66;
            this.label8.Text = "Закончена стройка:";
            // 
            // cb_buildingEnded
            // 
            this.cb_buildingEnded.AutoSize = true;
            this.cb_buildingEnded.Location = new System.Drawing.Point(181, 354);
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
            this.cb_buildingStatus.Location = new System.Drawing.Point(154, 377);
            this.cb_buildingStatus.Name = "cb_buildingStatus";
            this.cb_buildingStatus.Size = new System.Drawing.Size(175, 23);
            this.cb_buildingStatus.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(55, 380);
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
            this.tb_ObjectNum.Location = new System.Drawing.Point(153, 113);
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
            this.tb_ObjectName.Location = new System.Drawing.Point(153, 140);
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
            this.label10.Location = new System.Drawing.Point(211, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 15);
            this.label10.TabIndex = 73;
            this.label10.Text = "Проверена стройка:";
            // 
            // cb_isBuildingChecked
            // 
            this.cb_isBuildingChecked.AutoSize = true;
            this.cb_isBuildingChecked.Location = new System.Drawing.Point(335, 336);
            this.cb_isBuildingChecked.Name = "cb_isBuildingChecked";
            this.cb_isBuildingChecked.Size = new System.Drawing.Size(15, 14);
            this.cb_isBuildingChecked.TabIndex = 72;
            this.cb_isBuildingChecked.UseVisualStyleBackColor = true;
            // 
            // cb_Land
            // 
            this.cb_Land.FormattingEnabled = true;
            this.cb_Land.Location = new System.Drawing.Point(242, 438);
            this.cb_Land.Name = "cb_Land";
            this.cb_Land.Size = new System.Drawing.Size(175, 23);
            this.cb_Land.TabIndex = 76;
            this.cb_Land.SelectedIndexChanged += new System.EventHandler(this.cb_Land_SelectedIndexChanged);
            // 
            // cb_BuildingCompany
            // 
            this.cb_BuildingCompany.FormattingEnabled = true;
            this.cb_BuildingCompany.Location = new System.Drawing.Point(592, 439);
            this.cb_BuildingCompany.Name = "cb_BuildingCompany";
            this.cb_BuildingCompany.Size = new System.Drawing.Size(149, 23);
            this.cb_BuildingCompany.TabIndex = 80;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(423, 440);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 19);
            this.label13.TabIndex = 78;
            this.label13.Text = "Строительная компания:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(55, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 83;
            this.label7.Text = "Владелец:";
            // 
            // lb_LandOrg
            // 
            this.lb_LandOrg.AutoSize = true;
            this.lb_LandOrg.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_LandOrg.Location = new System.Drawing.Point(132, 468);
            this.lb_LandOrg.Name = "lb_LandOrg";
            this.lb_LandOrg.Size = new System.Drawing.Size(0, 19);
            this.lb_LandOrg.TabIndex = 84;
            // 
            // btn_AddObject
            // 
            this.btn_AddObject.CornerRoundingRadius = 5F;
            this.btn_AddObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddObject.Location = new System.Drawing.Point(452, 348);
            this.btn_AddObject.Name = "btn_AddObject";
            this.btn_AddObject.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_AddObject.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_AddObject.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddObject.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddObject.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddObject.OverrideDefault.Border.Width = 2;
            this.btn_AddObject.Size = new System.Drawing.Size(97, 43);
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
            this.btn_AddObject.TabIndex = 85;
            this.btn_AddObject.Values.Text = "Добавить\r\nобъект";
            this.btn_AddObject.Click += new System.EventHandler(this.btn_AddObject_Click_1);
            // 
            // btn_Exit
            // 
            this.btn_Exit.CornerRoundingRadius = 5F;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Location = new System.Drawing.Point(582, 348);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_Exit.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_Exit.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_Exit.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_Exit.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Exit.OverrideDefault.Border.Width = 2;
            this.btn_Exit.Size = new System.Drawing.Size(97, 43);
            this.btn_Exit.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_Exit.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_Exit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Exit.StateCommon.Border.Rounding = 5F;
            this.btn_Exit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Exit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Exit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.btn_Exit.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Exit.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Exit.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_Exit.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_Exit.StateNormal.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_Exit.StateNormal.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_Exit.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Exit.StateNormal.Border.Width = 2;
            this.btn_Exit.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Exit.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Exit.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_Exit.StatePressed.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_Exit.StatePressed.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_Exit.StatePressed.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_Exit.StatePressed.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_Exit.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Exit.StatePressed.Border.Width = 2;
            this.btn_Exit.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_Exit.StateTracking.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_Exit.StateTracking.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_Exit.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_Exit.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_Exit.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Exit.StateTracking.Border.Rounding = 5F;
            this.btn_Exit.StateTracking.Border.Width = 2;
            this.btn_Exit.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_Exit.TabIndex = 86;
            this.btn_Exit.Values.Text = "Выход";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_ChosePhoto
            // 
            this.btn_ChosePhoto.CornerRoundingRadius = 5F;
            this.btn_ChosePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChosePhoto.Location = new System.Drawing.Point(511, 290);
            this.btn_ChosePhoto.Name = "btn_ChosePhoto";
            this.btn_ChosePhoto.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_ChosePhoto.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_ChosePhoto.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChosePhoto.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChosePhoto.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChosePhoto.OverrideDefault.Border.Width = 2;
            this.btn_ChosePhoto.Size = new System.Drawing.Size(108, 39);
            this.btn_ChosePhoto.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_ChosePhoto.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_ChosePhoto.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChosePhoto.StateCommon.Border.Rounding = 5F;
            this.btn_ChosePhoto.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ChosePhoto.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ChosePhoto.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ChosePhoto.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.btn_ChosePhoto.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_ChosePhoto.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_ChosePhoto.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_ChosePhoto.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_ChosePhoto.StateNormal.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChosePhoto.StateNormal.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChosePhoto.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChosePhoto.StateNormal.Border.Width = 2;
            this.btn_ChosePhoto.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_ChosePhoto.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_ChosePhoto.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_ChosePhoto.StatePressed.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChosePhoto.StatePressed.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChosePhoto.StatePressed.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChosePhoto.StatePressed.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChosePhoto.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChosePhoto.StatePressed.Border.Width = 2;
            this.btn_ChosePhoto.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_ChosePhoto.StateTracking.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_ChosePhoto.StateTracking.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_ChosePhoto.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_ChosePhoto.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_ChosePhoto.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ChosePhoto.StateTracking.Border.Rounding = 5F;
            this.btn_ChosePhoto.StateTracking.Border.Width = 2;
            this.btn_ChosePhoto.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_ChosePhoto.TabIndex = 87;
            this.btn_ChosePhoto.Values.Text = "Выбор фото";
            this.btn_ChosePhoto.Click += new System.EventHandler(this.btn_ChosePhoto_Click_1);
            // 
            // AddNewObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 500);
            this.Controls.Add(this.btn_ChosePhoto);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_AddObject);
            this.Controls.Add(this.lb_LandOrg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_BuildingCompany);
            this.Controls.Add(this.label13);
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
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddNewObject";
            this.Text = "Добавление объекта";
            this.Load += new System.EventHandler(this.AddNewObject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Label label3;
        private Label label2;
        private Label label17;
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
        private ComboBox cb_BuildingCompany;
        private Label label13;
        private Label label7;
        private Label lb_LandOrg;
        private Krypton.Toolkit.KryptonButton btn_AddObject;
        private Krypton.Toolkit.KryptonButton btn_Exit;
        private Krypton.Toolkit.KryptonButton btn_ChosePhoto;
    }
}