﻿namespace BuildingProgram.Forms
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
            this.tb_Address = new BuildingProgram.Controls.CustomTextBox();
            this.tb_CadastralNum = new BuildingProgram.Controls.CustomTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_buildingStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.tb_BuyPrice = new BuildingProgram.Controls.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Square = new BuildingProgram.Controls.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_SellPrice = new BuildingProgram.Controls.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Buyer = new System.Windows.Forms.ComboBox();
            this.cb_IsSold = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.tb_Address.Size = new System.Drawing.Size(328, 21);
            this.tb_Address.TabIndex = 97;
            this.tb_Address.Texts = "";
            this.tb_Address.UnderlinedStyle = false;
            // 
            // tb_CadastralNum
            // 
            this.tb_CadastralNum.BackColor = System.Drawing.SystemColors.Window;
            this.tb_CadastralNum.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_CadastralNum.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_CadastralNum.BorderSize = 2;
            this.tb_CadastralNum.Location = new System.Drawing.Point(165, 164);
            this.tb_CadastralNum.Margin = new System.Windows.Forms.Padding(0);
            this.tb_CadastralNum.Multiline = false;
            this.tb_CadastralNum.Name = "tb_CadastralNum";
            this.tb_CadastralNum.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_CadastralNum.Size = new System.Drawing.Size(250, 21);
            this.tb_CadastralNum.TabIndex = 96;
            this.tb_CadastralNum.Texts = "";
            this.tb_CadastralNum.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(37, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 15);
            this.label9.TabIndex = 95;
            this.label9.Text = "Вид земельного участка:";
            // 
            // cb_buildingStatus
            // 
            this.cb_buildingStatus.FormattingEnabled = true;
            this.cb_buildingStatus.Items.AddRange(new object[] {
            "строится",
            "сдан под заселение"});
            this.cb_buildingStatus.Location = new System.Drawing.Point(183, 306);
            this.cb_buildingStatus.Name = "cb_buildingStatus";
            this.cb_buildingStatus.Size = new System.Drawing.Size(232, 23);
            this.cb_buildingStatus.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(37, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 85;
            this.label7.Text = "Адрес:";
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
            this.btn_AddLand.Location = new System.Drawing.Point(39, 425);
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
            this.label8.Location = new System.Drawing.Point(37, 284);
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
            this.cb_sellerId.Location = new System.Drawing.Point(108, 279);
            this.cb_sellerId.Name = "cb_sellerId";
            this.cb_sellerId.Size = new System.Drawing.Size(307, 23);
            this.cb_sellerId.TabIndex = 103;
            // 
            // tb_BuyPrice
            // 
            this.tb_BuyPrice.BackColor = System.Drawing.SystemColors.Window;
            this.tb_BuyPrice.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_BuyPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_BuyPrice.BorderSize = 2;
            this.tb_BuyPrice.Location = new System.Drawing.Point(165, 226);
            this.tb_BuyPrice.Margin = new System.Windows.Forms.Padding(0);
            this.tb_BuyPrice.Multiline = false;
            this.tb_BuyPrice.Name = "tb_BuyPrice";
            this.tb_BuyPrice.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_BuyPrice.Size = new System.Drawing.Size(250, 21);
            this.tb_BuyPrice.TabIndex = 106;
            this.tb_BuyPrice.Texts = "";
            this.tb_BuyPrice.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 105;
            this.label3.Text = "Покупная стоимость:";
            // 
            // tb_Square
            // 
            this.tb_Square.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Square.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_Square.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_Square.BorderSize = 2;
            this.tb_Square.Location = new System.Drawing.Point(142, 334);
            this.tb_Square.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Square.Multiline = false;
            this.tb_Square.Name = "tb_Square";
            this.tb_Square.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_Square.Size = new System.Drawing.Size(269, 21);
            this.tb_Square.TabIndex = 108;
            this.tb_Square.Texts = "";
            this.tb_Square.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 107;
            this.label4.Text = "Площадь (М^2):";
            // 
            // tb_SellPrice
            // 
            this.tb_SellPrice.BackColor = System.Drawing.SystemColors.Window;
            this.tb_SellPrice.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_SellPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_SellPrice.BorderSize = 2;
            this.tb_SellPrice.Location = new System.Drawing.Point(146, 252);
            this.tb_SellPrice.Margin = new System.Windows.Forms.Padding(0);
            this.tb_SellPrice.Multiline = false;
            this.tb_SellPrice.Name = "tb_SellPrice";
            this.tb_SellPrice.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_SellPrice.Size = new System.Drawing.Size(269, 21);
            this.tb_SellPrice.TabIndex = 112;
            this.tb_SellPrice.Texts = "";
            this.tb_SellPrice.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 111;
            this.label6.Text = "Продажная цена:";
            // 
            // cb_Buyer
            // 
            this.cb_Buyer.FormattingEnabled = true;
            this.cb_Buyer.Location = new System.Drawing.Point(570, 202);
            this.cb_Buyer.Name = "cb_Buyer";
            this.cb_Buyer.Size = new System.Drawing.Size(121, 23);
            this.cb_Buyer.TabIndex = 113;
            this.cb_Buyer.Visible = false;
            // 
            // cb_IsSold
            // 
            this.cb_IsSold.AutoSize = true;
            this.cb_IsSold.Location = new System.Drawing.Point(570, 158);
            this.cb_IsSold.Name = "cb_IsSold";
            this.cb_IsSold.Size = new System.Drawing.Size(69, 19);
            this.cb_IsSold.TabIndex = 114;
            this.cb_IsSold.Text = "Продан";
            this.cb_IsSold.UseVisualStyleBackColor = true;
            this.cb_IsSold.CheckedChanged += new System.EventHandler(this.cb_IsSold_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(570, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 115;
            this.label2.Text = "Покупатель:";
            this.label2.Visible = false;
            // 
            // AddLandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_IsSold);
            this.Controls.Add(this.cb_Buyer);
            this.Controls.Add(this.tb_SellPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Square);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_BuyPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_sellerId);
            this.Controls.Add(this.btn_AddLand);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_CadastralNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_buildingStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
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
        private Controls.CustomTextBox tb_Address;
        private Controls.CustomTextBox tb_CadastralNum;
        private Label label9;
        private ComboBox cb_buildingStatus;
        private Label label7;
        private Label label11;
        private Label label12;
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
        private Controls.CustomTextBox tb_BuyPrice;
        private Label label3;
        private Controls.CustomTextBox tb_Square;
        private Label label4;
        private Controls.CustomTextBox tb_SellPrice;
        private Label label6;
        private ComboBox cb_Buyer;
        private CheckBox cb_IsSold;
        private Label label2;
    }
}