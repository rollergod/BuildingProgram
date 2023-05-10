namespace BuildingProgram.Forms
{
    partial class AddNoteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_Text = new System.Windows.Forms.RichTextBox();
            this.cb_ProrityType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Приоритет:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Текст:";
            // 
            // rtb_Text
            // 
            this.rtb_Text.Location = new System.Drawing.Point(171, 156);
            this.rtb_Text.Name = "rtb_Text";
            this.rtb_Text.Size = new System.Drawing.Size(260, 96);
            this.rtb_Text.TabIndex = 13;
            this.rtb_Text.Text = "";
            // 
            // cb_ProrityType
            // 
            this.cb_ProrityType.FormattingEnabled = true;
            this.cb_ProrityType.Items.AddRange(new object[] {
            "важно",
            "второстепенно"});
            this.cb_ProrityType.Location = new System.Drawing.Point(244, 97);
            this.cb_ProrityType.Name = "cb_ProrityType";
            this.cb_ProrityType.Size = new System.Drawing.Size(187, 23);
            this.cb_ProrityType.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(184, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Добавление заметки для участка";
            // 
            // btn_Add
            // 
            this.btn_Add.CornerRoundingRadius = 5F;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Location = new System.Drawing.Point(244, 268);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_Add.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_Add.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_Add.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_Add.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Add.OverrideDefault.Border.Width = 2;
            this.btn_Add.Size = new System.Drawing.Size(109, 42);
            this.btn_Add.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_Add.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_Add.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Add.StateCommon.Border.Rounding = 5F;
            this.btn_Add.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Add.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Add.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            this.btn_Add.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Add.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btn_Add.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_Add.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_Add.StateNormal.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_Add.StateNormal.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_Add.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Add.StateNormal.Border.Width = 2;
            this.btn_Add.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Add.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Add.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_Add.StatePressed.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_Add.StatePressed.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_Add.StatePressed.Border.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_Add.StatePressed.Border.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_Add.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Add.StatePressed.Border.Width = 2;
            this.btn_Add.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_Add.StateTracking.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.btn_Add.StateTracking.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btn_Add.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_Add.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_Add.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Add.StateTracking.Border.Rounding = 5F;
            this.btn_Add.StateTracking.Border.Width = 2;
            this.btn_Add.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btn_Add.TabIndex = 30;
            this.btn_Add.Values.Text = "Добавить";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click_1);
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 339);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_ProrityType);
            this.Controls.Add(this.rtb_Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNoteForm";
            this.Text = "Добавить заметку";
            this.Load += new System.EventHandler(this.AddNoteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private RichTextBox rtb_Text;
        private ComboBox cb_ProrityType;
        private Label label3;
        private Krypton.Toolkit.KryptonButton btn_Add;
    }
}