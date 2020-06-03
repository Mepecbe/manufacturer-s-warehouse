using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace BDiSUBD.Forms
{
    public partial class SettingsForm : MetroFramework.Forms.MetroForm
    {
        public string WarehouseID = "";
        public SettingsForm(string WarehouseId)
        {
            InitializeComponent();
            this.WarehouseID = WarehouseId;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(Properties.Resources.MySqlConnectionString);

            try
            {
                connection.Open();

                {
                    MySqlDataReader reader = new MySqlCommand($"SELECT Name FROM technique_types WHERE Warehouse_ID = '{this.WarehouseID}'", connection).ExecuteReader();
                    while (reader.Read())
                    {
                        TypesList.Items.Add(reader[0].ToString());
                    }
                }

                connection.Close();
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка");
            }

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TypesList.SelectedItems.Count == 0) return; 
            MySqlConnection connection = new MySqlConnection(Properties.Resources.MySqlConnectionString);
            
            try
            {
                connection.Open();
                new MySqlCommand($"DELETE FROM technique_types WHERE Name = '{TypesList.SelectedItems[0].SubItems[0].Text}'", connection).ExecuteNonQuery();
                TypesList.SelectedItems[0].Remove();
                connection.Close();
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка");
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTypeForm form = new AddNewTypeForm();
            form.ShowDialog();

            if (form.OK)
            {
                MySqlConnection connection = new MySqlConnection(Properties.Resources.MySqlConnectionString);

                try
                {
                    connection.Open();
                    new MySqlCommand($"INSERT INTO technique_types VALUES ('{WarehouseID}', '{form.newTypeTextBox.Text}')", connection).ExecuteNonQuery();
                    TypesList.Items.Add(form.newTypeTextBox.Text);
                    connection.Close();
                }
                catch(Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка");
                }
            }


        }
    }
}
