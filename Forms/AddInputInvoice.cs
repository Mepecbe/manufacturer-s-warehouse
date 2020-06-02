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
    public partial class AddInputInvoice : MetroFramework.Forms.MetroForm
    {
        public bool OK = false;
        public AddInputInvoice(List<string> techniqueTypes)
        {
            InitializeComponent();
            foreach(string type in techniqueTypes)
            {
                this.TechniqueComboBox.Items.Add(type);
            }
        }

        private void AddInputInvoice_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (CountTextBox.Text.Length == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Введите количество", "Ошибка");
                return;
            }

            if (NameTextBox.Text.Length == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Введите наименование", "Ошибка");
                return;
            }

            OK = true;
            this.Close();
        }
    }
}
