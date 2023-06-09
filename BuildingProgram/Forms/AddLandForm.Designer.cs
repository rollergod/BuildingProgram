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
            this.cb_LandType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddLand = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_OwnerId = new System.Windows.Forms.ComboBox();
            this.tb_BuyPrice = new BuildingProgram.Controls.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Square = new BuildingProgram.Controls.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_SellPrice = new BuildingProgram.Controls.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Address
            // 
            this.tb_Address.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Address.BorderColor = System.Drawing.Color.Black;
            this.tb_Address.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_Address.BorderSize = 2;
            this.tb_Address.Location = new System.Drawing.Point(174, 145);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Address.Multiline = false;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_Address.Size = new System.Drawing.Size(283, 21);
            this.tb_Address.TabIndex = 97;
            this.tb_Address.Texts = "";
            this.tb_Address.UnderlinedStyle = true;
            // 
            // tb_CadastralNum
            // 
            this.tb_CadastralNum.BackColor = System.Drawing.SystemColors.Window;
            this.tb_CadastralNum.BorderColor = System.Drawing.Color.Black;
            this.tb_CadastralNum.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_CadastralNum.BorderSize = 2;
            this.tb_CadastralNum.Location = new System.Drawing.Point(249, 117);
            this.tb_CadastralNum.Margin = new System.Windows.Forms.Padding(0);
            this.tb_CadastralNum.Multiline = false;
            this.tb_CadastralNum.Name = "tb_CadastralNum";
            this.tb_CadastralNum.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_CadastralNum.Size = new System.Drawing.Size(206, 21);
            this.tb_CadastralNum.TabIndex = 96;
            this.tb_CadastralNum.Texts = "";
            this.tb_CadastralNum.UnderlinedStyle = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(125, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 15);
            this.label9.TabIndex = 95;
            this.label9.Text = "Вид земельного участка:";
            // 
            // cb_LandType
            // 
            this.cb_LandType.FormattingEnabled = true;
            this.cb_LandType.Items.AddRange(new object[] {
            "земли сельскохозяйственного назначения",
            "земли промышленности",
            "земли населенных пунктов"});
            this.cb_LandType.Location = new System.Drawing.Point(271, 259);
            this.cb_LandType.Name = "cb_LandType";
            this.cb_LandType.Size = new System.Drawing.Size(184, 23);
            this.cb_LandType.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(127, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 85;
            this.label7.Text = "Адрес:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(125, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 15);
            this.label11.TabIndex = 79;
            this.label11.Text = "Кадастровый номер:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(127, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 19);
            this.label12.TabIndex = 78;
            this.label12.Text = "Данные об объекте:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(132, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Добавление земельного участка";
            // 
            // btn_AddLand
            // 
            this.btn_AddLand.BackColor = System.Drawing.Color.Black;
            this.btn_AddLand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddLand.ForeColor = System.Drawing.Color.White;
            this.btn_AddLand.Location = new System.Drawing.Point(227, 352);
            this.btn_AddLand.Name = "btn_AddLand";
            this.btn_AddLand.Size = new System.Drawing.Size(140, 42);
            this.btn_AddLand.TabIndex = 102;
            this.btn_AddLand.Text = "Добавить земельный участок";
            this.btn_AddLand.UseVisualStyleBackColor = false;
            this.btn_AddLand.Click += new System.EventHandler(this.btn_AddLand_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(125, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 104;
            this.label8.Text = "Владелец:";
            // 
            // cb_OwnerId
            // 
            this.cb_OwnerId.FormattingEnabled = true;
            this.cb_OwnerId.Items.AddRange(new object[] {
            "строится",
            "сдан под заселение"});
            this.cb_OwnerId.Location = new System.Drawing.Point(271, 232);
            this.cb_OwnerId.Name = "cb_OwnerId";
            this.cb_OwnerId.Size = new System.Drawing.Size(184, 23);
            this.cb_OwnerId.TabIndex = 103;
            // 
            // tb_BuyPrice
            // 
            this.tb_BuyPrice.BackColor = System.Drawing.SystemColors.Window;
            this.tb_BuyPrice.BorderColor = System.Drawing.Color.Black;
            this.tb_BuyPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_BuyPrice.BorderSize = 2;
            this.tb_BuyPrice.Location = new System.Drawing.Point(252, 179);
            this.tb_BuyPrice.Margin = new System.Windows.Forms.Padding(0);
            this.tb_BuyPrice.Multiline = false;
            this.tb_BuyPrice.Name = "tb_BuyPrice";
            this.tb_BuyPrice.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_BuyPrice.Size = new System.Drawing.Size(203, 21);
            this.tb_BuyPrice.TabIndex = 106;
            this.tb_BuyPrice.Texts = "";
            this.tb_BuyPrice.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(125, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 105;
            this.label3.Text = "Покупная стоимость:";
            // 
            // tb_Square
            // 
            this.tb_Square.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Square.BorderColor = System.Drawing.Color.Black;
            this.tb_Square.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_Square.BorderSize = 2;
            this.tb_Square.Location = new System.Drawing.Point(227, 290);
            this.tb_Square.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Square.Multiline = false;
            this.tb_Square.Name = "tb_Square";
            this.tb_Square.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_Square.Size = new System.Drawing.Size(228, 21);
            this.tb_Square.TabIndex = 108;
            this.tb_Square.Texts = "";
            this.tb_Square.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(127, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 107;
            this.label4.Text = "Площадь (М^2):";
            // 
            // tb_SellPrice
            // 
            this.tb_SellPrice.BackColor = System.Drawing.SystemColors.Window;
            this.tb_SellPrice.BorderColor = System.Drawing.Color.Black;
            this.tb_SellPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_SellPrice.BorderSize = 2;
            this.tb_SellPrice.Location = new System.Drawing.Point(231, 205);
            this.tb_SellPrice.Margin = new System.Windows.Forms.Padding(0);
            this.tb_SellPrice.Multiline = false;
            this.tb_SellPrice.Name = "tb_SellPrice";
            this.tb_SellPrice.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_SellPrice.Size = new System.Drawing.Size(224, 21);
            this.tb_SellPrice.TabIndex = 112;
            this.tb_SellPrice.Texts = "";
            this.tb_SellPrice.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(125, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 111;
            this.label6.Text = "Продажная цена:";
            // 
            // AddLandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 429);
            this.Controls.Add(this.tb_SellPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Square);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_BuyPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_OwnerId);
            this.Controls.Add(this.btn_AddLand);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_CadastralNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_LandType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Name = "AddLandForm";
            this.Text = "Добавление земельного участка";
            this.Load += new System.EventHandler(this.AddLandForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.CustomTextBox tb_Address;
        private Controls.CustomTextBox tb_CadastralNum;
        private Label label9;
        private ComboBox cb_LandType;
        private Label label7;
        private Label label11;
        private Label label12;
        private Label label1;
        private Button btn_AddLand;
        private Label label8;
        private ComboBox cb_OwnerId;
        private Controls.CustomTextBox tb_BuyPrice;
        private Label label3;
        private Controls.CustomTextBox tb_Square;
        private Label label4;
        private Controls.CustomTextBox tb_SellPrice;
        private Label label6;
    }
}