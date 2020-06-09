namespace BDiSUBD.Forms
{
    partial class AddTransferOperation
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.inputWarehouseCell = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.OutputCell = new MetroFramework.Controls.MetroLabel();
            this.TovarName = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(63, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(137, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Из складской ячейки";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(63, 114);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(128, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "В складскую ячейку";
            // 
            // inputWarehouseCell
            // 
            this.inputWarehouseCell.FormattingEnabled = true;
            this.inputWarehouseCell.ItemHeight = 23;
            this.inputWarehouseCell.Location = new System.Drawing.Point(223, 114);
            this.inputWarehouseCell.Name = "inputWarehouseCell";
            this.inputWarehouseCell.Size = new System.Drawing.Size(154, 29);
            this.inputWarehouseCell.TabIndex = 8;
            this.inputWarehouseCell.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(141, 256);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(118, 34);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Создать перевод";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(63, 153);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Товар";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(63, 206);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Количество";
            // 
            // CountTextBox
            // 
            // 
            // 
            // 
            this.CountTextBox.CustomButton.Image = null;
            this.CountTextBox.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.CountTextBox.CustomButton.Name = "";
            this.CountTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CountTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CountTextBox.CustomButton.TabIndex = 1;
            this.CountTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CountTextBox.CustomButton.UseSelectable = true;
            this.CountTextBox.CustomButton.Visible = false;
            this.CountTextBox.Lines = new string[0];
            this.CountTextBox.Location = new System.Drawing.Point(223, 202);
            this.CountTextBox.MaxLength = 32767;
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.PasswordChar = '\0';
            this.CountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CountTextBox.SelectedText = "";
            this.CountTextBox.SelectionLength = 0;
            this.CountTextBox.SelectionStart = 0;
            this.CountTextBox.ShortcutsEnabled = true;
            this.CountTextBox.Size = new System.Drawing.Size(154, 23);
            this.CountTextBox.TabIndex = 13;
            this.CountTextBox.UseSelectable = true;
            this.CountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // OutputCell
            // 
            this.OutputCell.AutoSize = true;
            this.OutputCell.Location = new System.Drawing.Point(223, 73);
            this.OutputCell.Name = "OutputCell";
            this.OutputCell.Size = new System.Drawing.Size(83, 19);
            this.OutputCell.TabIndex = 14;
            this.OutputCell.Text = "metroLabel5";
            // 
            // TovarName
            // 
            this.TovarName.AutoSize = true;
            this.TovarName.Location = new System.Drawing.Point(223, 153);
            this.TovarName.Name = "TovarName";
            this.TovarName.Size = new System.Drawing.Size(83, 19);
            this.TovarName.TabIndex = 15;
            this.TovarName.Text = "metroLabel5";
            // 
            // AddTransferOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 311);
            this.Controls.Add(this.TovarName);
            this.Controls.Add(this.OutputCell);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.inputWarehouseCell);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Name = "AddTransferOperation";
            this.Text = "Добавление операции перевода";
            this.Load += new System.EventHandler(this.AddTransferOperation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTextBox CountTextBox;
        public MetroFramework.Controls.MetroComboBox inputWarehouseCell;
        public MetroFramework.Controls.MetroLabel OutputCell;
        public MetroFramework.Controls.MetroLabel TovarName;
    }
}