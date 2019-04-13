namespace _2015_j_1
{
    partial class teapa
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
            this.turismDataSet2 = new _2015_j_1.TurismDataSet2();
            this.porturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porturiTableAdapter = new _2015_j_1.TurismDataSet2TableAdapters.PorturiTableAdapter();
            this.iDPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turismDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porturiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPortDataGridViewTextBoxColumn,
            this.numeportDataGridViewTextBoxColumn,
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.porturiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // turismDataSet2
            // 
            this.turismDataSet2.DataSetName = "TurismDataSet2";
            this.turismDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // porturiBindingSource
            // 
            this.porturiBindingSource.DataMember = "Porturi";
            this.porturiBindingSource.DataSource = this.turismDataSet2;
            // 
            // porturiTableAdapter
            // 
            this.porturiTableAdapter.ClearBeforeFill = true;
            // 
            // iDPortDataGridViewTextBoxColumn
            // 
            this.iDPortDataGridViewTextBoxColumn.DataPropertyName = "ID_Port";
            this.iDPortDataGridViewTextBoxColumn.HeaderText = "ID_Port";
            this.iDPortDataGridViewTextBoxColumn.Name = "iDPortDataGridViewTextBoxColumn";
            this.iDPortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeportDataGridViewTextBoxColumn
            // 
            this.numeportDataGridViewTextBoxColumn.DataPropertyName = "Nume_port";
            this.numeportDataGridViewTextBoxColumn.HeaderText = "Nume_port";
            this.numeportDataGridViewTextBoxColumn.Name = "numeportDataGridViewTextBoxColumn";
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            this.yDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            // 
            // teapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.dataGridView1);
            this.Name = "teapa";
            this.Text = "s";
            this.Load += new System.EventHandler(this.teapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turismDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porturiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TurismDataSet2 turismDataSet2;
        private System.Windows.Forms.BindingSource porturiBindingSource;
        private TurismDataSet2TableAdapters.PorturiTableAdapter porturiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
    }
}