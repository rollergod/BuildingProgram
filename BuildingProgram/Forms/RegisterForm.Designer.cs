namespace BuildingProgram.Forms
{
    partial class RegisterForm
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
            this.btn_Create = new Krypton.Toolkit.KryptonButton();
            this.tB_Login = new Krypton.Toolkit.KryptonTextBox();
            this.tB_FirstPassword = new Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_SecondPassword = new Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // btn_Create
            // 
            this.btn_Create.CornerRoundingRadius = 5F;
            this.btn_Create.Location = new System.Drawing.Point(215, 302);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Create.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Create.Size = new System.Drawing.Size(100, 38);
            this.btn_Create.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Create.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Create.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Create.StateCommon.Border.Rounding = 5F;
            this.btn_Create.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Create.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Create.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Create.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_Create.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_Create.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Create.StateTracking.Border.Rounding = 5F;
            this.btn_Create.StateTracking.Border.Width = 2;
            this.btn_Create.TabIndex = 23;
            this.btn_Create.Values.Text = "Создать";
            this.btn_Create.Click += new System.EventHandler(this.btn_Create2_Click);
            // 
            // tB_Login
            // 
            this.tB_Login.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tB_Login.CueHint.CueHintText = "Введите логин";
            this.tB_Login.CueHint.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_Login.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tB_Login.Location = new System.Drawing.Point(161, 166);
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
            this.tB_Login.TabIndex = 22;
            // 
            // tB_FirstPassword
            // 
            this.tB_FirstPassword.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tB_FirstPassword.CueHint.CueHintText = "Введите пароль";
            this.tB_FirstPassword.CueHint.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_FirstPassword.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tB_FirstPassword.Location = new System.Drawing.Point(161, 211);
            this.tB_FirstPassword.Name = "tB_FirstPassword";
            this.tB_FirstPassword.Size = new System.Drawing.Size(210, 31);
            this.tB_FirstPassword.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.tB_FirstPassword.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.tB_FirstPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tB_FirstPassword.StateCommon.Border.Rounding = 5F;
            this.tB_FirstPassword.StateCommon.Border.Width = 1;
            this.tB_FirstPassword.StateCommon.Content.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_FirstPassword.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(133, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 62);
            this.label3.TabIndex = 19;
            this.label3.Text = "Регистрация нового аккаунта";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(180, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Введите необходимые данные";
            // 
            // tB_SecondPassword
            // 
            this.tB_SecondPassword.CueHint.Color1 = System.Drawing.Color.Gray;
            this.tB_SecondPassword.CueHint.CueHintText = "Повторите пароль";
            this.tB_SecondPassword.CueHint.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_SecondPassword.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.tB_SecondPassword.Location = new System.Drawing.Point(161, 256);
            this.tB_SecondPassword.Name = "tB_SecondPassword";
            this.tB_SecondPassword.Size = new System.Drawing.Size(210, 31);
            this.tB_SecondPassword.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.tB_SecondPassword.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.tB_SecondPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tB_SecondPassword.StateCommon.Border.Rounding = 5F;
            this.tB_SecondPassword.StateCommon.Border.Width = 1;
            this.tB_SecondPassword.StateCommon.Content.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_SecondPassword.TabIndex = 24;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 379);
            this.Controls.Add(this.tB_SecondPassword);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.tB_Login);
            this.Controls.Add(this.tB_FirstPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegisterForm";
            this.Text = "Создание аккаунта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonButton btn_Create;
        private Krypton.Toolkit.KryptonTextBox tB_Login;
        private Krypton.Toolkit.KryptonTextBox tB_FirstPassword;
        private Label label3;
        private Label label6;
        private Krypton.Toolkit.KryptonTextBox tB_SecondPassword;
    }
}