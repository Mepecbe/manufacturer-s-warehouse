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
        string warehouseId = "";

        public WarehouseBrowser(string warehouseId)
        {
            InitializeComponent();
            this.warehouseId = warehouseId;
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
                    TovarsListView.Columns[0].Width = 30;
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
                }

                reader.Close();
            }

            {
                //Заполнение таблицы складских ячеек
                MySqlDataReader reader = new MySqlCommand($"SELECT * FROM WarehouseCell WHERE Warehouse_ID = '{warehouseId}';", conn).ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = WarehouseCell.Items.Add(reader[1].ToString());
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
            for (int a = 0; a < InputInvoices.Columns.Count; a++) InputInvoices.Columns[a].Width = InputInvoices.Width / InputInvoices.Columns.Count;
            for (int a = 0; a < OutputListView.Columns.Count; a++) OutputListView.Columns[a].Width = OutputListView.Width / OutputListView.Columns.Count;
            for (int a = 0; a < TovarsListView.Columns.Count; a++) TovarsListView.Columns[a].Width = TovarsListView.Width / TovarsListView.Columns.Count;
            for (int a = 0; a < WarehouseCell.Columns.Count; a++) WarehouseCell.Columns[a].Width = WarehouseCell.Width / WarehouseCell.Columns.Count;
        }
    }
}
