namespace BiotestCompany
{
    partial class ProductPricingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPricingForm));
            this.sAD_1DataSet = new BiotestCompany.SAD_1DataSet();
            this.pRODUCTTYPESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTYPESTableAdapter = new BiotestCompany.SAD_1DataSetTableAdapters.PRODUCTTYPESTableAdapter();
            this.tableAdapterManager = new BiotestCompany.SAD_1DataSetTableAdapters.TableAdapterManager();
            this.pRODUCTTYPESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBar_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.shippingCost_txt = new System.Windows.Forms.TextBox();
            this.expSales_txt = new System.Windows.Forms.TextBox();
            this.revenue_txt = new System.Windows.Forms.TextBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.method_cmb = new System.Windows.Forms.ComboBox();
            this.weight_lbl = new System.Windows.Forms.Label();
            this.temp_lbl = new System.Windows.Forms.Label();
            this.shelfLife_lbl = new System.Windows.Forms.Label();
            this.prodName_lbl = new System.Windows.Forms.Label();
            this.supPrice_lbl = new System.Windows.Forms.Label();
            this.smartPricing_butt = new System.Windows.Forms.Button();
            this.manualPricing_butt = new System.Windows.Forms.Button();
            this.clear_butt = new System.Windows.Forms.Button();
            this.manualPricing_lbl = new System.Windows.Forms.Label();
            this.enterPrice_txt = new System.Windows.Forms.TextBox();
            this.calcPrice_butt = new System.Windows.Forms.Button();
            this.setPrice_butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTYPESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTYPESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sAD_1DataSet
            // 
            this.sAD_1DataSet.DataSetName = "SAD_1DataSet";
            this.sAD_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTTYPESBindingSource
            // 
            this.pRODUCTTYPESBindingSource.DataMember = "PRODUCTTYPES";
            this.pRODUCTTYPESBindingSource.DataSource = this.sAD_1DataSet;
            // 
            // pRODUCTTYPESTableAdapter
            // 
            this.pRODUCTTYPESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BUSINESSMEETINGSTableAdapter = null;
            this.tableAdapterManager.CHATPARTSTableAdapter = null;
            this.tableAdapterManager.CHATSTableAdapter = null;
            this.tableAdapterManager.CONTACTSTableAdapter = null;
            this.tableAdapterManager.CUSTOMERBIDSTableAdapter = null;
            this.tableAdapterManager.CUSTOMERCONTACTSTableAdapter = null;
            this.tableAdapterManager.CUSTOMERINVITSTableAdapter = null;
            this.tableAdapterManager.CUSTOMERORDERSTableAdapter = null;
            this.tableAdapterManager.CUSTOMERSTableAdapter = null;
            this.tableAdapterManager.DISTRICTSTableAdapter = null;
            this.tableAdapterManager.MESSAGESTableAdapter = null;
            this.tableAdapterManager.PAYTERMSTableAdapter = null;
            this.tableAdapterManager.PRODUCTSTableAdapter = null;
            this.tableAdapterManager.PRODUCTSTATUSESTableAdapter = null;
            this.tableAdapterManager.PRODUCTTYPESTableAdapter = this.pRODUCTTYPESTableAdapter;
            this.tableAdapterManager.ROLETYPESTableAdapter = null;
            this.tableAdapterManager.SUPPLIERBIDSTableAdapter = null;
            this.tableAdapterManager.SUPPLIERCONTACTSTableAdapter = null;
            this.tableAdapterManager.SUPPLIERORDERSTableAdapter = null;
            this.tableAdapterManager.SUPPLIERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BiotestCompany.SAD_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERINVITSTableAdapter = null;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // pRODUCTTYPESDataGridView
            // 
            this.pRODUCTTYPESDataGridView.AutoGenerateColumns = false;
            this.pRODUCTTYPESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pRODUCTTYPESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pRODUCTTYPESDataGridView.DataSource = this.pRODUCTTYPESBindingSource;
            this.pRODUCTTYPESDataGridView.Location = new System.Drawing.Point(345, 72);
            this.pRODUCTTYPESDataGridView.Name = "pRODUCTTYPESDataGridView";
            this.pRODUCTTYPESDataGridView.Size = new System.Drawing.Size(844, 220);
            this.pRODUCTTYPESDataGridView.TabIndex = 23;
            this.pRODUCTTYPESDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pRODUCTTYPESDataGridView_CellContentClick);
            this.pRODUCTTYPESDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pRODUCTTYPESDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "categorialNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "categorialNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "shelfLifeDays";
            this.dataGridViewTextBoxColumn3.HeaderText = "shelfLifeDays";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tempCels";
            this.dataGridViewTextBoxColumn4.HeaderText = "tempCels";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "weightKG";
            this.dataGridViewTextBoxColumn5.HeaderText = "weightKG";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn6.HeaderText = "price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(342, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Search by name";
            // 
            // SearchBar_txt
            // 
            this.SearchBar_txt.Location = new System.Drawing.Point(468, 34);
            this.SearchBar_txt.Name = "SearchBar_txt";
            this.SearchBar_txt.Size = new System.Drawing.Size(211, 20);
            this.SearchBar_txt.TabIndex = 2;
            this.SearchBar_txt.TextChanged += new System.EventHandler(this.SearchBar_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Product Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(38, 134);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(86, 13);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Supplier price ($)";
            this.lbl1.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(38, 195);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(76, 13);
            this.lbl3.TabIndex = 13;
            this.lbl3.Text = "Required temp";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(38, 226);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(62, 13);
            this.lbl4.TabIndex = 15;
            this.lbl4.Text = "Weight (kg)";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(38, 165);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(83, 13);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "Shelf life in days";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(38, 261);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(71, 13);
            this.lbl5.TabIndex = 35;
            this.lbl5.Text = "Shipping cost";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(38, 326);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(62, 13);
            this.lbl7.TabIndex = 21;
            this.lbl7.Text = "Revenue %";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(38, 294);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(99, 13);
            this.lbl6.TabIndex = 19;
            this.lbl6.Text = "Expected sales vol.";
            // 
            // shippingCost_txt
            // 
            this.shippingCost_txt.Location = new System.Drawing.Point(170, 254);
            this.shippingCost_txt.Name = "shippingCost_txt";
            this.shippingCost_txt.Size = new System.Drawing.Size(120, 20);
            this.shippingCost_txt.TabIndex = 3;
            this.shippingCost_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shippingCost_txt_KeyPress);
            // 
            // expSales_txt
            // 
            this.expSales_txt.Location = new System.Drawing.Point(170, 287);
            this.expSales_txt.Name = "expSales_txt";
            this.expSales_txt.Size = new System.Drawing.Size(120, 20);
            this.expSales_txt.TabIndex = 4;
            this.expSales_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.expSales_txt_KeyPress);
            // 
            // revenue_txt
            // 
            this.revenue_txt.Location = new System.Drawing.Point(170, 319);
            this.revenue_txt.Name = "revenue_txt";
            this.revenue_txt.Size = new System.Drawing.Size(120, 20);
            this.revenue_txt.TabIndex = 5;
            this.revenue_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.revenue_txt_KeyPress);
            this.revenue_txt.Leave += new System.EventHandler(this.revenue_txt_Leave);
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(38, 357);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(118, 13);
            this.lbl8.TabIndex = 22;
            this.lbl8.Text = "Choose pricing method:";
            // 
            // method_cmb
            // 
            this.method_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.method_cmb.FormattingEnabled = true;
            this.method_cmb.Items.AddRange(new object[] {
            "Default",
            "Short shelf life emphasis",
            "Shipping cost emphasis",
            "Small volume emphasis"});
            this.method_cmb.Location = new System.Drawing.Point(169, 349);
            this.method_cmb.Name = "method_cmb";
            this.method_cmb.Size = new System.Drawing.Size(121, 21);
            this.method_cmb.TabIndex = 6;
            this.method_cmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // weight_lbl
            // 
            this.weight_lbl.AutoSize = true;
            this.weight_lbl.Location = new System.Drawing.Point(167, 226);
            this.weight_lbl.Name = "weight_lbl";
            this.weight_lbl.Size = new System.Drawing.Size(0, 13);
            this.weight_lbl.TabIndex = 16;
            // 
            // temp_lbl
            // 
            this.temp_lbl.AutoSize = true;
            this.temp_lbl.Location = new System.Drawing.Point(167, 195);
            this.temp_lbl.Name = "temp_lbl";
            this.temp_lbl.Size = new System.Drawing.Size(0, 13);
            this.temp_lbl.TabIndex = 14;
            // 
            // shelfLife_lbl
            // 
            this.shelfLife_lbl.AutoSize = true;
            this.shelfLife_lbl.Location = new System.Drawing.Point(167, 165);
            this.shelfLife_lbl.Name = "shelfLife_lbl";
            this.shelfLife_lbl.Size = new System.Drawing.Size(0, 13);
            this.shelfLife_lbl.TabIndex = 12;
            this.shelfLife_lbl.Click += new System.EventHandler(this.label13_Click);
            // 
            // prodName_lbl
            // 
            this.prodName_lbl.AutoSize = true;
            this.prodName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.prodName_lbl.Location = new System.Drawing.Point(58, 100);
            this.prodName_lbl.Name = "prodName_lbl";
            this.prodName_lbl.Size = new System.Drawing.Size(0, 17);
            this.prodName_lbl.TabIndex = 8;
            // 
            // supPrice_lbl
            // 
            this.supPrice_lbl.AutoSize = true;
            this.supPrice_lbl.Location = new System.Drawing.Point(167, 134);
            this.supPrice_lbl.Name = "supPrice_lbl";
            this.supPrice_lbl.Size = new System.Drawing.Size(0, 13);
            this.supPrice_lbl.TabIndex = 10;
            // 
            // smartPricing_butt
            // 
            this.smartPricing_butt.Location = new System.Drawing.Point(40, 66);
            this.smartPricing_butt.Name = "smartPricing_butt";
            this.smartPricing_butt.Size = new System.Drawing.Size(106, 23);
            this.smartPricing_butt.TabIndex = 0;
            this.smartPricing_butt.Text = "Smart Pricing";
            this.smartPricing_butt.UseVisualStyleBackColor = true;
            this.smartPricing_butt.Click += new System.EventHandler(this.smartPricing_butt_Click);
            // 
            // manualPricing_butt
            // 
            this.manualPricing_butt.Location = new System.Drawing.Point(176, 66);
            this.manualPricing_butt.Name = "manualPricing_butt";
            this.manualPricing_butt.Size = new System.Drawing.Size(106, 23);
            this.manualPricing_butt.TabIndex = 1;
            this.manualPricing_butt.Text = "Manual Pricing";
            this.manualPricing_butt.UseVisualStyleBackColor = true;
            this.manualPricing_butt.Click += new System.EventHandler(this.manualPricing_butt_Click);
            // 
            // clear_butt
            // 
            this.clear_butt.Location = new System.Drawing.Point(701, 32);
            this.clear_butt.Name = "clear_butt";
            this.clear_butt.Size = new System.Drawing.Size(75, 23);
            this.clear_butt.TabIndex = 11;
            this.clear_butt.Text = "Clean";
            this.clear_butt.UseVisualStyleBackColor = true;
            this.clear_butt.Click += new System.EventHandler(this.clear_butt_Click);
            // 
            // manualPricing_lbl
            // 
            this.manualPricing_lbl.AutoSize = true;
            this.manualPricing_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.manualPricing_lbl.Location = new System.Drawing.Point(38, 261);
            this.manualPricing_lbl.Name = "manualPricing_lbl";
            this.manualPricing_lbl.Size = new System.Drawing.Size(69, 13);
            this.manualPricing_lbl.TabIndex = 17;
            this.manualPricing_lbl.Text = "Enter price";
            this.manualPricing_lbl.Visible = false;
            this.manualPricing_lbl.Click += new System.EventHandler(this.manualPricing_lbl_Click);
            // 
            // enterPrice_txt
            // 
            this.enterPrice_txt.Location = new System.Drawing.Point(170, 254);
            this.enterPrice_txt.Name = "enterPrice_txt";
            this.enterPrice_txt.Size = new System.Drawing.Size(120, 20);
            this.enterPrice_txt.TabIndex = 10;
            this.enterPrice_txt.Visible = false;
            this.enterPrice_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterPrice_txt_KeyPress);
            // 
            // calcPrice_butt
            // 
            this.calcPrice_butt.Location = new System.Drawing.Point(104, 387);
            this.calcPrice_butt.Name = "calcPrice_butt";
            this.calcPrice_butt.Size = new System.Drawing.Size(106, 23);
            this.calcPrice_butt.TabIndex = 7;
            this.calcPrice_butt.Text = "Calculate Price";
            this.calcPrice_butt.UseVisualStyleBackColor = true;
            this.calcPrice_butt.Click += new System.EventHandler(this.calcPrice_butt_Click);
            // 
            // setPrice_butt
            // 
            this.setPrice_butt.Location = new System.Drawing.Point(104, 285);
            this.setPrice_butt.Name = "setPrice_butt";
            this.setPrice_butt.Size = new System.Drawing.Size(106, 23);
            this.setPrice_butt.TabIndex = 8;
            this.setPrice_butt.Text = "Set Price";
            this.setPrice_butt.UseVisualStyleBackColor = true;
            this.setPrice_butt.Visible = false;
            // 
            // ProductPricingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 617);
            this.Controls.Add(this.setPrice_butt);
            this.Controls.Add(this.calcPrice_butt);
            this.Controls.Add(this.enterPrice_txt);
            this.Controls.Add(this.manualPricing_lbl);
            this.Controls.Add(this.clear_butt);
            this.Controls.Add(this.manualPricing_butt);
            this.Controls.Add(this.smartPricing_butt);
            this.Controls.Add(this.supPrice_lbl);
            this.Controls.Add(this.prodName_lbl);
            this.Controls.Add(this.shelfLife_lbl);
            this.Controls.Add(this.temp_lbl);
            this.Controls.Add(this.weight_lbl);
            this.Controls.Add(this.method_cmb);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.revenue_txt);
            this.Controls.Add(this.expSales_txt);
            this.Controls.Add(this.shippingCost_txt);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBar_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pRODUCTTYPESDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductPricingForm";
            this.Text = "1";
            this.Load += new System.EventHandler(this.ProductPricingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTYPESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTYPESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SAD_1DataSet sAD_1DataSet;
        private System.Windows.Forms.BindingSource pRODUCTTYPESBindingSource;
        private SAD_1DataSetTableAdapters.PRODUCTTYPESTableAdapter pRODUCTTYPESTableAdapter;
        private SAD_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pRODUCTTYPESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchBar_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox shippingCost_txt;
        private System.Windows.Forms.TextBox expSales_txt;
        private System.Windows.Forms.TextBox revenue_txt;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.ComboBox method_cmb;
        private System.Windows.Forms.Label weight_lbl;
        private System.Windows.Forms.Label temp_lbl;
        private System.Windows.Forms.Label shelfLife_lbl;
        private System.Windows.Forms.Label prodName_lbl;
        private System.Windows.Forms.Label supPrice_lbl;
        private System.Windows.Forms.Button smartPricing_butt;
        private System.Windows.Forms.Button manualPricing_butt;
        private System.Windows.Forms.Button clear_butt;
        private System.Windows.Forms.Label manualPricing_lbl;
        private System.Windows.Forms.TextBox enterPrice_txt;
        private System.Windows.Forms.Button calcPrice_butt;
        private System.Windows.Forms.Button setPrice_butt;
    }
}