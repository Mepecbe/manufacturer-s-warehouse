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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.ForeignWarehouseCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.outputWarehouse = new MetroFramework.Controls.MetroComboBox();
            this.outputWarehouseCell = new MetroFramework.Controls.MetroComboBox();
            this.InputWarehouse = new MetroFramework.Controls.MetroComboBox();
            this.inputWarehouseCell = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(58, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Из склада";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(58, 121);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(120, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Складской ячейки";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(58, 196);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "В склад";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(58, 245);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(128, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "В складскую ячейку";
            // 
            // ForeignWarehouseCheckBox
            // 
            this.ForeignWarehouseCheckBox.AutoSize = true;
            this.ForeignWarehouseCheckBox.Location = new System.Drawing.Point(62, 158);
            this.ForeignWarehouseCheckBox.Name = "ForeignWarehouseCheckBox";
            this.ForeignWarehouseCheckBox.Size = new System.Drawing.Size(161, 15);
            this.ForeignWarehouseCheckBox.TabIndex = 4;
            this.ForeignWarehouseCheckBox.Text = "Перевод на другой склад";
            this.ForeignWarehouseCheckBox.UseSelectable = true;
            // 
            // outputWarehouse
            // 
            this.outputWarehouse.FormattingEnabled = true;
            this.outputWarehouse.ItemHeight = 23;
            this.outputWarehouse.Location = new System.Drawing.Point(218, 63);
            this.outputWarehouse.Name = "outputWarehouse";
            this.outputWarehouse.Size = new System.Drawing.Size(154, 29);
            this.outputWarehouse.TabIndex = 5;
            this.outputWarehouse.UseSelectable = true;
            // 
            // outputWarehouseCell
            // 
            this.outputWarehouseCell.FormattingEnabled = true;
            this.outputWarehouseCell.ItemHeight = 23;
            this.outputWarehouseCell.Location = new System.Drawing.Point(218, 111);
            this.outputWarehouseCell.Name = "outputWarehouseCell";
            this.outputWarehouseCell.Size = new System.Drawing.Size(154, 29);
            this.outputWarehouseCell.TabIndex = 6;
            this.outputWarehouseCell.UseSelectable = true;
            // 
            // InputWarehouse
            // 
            this.InputWarehouse.Enabled = false;
            this.InputWarehouse.FormattingEnabled = true;
            this.InputWarehouse.ItemHeight = 23;
            this.InputWarehouse.Location = new System.Drawing.Point(218, 191);
            this.InputWarehouse.Name = "InputWarehouse";
            this.InputWarehouse.Size = new System.Drawing.Size(154, 29);
            this.InputWarehouse.TabIndex = 7;
            this.InputWarehouse.UseSelectable = true;
            // 
            // inputWarehouseCell
            // 
            this.inputWarehouseCell.FormattingEnabled = true;
            this.inputWarehouseCell.ItemHeight = 23;
            this.inputWarehouseCell.Location = new System.Drawing.Point(218, 239);
            this.inputWarehouseCell.Name = "inputWarehouseCell";
            this.inputWarehouseCell.Size = new System.Drawing.Size(154, 29);
            this.inputWarehouseCell.TabIndex = 8;
            this.inputWarehouseCell.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(141, 291);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(118, 34);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Создать перевод";
            this.metroButton1.UseSelectable = true;
            // 
            // AddTransferOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 331);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.inputWarehouseCell);
            this.Controls.Add(this.InputWarehouse);
            this.Controls.Add(this.outputWarehouseCell);
            this.Controls.Add(this.outputWarehouse);
            this.Controls.Add(this.ForeignWarehouseCheckBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddTransferOperation";
            this.Text = "Добавление операции перевода";
            this.Load += new System.EventHandler(this.AddTransferOperation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroCheckBox ForeignWarehouseCheckBox;
        private MetroFramework.Controls.MetroComboBox outputWarehouse;
        private MetroFramework.Controls.MetroComboBox outputWarehouseCell;
        private MetroFramework.Controls.MetroComboBox InputWarehouse;
        private MetroFramework.Controls.MetroComboBox inputWarehouseCell;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}