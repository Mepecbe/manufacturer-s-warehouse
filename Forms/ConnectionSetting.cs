using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.IO;

namespace BDiSUBD.Forms
{
    public partial class ConnectionSetting : MetroFramework.Forms.MetroForm
    {
        Auth AuthForm;

        public ConnectionSetting(Auth form)
        {
            InitializeComponent();
            this.AuthForm = form;
        }

        private void ConnectionSetting_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ServerAddress.Text.Length == 0 ||
                DataBase.Text.Length == 0 ||
                Username.Text.Length == 0 ||
                Password.Text.Length == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Не все поля заполнены", "Ошибка");
                return;
            }

            if (!Regex.IsMatch(ServerAddress.Text, @"([0-9]{1,3}[\.]){3}[0-9]{1,3}"))
            {
                MetroFramework.MetroMessageBox.Show(this, "Введите корректный IP адрес", "Ошибка");
                return;
            }

            {
                //Запись строки подключения в форму и файл
                File.WriteAllText("connection.txt", this.AuthForm.ConnectionString = $"server={ServerAddress.Text};uid={Username.Text};pwd={Password.Text};database={DataBase.Text};CharSet=utf-8;");
                this.Close();
                this.AuthForm.Form1_Load(null, null);
            }
        }
    }
}
