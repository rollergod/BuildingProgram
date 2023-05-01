namespace BuildingProgram.Forms
{
    partial class AddOrgForm
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
            this.tb_OrgName = new BuildingProgram.Controls.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Director = new BuildingProgram.Controls.CustomTextBox();
            this.btn_AddOrg = new System.Windows.Forms.Button();
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
            this.xToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(459, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 34);
            this.toolStripMenuItem1.Text = "Объекты";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(92, 34);
            this.toolStripMenuItem2.Text = "Организации";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(65, 34);
            this.toolStripMenuItem3.Text = "Справка";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // земельныеУчасткиToolStripMenuItem
            // 
            this.земельныеУчасткиToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.земельныеУчасткиToolStripMenuItem.Name = "земельныеУчасткиToolStripMenuItem";
            this.земельныеУчасткиToolStripMenuItem.Size = new System.Drawing.Size(128, 34);
            this.земельныеУчасткиToolStripMenuItem.Text = "Земельные участки";
            this.земельныеУчасткиToolStripMenuItem.Click += new System.EventHandler(this.земельныеУчасткиToolStripMenuItem_Click);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(26, 34);
            this.xToolStripMenuItem.Text = "X";
            // 
            // tb_OrgName
            // 
            this.tb_OrgName.BackColor = System.Drawing.SystemColors.Window;
            this.tb_OrgName.BorderColor = System.Drawing.Color.Black;
            this.tb_OrgName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_OrgName.BorderSize = 2;
            this.tb_OrgName.Location = new System.Drawing.Point(100, 117);
            this.tb_OrgName.Margin = new System.Windows.Forms.Padding(0);
            this.tb_OrgName.Multiline = false;
            this.tb_OrgName.Name = "tb_OrgName";
            this.tb_OrgName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_OrgName.Size = new System.Drawing.Size(250, 21);
            this.tb_OrgName.TabIndex = 2;
            this.tb_OrgName.Texts = "";
            this.tb_OrgName.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название организации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Директор организации (Фамилия и инициалы)";
            // 
            // tb_Director
            // 
            this.tb_Director.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Director.BorderColor = System.Drawing.Color.Black;
            this.tb_Director.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_Director.BorderSize = 2;
            this.tb_Director.Location = new System.Drawing.Point(100, 168);
            this.tb_Director.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Director.Multiline = false;
            this.tb_Director.Name = "tb_Director";
            this.tb_Director.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_Director.Size = new System.Drawing.Size(250, 21);
            this.tb_Director.TabIndex = 4;
            this.tb_Director.Texts = "";
            this.tb_Director.UnderlinedStyle = true;
            // 
            // btn_AddOrg
            // 
            this.btn_AddOrg.Location = new System.Drawing.Point(175, 221);
            this.btn_AddOrg.Name = "btn_AddOrg";
            this.btn_AddOrg.Size = new System.Drawing.Size(105, 40);
            this.btn_AddOrg.TabIndex = 6;
            this.btn_AddOrg.Text = "Добавить организацию";
            this.btn_AddOrg.UseVisualStyleBackColor = true;
            this.btn_AddOrg.Click += new System.EventHandler(this.btn_AddOrg_Click);
            // 
            // AddOrgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 305);
            this.Controls.Add(this.btn_AddOrg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Director);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_OrgName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddOrgForm";
            this.Text = "Добавление организации";
            this.Load += new System.EventHandler(this.AddOrgForm_Load);
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
        private Controls.CustomTextBox tb_OrgName;
        private Label label1;
        private Label label2;
        private Controls.CustomTextBox tb_Director;
        private Button btn_AddOrg;
    }
}