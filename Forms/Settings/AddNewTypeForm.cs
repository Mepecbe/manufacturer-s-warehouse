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
    public partial class AddNewTypeForm : MetroFramework.Forms.MetroForm
    {
        public bool OK = false;
        public AddNewTypeForm()
        {
            InitializeComponent();
        }

        private void AddNewTypeForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(newTypeTextBox.Text.Length < 2)
            {
                MetroFramework.MetroMessageBox.Show(this, "Введите название", "Предупреждение");
                return;
            }

            OK = true;
            this.Close();
        }
    }
}
