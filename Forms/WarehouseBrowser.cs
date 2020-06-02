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
    public partial class WarehouseBrowser : MetroFramework.Forms.MetroForm
    {
        Random rnd = new Random();
        string warehouseId = "";
        string FIO = "";

        public WarehouseBrowser(string warehouseId, string WorkerFio)
        {
            InitializeComponent();
            this.warehouseId = warehouseId;
            this.FIO = WorkerFio;
        }

        private void WarehouseBrowser_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Properties.Resources.MySqlConnectionString); 
            conn.Open();

            {
                //Заполнение таблицы товаров
                MySqlDataReader reader = new MySqlCommand($"SELECT * FROM technique;", conn).ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = TovarsListView.Items.Add(reader[2].ToString());

                    item.SubItems.Add(reader[1].ToString());
                    item.SubItems.Add(reader[3].ToString());
                    item.SubItems.Add(reader[4].ToString());
                }

                reader.Close();
            }


            {
                //Заполнение приходных накладных
                MySqlDataReader reader = new MySqlCommand($"SELECT * FROM Invoices WHERE Warehouse_ID = '{warehouseId}' AND Type = 'Приходная';", conn).ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = InputInvoices.Items.Add(reader[0].ToString());
                    item.SubItems.Add(reader[2].ToString());
                    item.SubItems.Add(reader[3].ToString());
                    item.SubItems.Add(reader[4].ToString());
                    item.SubItems.Add(reader[5].ToString());
                    item.SubItems.Add(reader[6].ToString());
                    item.SubItems.Add(reader[7].ToString());
                }

                reader.Close();
            }

            {
                //Заполнение расходных накладных
                MySqlDataReader reader = new MySqlCommand($"SELECT * FROM Invoices WHERE Warehouse_ID = '{warehouseId}' AND Type = 'Расходная';", conn).ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = OutputListView.Items.Add(reader[0].ToString());
                    item.SubItems.Add(reader[2].ToString());
                    item.SubItems.Add(reader[3].ToString());
                    item.SubItems.Add(reader[4].ToString());
                    item.SubItems.Add(reader[5].ToString());
                    item.SubItems.Add(reader[6].ToString());
                    item.SubItems.Add(reader[7].ToString());
                }

                reader.Close();
            }

            {
                //Заполнение таблицы складских ячеек
                MySqlDataReader reader = new MySqlCommand($"SELECT * FROM WarehouseCell WHERE Warehouse_ID = '{warehouseId}';", conn).ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = WarehouseCell.Items.Add(reader[1].ToString());
                    item.SubItems.Add($"{reader[2].ToString()}-{reader[3].ToString()}-{reader[4].ToString()}-{reader[5].ToString()}-{reader[6].ToString()}");
                    item.SubItems.Add(reader[2].ToString());
                    item.SubItems.Add(reader[3].ToString());
                    item.SubItems.Add(reader[4].ToString());
                    item.SubItems.Add(reader[5].ToString());
                    item.SubItems.Add(reader[6].ToString());
                }

                reader.Close();
            }


            UpdateCellSize(); 

            conn.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void WarehouseBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void WarehouseBrowser_Resize(object sender, EventArgs e)
        {
            UpdateCellSize();
        }

        private void UpdateCellSize()
        {
            for (int a = 0; a < InputInvoices.Columns.Count; a++) 
                InputInvoices.Columns[a].Width = InputInvoices.Width / InputInvoices.Columns.Count;

            for (int a = 0; a < OutputListView.Columns.Count; a++) 
                OutputListView.Columns[a].Width = OutputListView.Width / OutputListView.Columns.Count;

            for (int a = 0; a < TovarsListView.Columns.Count; a++) 
                TovarsListView.Columns[a].Width = TovarsListView.Width / TovarsListView.Columns.Count;

            for (int a = 0; a < WarehouseCell.Columns.Count; a++) 
                WarehouseCell.Columns[a].Width = WarehouseCell.Width / WarehouseCell.Columns.Count;
        }

        private void добавитьСкладскуюЯчейкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarehouseAddCell FormAddCell = new WarehouseAddCell(this);
            FormAddCell.ShowDialog();

            if (FormAddCell.OkClick)
            {
                ListViewItem item = this.WarehouseCell.Items.Add(FormAddCell.IdTextBox.Text);
                item.SubItems.Add(FormAddCell.FullCellAddress.Text);
                item.SubItems.Add(FormAddCell.SectionTextBox.Text);
                item.SubItems.Add(FormAddCell.LineTextBox.Text);
                item.SubItems.Add(FormAddCell.RackTextBox.Text);
                item.SubItems.Add(FormAddCell.TierTextBox.Text);
                item.SubItems.Add(FormAddCell.PositionTextBox.Text);
            }

            {
                //Добавление в БД
                MySqlConnection conn = new MySqlConnection(Properties.Resources.MySqlConnectionString);
                try
                {
                    conn.Open();
                    new MySqlCommand($"INSERT INTO WarehouseCell VALUES ('{warehouseId}', '{FormAddCell.IdTextBox.Text}', '{FormAddCell.SectionTextBox.Text}', '{FormAddCell.LineTextBox.Text}', '{FormAddCell.RackTextBox.Text}', '{FormAddCell.TierTextBox.Text}', '{FormAddCell.PositionTextBox.Text}')", conn).ExecuteNonQuery();
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, $"Произошла ошибка\n{ex.Message}", "Ошибка");
                }
            }
        }

        public string genId(byte len)
        {
            string retId = "";

            for (int n = 0; n < len; n++) 
                retId += Encoding.ASCII.GetChars(new byte[] { rnd.Next(0,2) == 0 ? (byte)rnd.Next(48,58) : (byte)rnd.Next(97,123) })[0];

            return retId;
        }

        private void удалитьСкладскуюЯчейкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WarehouseCell.SelectedItems.Count == 0) return;

            MySqlConnection conn = new MySqlConnection(Properties.Resources.MySqlConnectionString);
            try
            {
                conn.Open();
                new MySqlCommand($"DELETE FROM WarehouseCell WHERE ID = '{WarehouseCell.SelectedItems[0].SubItems[0].Text}'", conn).ExecuteNonQuery();
                WarehouseCell.SelectedItems[0].Remove();
                conn.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Произошла ошибка\n{ex.Message}", "Ошибка");
            }
        }

        private void добавитьПриходнуюНакладнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(Properties.Resources.MySqlConnectionString);
            List<string> types = new List<string>();

            {
                //Запись в список всех типов техники, которые доступны для этого склада
                try
                {
                    connection.Open();

                    MySqlDataReader reader = new MySqlCommand($"SELECT Name FROM technique_types WHERE Warehouse_ID = '{warehouseId}'", connection).ExecuteReader();

                    while (reader.Read())
                    {
                        types.Add(reader[0].ToString());
                    }

                    reader.Close();
                    connection.Close();
                }
                catch(Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, $"{ex.Message}", "Ошибка получения типов");
                    return;
                }
            }

            AddInputInvoice AddForm = new AddInputInvoice(types);
            AddForm.ShowDialog();
            
            try
            {
                connection.Open();
                new MySqlCommand($"INSERT INTO Invoices VALUES (null, '{warehouseId}', '{AddForm.TechniqueComboBox.Text}', '{AddForm.NameTextBox.Text}', {AddForm.CountTextBox.Text}, '{DateTime.Now.ToString()}', '{FIO}', '', 'Приходная') ", connection).ExecuteNonQuery();
                connection.Close();
                

                {
                    ListViewItem item = null;

                    item = InputInvoices.Items.Count == 0 ? InputInvoices.Items.Add("1") : InputInvoices.Items.Add((int.Parse(InputInvoices.Items[InputInvoices.Items.Count - 1].SubItems[0].Text) + 1).ToString());

                    item.SubItems.Add(AddForm.TechniqueComboBox.Text);
                    item.SubItems.Add(AddForm.NameTextBox.Text);
                    item.SubItems.Add(AddForm.CountTextBox.Text);
                    item.SubItems.Add(DateTime.Now.ToString());
                    item.SubItems.Add(FIO);
                    item.SubItems.Add("");
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"{ex.Message}", "Ошибка");
            }
        }

        private void сдатьНакладнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InputInvoices.SelectedItems.Count == 0) return;
            if (InputInvoices.SelectedItems[0].SubItems[6].Text.Length > 1) return; //Если уже сдана

            MySqlConnection connection = new MySqlConnection(Properties.Resources.MySqlConnectionString);

            try
            {
                connection.Open();

                List<string> cells = new List<string>();

                {
                    //Получаем свободные складские ячейки
                    MySqlDataReader reader = new MySqlCommand($"SELECT ID FROM WarehouseCell", connection).ExecuteReader();
                    while (reader.Read())
                    {
                        cells.Add(reader[0].ToString());
                    }
                    reader.Close();
                }

                CloseInputInvoice CloseInvoiceForm = new CloseInputInvoice(cells);
                CloseInvoiceForm.ShowDialog();

                if (!CloseInvoiceForm.OK) return;

                {
                    //Обновляем накладную в таблицe
                    new MySqlCommand($"UPDATE Invoices SET `Passed the invoice` = '{FIO}' WHERE Number = {InputInvoices.SelectedItems[0].SubItems[0].Text}", connection).ExecuteNonQuery();
                }

                {
                    //Добавляем в таблицу товаров на складе
                    new MySqlCommand($"INSERT INTO technique VALUES ('{genId(10)}', '{CloseInvoiceForm.metroComboBox1.Text}', '{InputInvoices.SelectedItems[0].SubItems[1].Text}', '{InputInvoices.SelectedItems[0].SubItems[2].Text}', '{InputInvoices.SelectedItems[0].SubItems[3].Text}')", connection).ExecuteNonQuery();
                }

                {
                    //Изменяем запись
                    InputInvoices.SelectedItems[0].SubItems[6].Text = FIO;

                    //Добавляем в лист товаров
                    ListViewItem item = TovarsListView.Items.Add(InputInvoices.SelectedItems[0].SubItems[1].Text);
                    item.SubItems.Add(CloseInvoiceForm.metroComboBox1.Text);
                    item.SubItems.Add(InputInvoices.SelectedItems[0].SubItems[2].Text);
                    item.SubItems.Add(InputInvoices.SelectedItems[0].SubItems[3].Text);
                }

                connection.Close();
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Ошибка \n{ex.Message}", "Ошибка");
            }

        }
    }
}
