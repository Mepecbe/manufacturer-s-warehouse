namespace BDiSUBD.Forms
{
    partial class WarehouseBrowser
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TovarsListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.OutputListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WarehouseCell = new MetroFramework.Controls.MetroListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InputInvoices = new MetroFramework.Controls.MetroListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.tabPage3);
            this.metroTabControl1.Controls.Add(this.tabPage4);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 3;
            this.metroTabControl1.Size = new System.Drawing.Size(1036, 466);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TovarsListView);
            this.tabPage1.Controls.Add(this.metroListView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1028, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Товары на складе";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // TovarsListView
            // 
            this.TovarsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader10});
            this.TovarsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TovarsListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TovarsListView.FullRowSelect = true;
            this.TovarsListView.Location = new System.Drawing.Point(0, 0);
            this.TovarsListView.Name = "TovarsListView";
            this.TovarsListView.OwnerDraw = true;
            this.TovarsListView.Size = new System.Drawing.Size(1028, 424);
            this.TovarsListView.TabIndex = 1;
            this.TovarsListView.UseCompatibleStateImageBehavior = false;
            this.TovarsListView.UseSelectable = true;
            this.TovarsListView.View = System.Windows.Forms.View.Details;
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
            this.columnHeader3.Text = "Имя";
            this.columnHeader3.Width = 340;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Количество";
            this.columnHeader10.Width = 104;
            // 
            // metroListView1
            // 
            this.metroListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(0, 0);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(1028, 424);
            this.metroListView1.TabIndex = 0;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.InputInvoices);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1028, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Приходные накладные";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.WarehouseCell);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1028, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Складские ячейки";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.OutputListView);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1028, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Расходные накладные";
            // 
            // OutputListView
            // 
            this.OutputListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.OutputListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OutputListView.FullRowSelect = true;
            this.OutputListView.Location = new System.Drawing.Point(0, 0);
            this.OutputListView.Name = "OutputListView";
            this.OutputListView.OwnerDraw = true;
            this.OutputListView.Size = new System.Drawing.Size(1028, 424);
            this.OutputListView.TabIndex = 1;
            this.OutputListView.UseCompatibleStateImageBehavior = false;
            this.OutputListView.UseSelectable = true;
            this.OutputListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Номер";
            this.columnHeader11.Width = 63;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Тип техники";
            this.columnHeader12.Width = 107;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Наименование";
            this.columnHeader13.Width = 176;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Дата создания";
            this.columnHeader14.Width = 165;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Принял";
            this.columnHeader15.Width = 137;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Сдал";
            this.columnHeader16.Width = 98;
            // 
            // WarehouseCell
            // 
            this.WarehouseCell.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.WarehouseCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarehouseCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WarehouseCell.FullRowSelect = true;
            this.WarehouseCell.Location = new System.Drawing.Point(0, 0);
            this.WarehouseCell.Name = "WarehouseCell";
            this.WarehouseCell.OwnerDraw = true;
            this.WarehouseCell.Size = new System.Drawing.Size(1028, 424);
            this.WarehouseCell.TabIndex = 2;
            this.WarehouseCell.UseCompatibleStateImageBehavior = false;
            this.WarehouseCell.UseSelectable = true;
            this.WarehouseCell.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Номер";
            this.columnHeader17.Width = 63;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Секция";
            this.columnHeader18.Width = 107;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Линия";
            this.columnHeader19.Width = 176;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Стеллаж";
            this.columnHeader20.Width = 165;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Ярус";
            this.columnHeader21.Width = 137;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Позиция";
            this.columnHeader22.Width = 98;
            // 
            // InputInvoices
            // 
            this.InputInvoices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.InputInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputInvoices.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.InputInvoices.FullRowSelect = true;
            this.InputInvoices.Location = new System.Drawing.Point(0, 0);
            this.InputInvoices.Name = "InputInvoices";
            this.InputInvoices.OwnerDraw = true;
            this.InputInvoices.Size = new System.Drawing.Size(1028, 424);
            this.InputInvoices.TabIndex = 0;
            this.InputInvoices.UseCompatibleStateImageBehavior = false;
            this.InputInvoices.UseSelectable = true;
            this.InputInvoices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Номер";
            this.columnHeader4.Width = 73;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Тип техники";
            this.columnHeader5.Width = 153;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Наименование";
            this.columnHeader6.Width = 164;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Дата создания";
            this.columnHeader7.Width = 136;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Принял";
            this.columnHeader8.Width = 125;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Сдал";
            // 
            // WarehouseBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 546);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "WarehouseBrowser";
            this.Text = "Обозреватель";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WarehouseBrowser_FormClosing);
            this.Load += new System.EventHandler(this.WarehouseBrowser_Load);
            this.Resize += new System.EventHandler(this.WarehouseBrowser_Resize);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        public MetroFramework.Controls.MetroListView TovarsListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MetroFramework.Controls.MetroListView OutputListView;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private MetroFramework.Controls.MetroListView WarehouseCell;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private MetroFramework.Controls.MetroListView InputInvoices;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}