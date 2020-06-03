namespace BDiSUBD.Forms
{
    partial class AddNewTypeForm
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
            this.newTypeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // newTypeTextBox
            // 
            // 
            // 
            // 
            this.newTypeTextBox.CustomButton.Image = null;
            this.newTypeTextBox.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.newTypeTextBox.CustomButton.Name = "";
            this.newTypeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.newTypeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newTypeTextBox.CustomButton.TabIndex = 1;
            this.newTypeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newTypeTextBox.CustomButton.UseSelectable = true;
            this.newTypeTextBox.CustomButton.Visible = false;
            this.newTypeTextBox.Lines = new string[0];
            this.newTypeTextBox.Location = new System.Drawing.Point(52, 63);
            this.newTypeTextBox.MaxLength = 32767;
            this.newTypeTextBox.Name = "newTypeTextBox";
            this.newTypeTextBox.PasswordChar = '\0';
            this.newTypeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newTypeTextBox.SelectedText = "";
            this.newTypeTextBox.SelectionLength = 0;
            this.newTypeTextBox.SelectionStart = 0;
            this.newTypeTextBox.ShortcutsEnabled = true;
            this.newTypeTextBox.Size = new System.Drawing.Size(140, 23);
            this.newTypeTextBox.TabIndex = 0;
            this.newTypeTextBox.UseSelectable = true;
            this.newTypeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.newTypeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(209, 63);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Добавить";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AddNewTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 123);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.newTypeTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewTypeForm";
            this.Resizable = false;
            this.Text = "Добавление нового типа";
            this.Load += new System.EventHandler(this.AddNewTypeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        public MetroFramework.Controls.MetroTextBox newTypeTextBox;
    }
}