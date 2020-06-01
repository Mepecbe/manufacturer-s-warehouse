using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDiSUBD.Forms
{
    public partial class WarehouseAddCell : MetroFramework.Forms.MetroForm
    {
        WarehouseBrowser browser;
        public bool OkClick = false;

        public WarehouseAddCell(WarehouseBrowser form)
        {
            InitializeComponent();
            this.browser = form;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            IdTextBox.Text = browser.genId(10);
        }

        private void textChanged(object sender, EventArgs e)
        {
            FullCellAddress.Text = $"{SectionTextBox.Text}-{LineTextBox.Text}-{RackTextBox.Text}-{TierTextBox.Text}-{PositionTextBox.Text}";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OkClick = true;
            this.Close();
        }
    }
}
