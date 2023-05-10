namespace BuildingProgram.Forms
{
    partial class AddBuildingCompanyForm
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
            this.btn_AddOrg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_BuildingCompanyName = new BuildingProgram.Controls.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AddOrg
            // 
            this.btn_AddOrg.BackColor = System.Drawing.Color.Black;
            this.btn_AddOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddOrg.ForeColor = System.Drawing.Color.White;
            this.btn_AddOrg.Location = new System.Drawing.Point(200, 164);
            this.btn_AddOrg.Name = "btn_AddOrg";
            this.btn_AddOrg.Size = new System.Drawing.Size(105, 58);
            this.btn_AddOrg.TabIndex = 11;
            this.btn_AddOrg.Text = "Добавить строительную компанию";
            this.btn_AddOrg.UseVisualStyleBackColor = false;
            this.btn_AddOrg.Click += new System.EventHandler(this.btn_AddOrg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название организации";
            // 
            // tb_BuildingCompanyName
            // 
            this.tb_BuildingCompanyName.BackColor = System.Drawing.SystemColors.Window;
            this.tb_BuildingCompanyName.BorderColor = System.Drawing.Color.Black;
            this.tb_BuildingCompanyName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_BuildingCompanyName.BorderSize = 2;
            this.tb_BuildingCompanyName.Location = new System.Drawing.Point(127, 115);
            this.tb_BuildingCompanyName.Margin = new System.Windows.Forms.Padding(0);
            this.tb_BuildingCompanyName.Multiline = false;
            this.tb_BuildingCompanyName.Name = "tb_BuildingCompanyName";
            this.tb_BuildingCompanyName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_BuildingCompanyName.Size = new System.Drawing.Size(250, 21);
            this.tb_BuildingCompanyName.TabIndex = 7;
            this.tb_BuildingCompanyName.Texts = "";
            this.tb_BuildingCompanyName.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(93, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 25);
            this.label2.TabIndex = 75;
            this.label2.Text = "Добавление строительной компании";
            // 
            // AddBuildingCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AddOrg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_BuildingCompanyName);
            this.Name = "AddBuildingCompanyForm";
            this.Text = "Добавление строительной компании";
            this.Load += new System.EventHandler(this.AddBuildingCompanyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_AddOrg;
        private Label label1;
        private Controls.CustomTextBox tb_BuildingCompanyName;
        private Label label2;
    }
}