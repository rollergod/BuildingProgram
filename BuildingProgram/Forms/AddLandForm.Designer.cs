namespace BuildingProgram.Forms
{
    partial class AddLandForm
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
            this.tb_ObjectName = new BuildingProgram.Controls.CustomTextBox();
            this.tb_Address = new BuildingProgram.Controls.CustomTextBox();
            this.tb_ObjectNum = new BuildingProgram.Controls.CustomTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_buildingStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_isSold = new System.Windows.Forms.CheckBox();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartFact = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartPlan = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.земельныеУчасткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.организацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AddLand = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_sellerId = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ObjectName
            // 
            this.tb_ObjectName.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ObjectName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_ObjectName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_ObjectName.BorderSize = 2;
            this.tb_ObjectName.Location = new System.Drawing.Point(135, 218);
            this.tb_ObjectName.Margin = new System.Windows.Forms.Padding(0);
            this.tb_ObjectName.Multiline = false;
            this.tb_ObjectName.Name = "tb_ObjectName";
            this.tb_ObjectName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_ObjectName.Size = new System.Drawing.Size(250, 21);
            this.tb_ObjectName.TabIndex = 98;
            this.tb_ObjectName.Texts = "";
            this.tb_ObjectName.UnderlinedStyle = false;
            // 
            // tb_Address
            // 
            this.tb_Address.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Address.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_Address.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_Address.BorderSize = 2;
            this.tb_Address.Location = new System.Drawing.Point(87, 192);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Address.Multiline = false;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_Address.Size = new System.Drawing.Size(250, 21);
            this.tb_Address.TabIndex = 97;
            this.tb_Address.Texts = "";
            this.tb_Address.UnderlinedStyle = false;
            // 
            // tb_ObjectNum
            // 
            this.tb_ObjectNum.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ObjectNum.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_ObjectNum.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_ObjectNum.BorderSize = 2;
            this.tb_ObjectNum.Location = new System.Drawing.Point(165, 164);
            this.tb_ObjectNum.Margin = new System.Windows.Forms.Padding(0);
            this.tb_ObjectNum.Multiline = false;
            this.tb_ObjectNum.Name = "tb_ObjectNum";
            this.tb_ObjectNum.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_ObjectNum.Size = new System.Drawing.Size(250, 21);
            this.tb_ObjectNum.TabIndex = 96;
            this.tb_ObjectNum.Texts = "";
            this.tb_ObjectNum.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(41, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 15);
            this.label9.TabIndex = 95;
            this.label9.Text = "Тип земельного участка:";
            // 
            // cb_buildingStatus
            // 
            this.cb_buildingStatus.FormattingEnabled = true;
            this.cb_buildingStatus.Items.AddRange(new object[] {
            "строится",
            "сдан под заселение"});
            this.cb_buildingStatus.Location = new System.Drawing.Point(188, 407);
            this.cb_buildingStatus.Name = "cb_buildingStatus";
            this.cb_buildingStatus.Size = new System.Drawing.Size(121, 23);
            this.cb_buildingStatus.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(41, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 91;
            this.label5.Text = "Разрешена стройка:";
            // 
            // cb_isSold
            // 
            this.cb_isSold.AutoSize = true;
            this.cb_isSold.Location = new System.Drawing.Point(165, 383);
            this.cb_isSold.Name = "cb_isSold";
            this.cb_isSold.Size = new System.Drawing.Size(15, 14);
            this.cb_isSold.TabIndex = 90;
            this.cb_isSold.UseVisualStyleBackColor = true;
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(137, 352);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(215, 23);
            this.dtp_EndDate.TabIndex = 89;
            // 
            // dtp_StartFact
            // 
            this.dtp_StartFact.Location = new System.Drawing.Point(170, 314);
            this.dtp_StartFact.Name = "dtp_StartFact";
            this.dtp_StartFact.Size = new System.Drawing.Size(182, 23);
            this.dtp_StartFact.TabIndex = 88;
            // 
            // dtp_StartPlan
            // 
            this.dtp_StartPlan.Location = new System.Drawing.Point(152, 281);
            this.dtp_StartPlan.Name = "dtp_StartPlan";
            this.dtp_StartPlan.Size = new System.Drawing.Size(200, 23);
            this.dtp_StartPlan.TabIndex = 87;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(37, 490);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(183, 19);
            this.label17.TabIndex = 86;
            this.label17.Text = "Выбор земельного участка:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(40, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 85;
            this.label7.Text = "Адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 84;
            this.label2.Text = "Наименование:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(39, 257);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(152, 20);
            this.label23.TabIndex = 83;
            this.label23.Text = "Даты строительства:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(41, 353);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 15);
            this.label21.TabIndex = 82;
            this.label21.Text = "Сдача объекта:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(40, 320);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 15);
            this.label19.TabIndex = 81;
            this.label19.Text = "Начало фактическое:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(40, 287);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 15);
            this.label15.TabIndex = 80;
            this.label15.Text = "Начало плановое:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(37, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 15);
            this.label11.TabIndex = 79;
            this.label11.Text = "Кадастровый номер:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(39, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 19);
            this.label12.TabIndex = 78;
            this.label12.Text = "Данные об объекте:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "Организация:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 19);
            this.label4.TabIndex = 76;
            this.label4.Text = "Зайдествованные организации:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Земельные участок:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Добавление земельного участка";
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
            this.организацииToolStripMenuItem,
            this.xToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 101;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 34);
            this.toolStripMenuItem1.Text = "Объекты";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(92, 34);
            this.toolStripMenuItem2.Text = "Организации";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(65, 34);
            this.toolStripMenuItem3.Text = "Справка";
            // 
            // земельныеУчасткиToolStripMenuItem
            // 
            this.земельныеУчасткиToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.земельныеУчасткиToolStripMenuItem.Name = "земельныеУчасткиToolStripMenuItem";
            this.земельныеУчасткиToolStripMenuItem.Size = new System.Drawing.Size(128, 34);
            this.земельныеУчасткиToolStripMenuItem.Text = "Земельные участки";
            // 
            // организацииToolStripMenuItem
            // 
            this.организацииToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.организацииToolStripMenuItem.Name = "организацииToolStripMenuItem";
            this.организацииToolStripMenuItem.Size = new System.Drawing.Size(92, 34);
            this.организацииToolStripMenuItem.Text = "Организации";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(26, 34);
            this.xToolStripMenuItem.Text = "X";
            // 
            // btn_AddLand
            // 
            this.btn_AddLand.Location = new System.Drawing.Point(564, 468);
            this.btn_AddLand.Name = "btn_AddLand";
            this.btn_AddLand.Size = new System.Drawing.Size(75, 63);
            this.btn_AddLand.TabIndex = 102;
            this.btn_AddLand.Text = "Добавить земельный участок";
            this.btn_AddLand.UseVisualStyleBackColor = true;
            this.btn_AddLand.Click += new System.EventHandler(this.btn_AddLand_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(41, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 104;
            this.label8.Text = "Продавец:";
            // 
            // cb_sellerId
            // 
            this.cb_sellerId.FormattingEnabled = true;
            this.cb_sellerId.Items.AddRange(new object[] {
            "строится",
            "сдан под заселение"});
            this.cb_sellerId.Location = new System.Drawing.Point(188, 436);
            this.cb_sellerId.Name = "cb_sellerId";
            this.cb_sellerId.Size = new System.Drawing.Size(121, 23);
            this.cb_sellerId.TabIndex = 103;
            // 
            // AddLandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_sellerId);
            this.Controls.Add(this.btn_AddLand);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tb_ObjectName);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_ObjectNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_buildingStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_isSold);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.dtp_StartFact);
            this.Controls.Add(this.dtp_StartPlan);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddLandForm";
            this.Text = "Добавление земельного участка";
            this.Load += new System.EventHandler(this.AddLandForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.CustomTextBox tb_ObjectName;
        private Controls.CustomTextBox tb_Address;
        private Controls.CustomTextBox tb_ObjectNum;
        private Label label9;
        private ComboBox cb_buildingStatus;
        private Label label5;
        private CheckBox cb_isSold;
        private DateTimePicker dtp_EndDate;
        private DateTimePicker dtp_StartFact;
        private DateTimePicker dtp_StartPlan;
        private Label label17;
        private Label label7;
        private Label label2;
        private Label label23;
        private Label label21;
        private Label label19;
        private Label label15;
        private Label label11;
        private Label label12;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem земельныеУчасткиToolStripMenuItem;
        private ToolStripMenuItem организацииToolStripMenuItem;
        private ToolStripMenuItem xToolStripMenuItem;
        private Button btn_AddLand;
        private Label label8;
        private ComboBox cb_sellerId;
    }
}