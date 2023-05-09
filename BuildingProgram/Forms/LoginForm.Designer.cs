namespace BuildingProgram
{
    partial class Login_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CreateAccount = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_Password = new Krypton.Toolkit.KryptonTextBox();
            this.tB_Login = new Krypton.Toolkit.KryptonTextBox();
            this.btn_Enter2 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вход в аккаунт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(71, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Нет аккаунта?";
            // 
            // btn_CreateAccount
            // 
            this.btn_CreateAccount.BackColor = System.Drawing.Color.White;
            this.btn_CreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_CreateAccount.FlatAppearance.BorderSize = 0;
            this.btn_CreateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CreateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateAccount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_CreateAccount.Location = new System.Drawing.Point(152, 339);
            this.btn_CreateAccount.Name = "btn_CreateAccount";
            this.btn_CreateAccount.Size = new System.Drawing.Size(78, 23);
            this.btn_CreateAccount.TabIndex = 7;
            this.btn_CreateAccount.Text = "Создай его!";
            this.btn_CreateAccount.UseVisualStyleBackColor = false;
            this.btn_CreateAccount.Click += new System.EventHandler(this.btn_CreateAccount_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 62);
            this.label4.TabIndex = 10;
            this.label4.Text = "Надзор за строительством ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(54, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 62);
            this.label5.TabIndex = 11;
            this.label5.Text = "Контроль за строительством в современном формате.";
            // 
            // tB_Password
            // 
            this.tB_Password.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tB_Password.CueHint.CueHintText = "Введите пароль";
            this.tB_Password.CueHint.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_Password.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tB_Password.Location = new System.Drawing.Point(54, 233);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.Size = new System.Drawing.Size(210, 31);
            this.tB_Password.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.tB_Password.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.tB_Password.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tB_Password.StateCommon.Border.Rounding = 5F;
            this.tB_Password.StateCommon.Border.Width = 1;
            this.tB_Password.StateCommon.Content.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_Password.TabIndex = 12;
            // 
            // tB_Login
            // 
            this.tB_Login.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tB_Login.CueHint.CueHintText = "Введите логин";
            this.tB_Login.CueHint.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_Login.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tB_Login.Location = new System.Drawing.Point(54, 184);
            this.tB_Login.Name = "tB_Login";
            this.tB_Login.Size = new System.Drawing.Size(210, 31);
            this.tB_Login.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.tB_Login.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.tB_Login.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tB_Login.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tB_Login.StateCommon.Border.Rounding = 5F;
            this.tB_Login.StateCommon.Border.Width = 1;
            this.tB_Login.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.tB_Login.StateCommon.Content.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_Login.TabIndex = 13;
            // 
            // btn_Enter2
            // 
            this.btn_Enter2.CornerRoundingRadius = 5F;
            this.btn_Enter2.Location = new System.Drawing.Point(105, 280);
            this.btn_Enter2.Name = "btn_Enter2";
            this.btn_Enter2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Enter2.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Enter2.Size = new System.Drawing.Size(100, 38);
            this.btn_Enter2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Enter2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Enter2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Enter2.StateCommon.Border.Rounding = 5F;
            this.btn_Enter2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Enter2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Enter2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Enter2.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Enter2.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Enter2.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Enter2.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Enter2.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Enter2.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Enter2.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Enter2.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Enter2.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_Enter2.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_Enter2.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Enter2.StateTracking.Border.Rounding = 5F;
            this.btn_Enter2.StateTracking.Border.Width = 2;
            this.btn_Enter2.TabIndex = 14;
            this.btn_Enter2.Values.Text = "Войти";
            this.btn_Enter2.Click += new System.EventHandler(this.btn_Enter2_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Enter2);
            this.Controls.Add(this.tB_Login);
            this.Controls.Add(this.tB_Password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_CreateAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label3;
        private Button btn_CreateAccount;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Krypton.Toolkit.KryptonTextBox tB_Password;
        private Krypton.Toolkit.KryptonTextBox tB_Login;
        private Krypton.Toolkit.KryptonButton btn_Enter2;
    }
}