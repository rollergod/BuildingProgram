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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.земельныеУчасткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AddOrg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_BuildingCompanyName = new BuildingProgram.Controls.CustomTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(450, 38);
            this.menuStrip1.TabIndex = 2;
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
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(26, 34);
            this.xToolStripMenuItem.Text = "X";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.отчетыToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 34);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // btn_AddOrg
            // 
            this.btn_AddOrg.Location = new System.Drawing.Point(167, 217);
            this.btn_AddOrg.Name = "btn_AddOrg";
            this.btn_AddOrg.Size = new System.Drawing.Size(105, 58);
            this.btn_AddOrg.TabIndex = 11;
            this.btn_AddOrg.Text = "Добавить строительную компанию";
            this.btn_AddOrg.UseVisualStyleBackColor = true;
            this.btn_AddOrg.Click += new System.EventHandler(this.btn_AddOrg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 148);
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
            this.tb_BuildingCompanyName.Location = new System.Drawing.Point(94, 168);
            this.tb_BuildingCompanyName.Margin = new System.Windows.Forms.Padding(0);
            this.tb_BuildingCompanyName.Multiline = false;
            this.tb_BuildingCompanyName.Name = "tb_BuildingCompanyName";
            this.tb_BuildingCompanyName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_BuildingCompanyName.Size = new System.Drawing.Size(250, 21);
            this.tb_BuildingCompanyName.TabIndex = 7;
            this.tb_BuildingCompanyName.Texts = "";
            this.tb_BuildingCompanyName.UnderlinedStyle = true;
            // 
            // AddBuildingCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 326);
            this.Controls.Add(this.btn_AddOrg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_BuildingCompanyName);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AddBuildingCompanyForm";
            this.Text = "AddBuildingCompanyForm";
            this.Load += new System.EventHandler(this.AddBuildingCompanyForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem земельныеУчасткиToolStripMenuItem;
        private ToolStripMenuItem xToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
        private Button btn_AddOrg;
        private Label label1;
        private Controls.CustomTextBox tb_BuildingCompanyName;
    }
}