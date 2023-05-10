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
            this.tb_OrgName = new BuildingProgram.Controls.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Director = new BuildingProgram.Controls.CustomTextBox();
            this.btn_AddOrg = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // tb_OrgName
            // 
            this.tb_OrgName.BackColor = System.Drawing.SystemColors.Window;
            this.tb_OrgName.BorderColor = System.Drawing.Color.Black;
            this.tb_OrgName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_OrgName.BorderSize = 2;
            this.tb_OrgName.Location = new System.Drawing.Point(175, 100);
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
            this.label1.Location = new System.Drawing.Point(236, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название организации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 127);
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
            this.tb_Director.Location = new System.Drawing.Point(175, 151);
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
            this.btn_AddOrg.CornerRoundingRadius = 5F;
            this.btn_AddOrg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddOrg.Location = new System.Drawing.Point(245, 206);
            this.btn_AddOrg.Name = "btn_AddOrg";
            this.btn_AddOrg.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_AddOrg.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_AddOrg.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddOrg.OverrideDefault.Border.Width = 2;
            this.btn_AddOrg.Size = new System.Drawing.Size(109, 48);
            this.btn_AddOrg.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_AddOrg.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_AddOrg.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddOrg.StateCommon.Border.Rounding = 5F;
            this.btn_AddOrg.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_AddOrg.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_AddOrg.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddOrg.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.btn_AddOrg.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_AddOrg.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_AddOrg.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_AddOrg.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_AddOrg.StateNormal.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.StateNormal.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddOrg.StateNormal.Border.Width = 2;
            this.btn_AddOrg.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_AddOrg.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_AddOrg.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_AddOrg.StatePressed.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.StatePressed.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.StatePressed.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.StatePressed.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddOrg.StatePressed.Border.Width = 2;
            this.btn_AddOrg.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_AddOrg.StateTracking.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.StateTracking.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_AddOrg.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_AddOrg.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_AddOrg.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddOrg.StateTracking.Border.Rounding = 5F;
            this.btn_AddOrg.StateTracking.Border.Width = 2;
            this.btn_AddOrg.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_AddOrg.TabIndex = 29;
            this.btn_AddOrg.Values.Text = "Добавить \r\nорганизацию";
            this.btn_AddOrg.Click += new System.EventHandler(this.btn_AddOrg_Click_1);
            // 
            // AddOrgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 305);
            this.Controls.Add(this.btn_AddOrg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Director);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_OrgName);
            this.Name = "AddOrgForm";
            this.Text = "Добавление организации";
            this.Load += new System.EventHandler(this.AddOrgForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.CustomTextBox tb_OrgName;
        private Label label1;
        private Label label2;
        private Controls.CustomTextBox tb_Director;
        private Krypton.Toolkit.KryptonButton btn_AddOrg;
    }
}