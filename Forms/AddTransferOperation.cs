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
    public partial class AddTransferOperation : MetroFramework.Forms.MetroForm
    {
        public int count = 0;

        public bool OK = false;
        public AddTransferOperation(string cell, string TovarName, int count)
        {
            InitializeComponent();
            this.OutputCell.Text = cell;
            this.TovarName.Text = TovarName;
            this.CountTextBox.Text = count.ToString();

            this.count = count;
        }

        private void AddTransferOperation_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(Properties.Resources.MySqlConnectionString);

            try
            {
                connection.Open();

                {
                    //Получение складских ячеек
                    MySqlDataReader reader = new MySqlCommand($"SELECT ID FROM WarehouseCell", connection).ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader[0].ToString() == OutputCell.Text) continue;
                        inputWarehouseCell.Items.Add(reader[0].ToString());
                    }

                    reader.Close();
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(int.Parse(CountTextBox.Text) > this.count)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Вы не можете выставить количество больше, чем есть на складе(максимум {count.ToString()})", "Ошибка");
                return;
            }

            OK = true;
            this.Close();
        }
    }
}
