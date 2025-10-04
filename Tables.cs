using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.TabControl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursach
{
    public partial class Tables : Form
    {
        List<TabPage> allTabPages = new List<TabPage>();
        public string tableName = string.Empty;
        public string tableType = string.Empty;
        DataGridView gridView = null;
        DateTimePicker dateTimePicker;
        public static DataSet1 data = new DataSet1();


        public Tables()
        {
            InitializeComponent();

            tableType = "Main";
            TabPageCollection tabPages = tabControl1.TabPages;
            foreach (TabPage tabPage in tabPages) 
            {
                allTabPages.Add(tabPage);
                if (tabPage.Tag.ToString() == "Manual" || tabPage.Tag.ToString() == "System") { tabPage.Parent = null; }
            }
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.pg_timezone_names". При необходимости она может быть перемещена или удалена.
            this.pg_timezone_namesTableAdapter.Fill(this.dataSet1.pg_timezone_names);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.pg_timezone_abbrevs". При необходимости она может быть перемещена или удалена.
            this.pg_timezone_abbrevsTableAdapter.Fill(this.dataSet1.pg_timezone_abbrevs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.pg_ident_file_mappings". При необходимости она может быть перемещена или удалена.
            this.pg_ident_file_mappingsTableAdapter.Fill(this.dataSet1.pg_ident_file_mappings);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.pg_hba_file_rules". При необходимости она может быть перемещена или удалена.
            this.pg_hba_file_rulesTableAdapter.Fill(this.dataSet1.pg_hba_file_rules);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.pg_config". При необходимости она может быть перемещена или удалена.
            this.pg_configTableAdapter.Fill(this.dataSet1.pg_config);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.pg_available_extensions". При необходимости она может быть перемещена или удалена.
            this.pg_available_extensionsTableAdapter.Fill(this.dataSet1.pg_available_extensions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.pg_available_extension_versions". При необходимости она может быть перемещена или удалена.
            this.pg_available_extension_versionsTableAdapter.Fill(this.dataSet1.pg_available_extension_versions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.path". При необходимости она может быть перемещена или удалена.
            this.pathTableAdapter.Fill(this.dataSet1.path);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.dataSet1.model);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.stamp". При необходимости она может быть перемещена или удалена.
            this.stampTableAdapter.Fill(this.dataSet1.stamp);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.dataSet1.category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.rank". При необходимости она может быть перемещена или удалена.
            this.rankTableAdapter.Fill(this.dataSet1.rank);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.dataSet1.driver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.bus". При необходимости она может быть перемещена или удалена.
            this.busTableAdapter.Fill(this.dataSet1.bus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.fine". При необходимости она может быть перемещена или удалена.
            this.fineTableAdapter.Fill(this.dataSet1.fine);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.trip". При необходимости она может быть перемещена или удалена.
            this.tripTableAdapter.Fill(this.dataSet1.trip);
            WhichDataGrid(tabControl1);
        }

        public void WhichDataGrid(TabControl tabControl)
        {
            tableName = tabControl.SelectedTab.Text.ToLower();

            if (tableName == "рейсы")
            {
                tableName = "trip";
                gridView = dataGridView1;
            }
            else if (tableName == "штрафы")
            {
                tableName = "fine";
                gridView = dataGridView2;
            }
            else if (tableName == "автобусы")
            {
                tableName = "bus";
                gridView = dataGridView3;
            }
            else if (tableName == "водители")
            {
                tableName = "driver";
                gridView = dataGridView4;
            }
            else if (tableName == "маршруты")
            {
                tableName = "path";
                gridView = dataGridView5;
            }
            else if (tableName == "класс водителя")
            {
                tableName = "rank";
                gridView = dataGridView6;
            }
            else if (tableName == "категория водителя")
            {
                tableName = "category";
                gridView = dataGridView7;
            }
            else if (tableName == "модель автобуса")
            {
                tableName = "model";
                gridView = dataGridView8;
            }
            else if (tableName == "вид автобуса")
            {
                tableName = "stamp";
                gridView = dataGridView9;
            }
        }

        private void Tables_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void главныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableType = "Main";
            foreach (TabPage tabPage in allTabPages)
            { if (tabPage.Tag.ToString() == "Main") { tabPage.Parent = tabControl1; } }
            foreach (TabPage tabPage in allTabPages)
            { if (tabPage.Tag.ToString() == "Manual") { tabPage.Parent = null; } }
            foreach (TabPage tabPage in allTabPages)
            { if (tabPage.Tag.ToString() == "System") { tabPage.Parent = null; } }
        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableType = "Manual";
            foreach (TabPage tabPage in allTabPages)
            { if (tabPage.Tag.ToString() == "Manual") { tabPage.Parent = tabControl1; } }
            foreach (TabPage tabPage in allTabPages)
            { if (tabPage.Tag.ToString() == "Main") { tabPage.Parent = null; } }
            foreach (TabPage tabPage in allTabPages)
            { if (tabPage.Tag.ToString() == "System") { tabPage.Parent = null; } }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string delimiter = $"select count(*) from {tableName};";
            int delimiterID = 0;
            bool isDo = false;
            string values = null;
            NpgsqlConnection conn = new NpgsqlConnection(Form1.connectionString);
            NpgsqlCommand comm = new NpgsqlCommand(delimiter, conn);
            conn.Open();
            try { comm.ExecuteNonQuery(); NpgsqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) { delimiterID = reader.GetInt32(0); } }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { conn.Close(); }
            conn.Close();

            string sqlQuery = "";
            string name = "";
            for (int i = delimiterID; i < gridView.Rows.Count - 1; i++)
            {
                sqlQuery = $"INSERT INTO {tableName} VALUES ";
                var cells = gridView.Rows[i].Cells;
                values += "(";
                for (i = 0; i < cells.Count; i++) 
                {
                    if (i == 4 && tableName == "driver") { name = (string)cells[i].Value; }
                    string value = null;
                    if (cells[i].Value.GetType() == typeof(string) || cells[i].Value.GetType() == typeof(DateTime) || cells[i].Value.GetType() == typeof(TimeSpan)) { value = $"\'{cells[i].Value}\'"; }
                    else value = cells[i].Value.ToString();
                    values += $"{value}, ";
                }
                int deletePoint = tableName == "driver" ? 4 : 2;
                values = values.Substring(0, values.Length - deletePoint);
                sqlQuery += $"{values});";
                conn = new NpgsqlConnection(Form1.connectionString);
                conn.Open();
                comm = new NpgsqlCommand(sqlQuery, conn);
                try { comm.ExecuteNonQuery();  isDo = true; }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { conn.Close(); }
            }

            int id = 0;
            for (int i = 0; i < delimiterID; i++)
            {
                if (!isDo) { break; };
                sqlQuery = $"UPDATE {tableName} SET ";
                var cells = gridView.Rows[i].Cells;
                values = "";
                for (int j = 1; j < cells.Count; j++)
                {
                    id = (int)cells[0].Value;
                    if (gridView.Columns[j].DataPropertyName == "name_md5") { break; }
                    values += $"{gridView.Columns[j].DataPropertyName} = ";
                    string value = null;
                    if (cells[j].Value.GetType() == typeof(string) || cells[j].Value.GetType() == typeof(DateTime) || cells[j].Value.GetType() == typeof(TimeSpan)) { value = $"\'{cells[j].Value}\'"; }
                    else value = cells[j].Value.ToString();
                    values += $"{value}, ";
                }
                sqlQuery += $"{values.Remove(values.Length - 2, 2)} WHERE {gridView.Columns[0].DataPropertyName} = {id};";
                conn = new NpgsqlConnection(Form1.connectionString);
                conn.Open();
                comm = new NpgsqlCommand(sqlQuery, conn);
                try { comm.ExecuteNonQuery(); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { conn.Close(); }
            }
            if (isDo) { MessageBox.Show("Вы успешно сохранили изменения", "Оповещение", MessageBoxButtons.OK); }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            WhichDataGrid(tabControl1);

            if (tableName == "bus")
            {
                label2.Visible = true;
                label3.Visible = true;
                pictureBox1.Visible = true;
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
                pictureBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void dataGridView5_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            gridView.Rows[gridView.RowCount-1].Cells[0].Value = gridView.RowCount;
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            gridView.Rows[gridView.RowCount - 1].Cells[0].Value = gridView.RowCount;
        }

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            gridView.Rows[gridView.RowCount - 1].Cells[0].Value = gridView.RowCount;
        }

        private void dataGridView3_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            gridView.Rows[gridView.RowCount - 1].Cells[0].Value = gridView.RowCount;
        }

        private void dataGridView4_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            gridView.Rows[gridView.RowCount - 1].Cells[0].Value = gridView.RowCount;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                dateTimePicker = new DateTimePicker();
                dataGridView1.Controls.Add(dateTimePicker);
                dateTimePicker.Format = DateTimePickerFormat.Short;
                Rectangle rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dateTimePicker.Size = new Size(rectangle.Width, rectangle.Height);
                dateTimePicker.Location = new Point(rectangle.X, rectangle.Y);
                dateTimePicker.CloseUp += new EventHandler(dtPickerClose);
                dateTimePicker.CloseUp += new EventHandler(dtPickerTextChange);
            }
        }

        private void dtPickerClose(object sender, EventArgs e)
        {
            var value = Convert.ToDateTime(dateTimePicker.Value.Date);
            dataGridView1.CurrentCell.Value = value;
        }

        private void dtPickerTextChange(object sender, EventArgs e)
        {
            dateTimePicker.Visible = false;
        }

        public new void Update()
        {
            WhichDataGrid(tabControl1);

            switch (tableName.ToLower())
            {
                case "bus":
                    {
                        busTableAdapter.Fill(data.bus);
                        busBindingSource.DataSource = busTableAdapter.GetData();
                        dataGridView3.DataSource = busBindingSource;
                    }
                    break;
                case "driver":
                    {
                        var let = dataGridView3.Rows;
                        driverTableAdapter.Fill(data.driver);
                        driverBindingSource.DataSource = driverTableAdapter.GetData();
                        dataGridView4.DataSource = driverBindingSource;
                    }
                    break;
                case "path":
                    {
                        pathTableAdapter.Fill(data.path);
                        pathBindingSource.DataSource = pathTableAdapter.GetData();
                        dataGridView5.DataSource = pathBindingSource;
                    }
                    break;
                case "fine":
                    {
                        fineTableAdapter.Fill(data.fine);
                        fineBindingSource.DataSource = fineTableAdapter.GetData();
                        dataGridView2.DataSource = fineBindingSource;
                    }
                    break;
                case "trip":
                    {
                        tripTableAdapter.Fill(data.trip);
                        tripBindingSource.DataSource = tripTableAdapter.GetData();
                        dataGridView1.DataSource = tripBindingSource;
                    }
                    break;
                case "rank":
                    {
                        rankTableAdapter.Fill(data.rank);
                        rankBindingSource.DataSource = rankTableAdapter.GetData();
                        dataGridView6.DataSource = rankBindingSource;
                    }
                    break;
                case "category":
                    {
                        categoryTableAdapter.Fill(data.category);
                        categoryBindingSource.DataSource = categoryTableAdapter.GetData();
                        dataGridView7.DataSource = categoryBindingSource;
                    }
                    break;
                case "stamp":
                    {
                        stampTableAdapter.Fill(data.stamp);
                        stampBindingSource.DataSource = stampTableAdapter.GetData();
                        dataGridView8.DataSource = stampBindingSource;
                    }
                    break;
                case "model":
                    {
                        modelTableAdapter.Fill(data.model);
                        modelBindingSource.DataSource = modelTableAdapter.GetData();
                        dataGridView9.DataSource = modelBindingSource;
                    }
                    break;
                default: break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection(Form1.connectionString);
            conn.Open();
            try
            {
                string sqlQuery = $"SELECT column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = \'{tableName}\' and ordinal_position = 1;";
                string name_id = "";
                NpgsqlCommand comm = new NpgsqlCommand(sqlQuery, conn);
                comm.ExecuteNonQuery();
                NpgsqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) { name_id = reader.GetString(0); }

                conn = new NpgsqlConnection(Form1.connectionString);
                conn.Open();
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить данныую строку?", "Предупреждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sqlQuery = $"delete from {tableName} where {name_id} = {textBox1.Text}";
                    comm = new NpgsqlCommand(sqlQuery, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Вы успешно удалили данные!", "Оповещение", MessageBoxButtons.OK);
                }                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { conn.Close(); }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < gridView.RowCount - 1)
            {
                string img_path = (string)dataGridView3[7, e.RowIndex].Value;
                MemoryStream image = new MemoryStream();
                Bitmap img = new Bitmap(img_path);
                img.Save(image, ImageFormat.Bmp);
                using (var ms = image) { pictureBox1.Image = Image.FromStream(ms); }
            }
            
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            if (e.ColumnIndex == 7)
            {
                var dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    dataGridView3[e.ColumnIndex, e.RowIndex].Value = dialog.FileName;
                }
            }
        }

        private void фИОВодителейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quary quary = new Quary("driverFullName");
            quary.Show();
        }

        private void маршрутыДоЕлабугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quary quary = new Quary("pathToElabuga");
            quary.Show();
        }

        private void рейсамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quary quary = new Quary("tripAllInfo");
            quary.Show();
        }

        private void штрафамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quary quary = new Quary("fineAllInfo");
            quary.Show();
        }

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

        private void системныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection(Form1.connectionString);
            conn.Open();
            string sqlQuery = $"select rolname from pg_user join pg_auth_members on (pg_user.usesysid=pg_auth_members.member) join pg_roles on (pg_roles.oid=pg_auth_members.roleid) where pg_user.usename='{Form1.user_id}';";
            string roleGroup = "";
            NpgsqlCommand comm = new NpgsqlCommand(sqlQuery, conn);
            comm.ExecuteNonQuery();
            NpgsqlDataReader reader = comm.ExecuteReader();
            while (reader.Read()) { roleGroup = reader.GetString(0); }
            if (roleGroup == "admins")
            {
                tableType = "System";
                foreach (TabPage tabPage in allTabPages)
                { if (tabPage.Tag.ToString() == "System") { tabPage.Parent = tabControl1; } }
                foreach (TabPage tabPage in allTabPages)
                { if (tabPage.Tag.ToString() == "Main") { tabPage.Parent = null; } }
                foreach (TabPage tabPage in allTabPages)
                { if (tabPage.Tag.ToString() == "Manual") { tabPage.Parent = null; } }
            }
            else { MessageBox.Show("У вас нет доступа к системным таблицам", "Оповещение", MessageBoxButtons.OK); }
        }
    }
}
