namespace BiotestCompany
{
    partial class SO_Products_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SO_Products_Form));
            this.sAD_1DataSet = new BiotestCompany.SAD_1DataSet();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTSTableAdapter = new BiotestCompany.SAD_1DataSetTableAdapters.PRODUCTSTableAdapter();
            this.pRODUCTTYPESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTYPESTableAdapter = new BiotestCompany.SAD_1DataSetTableAdapters.PRODUCTTYPESTableAdapter();
            this.sAD1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTYPESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfLifeDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAllProducttypesBySupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnSupplierRankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnSupplierRankTableAdapter = new BiotestCompany.SAD_1DataSetTableAdapters.ReturnSupplierRankTableAdapter();
            this.getAllProducttypesBySupplierTableAdapter = new BiotestCompany.SAD_1DataSetTableAdapters.GetAllProducttypesBySupplierTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.amount_label = new System.Windows.Forms.Label();
            this.productName_txt = new System.Windows.Forms.TextBox();
            this.productID_txt = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.productID_label = new System.Windows.Forms.Label();
            this.addProduct_button = new System.Windows.Forms.Button();
            this.currently_label = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.remove_button = new System.Windows.Forms.Button();
            this.finish_button = new System.Windows.Forms.Button();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTYPESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTYPESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllProducttypesBySupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnSupplierRankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sAD_1DataSet
            // 
            this.sAD_1DataSet.DataSetName = "SAD_1DataSet";
            this.sAD_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.sAD_1DataSet;
            // 
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
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
            // sAD1DataSetBindingSource
            // 
            this.sAD1DataSetBindingSource.DataSource = this.sAD_1DataSet;
            this.sAD1DataSetBindingSource.Position = 0;
            // 
            // pRODUCTTYPESBindingSource1
            // 
            this.pRODUCTTYPESBindingSource1.DataMember = "PRODUCTTYPES";
            this.pRODUCTTYPESBindingSource1.DataSource = this.sAD_1DataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierIDDataGridViewTextBoxColumn,
            this.categorialNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.shelfLifeDaysDataGridViewTextBoxColumn,
            this.pricePerUnitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getAllProducttypesBySupplierBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(368, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 164);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "supplierID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // categorialNumberDataGridViewTextBoxColumn
            // 
            this.categorialNumberDataGridViewTextBoxColumn.DataPropertyName = "categorialNumber";
            this.categorialNumberDataGridViewTextBoxColumn.HeaderText = "CategorialNumber";
            this.categorialNumberDataGridViewTextBoxColumn.Name = "categorialNumberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // shelfLifeDaysDataGridViewTextBoxColumn
            // 
            this.shelfLifeDaysDataGridViewTextBoxColumn.DataPropertyName = "shelfLifeDays";
            this.shelfLifeDaysDataGridViewTextBoxColumn.HeaderText = "shelf Life";
            this.shelfLifeDaysDataGridViewTextBoxColumn.Name = "shelfLifeDaysDataGridViewTextBoxColumn";
            // 
            // pricePerUnitDataGridViewTextBoxColumn
            // 
            this.pricePerUnitDataGridViewTextBoxColumn.DataPropertyName = "pricePerUnit";
            this.pricePerUnitDataGridViewTextBoxColumn.HeaderText = "Unit Price";
            this.pricePerUnitDataGridViewTextBoxColumn.Name = "pricePerUnitDataGridViewTextBoxColumn";
            // 
            // getAllProducttypesBySupplierBindingSource
            // 
            this.getAllProducttypesBySupplierBindingSource.DataMember = "GetAllProducttypesBySupplier";
            this.getAllProducttypesBySupplierBindingSource.DataSource = this.sAD_1DataSet;
            // 
            // returnSupplierRankBindingSource
            // 
            this.returnSupplierRankBindingSource.DataMember = "ReturnSupplierRank";
            this.returnSupplierRankBindingSource.DataSource = this.sAD_1DataSet;
            // 
            // returnSupplierRankTableAdapter
            // 
            this.returnSupplierRankTableAdapter.ClearBeforeFill = true;
            // 
            // getAllProducttypesBySupplierTableAdapter
            // 
            this.getAllProducttypesBySupplierTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Offered Products";
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(153, 146);
            this.amount_txt.MaxLength = 9;
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(170, 20);
            this.amount_txt.TabIndex = 26;
            this.amount_txt.TextChanged += new System.EventHandler(this.amount_txt_TextChanged);
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.amount_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.amount_label.Location = new System.Drawing.Point(34, 143);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(72, 21);
            this.amount_label.TabIndex = 29;
            this.amount_label.Text = "Amount";
            // 
            // productName_txt
            // 
            this.productName_txt.Location = new System.Drawing.Point(153, 116);
            this.productName_txt.Name = "productName_txt";
            this.productName_txt.Size = new System.Drawing.Size(170, 20);
            this.productName_txt.TabIndex = 24;
            // 
            // productID_txt
            // 
            this.productID_txt.Location = new System.Drawing.Point(153, 85);
            this.productID_txt.Name = "productID_txt";
            this.productID_txt.Size = new System.Drawing.Size(170, 20);
            this.productID_txt.TabIndex = 22;
            this.productID_txt.TextChanged += new System.EventHandler(this.productID_txt_TextChanged);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.name_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.name_label.Location = new System.Drawing.Point(34, 113);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(120, 21);
            this.name_label.TabIndex = 25;
            this.name_label.Text = "Product Name";
            // 
            // productID_label
            // 
            this.productID_label.AutoSize = true;
            this.productID_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.productID_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.productID_label.Location = new System.Drawing.Point(34, 82);
            this.productID_label.Name = "productID_label";
            this.productID_label.Size = new System.Drawing.Size(91, 21);
            this.productID_label.TabIndex = 23;
            this.productID_label.Text = "Product ID";
            // 
            // addProduct_button
            // 
            this.addProduct_button.BackColor = System.Drawing.Color.MidnightBlue;
            this.addProduct_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProduct_button.FlatAppearance.BorderSize = 2;
            this.addProduct_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addProduct_button.ForeColor = System.Drawing.Color.Lavender;
            this.addProduct_button.Location = new System.Drawing.Point(70, 185);
            this.addProduct_button.Name = "addProduct_button";
            this.addProduct_button.Size = new System.Drawing.Size(211, 51);
            this.addProduct_button.TabIndex = 30;
            this.addProduct_button.Text = "Add Product to Order";
            this.addProduct_button.UseVisualStyleBackColor = false;
            this.addProduct_button.Click += new System.EventHandler(this.addProduct_button_Click);
            // 
            // currently_label
            // 
            this.currently_label.AutoSize = true;
            this.currently_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.currently_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.currently_label.Location = new System.Drawing.Point(29, 296);
            this.currently_label.Name = "currently_label";
            this.currently_label.Size = new System.Drawing.Size(229, 32);
            this.currently_label.TabIndex = 31;
            this.currently_label.Text = "Currently in order:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(38, 348);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(243, 161);
            this.dataGridView2.TabIndex = 32;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick_1);
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.MidnightBlue;
            this.remove_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove_button.FlatAppearance.BorderSize = 2;
            this.remove_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.remove_button.ForeColor = System.Drawing.Color.Lavender;
            this.remove_button.Location = new System.Drawing.Point(299, 480);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(169, 33);
            this.remove_button.TabIndex = 33;
            this.remove_button.Text = "Remove from order";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // finish_button
            // 
            this.finish_button.BackColor = System.Drawing.Color.MidnightBlue;
            this.finish_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finish_button.FlatAppearance.BorderSize = 2;
            this.finish_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.finish_button.ForeColor = System.Drawing.Color.Lavender;
            this.finish_button.Location = new System.Drawing.Point(733, 489);
            this.finish_button.Name = "finish_button";
            this.finish_button.Size = new System.Drawing.Size(79, 33);
            this.finish_button.TabIndex = 37;
            this.finish_button.Text = "Finish";
            this.finish_button.UseVisualStyleBackColor = false;
            this.finish_button.Click += new System.EventHandler(this.finish_button_Click);
            // 
            // searchbar
            // 
            this.searchbar.Location = new System.Drawing.Point(543, 59);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(170, 20);
            this.searchbar.TabIndex = 38;
            this.searchbar.TextChanged += new System.EventHandler(this.searchbar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(364, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Search product type";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BiotestCompany.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(-18, 315);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(934, 231);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // SO_Products_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 544);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchbar);
            this.Controls.Add(this.finish_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.currently_label);
            this.Controls.Add(this.addProduct_button);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.amount_label);
            this.Controls.Add(this.productName_txt);
            this.Controls.Add(this.productID_txt);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.productID_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SO_Products_Form";
            this.Text = "Order Products from Suppliers";
            this.Load += new System.EventHandler(this.SO_Products_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTYPESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTYPESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllProducttypesBySupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnSupplierRankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SAD_1DataSet sAD_1DataSet;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private SAD_1DataSetTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTTYPESBindingSource;
        private SAD_1DataSetTableAdapters.PRODUCTTYPESTableAdapter pRODUCTTYPESTableAdapter;
        private System.Windows.Forms.BindingSource sAD1DataSetBindingSource;
        private System.Windows.Forms.BindingSource pRODUCTTYPESBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource getAllProducttypesBySupplierBindingSource;
        private System.Windows.Forms.BindingSource returnSupplierRankBindingSource;
        private SAD_1DataSetTableAdapters.ReturnSupplierRankTableAdapter returnSupplierRankTableAdapter;
        private SAD_1DataSetTableAdapters.GetAllProducttypesBySupplierTableAdapter getAllProducttypesBySupplierTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.TextBox productName_txt;
        private System.Windows.Forms.TextBox productID_txt;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label productID_label;
        private System.Windows.Forms.Button addProduct_button;
        private System.Windows.Forms.Label currently_label;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button finish_button;
        private System.Windows.Forms.TextBox searchbar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfLifeDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}