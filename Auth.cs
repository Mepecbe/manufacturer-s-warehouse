using System;
using System.Xml;
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
using System.IO;

namespace BDiSUBD
{
    public partial class Auth : MetroFramework.Forms.MetroForm
    {
        public string ConnectionString = "";
        public string warehouseId = "";

        public Auth()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            {
                //Загрузка строки подключения
                if (!File.Exists("connection.txt"))
                {
                    File.Create("connection.txt");
                    MetroFramework.MetroMessageBox.Show(this, "Это первый запуск программы, задайте настройки подключения", "Внимание");
                    return;
                }
                else
                {
                    ConnectionString = File.ReadAllText("connection.txt");
                }
            }


            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString);
                conn.Open();
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
                MetroFramework.MetroMessageBox.Show(this, "Невозможно подключится к серверу, обратитесь к администратору", "Ошибка подключения");
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            if (Storehouse.Text.Length < 2)
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
                    if (reader[5].ToString() == PasswordTextBox.Text)
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
            catch (Exception ex)
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

        private void metroLink1_Click(object sender, EventArgs e)
        {
            new ConnectionSetting(this).ShowDialog();
        }
    }
}
