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
    public partial class CloseInputInvoice : MetroFramework.Forms.MetroForm
    {
        public bool OK = false;
        public CloseInputInvoice(List<string> cells)
        {
            InitializeComponent();
         
            foreach (string cell in cells)
                metroComboBox1.Items.Add(cell);
        }

        private void CloseInputInvoice_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text.Length == 0) return;
            OK = true;
            this.Close();
        }
    }
}
