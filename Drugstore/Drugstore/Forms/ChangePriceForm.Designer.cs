namespace Drugstore
{
    partial class ChangePriceForm
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
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceNewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugstoreDataSet3 = new Drugstore.DrugstoreDataSet3();
            this.auditPriceTableAdapter = new Drugstore.DrugstoreDataSet3TableAdapters.AuditPriceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditPriceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.priceOldDataGridViewTextBoxColumn,
            this.priceNewDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.auditPriceBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(471, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // priceOldDataGridViewTextBoxColumn
            // 
            this.priceOldDataGridViewTextBoxColumn.DataPropertyName = "PriceOld";
            this.priceOldDataGridViewTextBoxColumn.HeaderText = "PriceOld";
            this.priceOldDataGridViewTextBoxColumn.Name = "priceOldDataGridViewTextBoxColumn";
            // 
            // priceNewDataGridViewTextBoxColumn
            // 
            this.priceNewDataGridViewTextBoxColumn.DataPropertyName = "PriceNew";
            this.priceNewDataGridViewTextBoxColumn.HeaderText = "PriceNew";
            this.priceNewDataGridViewTextBoxColumn.Name = "priceNewDataGridViewTextBoxColumn";
            // 
            // auditPriceBindingSource
            // 
            this.auditPriceBindingSource.DataMember = "AuditPrice";
            this.auditPriceBindingSource.DataSource = this.drugstoreDataSet3;
            // 
            // drugstoreDataSet3
            // 
            this.drugstoreDataSet3.DataSetName = "DrugstoreDataSet3";
            this.drugstoreDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auditPriceTableAdapter
            // 
            this.auditPriceTableAdapter.ClearBeforeFill = true;
            // 
            // ChangePriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 392);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ChangePriceForm";
            this.Text = "ChangePriceForm";
            this.Load += new System.EventHandler(this.ChangePriceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditPriceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DrugstoreDataSet3 drugstoreDataSet3;
        private System.Windows.Forms.BindingSource auditPriceBindingSource;
        private DrugstoreDataSet3TableAdapters.AuditPriceTableAdapter auditPriceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceNewDataGridViewTextBoxColumn;
    }
}