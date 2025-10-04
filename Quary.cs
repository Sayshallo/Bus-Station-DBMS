using Kursach.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Quary : Form
    {
        string quaryName;
        public Quary(string quaryName)
        {
            InitializeComponent();

            if (quaryName == "driverFullName") 
            {
                driver_viewTableAdapter.Fill(Tables.data.driver_view);
                dataGridView1.DataSource = driver_viewTableAdapter.GetData();
            }
            else if (quaryName == "pathToElabuga")
            {
                path_to_elabugaTableAdapter.Fill(Tables.data.path_to_elabuga);
                dataGridView1.DataSource = path_to_elabugaTableAdapter.GetData();
            }
            else if (quaryName == "tripAllInfo")
            {
                trip_all_infoTableAdapter.Fill(Tables.data.trip_all_info);
                dataGridView1.DataSource = trip_all_infoTableAdapter.GetData();
            }
            else if (quaryName == "fineAllInfo")
            {
                fine_all_infoTableAdapter.Fill(Tables.data.fine_all_info);
                dataGridView1.DataSource = fine_all_infoTableAdapter.GetData();
            }
        }

        private void Quary_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.trip_all_info". При необходимости она может быть перемещена или удалена.
            this.trip_all_infoTableAdapter.Fill(this.dataSet1.trip_all_info);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.fine_all_info". При необходимости она может быть перемещена или удалена.
            this.fine_all_infoTableAdapter.Fill(this.dataSet1.fine_all_info);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.path_to_elabuga". При необходимости она может быть перемещена или удалена.
            this.path_to_elabugaTableAdapter.Fill(this.dataSet1.path_to_elabuga);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.driver_view". При необходимости она может быть перемещена или удалена.
            this.driver_viewTableAdapter.Fill(this.dataSet1.driver_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.bus". При необходимости она может быть перемещена или удалена.
            this.busTableAdapter.Fill(this.dataSet1.bus);
        }
    }
}
