using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BDiSUBD.Forms;

using MySql.Data.MySqlClient;
using MicrosoftExcel = Microsoft.Office.Interop.Excel;

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


            {
                //Заполнение таблицы внутренних переводов
                MySqlDataReader reader = new MySqlCommand($"SELECT * FROM Transfers WHERE Warehouse_ID = '{warehouseId}';", conn).ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = TransferOperations.Items.Add(reader[1].ToString());
                    item.SubItems.Add(reader[2].ToString());
                    item.SubItems.Add(reader[3].ToString());
                    item.SubItems.Add(reader[4].ToString());
                    item.SubItems.Add(reader[5].ToString());
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

            for (int a = 0; a < TransferOperations.Columns.Count; a++)
                TransferOperations.Columns[a].Width = TransferOperations.Width / TransferOperations.Columns.Count;


            this.SettingsButton.Location = new Point(this.Size.Width - this.SettingsButton.Width - 80, this.SettingsButton.Location.Y);
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
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, $"Произошла ошибка\n{ex.Message}", "Ошибка");
                }
            }
        }

        public string genId(byte len)
        {
            string retId = "";

            for (int n = 0; n < len; n++)
                retId += Encoding.ASCII.GetChars(new byte[] { rnd.Next(0, 2) == 0 ? (byte)rnd.Next(48, 58) : (byte)rnd.Next(97, 123) })[0];

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
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, $"{ex.Message}", "Ошибка получения типов");
                    return;
                }
            }

            AddInputInvoice AddForm = new AddInputInvoice(types);
            AddForm.ShowDialog();

            if (!AddForm.OK) return;

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
            catch (Exception ex)
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
                    MySqlDataReader reader = new MySqlCommand($"SELECT `WarehouseCell`.`ID` FROM `WarehouseCell` WHERE `WarehouseCell`.`ID` NOT IN (SELECT `technique`.`Cell_Id` FROM technique)", connection).ExecuteReader();
                    while (reader.Read())
                    {
                        cells.Add(reader[0].ToString());
                    }
                    reader.Close();
                }

                if(cells.Count == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Нет свободных складских ячеек", "Предупреждение");
                    connection.Close();
                    return;
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
                    new MySqlCommand($"INSERT INTO technique VALUES ('{warehouseId}', '{CloseInvoiceForm.metroComboBox1.Text}', '{InputInvoices.SelectedItems[0].SubItems[1].Text}', '{InputInvoices.SelectedItems[0].SubItems[2].Text}', '{InputInvoices.SelectedItems[0].SubItems[3].Text}')", connection).ExecuteNonQuery();
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
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Ошибка \n{ex.Message}", "Ошибка");
            }

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            //**/
            new SettingsForm(warehouseId).ShowDialog();
        }

        private void добавитьРасходнуюНакладнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(Properties.Resources.MySqlConnectionString);
            AddOutputInvoice form = new AddOutputInvoice(this);
            form.ShowDialog();

            if (form.OK)
            {

                //Поиск Item'a накладной, среди Item'ов всех товаров
                foreach (ListViewItem item in TovarsListView.Items)
                {
                    if (item.SubItems[0].Text == form.Type
                        && item.SubItems[2].Text == form.TovarName)
                    {
                        try
                        {
                            connection.Open();
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка подключения");
                            return;
                        }


                        DateTime Now = DateTime.Now;
                        new MySqlCommand($"INSERT INTO Invoices VALUES (null, '{warehouseId}', '{form.Type}', '{form.TovarName}', {form.Count}, '{Now.ToString()}', '{FIO}', '', 'Расходная')", connection).ExecuteNonQuery();
                        
                        {
                            ListViewItem NewItem = OutputListView.Items.Add(OutputListView.Items.Count == 0 ? "1" : (int.Parse(OutputListView.Items[OutputListView.Items.Count - 1].SubItems[0].Text).ToString()));
                            NewItem.SubItems.Add(form.Type);
                            NewItem.SubItems.Add(form.TovarName);
                            NewItem.SubItems.Add(form.Count.ToString());
                            NewItem.SubItems.Add(Now.ToString());
                            NewItem.SubItems.Add(FIO);
                            NewItem.SubItems.Add("");
                        }

                        connection.Close();
                        break;
                    }
                }
            }
        }

        private void СдатьНакладнуюItem_Click(object sender, EventArgs e)
        {
            //Если не выбрано
            if (OutputListView.SelectedItems.Count == 0) return; 
            //Если уже сдана
            if (OutputListView.SelectedItems[0].SubItems[6].Text.Length > 4) return;

            MySqlConnection connection = new MySqlConnection(Properties.Resources.MySqlConnectionString);

            try
            {
                connection.Open();

                if (MetroFramework.MetroMessageBox.Show(this, "Вы действительно хотите сдать расходную накладную?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach(ListViewItem item in TovarsListView.Items)
                    {
                        if(item.SubItems[2].Text == OutputListView.SelectedItems[0].SubItems[2].Text)
                        {
                            if(OutputListView.SelectedItems[0].SubItems[3].Text == item.SubItems[3].Text)
                            {
                                //Если со склада выгружаются все товары такого наименования, то удаляем его с таблицы товаров
                                new MySqlCommand($"DELETE FROM technique WHERE Name = '{item.SubItems[2].Text}'", connection).ExecuteNonQuery();
                                new MySqlCommand($"UPDATE Invoices SET `Passed the invoice` = '{FIO}' WHERE Warehouse_ID = '{warehouseId}' AND Name = '{OutputListView.SelectedItems[0].SubItems[2].Text}' AND Count = {OutputListView.SelectedItems[0].SubItems[3].Text}", connection).ExecuteNonQuery();
                                OutputListView.SelectedItems[0].SubItems[6].Text = FIO;
                                item.Remove();
                                break;
                            }
                            else
                            {
                                //Если на складе не выгружается всё и остаётся остаток
                                int newCount = int.Parse(item.SubItems[3].Text) - int.Parse(OutputListView.SelectedItems[0].SubItems[3].Text);

                                new MySqlCommand($"UPDATE technique SET Count = {newCount} WHERE Name = '{item.SubItems[2].Text}' ", connection).ExecuteNonQuery();
                                new MySqlCommand($"UPDATE Invoices SET `Passed the invoice` = '{FIO}' WHERE Warehouse_ID = '{warehouseId}' AND Name = '{OutputListView.SelectedItems[0].SubItems[2].Text}' AND Count = {OutputListView.SelectedItems[0].SubItems[3].Text}", connection).ExecuteNonQuery();
                                OutputListView.SelectedItems[0].SubItems[6].Text = FIO;

                                item.SubItems[3].Text = newCount.ToString();
                                break;
                            }
                        }
                    }


                   // new MySqlCommand($"UPDATE Invoices WHERE Warehouse_ID = '{warehouseId}' AND Number = '{OutputListView.SelectedItems[0].SubItems[0].Text}' SET `Passed the invoice` = '{FIO}'", connection).ExecuteNonQuery();
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\n" + ex.StackTrace, "Ошибка");
            }
        }

        private void добавитьПереводToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TovarsListView.SelectedItems.Count == 0) return;

            AddTransferOperation form = new AddTransferOperation(TovarsListView.SelectedItems[0].SubItems[1].Text, TovarsListView.SelectedItems[0].SubItems[0].Text + ": " + TovarsListView.SelectedItems[0].SubItems[2].Text, int.Parse(TovarsListView.SelectedItems[0].SubItems[3].Text));
            form.ShowDialog();

            if (form.OK)
            {
                MySqlConnection connection = new MySqlConnection(Properties.Resources.MySqlConnectionString);

                try
                {
                    connection.Open();

                    new MySqlCommand($"INSERT INTO Transfers VALUES('{warehouseId}', '{form.TovarName.Text}', {form.CountTextBox.Text}, '{form.OutputCell.Text}', '{form.inputWarehouseCell.Text}', '{FIO}')", connection).ExecuteNonQuery();

                    ListViewItem item = TransferOperations.Items.Add(form.TovarName.Text);
                    item.SubItems.Add(form.CountTextBox.Text);
                    item.SubItems.Add(form.OutputCell.Text);
                    item.SubItems.Add(form.inputWarehouseCell.Text);
                    item.SubItems.Add(FIO);

                    connection.Close();
                }
                catch(Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка");
                }
            }
        }

        private void потвердитьПереводToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TransferOperations.SelectedItems.Count == 0) return;

            foreach(ListViewItem item in TovarsListView.Items)
            {
                //Ищем этот элемент в таблице товаров
                if(item.SubItems[1].Text == TransferOperations.SelectedItems[0].SubItems[2].Text)
                {
                    if(int.Parse(item.SubItems[3].Text) - int.Parse(TransferOperations.SelectedItems[0].SubItems[1].Text) <= 0)
                    {
                        //Если производится перевод всего кол-ва, что есть на складе
                        MySqlConnection connection = new MySqlConnection(Properties.Resources.MySqlConnectionString);
                        connection.Open();

                        //Обновление ячейки местанохждения товара на складе
                        new MySqlCommand($"UPDATE technique SET Cell_ID = '{TransferOperations.SelectedItems[0].SubItems[3].Text}' WHERE Warehouse_ID = '{warehouseId}' AND Name = '{TransferOperations.SelectedItems[0].SubItems[0].Text}'", connection).ExecuteNonQuery();

                        //Удаление операции перевода из таблицы
                        new MySqlCommand($"DELETE FROM Transfers WHERE Warehouse_ID = '{warehouseId}' AND OutputCell = '{TransferOperations.SelectedItems[0].SubItems[2].Text}' AND InputCell = '{TransferOperations.SelectedItems[0].SubItems[3].Text}'");

                        //Обновление ячейки в списке в форме
                        item.SubItems[1].Text = TransferOperations.SelectedItems[0].SubItems[3].Text;

                        //Удаление операции из списка в форме
                        TransferOperations.SelectedItems[0].Remove();
                        

                        connection.Close();
                    }
                    else
                    {
                        //Если переводим не всё кол-во
                    }
                }
            }
        }

        private void ПеренестиВАрхивItem_Click(object sender, EventArgs e)
        {
            if (OutputListView.SelectedItems.Count == 0) return;

            MySqlConnection connection = new MySqlConnection(Properties.Resources.MySqlConnectionString);

            try
            {
                connection.Open();

                string text = $"Тип накладной: Приходная\n"
                            + $"Наименование: {OutputListView.SelectedItems[0].SubItems[2].Text}\n"
                            + $"Количество {OutputListView.SelectedItems[0].SubItems[3].Text}\n"
                            + $"Дата создания: {OutputListView.SelectedItems[0].SubItems[4].Text}\n"
                            + $"Принял: {OutputListView.SelectedItems[0].SubItems[5].Text}\n"
                            + $"Сдал: {OutputListView.SelectedItems[0].SubItems[6].Text}\n";


                new MySqlCommand($"INSERT INTO Archive VALUES('{warehouseId}', '{text}')", connection).ExecuteNonQuery();
                new MySqlCommand($"DELETE FROM Invoices WHERE Warehouse_ID = '{warehouseId}' AND Type = 'Приходная' AND Name = '{OutputListView.SelectedItems[0].SubItems[2].Text}' AND CreateDate = '{OutputListView.SelectedItems[0].SubItems[4].Text}'", connection).ExecuteNonQuery();

                OutputListView.SelectedItems[0].Remove();

                connection.Close();
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка");
            }
        }

        private void перенестиНакладнуюВАрхивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InputInvoices.SelectedItems.Count == 0) return;

            MySqlConnection connection = new MySqlConnection(Properties.Resources.MySqlConnectionString);

            try
            {
                connection.Open();

                string text = $"Тип накладной: Приходная\n"
                            + $"Наименование: {InputInvoices.SelectedItems[0].SubItems[2].Text}\n"
                            + $"Количество {InputInvoices.SelectedItems[0].SubItems[3].Text}\n"
                            + $"Дата создания: {InputInvoices.SelectedItems[0].SubItems[4].Text}\n"
                            + $"Принял: {InputInvoices.SelectedItems[0].SubItems[5].Text}\n"
                            + $"Сдал: {InputInvoices.SelectedItems[0].SubItems[6].Text}\n";


                new MySqlCommand($"INSERT INTO Archive VALUES('{warehouseId}', '{text}')", connection).ExecuteNonQuery();
                new MySqlCommand($"DELETE FROM Invoices WHERE Warehouse_ID = '{warehouseId}' AND Type = 'Приходная' AND Name = '{InputInvoices.SelectedItems[0].SubItems[2].Text}' AND CreateDate = '{InputInvoices.SelectedItems[0].SubItems[4].Text}'", connection).ExecuteNonQuery();

                InputInvoices.SelectedItems[0].Remove();

                connection.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка");
            }
        }

        private void выводВсегоВТаблицуExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вывод приходных накладных

            // Создаём экземпляр нашего приложения
            MicrosoftExcel.Application excelApp = new MicrosoftExcel.Application();
            // Создаём экземпляр рабочий книги Excel
            MicrosoftExcel.Workbook workBook;
            // Создаём экземпляр листа Excel
            MicrosoftExcel.Worksheet workSheet;

            workBook = excelApp.Workbooks.Add();
            workSheet = (MicrosoftExcel.Worksheet)workBook.Worksheets.get_Item(1);

            int RowOffset = 2;
            workSheet.StandardWidth = 20;
            workSheet.Cells[1, 1] = "Номер";
            workSheet.Cells[1, 2] = "Тип техники";
            workSheet.Cells[1, 3] = "Наименование";
            workSheet.Cells[1, 4] = "Количество";
            workSheet.Cells[1, 5] = "Дата создания";
            workSheet.Cells[1, 6] = "Принял";
            workSheet.Cells[1, 7] = "Сдал";


            int row = 0;
            foreach(ListViewItem item in InputInvoices.Items)
            {
                for (int a = 0; a < 7; a++) {
                    workSheet.Cells[row + RowOffset, a + 1] = item.SubItems[a].Text;
                }

                row++;
            }


            // Открываем созданный excel-файл
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        private void вывестиВсёВТаблицуExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вывод выходных накладных

            // Создаём экземпляр нашего приложения
            MicrosoftExcel.Application excelApp = new MicrosoftExcel.Application();
            // Создаём экземпляр рабочий книги Excel
            MicrosoftExcel.Workbook workBook;
            // Создаём экземпляр листа Excel
            MicrosoftExcel.Worksheet workSheet;

            workBook = excelApp.Workbooks.Add();
            workSheet = (MicrosoftExcel.Worksheet)workBook.Worksheets.get_Item(1);

            int RowOffset = 2;
            workSheet.StandardWidth = 20;
            workSheet.Cells[1, 1] = "Номер";
            workSheet.Cells[1, 2] = "Тип техники";
            workSheet.Cells[1, 3] = "Наименование";
            workSheet.Cells[1, 4] = "Количество";
            workSheet.Cells[1, 5] = "Дата создания";
            workSheet.Cells[1, 6] = "Принял";
            workSheet.Cells[1, 7] = "Сдал";


            int row = 0;
            foreach (ListViewItem item in OutputListView.Items)
            {
                for (int a = 0; a < 7; a++)
                {
                    workSheet.Cells[row + RowOffset, a + 1] = item.SubItems[a].Text;
                }

                row++;
            }


            // Открываем созданный excel-файл
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }
    }
}
