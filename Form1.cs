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

//Программное средство учёта бытовой техники на складе производителя
//server=localhost;database=testDB;uid=root;pwd=abc123;";

namespace BDiSUBD
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string connString = "server=2.57.184.157;database=sklad;uid=admin_sklad;pwd=1234;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            bool Auth = false;

            try
            {
                MySqlConnection conn = new MySqlConnection(Properties.Resources.MySqlConnectionString); conn.Open();
                MySqlDataReader reader = new MySqlCommand($"SELECT * FROM Accounts WHERE Login = '{LoginTextBox.Text}';", conn).ExecuteReader();
                
                while (reader.Read())
                {
                    if(reader[5].ToString() == PasswordTextBox.Text)
                    {
                        Auth = true;
                        break;
                    }
                }

                reader.Close();
                conn.Close();
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка подключения");
            }

            if (Auth)            
                MetroFramework.MetroMessageBox.Show(this, "Подключение успешно", "Подключение");
            else
                MetroFramework.MetroMessageBox.Show(this, "Подключение не успешно", "Подключение");
        }
    }
}
