namespace BDiSUBD.Forms
{
    partial class AddInputInvoice
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
            this.TechniqueComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // TechniqueComboBox
            // 
            this.TechniqueComboBox.FormattingEnabled = true;
            this.TechniqueComboBox.ItemHeight = 23;
            this.TechniqueComboBox.Location = new System.Drawing.Point(173, 72);
            this.TechniqueComboBox.Name = "TechniqueComboBox";
            this.TechniqueComboBox.Size = new System.Drawing.Size(191, 29);
            this.TechniqueComboBox.TabIndex = 0;
            this.TechniqueComboBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(64, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Тип техники";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(64, 121);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Наименование";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(68, 163);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Количество";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(155, 204);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(106, 40);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Добавить";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // NameTextBox
            // 
            // 
            // 
            // 
            this.NameTextBox.CustomButton.Image = null;
            this.NameTextBox.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.NameTextBox.CustomButton.Name = "";
            this.NameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameTextBox.CustomButton.TabIndex = 1;
            this.NameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameTextBox.CustomButton.UseSelectable = true;
            this.NameTextBox.CustomButton.Visible = false;
            this.NameTextBox.Lines = new string[0];
            this.NameTextBox.Location = new System.Drawing.Point(173, 119);
            this.NameTextBox.MaxLength = 32767;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.SelectionLength = 0;
            this.NameTextBox.SelectionStart = 0;
            this.NameTextBox.ShortcutsEnabled = true;
            this.NameTextBox.Size = new System.Drawing.Size(191, 23);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.UseSelectable = true;
            this.NameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CountTextBox
            // 
            // 
            // 
            // 
            this.CountTextBox.CustomButton.Image = null;
            this.CountTextBox.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.CountTextBox.CustomButton.Name = "";
            this.CountTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CountTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CountTextBox.CustomButton.TabIndex = 1;
            this.CountTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CountTextBox.CustomButton.UseSelectable = true;
            this.CountTextBox.CustomButton.Visible = false;
            this.CountTextBox.Lines = new string[0];
            this.CountTextBox.Location = new System.Drawing.Point(173, 160);
            this.CountTextBox.MaxLength = 32767;
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.PasswordChar = '\0';
            this.CountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CountTextBox.SelectedText = "";
            this.CountTextBox.SelectionLength = 0;
            this.CountTextBox.SelectionStart = 0;
            this.CountTextBox.ShortcutsEnabled = true;
            this.CountTextBox.Size = new System.Drawing.Size(191, 23);
            this.CountTextBox.TabIndex = 8;
            this.CountTextBox.UseSelectable = true;
            this.CountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddInputInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 258);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TechniqueComboBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddInputInvoice";
            this.Text = "Добавление приходной накладной";
            this.Load += new System.EventHandler(this.AddInputInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        public MetroFramework.Controls.MetroComboBox TechniqueComboBox;
        public MetroFramework.Controls.MetroTextBox NameTextBox;
        public MetroFramework.Controls.MetroTextBox CountTextBox;
    }
}