namespace BiotestCompany
{
    partial class CRUDproductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.biotestDataSet = new BiotestCompany.BiotestDataSet();
            this.biotestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_1DataSet3 = new BiotestCompany.SAD_1DataSet3();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTSTableAdapter = new BiotestCompany.SAD_1DataSet3TableAdapters.PRODUCTSTableAdapter();
            this.getAllCustomerOrderProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllCustomerOrderProductsTableAdapter = new BiotestCompany.SAD_1DataSet3TableAdapters.GetAllCustomerOrderProductsTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sAD_1DataSet = new BiotestCompany.SAD_1DataSet();
            this.getCustomerOrderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCustomerOrderDetailsTableAdapter = new BiotestCompany.SAD_1DataSetTableAdapters.getCustomerOrderDetailsTableAdapter();
            this.serialNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierOrderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerOrderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madeByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfLifeDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempCelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightKGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.biotestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biotestDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllCustomerOrderProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerOrderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search product";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // biotestDataSet
            // 
            this.biotestDataSet.DataSetName = "BiotestDataSet";
            this.biotestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biotestDataSetBindingSource
            // 
            this.biotestDataSetBindingSource.DataSource = this.biotestDataSet;
            this.biotestDataSetBindingSource.Position = 0;
            // 
            // sAD_1DataSet3
            // 
            this.sAD_1DataSet3.DataSetName = "SAD_1DataSet3";
            this.sAD_1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.sAD_1DataSet3;
            // 
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // getAllCustomerOrderProductsBindingSource
            // 
            this.getAllCustomerOrderProductsBindingSource.DataMember = "GetAllCustomerOrderProducts";
            this.getAllCustomerOrderProductsBindingSource.DataSource = this.sAD_1DataSet3;
            // 
            // getAllCustomerOrderProductsTableAdapter
            // 
            this.getAllCustomerOrderProductsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNumberDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.categorialNumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn1,
            this.supplierOrderIDDataGridViewTextBoxColumn1,
            this.unitsNumberDataGridViewTextBoxColumn1,
            this.expirationdateDataGridViewTextBoxColumn1,
            this.customerOrderIDDataGridViewTextBoxColumn1,
            this.bidIDDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.madeByDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.paymentTermDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.shelfLifeDaysDataGridViewTextBoxColumn,
            this.tempCelsDataGridViewTextBoxColumn,
            this.weightKGDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.getCustomerOrderDetailsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(21, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1209, 320);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // sAD_1DataSet
            // 
            this.sAD_1DataSet.DataSetName = "SAD_1DataSet";
            this.sAD_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getCustomerOrderDetailsBindingSource
            // 
            this.getCustomerOrderDetailsBindingSource.DataMember = "getCustomerOrderDetails";
            this.getCustomerOrderDetailsBindingSource.DataSource = this.sAD_1DataSet;
            // 
            // getCustomerOrderDetailsTableAdapter
            // 
            this.getCustomerOrderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // serialNumberDataGridViewTextBoxColumn1
            // 
            this.serialNumberDataGridViewTextBoxColumn1.DataPropertyName = "serialNumber";
            this.serialNumberDataGridViewTextBoxColumn1.HeaderText = "serialNumber";
            this.serialNumberDataGridViewTextBoxColumn1.Name = "serialNumberDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categorialNumberDataGridViewTextBoxColumn
            // 
            this.categorialNumberDataGridViewTextBoxColumn.DataPropertyName = "categorialNumber";
            this.categorialNumberDataGridViewTextBoxColumn.HeaderText = "categorialNumber";
            this.categorialNumberDataGridViewTextBoxColumn.Name = "categorialNumberDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            // 
            // supplierOrderIDDataGridViewTextBoxColumn1
            // 
            this.supplierOrderIDDataGridViewTextBoxColumn1.DataPropertyName = "supplierOrderID";
            this.supplierOrderIDDataGridViewTextBoxColumn1.HeaderText = "supplierOrderID";
            this.supplierOrderIDDataGridViewTextBoxColumn1.Name = "supplierOrderIDDataGridViewTextBoxColumn1";
            // 
            // unitsNumberDataGridViewTextBoxColumn1
            // 
            this.unitsNumberDataGridViewTextBoxColumn1.DataPropertyName = "unitsNumber";
            this.unitsNumberDataGridViewTextBoxColumn1.HeaderText = "unitsNumber";
            this.unitsNumberDataGridViewTextBoxColumn1.Name = "unitsNumberDataGridViewTextBoxColumn1";
            // 
            // expirationdateDataGridViewTextBoxColumn1
            // 
            this.expirationdateDataGridViewTextBoxColumn1.DataPropertyName = "expiration_date";
            this.expirationdateDataGridViewTextBoxColumn1.HeaderText = "expiration_date";
            this.expirationdateDataGridViewTextBoxColumn1.Name = "expirationdateDataGridViewTextBoxColumn1";
            // 
            // customerOrderIDDataGridViewTextBoxColumn1
            // 
            this.customerOrderIDDataGridViewTextBoxColumn1.DataPropertyName = "customerOrderID";
            this.customerOrderIDDataGridViewTextBoxColumn1.HeaderText = "customerOrderID";
            this.customerOrderIDDataGridViewTextBoxColumn1.Name = "customerOrderIDDataGridViewTextBoxColumn1";
            // 
            // bidIDDataGridViewTextBoxColumn
            // 
            this.bidIDDataGridViewTextBoxColumn.DataPropertyName = "bidID";
            this.bidIDDataGridViewTextBoxColumn.HeaderText = "bidID";
            this.bidIDDataGridViewTextBoxColumn.Name = "bidIDDataGridViewTextBoxColumn";
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
            // madeByDataGridViewTextBoxColumn
            // 
            this.madeByDataGridViewTextBoxColumn.DataPropertyName = "madeBy";
            this.madeByDataGridViewTextBoxColumn.HeaderText = "madeBy";
            this.madeByDataGridViewTextBoxColumn.Name = "madeByDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // paymentTermDataGridViewTextBoxColumn
            // 
            this.paymentTermDataGridViewTextBoxColumn.DataPropertyName = "paymentTerm";
            this.paymentTermDataGridViewTextBoxColumn.HeaderText = "paymentTerm";
            this.paymentTermDataGridViewTextBoxColumn.Name = "paymentTermDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // shelfLifeDaysDataGridViewTextBoxColumn
            // 
            this.shelfLifeDaysDataGridViewTextBoxColumn.DataPropertyName = "shelfLifeDays";
            this.shelfLifeDaysDataGridViewTextBoxColumn.HeaderText = "shelfLifeDays";
            this.shelfLifeDaysDataGridViewTextBoxColumn.Name = "shelfLifeDaysDataGridViewTextBoxColumn";
            // 
            // tempCelsDataGridViewTextBoxColumn
            // 
            this.tempCelsDataGridViewTextBoxColumn.DataPropertyName = "tempCels";
            this.tempCelsDataGridViewTextBoxColumn.HeaderText = "tempCels";
            this.tempCelsDataGridViewTextBoxColumn.Name = "tempCelsDataGridViewTextBoxColumn";
            // 
            // weightKGDataGridViewTextBoxColumn
            // 
            this.weightKGDataGridViewTextBoxColumn.DataPropertyName = "weightKG";
            this.weightKGDataGridViewTextBoxColumn.HeaderText = "weightKG";
            this.weightKGDataGridViewTextBoxColumn.Name = "weightKGDataGridViewTextBoxColumn";
            // 
            // expirationdateDataGridViewTextBoxColumn
            // 
            this.expirationdateDataGridViewTextBoxColumn.DataPropertyName = "expiration_date";
            this.expirationdateDataGridViewTextBoxColumn.HeaderText = "expiration_date";
            this.expirationdateDataGridViewTextBoxColumn.Name = "expirationdateDataGridViewTextBoxColumn";
            // 
            // customerOrderIDDataGridViewTextBoxColumn
            // 
            this.customerOrderIDDataGridViewTextBoxColumn.DataPropertyName = "customerOrderID";
            this.customerOrderIDDataGridViewTextBoxColumn.HeaderText = "customerOrderID";
            this.customerOrderIDDataGridViewTextBoxColumn.Name = "customerOrderIDDataGridViewTextBoxColumn";
            // 
            // supplierOrderIDDataGridViewTextBoxColumn
            // 
            this.supplierOrderIDDataGridViewTextBoxColumn.DataPropertyName = "supplierOrderID";
            this.supplierOrderIDDataGridViewTextBoxColumn.HeaderText = "supplierOrderID";
            this.supplierOrderIDDataGridViewTextBoxColumn.Name = "supplierOrderIDDataGridViewTextBoxColumn";
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "productType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "productType";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // unitsNumberDataGridViewTextBoxColumn
            // 
            this.unitsNumberDataGridViewTextBoxColumn.DataPropertyName = "unitsNumber";
            this.unitsNumberDataGridViewTextBoxColumn.HeaderText = "unitsNumber";
            this.unitsNumberDataGridViewTextBoxColumn.Name = "unitsNumberDataGridViewTextBoxColumn";
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "serialNumber";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "serialNumber";
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNumberDataGridViewTextBoxColumn,
            this.unitsNumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.supplierOrderIDDataGridViewTextBoxColumn,
            this.customerOrderIDDataGridViewTextBoxColumn,
            this.expirationdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 359);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // CRUDproductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 484);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CRUDproductForm";
            this.Text = "CRUDproductForm";
            this.Load += new System.EventHandler(this.CRUDproductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biotestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biotestDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllCustomerOrderProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerOrderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource biotestDataSetBindingSource;
        private BiotestDataSet biotestDataSet;
        private SAD_1DataSet3 sAD_1DataSet3;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private SAD_1DataSet3TableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private System.Windows.Forms.BindingSource getAllCustomerOrderProductsBindingSource;
        private SAD_1DataSet3TableAdapters.GetAllCustomerOrderProductsTableAdapter getAllCustomerOrderProductsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private SAD_1DataSet sAD_1DataSet;
        private System.Windows.Forms.BindingSource getCustomerOrderDetailsBindingSource;
        private SAD_1DataSetTableAdapters.getCustomerOrderDetailsTableAdapter getCustomerOrderDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierOrderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerOrderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madeByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfLifeDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempCelsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightKGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}