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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_SecondPassword = new System.Windows.Forms.TextBox();
            this.tB_Login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_FirstPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(353, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 15;
            this.button2.Text = "Создать";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(344, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Повторите пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(353, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите логин";
            // 
            // tB_SecondPassword
            // 
            this.tB_SecondPassword.BackColor = System.Drawing.Color.Black;
            this.tB_SecondPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_SecondPassword.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_SecondPassword.ForeColor = System.Drawing.Color.White;
            this.tB_SecondPassword.Location = new System.Drawing.Point(302, 232);
            this.tB_SecondPassword.Multiline = true;
            this.tB_SecondPassword.Name = "tB_SecondPassword";
            this.tB_SecondPassword.Size = new System.Drawing.Size(199, 32);
            this.tB_SecondPassword.TabIndex = 10;
            // 
            // tB_Login
            // 
            this.tB_Login.BackColor = System.Drawing.Color.Black;
            this.tB_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Login.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tB_Login.ForeColor = System.Drawing.Color.White;
            this.tB_Login.Location = new System.Drawing.Point(302, 112);
            this.tB_Login.Multiline = true;
            this.tB_Login.Name = "tB_Login";
            this.tB_Login.Size = new System.Drawing.Size(199, 32);
            this.tB_Login.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(351, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Введите пароль";
            // 
            // tb_FirstPassword
            // 
            this.tb_FirstPassword.BackColor = System.Drawing.Color.Black;
            this.tb_FirstPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_FirstPassword.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_FirstPassword.ForeColor = System.Drawing.Color.White;
            this.tb_FirstPassword.Location = new System.Drawing.Point(302, 173);
            this.tb_FirstPassword.Multiline = true;
            this.tb_FirstPassword.Name = "tb_FirstPassword";
            this.tb_FirstPassword.Size = new System.Drawing.Size(199, 32);
            this.tb_FirstPassword.TabIndex = 17;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 385);
            this.Controls.Add(this.tb_FirstPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_SecondPassword);
            this.Controls.Add(this.tB_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private Label label2;
        private Label label1;
        private TextBox tB_SecondPassword;
        private TextBox tB_Login;
        private Label label4;
        private TextBox tb_FirstPassword;
    }
}