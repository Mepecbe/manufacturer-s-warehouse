using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BDiSUBD.Forms
{
    public partial class AddOutputInvoice : MetroFramework.Forms.MetroForm
    {
        public bool OK = false;
        public WarehouseBrowser BrowserForm;

        /**/
        public string Type = "";
        public string WarehouseCell = "";
        public string TovarName = "";
        public int Count = 0;
        /**/

        public AddOutputInvoice(WarehouseBrowser form)
        {
            InitializeComponent();
            this.BrowserForm = form;
        }

        private void AddOutputInvoce_Load(object sender, EventArgs e)
        {
            foreach(ListViewItem item in BrowserForm.TovarsListView.Items)
            {
                ListViewItem newItem = this.TovarsListView.Items.Add(item.SubItems[0].Text);
                newItem.SubItems.Add(item.SubItems[1].Text);
                newItem.SubItems.Add(item.SubItems[2].Text);
                newItem.SubItems.Add(item.SubItems[3].Text);
            }
        }

        private int index = 0;
        private void TovarsListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.TovarsListView.SelectedItems.Count == 0)
            {
                CountTextBox.Text = "";
                return;
            }

            this.index = this.TovarsListView.SelectedItems[0].Index;
            CountTextBox.Text = this.TovarsListView.SelectedItems[0].SubItems[3].Text;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(int.Parse(this.TovarsListView.Items[index].SubItems[3].Text) < int.Parse(CountTextBox.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Вы не можете поставить количество больше, чем есть на складе", "Ошибка");
                return;
            }

            {
                Type = this.TovarsListView.Items[index].SubItems[0].Text;
                WarehouseCell = this.TovarsListView.Items[index].SubItems[1].Text;
                TovarName = this.TovarsListView.Items[index].SubItems[2].Text;
                Count = int.Parse(CountTextBox.Text);
            }

            OK = true;
            this.Close();
        }
    }
}
