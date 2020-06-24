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
    public partial class StatisticsForm : MetroFramework.Forms.MetroForm
    {
        WarehouseBrowser browser;
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Вывести статистику
            chart1.Series["Количество"].Points.Clear();
            DateTime[] diapazon = new DateTime[] { this.metroDateTime1.Value, this.metroDateTime2.Value };

            MySqlConnection conn = new MySqlConnection(Properties.Resources.MySqlConnectionString);
            
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка");
                return;
            }

            int Day = 0;

            MySqlDataReader readbuff = null;

            switch (metroComboBox1.Text)
            {
                case "Количеству приходных накладных": 
                    {

                        for (DateTime active = metroDateTime1.Value; active.Month <= metroDateTime2.Value.Month && active.Day <= metroDateTime2.Value.Day; active = active.AddDays(1), Day++)
                        {
                            readbuff = new MySqlCommand($"SELECT * FROM Invoices WHERE Type = 'Приходная' ORDER BY CreateDate", conn).ExecuteReader();

                            //MessageBox.Show(active.ToString());
                            int count = 0;

                            while (readbuff.Read())
                            {
                                if (DateTime.Parse(readbuff[5].ToString()).Year == active.Year &&
                                    DateTime.Parse(readbuff[5].ToString()).Month == active.Month &&
                                    DateTime.Parse(readbuff[5].ToString()).Day == active.Day) count++;
                            }

                            chart1.Series["Количество"].Points.Add( count, Day);
                            readbuff.Close();
                        }

                        break; 
                    }

                case "Количеству расходных накладных":
                    {
                        for (DateTime active = metroDateTime1.Value; active.Month <= metroDateTime2.Value.Month && active.Day <= metroDateTime2.Value.Day; active = active.AddDays(1), Day++)
                        {
                            readbuff = new MySqlCommand($"SELECT * FROM Invoices WHERE Type = 'Расходная' ORDER BY CreateDate", conn).ExecuteReader();

                            int count = 0;

                            while (readbuff.Read())
                            {
                                if (DateTime.Parse(readbuff[5].ToString()).Year == active.Year &&
                                    DateTime.Parse(readbuff[5].ToString()).Month == active.Month &&
                                    DateTime.Parse(readbuff[5].ToString()).Day == active.Day) count++;
                            }

                            chart1.Series["Количество"].Points.Add(count, Day);
                            readbuff.Close();
                        }

                        break;
                    }
            }


            conn.Close();

        }
    }
}
