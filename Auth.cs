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

using BDiSUBD.Forms;

//Программное средство учёта бытовой техники на складе производителя
//server=localhost;database=testDB;uid=root;pwd=abc123;";

namespace BDiSUBD
{
    public partial class Auth : MetroFramework.Forms.MetroForm
    {
        string warehouseId = "";

        public Auth()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Properties.Resources.MySqlConnectionString); conn.Open();
                MySqlDataReader reader = new MySqlCommand($"SELECT * FROM manufacturer_warehouses;", conn).ExecuteReader();

                while (reader.Read())
                {
                    Storehouse.Items.Add(reader[2].ToString());
                }
                
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка подключения");
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            if(Storehouse.Text.Length < 2)
            {
                MetroFramework.MetroMessageBox.Show(this, "Необходимо выбрать склад", "Внимание");
                return;
            }


            bool Auth = false;
            string fio = "";

            try
            {
                MySqlConnection conn = new MySqlConnection(Properties.Resources.MySqlConnectionString); conn.Open();
                MySqlDataReader reader = new MySqlCommand($"SELECT * FROM Accounts WHERE Login = '{LoginTextBox.Text}';", conn).ExecuteReader();
                
                while (reader.Read())
                {
                    if(reader[5].ToString() == PasswordTextBox.Text)
                    {
                        Auth = true;
                        fio = reader[1].ToString();
                        break;
                    }
                }
                               
                reader.Close();

                if (Auth)
                {
                    //Если авторизация успешна, получаем АЙДИ выбранного склада
                    MySqlDataReader r = new MySqlCommand($"SELECT ID FROM manufacturer_warehouses WHERE Name = '{Storehouse.Text}';", conn).ExecuteReader();
                    if (r.Read())
                    {
                        warehouseId = r[0].ToString();
                    }
                    r.Close(); 
                }

                conn.Close();
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка подключения");
            }

            if (Auth)
            {
                this.Visible = false;
                new WarehouseBrowser(warehouseId, fio).Show();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Подключение не успешно", "Ошибка");
        }
    }
}
