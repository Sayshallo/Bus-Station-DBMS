using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursach
{
    public partial class Form1 : Form
    {
        public static string connectionString;
        public static string user_id;
        public static string user_pass;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_id = textBox1.Text;
            user_pass = textBox2.Text;
            connectionString = $"Server = localhost; Port = 5432; Database = postgres; User Id = {user_id}; Password = {user_pass};";

            NpgsqlConnection connection = new NpgsqlConnection();
            try {
                connection = new NpgsqlConnection(connectionString);
                connection.Open();
                Tables tables = new Tables();
                tables.Show();
                Hide();
            }
            catch (Exception ex) { MessageBox.Show("Неверные данные", "Error", MessageBoxButtons.OK); }
            finally { connection.Close(); }
        }
    }
}
