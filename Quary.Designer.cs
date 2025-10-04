namespace Kursach
{
    partial class Quary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new Kursach.DataSet1();
            this.busBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busTableAdapter = new Kursach.DataSet1TableAdapters.busTableAdapter();
            this.busBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.driverviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driver_viewTableAdapter = new Kursach.DataSet1TableAdapters.driver_viewTableAdapter();
            this.pathtoelabugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.path_to_elabugaTableAdapter = new Kursach.DataSet1TableAdapters.path_to_elabugaTableAdapter();
            this.fineallinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fine_all_infoTableAdapter = new Kursach.DataSet1TableAdapters.fine_all_infoTableAdapter();
            this.tripallinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trip_all_infoTableAdapter = new Kursach.DataSet1TableAdapters.trip_all_infoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathtoelabugaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineallinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripallinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // busBindingSource
            // 
            this.busBindingSource.DataMember = "bus";
            this.busBindingSource.DataSource = this.dataSet1;
            // 
            // busTableAdapter
            // 
            this.busTableAdapter.ClearBeforeFill = true;
            // 
            // busBindingSource1
            // 
            this.busBindingSource1.DataMember = "bus";
            this.busBindingSource1.DataSource = this.dataSet1;
            // 
            // driverviewBindingSource
            // 
            this.driverviewBindingSource.DataMember = "driver_view";
            this.driverviewBindingSource.DataSource = this.dataSet1;
            // 
            // driver_viewTableAdapter
            // 
            this.driver_viewTableAdapter.ClearBeforeFill = true;
            // 
            // pathtoelabugaBindingSource
            // 
            this.pathtoelabugaBindingSource.DataMember = "path_to_elabuga";
            this.pathtoelabugaBindingSource.DataSource = this.dataSet1;
            // 
            // path_to_elabugaTableAdapter
            // 
            this.path_to_elabugaTableAdapter.ClearBeforeFill = true;
            // 
            // fineallinfoBindingSource
            // 
            this.fineallinfoBindingSource.DataMember = "fine_all_info";
            this.fineallinfoBindingSource.DataSource = this.dataSet1;
            // 
            // fine_all_infoTableAdapter
            // 
            this.fine_all_infoTableAdapter.ClearBeforeFill = true;
            // 
            // tripallinfoBindingSource
            // 
            this.tripallinfoBindingSource.DataMember = "trip_all_info";
            this.tripallinfoBindingSource.DataSource = this.dataSet1;
            // 
            // trip_all_infoTableAdapter
            // 
            this.trip_all_infoTableAdapter.ClearBeforeFill = true;
            // 
            // Quary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 347);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Quary";
            this.Text = "Quary";
            this.Load += new System.EventHandler(this.Quary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathtoelabugaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineallinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripallinfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource busBindingSource;
        private DataSet1TableAdapters.busTableAdapter busTableAdapter;
        private System.Windows.Forms.BindingSource busBindingSource1;
        private System.Windows.Forms.BindingSource driverviewBindingSource;
        private DataSet1TableAdapters.driver_viewTableAdapter driver_viewTableAdapter;
        private System.Windows.Forms.BindingSource pathtoelabugaBindingSource;
        private DataSet1TableAdapters.path_to_elabugaTableAdapter path_to_elabugaTableAdapter;
        private System.Windows.Forms.BindingSource fineallinfoBindingSource;
        private DataSet1TableAdapters.fine_all_infoTableAdapter fine_all_infoTableAdapter;
        private System.Windows.Forms.BindingSource tripallinfoBindingSource;
        private DataSet1TableAdapters.trip_all_infoTableAdapter trip_all_infoTableAdapter;
    }
}