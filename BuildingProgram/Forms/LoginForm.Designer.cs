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
            this.tB_Login = new System.Windows.Forms.TextBox();
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CreateAccount = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_Login
            // 
            this.tB_Login.BackColor = System.Drawing.Color.Black;
            this.tB_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Login.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_Login.ForeColor = System.Drawing.Color.White;
            this.tB_Login.Location = new System.Drawing.Point(300, 140);
            this.tB_Login.Multiline = true;
            this.tB_Login.Name = "tB_Login";
            this.tB_Login.Size = new System.Drawing.Size(199, 32);
            this.tB_Login.TabIndex = 0;
            // 
            // tB_Password
            // 
            this.tB_Password.BackColor = System.Drawing.Color.Black;
            this.tB_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Password.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_Password.ForeColor = System.Drawing.Color.White;
            this.tB_Password.Location = new System.Drawing.Point(300, 209);
            this.tB_Password.Multiline = true;
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.PasswordChar = '*';
            this.tB_Password.Size = new System.Drawing.Size(199, 32);
            this.tB_Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(351, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(351, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(317, 320);
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
            this.btn_CreateAccount.Location = new System.Drawing.Point(398, 317);
            this.btn_CreateAccount.Name = "btn_CreateAccount";
            this.btn_CreateAccount.Size = new System.Drawing.Size(78, 23);
            this.btn_CreateAccount.TabIndex = 7;
            this.btn_CreateAccount.Text = "Создай его!";
            this.btn_CreateAccount.UseVisualStyleBackColor = false;
            this.btn_CreateAccount.Click += new System.EventHandler(this.btn_CreateAccount_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.LightGray;
            this.btn_Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Enter.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Enter.FlatAppearance.BorderSize = 0;
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.Font = new System.Drawing.Font("Yu Gothic UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Enter.Location = new System.Drawing.Point(351, 254);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(100, 38);
            this.btn_Enter.TabIndex = 8;
            this.btn_Enter.Text = "Войти";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.btn_CreateAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_Password);
            this.Controls.Add(this.tB_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login_Form";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tB_Login;
        private TextBox tB_Password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_CreateAccount;
        private Button btn_Enter;
    }
}