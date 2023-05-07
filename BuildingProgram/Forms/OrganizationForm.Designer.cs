namespace BuildingProgram.Forms
{
    partial class OrganizationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_AddOrg = new System.Windows.Forms.Button();
            this.btn_ChangeOrg = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.земельныеУчасткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строительныеКомпанииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЗемельнымУчасткамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поСтроительнымКомпаниямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_OrgName = new System.Windows.Forms.Label();
            this.lb_ObjectsNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_TotalSum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Search
            // 
            this.tb_Search.BackColor = System.Drawing.Color.LightGray;
            this.tb_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Search.Location = new System.Drawing.Point(364, 66);
            this.tb_Search.Multiline = true;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(196, 13);
            this.tb_Search.TabIndex = 12;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Black;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(293, 60);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(53, 27);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Поиск";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_AddOrg
            // 
            this.btn_AddOrg.BackColor = System.Drawing.Color.Black;
            this.btn_AddOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddOrg.ForeColor = System.Drawing.Color.White;
            this.btn_AddOrg.Location = new System.Drawing.Point(30, 204);
            this.btn_AddOrg.Name = "btn_AddOrg";
            this.btn_AddOrg.Size = new System.Drawing.Size(96, 49);
            this.btn_AddOrg.TabIndex = 8;
            this.btn_AddOrg.Text = "Добавить оганизацию";
            this.btn_AddOrg.UseVisualStyleBackColor = false;
            this.btn_AddOrg.Click += new System.EventHandler(this.btn_AddOrg_Click);
            // 
            // btn_ChangeOrg
            // 
            this.btn_ChangeOrg.BackColor = System.Drawing.Color.Black;
            this.btn_ChangeOrg.Enabled = false;
            this.btn_ChangeOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeOrg.ForeColor = System.Drawing.Color.White;
            this.btn_ChangeOrg.Location = new System.Drawing.Point(30, 272);
            this.btn_ChangeOrg.Name = "btn_ChangeOrg";
            this.btn_ChangeOrg.Size = new System.Drawing.Size(96, 48);
            this.btn_ChangeOrg.TabIndex = 9;
            this.btn_ChangeOrg.Text = "Изменить организацию";
            this.btn_ChangeOrg.UseVisualStyleBackColor = false;
            this.btn_ChangeOrg.Click += new System.EventHandler(this.btn_ChangeOrg_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(167, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(576, 328);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.земельныеУчасткиToolStripMenuItem,
            this.xToolStripMenuItem,
            this.строительныеКомпанииToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 34);
            this.toolStripMenuItem1.Text = "Объекты";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(92, 34);
            this.toolStripMenuItem2.Text = "Организации";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // земельныеУчасткиToolStripMenuItem
            // 
            this.земельныеУчасткиToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.земельныеУчасткиToolStripMenuItem.Name = "земельныеУчасткиToolStripMenuItem";
            this.земельныеУчасткиToolStripMenuItem.Size = new System.Drawing.Size(128, 34);
            this.земельныеУчасткиToolStripMenuItem.Text = "Земельные участки";
            this.земельныеУчасткиToolStripMenuItem.Click += new System.EventHandler(this.земельныеУчасткиToolStripMenuItem_Click_1);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(26, 34);
            this.xToolStripMenuItem.Text = "X";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click_1);
            // 
            // строительныеКомпанииToolStripMenuItem
            // 
            this.строительныеКомпанииToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.строительныеКомпанииToolStripMenuItem.Name = "строительныеКомпанииToolStripMenuItem";
            this.строительныеКомпанииToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.строительныеКомпанииToolStripMenuItem.Text = "Строительные компании";
            this.строительныеКомпанииToolStripMenuItem.Click += new System.EventHandler(this.строительныеКомпанииToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поЗемельнымУчасткамToolStripMenuItem,
            this.поСтроительнымКомпаниямToolStripMenuItem});
            this.отчетыToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 34);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // поЗемельнымУчасткамToolStripMenuItem
            // 
            this.поЗемельнымУчасткамToolStripMenuItem.Name = "поЗемельнымУчасткамToolStripMenuItem";
            this.поЗемельнымУчасткамToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.поЗемельнымУчасткамToolStripMenuItem.Text = "По земельным участкам";
            this.поЗемельнымУчасткамToolStripMenuItem.Click += new System.EventHandler(this.поЗемельнымУчасткамToolStripMenuItem_Click);
            // 
            // поСтроительнымКомпаниямToolStripMenuItem
            // 
            this.поСтроительнымКомпаниямToolStripMenuItem.Name = "поСтроительнымКомпаниямToolStripMenuItem";
            this.поСтроительнымКомпаниямToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.поСтроительнымКомпаниямToolStripMenuItem.Text = "По строительным компаниям";
            this.поСтроительнымКомпаниямToolStripMenuItem.Click += new System.EventHandler(this.поСтроительнымКомпаниямToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Дата окончания последнего объекта:";
            this.label1.Visible = false;
            // 
            // lb_OrgName
            // 
            this.lb_OrgName.AutoSize = true;
            this.lb_OrgName.Location = new System.Drawing.Point(385, 450);
            this.lb_OrgName.Name = "lb_OrgName";
            this.lb_OrgName.Size = new System.Drawing.Size(0, 15);
            this.lb_OrgName.TabIndex = 16;
            this.lb_OrgName.Visible = false;
            // 
            // lb_ObjectsNum
            // 
            this.lb_ObjectsNum.AutoSize = true;
            this.lb_ObjectsNum.Location = new System.Drawing.Point(301, 475);
            this.lb_ObjectsNum.Name = "lb_ObjectsNum";
            this.lb_ObjectsNum.Size = new System.Drawing.Size(0, 15);
            this.lb_ObjectsNum.TabIndex = 18;
            this.lb_ObjectsNum.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Количество объектов:";
            this.label3.Visible = false;
            // 
            // lb_TotalSum
            // 
            this.lb_TotalSum.AutoSize = true;
            this.lb_TotalSum.Location = new System.Drawing.Point(302, 501);
            this.lb_TotalSum.Name = "lb_TotalSum";
            this.lb_TotalSum.Size = new System.Drawing.Size(0, 15);
            this.lb_TotalSum.TabIndex = 20;
            this.lb_TotalSum.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Общая стоимость участков:";
            this.label4.Visible = false;
            // 
            // OrganizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.lb_TotalSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_ObjectsNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_OrgName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_ChangeOrg);
            this.Controls.Add(this.btn_AddOrg);
            this.Name = "OrganizationForm";
            this.Text = "Организации";
            this.Load += new System.EventHandler(this.OrganizationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tb_Search;
        private Button btn_Search;
        private Button btn_AddOrg;
        private Button btn_ChangeOrg;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem земельныеУчасткиToolStripMenuItem;
        private ToolStripMenuItem xToolStripMenuItem;
        private ToolStripMenuItem строительныеКомпанииToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
        private ToolStripMenuItem поЗемельнымУчасткамToolStripMenuItem;
        private ToolStripMenuItem поСтроительнымКомпаниямToolStripMenuItem;
        private Label label1;
        private Label lb_OrgName;
        private Label lb_ObjectsNum;
        private Label label3;
        private Label lb_TotalSum;
        private Label label4;
    }
}