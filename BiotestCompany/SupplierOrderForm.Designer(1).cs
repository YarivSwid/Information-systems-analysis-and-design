namespace BiotestCompany
{
    partial class SupplierOrderForm
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
            this.sAD_1DataSet = new BiotestCompany.SAD_1DataSet();
            this.getCustomerOrderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCustomerOrderDetailTableAdapter = new BiotestCompany.SAD_1DataSetTableAdapters.getCustomerOrderDetailTableAdapter();
            this.bidIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madeByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerOrderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bidIDDataGridViewTextBoxColumn,
            this.customerOrderIDDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.madeByDataGridViewTextBoxColumn,
            this.paymentTermDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getCustomerOrderDetailBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(134, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // sAD_1DataSet
            // 
            this.sAD_1DataSet.DataSetName = "SAD_1DataSet";
            this.sAD_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getCustomerOrderDetailBindingSource
            // 
            this.getCustomerOrderDetailBindingSource.DataMember = "getCustomerOrderDetail";
            this.getCustomerOrderDetailBindingSource.DataSource = this.sAD_1DataSet;
            // 
            // getCustomerOrderDetailTableAdapter
            // 
            this.getCustomerOrderDetailTableAdapter.ClearBeforeFill = true;
            // 
            // bidIDDataGridViewTextBoxColumn
            // 
            this.bidIDDataGridViewTextBoxColumn.DataPropertyName = "bidID";
            this.bidIDDataGridViewTextBoxColumn.HeaderText = "bidID";
            this.bidIDDataGridViewTextBoxColumn.Name = "bidIDDataGridViewTextBoxColumn";
            // 
            // customerOrderIDDataGridViewTextBoxColumn
            // 
            this.customerOrderIDDataGridViewTextBoxColumn.DataPropertyName = "customerOrderID";
            this.customerOrderIDDataGridViewTextBoxColumn.HeaderText = "customerOrderID";
            this.customerOrderIDDataGridViewTextBoxColumn.Name = "customerOrderIDDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // madeByDataGridViewTextBoxColumn
            // 
            this.madeByDataGridViewTextBoxColumn.DataPropertyName = "madeBy";
            this.madeByDataGridViewTextBoxColumn.HeaderText = "madeBy";
            this.madeByDataGridViewTextBoxColumn.Name = "madeByDataGridViewTextBoxColumn";
            // 
            // paymentTermDataGridViewTextBoxColumn
            // 
            this.paymentTermDataGridViewTextBoxColumn.DataPropertyName = "paymentTerm";
            this.paymentTermDataGridViewTextBoxColumn.HeaderText = "paymentTerm";
            this.paymentTermDataGridViewTextBoxColumn.Name = "paymentTermDataGridViewTextBoxColumn";
            // 
            // SupplierOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 356);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SupplierOrderForm";
            this.Text = "SupplierOrderForm";
            this.Load += new System.EventHandler(this.SupplierOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerOrderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SAD_1DataSet sAD_1DataSet;
        private System.Windows.Forms.BindingSource getCustomerOrderDetailBindingSource;
        private SAD_1DataSetTableAdapters.getCustomerOrderDetailTableAdapter getCustomerOrderDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madeByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTermDataGridViewTextBoxColumn;
    }
}