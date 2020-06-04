namespace BDiSUBD.Forms
{
    partial class AddOutputInvoice
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
            this.TovarsListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddButton = new MetroFramework.Controls.MetroButton();
            this.CountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // TovarsListView
            // 
            this.TovarsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader10});
            this.TovarsListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TovarsListView.FullRowSelect = true;
            this.TovarsListView.Location = new System.Drawing.Point(33, 84);
            this.TovarsListView.Name = "TovarsListView";
            this.TovarsListView.OwnerDraw = true;
            this.TovarsListView.Size = new System.Drawing.Size(866, 314);
            this.TovarsListView.TabIndex = 2;
            this.TovarsListView.UseCompatibleStateImageBehavior = false;
            this.TovarsListView.UseSelectable = true;
            this.TovarsListView.View = System.Windows.Forms.View.Details;
            this.TovarsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TovarsListView_MouseClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Тип";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Складская ячейка";
            this.columnHeader1.Width = 174;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Наименование";
            this.columnHeader3.Width = 340;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Количество";
            this.columnHeader10.Width = 104;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(288, 55);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(86, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseSelectable = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CountTextBox
            // 
            // 
            // 
            // 
            this.CountTextBox.CustomButton.Image = null;
            this.CountTextBox.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.CountTextBox.CustomButton.Name = "";
            this.CountTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CountTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CountTextBox.CustomButton.TabIndex = 1;
            this.CountTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CountTextBox.CustomButton.UseSelectable = true;
            this.CountTextBox.CustomButton.Visible = false;
            this.CountTextBox.Lines = new string[0];
            this.CountTextBox.Location = new System.Drawing.Point(142, 55);
            this.CountTextBox.MaxLength = 32767;
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.PasswordChar = '\0';
            this.CountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CountTextBox.SelectedText = "";
            this.CountTextBox.SelectionLength = 0;
            this.CountTextBox.SelectionStart = 0;
            this.CountTextBox.ShortcutsEnabled = true;
            this.CountTextBox.Size = new System.Drawing.Size(102, 23);
            this.CountTextBox.TabIndex = 4;
            this.CountTextBox.UseSelectable = true;
            this.CountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(48, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Количество";
            // 
            // AddOutputInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 408);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TovarsListView);
            this.Name = "AddOutputInvoice";
            this.Text = "Добавление расходной накладной";
            this.Load += new System.EventHandler(this.AddOutputInvoce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroListView TovarsListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private MetroFramework.Controls.MetroButton AddButton;
        private MetroFramework.Controls.MetroTextBox CountTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}