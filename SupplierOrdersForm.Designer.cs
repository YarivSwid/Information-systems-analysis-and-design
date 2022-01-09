namespace BiotestCompany
{
    partial class SupplierOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierOrdersForm));
            this.sUPPLIERORDERSDataGridView = new System.Windows.Forms.DataGridView();
            this.supplierOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punctualityScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualityScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPLIERORDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_1DataSet = new BiotestCompany.SAD_1DataSet();
            this.qualityScore = new System.Windows.Forms.Label();
            this.punctualityScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.puncValue = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.qualValue = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBar_txt = new System.Windows.Forms.TextBox();
            this.orderValue_txt = new System.Windows.Forms.TextBox();
            this.arrivalDate_label = new System.Windows.Forms.Label();
            this.arrivalDate_picker = new System.Windows.Forms.DateTimePicker();
            this.shippingCost_txt = new System.Windows.Forms.TextBox();
            this.orderID_txt = new System.Windows.Forms.TextBox();
            this.supplierID_label = new System.Windows.Forms.Label();
            this.shippingCost_label = new System.Windows.Forms.Label();
            this.orderValue_label = new System.Windows.Forms.Label();
            this.orderDate_label = new System.Windows.Forms.Label();
            this.orderID_label = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.orderDate_picker = new System.Windows.Forms.DateTimePicker();
            this.addProducts_button = new System.Windows.Forms.Button();
            this.sUPPLIERORDERSTableAdapter = new BiotestCompany.SAD_1DataSetTableAdapters.SUPPLIERORDERSTableAdapter();
            this.tableAdapterManager = new BiotestCompany.SAD_1DataSetTableAdapters.TableAdapterManager();
            this.supplierID_Box = new System.Windows.Forms.TextBox();
            this.Out_Butt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERORDERSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERORDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sUPPLIERORDERSDataGridView
            // 
            this.sUPPLIERORDERSDataGridView.AutoGenerateColumns = false;
            this.sUPPLIERORDERSDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.sUPPLIERORDERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sUPPLIERORDERSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierOrderIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.arrivalDateDataGridViewTextBoxColumn,
            this.shippingCostDataGridViewTextBoxColumn,
            this.orderValueDataGridViewTextBoxColumn,
            this.punctualityScoreDataGridViewTextBoxColumn,
            this.qualityScoreDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn});
            this.sUPPLIERORDERSDataGridView.DataSource = this.sUPPLIERORDERSBindingSource;
            this.sUPPLIERORDERSDataGridView.Location = new System.Drawing.Point(432, 119);
            this.sUPPLIERORDERSDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.sUPPLIERORDERSDataGridView.Name = "sUPPLIERORDERSDataGridView";
            this.sUPPLIERORDERSDataGridView.Size = new System.Drawing.Size(1147, 370);
            this.sUPPLIERORDERSDataGridView.TabIndex = 1;
            this.sUPPLIERORDERSDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sUPPLIERORDERSDataGridView_CellClick);
            this.sUPPLIERORDERSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sUPPLIERORDERSDataGridView_CellContentClick);
            this.sUPPLIERORDERSDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sUPPLIERORDERSDataGridView_CellDoubleClick);
            // 
            // supplierOrderIDDataGridViewTextBoxColumn
            // 
            this.supplierOrderIDDataGridViewTextBoxColumn.DataPropertyName = "supplierOrderID";
            this.supplierOrderIDDataGridViewTextBoxColumn.HeaderText = "supplierOrderID";
            this.supplierOrderIDDataGridViewTextBoxColumn.Name = "supplierOrderIDDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "orderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "orderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "arrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "arrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            // 
            // shippingCostDataGridViewTextBoxColumn
            // 
            this.shippingCostDataGridViewTextBoxColumn.DataPropertyName = "shippingCost";
            this.shippingCostDataGridViewTextBoxColumn.HeaderText = "shippingCost";
            this.shippingCostDataGridViewTextBoxColumn.Name = "shippingCostDataGridViewTextBoxColumn";
            // 
            // orderValueDataGridViewTextBoxColumn
            // 
            this.orderValueDataGridViewTextBoxColumn.DataPropertyName = "orderValue";
            this.orderValueDataGridViewTextBoxColumn.HeaderText = "orderValue";
            this.orderValueDataGridViewTextBoxColumn.Name = "orderValueDataGridViewTextBoxColumn";
            // 
            // punctualityScoreDataGridViewTextBoxColumn
            // 
            this.punctualityScoreDataGridViewTextBoxColumn.DataPropertyName = "punctualityScore";
            this.punctualityScoreDataGridViewTextBoxColumn.HeaderText = "punctualityScore";
            this.punctualityScoreDataGridViewTextBoxColumn.Name = "punctualityScoreDataGridViewTextBoxColumn";
            // 
            // qualityScoreDataGridViewTextBoxColumn
            // 
            this.qualityScoreDataGridViewTextBoxColumn.DataPropertyName = "qualityScore";
            this.qualityScoreDataGridViewTextBoxColumn.HeaderText = "qualityScore";
            this.qualityScoreDataGridViewTextBoxColumn.Name = "qualityScoreDataGridViewTextBoxColumn";
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "supplierID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            // 
            // sUPPLIERORDERSBindingSource
            // 
            this.sUPPLIERORDERSBindingSource.DataMember = "SUPPLIERORDERS";
            this.sUPPLIERORDERSBindingSource.DataSource = this.sAD_1DataSet;
            // 
            // sAD_1DataSet
            // 
            this.sAD_1DataSet.DataSetName = "SAD_1DataSet";
            this.sAD_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qualityScore
            // 
            this.qualityScore.AutoSize = true;
            this.qualityScore.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.qualityScore.ForeColor = System.Drawing.Color.MidnightBlue;
            this.qualityScore.Location = new System.Drawing.Point(313, 372);
            this.qualityScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qualityScore.Name = "qualityScore";
            this.qualityScore.Size = new System.Drawing.Size(99, 19);
            this.qualityScore.TabIndex = 26;
            this.qualityScore.Text = "Quality Score";
            // 
            // punctualityScore
            // 
            this.punctualityScore.AutoSize = true;
            this.punctualityScore.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.punctualityScore.ForeColor = System.Drawing.Color.MidnightBlue;
            this.punctualityScore.Location = new System.Drawing.Point(92, 372);
            this.punctualityScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.punctualityScore.Name = "punctualityScore";
            this.punctualityScore.Size = new System.Drawing.Size(125, 19);
            this.punctualityScore.TabIndex = 25;
            this.punctualityScore.Text = "Punctuality Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 41);
            this.label1.TabIndex = 24;
            this.label1.Text = "Supplier Orders Information";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(28, 357);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 172);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // puncValue
            // 
            this.puncValue.AutoSize = true;
            this.puncValue.Font = new System.Drawing.Font("Adobe Heiti Std R", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puncValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.puncValue.Location = new System.Drawing.Point(88, 393);
            this.puncValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.puncValue.Name = "puncValue";
            this.puncValue.Size = new System.Drawing.Size(63, 43);
            this.puncValue.TabIndex = 34;
            this.puncValue.Text = "AA";
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(251, 357);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(56, 172);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // qualValue
            // 
            this.qualValue.AutoSize = true;
            this.qualValue.Font = new System.Drawing.Font("Adobe Heiti Std R", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.qualValue.Location = new System.Drawing.Point(311, 393);
            this.qualValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qualValue.Name = "qualValue";
            this.qualValue.Size = new System.Drawing.Size(63, 43);
            this.qualValue.TabIndex = 36;
            this.qualValue.Text = "AA";
            this.qualValue.Click += new System.EventHandler(this.qualValue_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(913, 63);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 36);
            this.button2.TabIndex = 39;
            this.button2.Text = "Clean";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(432, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Search By Order ID";
            // 
            // SearchBar_txt
            // 
            this.SearchBar_txt.Location = new System.Drawing.Point(628, 73);
            this.SearchBar_txt.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBar_txt.Name = "SearchBar_txt";
            this.SearchBar_txt.Size = new System.Drawing.Size(280, 22);
            this.SearchBar_txt.TabIndex = 0;
            this.SearchBar_txt.TextChanged += new System.EventHandler(this.SearchBar_txt_TextChanged);
            // 
            // orderValue_txt
            // 
            this.orderValue_txt.Location = new System.Drawing.Point(179, 272);
            this.orderValue_txt.Margin = new System.Windows.Forms.Padding(4);
            this.orderValue_txt.MaxLength = 9;
            this.orderValue_txt.Name = "orderValue_txt";
            this.orderValue_txt.Size = new System.Drawing.Size(225, 22);
            this.orderValue_txt.TabIndex = 5;
            // 
            // arrivalDate_label
            // 
            this.arrivalDate_label.AutoSize = true;
            this.arrivalDate_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.arrivalDate_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.arrivalDate_label.Location = new System.Drawing.Point(20, 191);
            this.arrivalDate_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arrivalDate_label.Name = "arrivalDate_label";
            this.arrivalDate_label.Size = new System.Drawing.Size(127, 28);
            this.arrivalDate_label.TabIndex = 52;
            this.arrivalDate_label.Text = "Arrival Date";
            // 
            // arrivalDate_picker
            // 
            this.arrivalDate_picker.Location = new System.Drawing.Point(179, 194);
            this.arrivalDate_picker.Margin = new System.Windows.Forms.Padding(4);
            this.arrivalDate_picker.Name = "arrivalDate_picker";
            this.arrivalDate_picker.Size = new System.Drawing.Size(225, 22);
            this.arrivalDate_picker.TabIndex = 3;
            this.arrivalDate_picker.ValueChanged += new System.EventHandler(this.arrivalDate_picker_ValueChanged);
            // 
            // shippingCost_txt
            // 
            this.shippingCost_txt.Location = new System.Drawing.Point(179, 233);
            this.shippingCost_txt.Margin = new System.Windows.Forms.Padding(4);
            this.shippingCost_txt.Name = "shippingCost_txt";
            this.shippingCost_txt.Size = new System.Drawing.Size(225, 22);
            this.shippingCost_txt.TabIndex = 4;
            // 
            // orderID_txt
            // 
            this.orderID_txt.Location = new System.Drawing.Point(179, 119);
            this.orderID_txt.Margin = new System.Windows.Forms.Padding(4);
            this.orderID_txt.Name = "orderID_txt";
            this.orderID_txt.Size = new System.Drawing.Size(225, 22);
            this.orderID_txt.TabIndex = 1;
            this.orderID_txt.TextChanged += new System.EventHandler(this.orderID_txt_TextChanged);
            // 
            // supplierID_label
            // 
            this.supplierID_label.AutoSize = true;
            this.supplierID_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.supplierID_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.supplierID_label.Location = new System.Drawing.Point(20, 313);
            this.supplierID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supplierID_label.Name = "supplierID_label";
            this.supplierID_label.Size = new System.Drawing.Size(117, 28);
            this.supplierID_label.TabIndex = 50;
            this.supplierID_label.Text = "Supplier ID";
            // 
            // shippingCost_label
            // 
            this.shippingCost_label.AutoSize = true;
            this.shippingCost_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.shippingCost_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.shippingCost_label.Location = new System.Drawing.Point(20, 229);
            this.shippingCost_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shippingCost_label.Name = "shippingCost_label";
            this.shippingCost_label.Size = new System.Drawing.Size(142, 28);
            this.shippingCost_label.TabIndex = 48;
            this.shippingCost_label.Text = "Shipping Cost";
            this.shippingCost_label.Click += new System.EventHandler(this.label6_Click);
            // 
            // orderValue_label
            // 
            this.orderValue_label.AutoSize = true;
            this.orderValue_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.orderValue_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.orderValue_label.Location = new System.Drawing.Point(20, 272);
            this.orderValue_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderValue_label.Name = "orderValue_label";
            this.orderValue_label.Size = new System.Drawing.Size(123, 28);
            this.orderValue_label.TabIndex = 46;
            this.orderValue_label.Text = "Order Value";
            // 
            // orderDate_label
            // 
            this.orderDate_label.AutoSize = true;
            this.orderDate_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.orderDate_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.orderDate_label.Location = new System.Drawing.Point(20, 154);
            this.orderDate_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderDate_label.Name = "orderDate_label";
            this.orderDate_label.Size = new System.Drawing.Size(117, 28);
            this.orderDate_label.TabIndex = 44;
            this.orderDate_label.Text = "Order Date";
            // 
            // orderID_label
            // 
            this.orderID_label.AutoSize = true;
            this.orderID_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.orderID_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.orderID_label.Location = new System.Drawing.Point(20, 116);
            this.orderID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderID_label.Name = "orderID_label";
            this.orderID_label.Size = new System.Drawing.Size(93, 28);
            this.orderID_label.TabIndex = 42;
            this.orderID_label.Text = "Order ID";
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.MidnightBlue;
            this.update_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.update_button.ForeColor = System.Drawing.Color.Lavender;
            this.update_button.Location = new System.Drawing.Point(35, 620);
            this.update_button.Margin = new System.Windows.Forms.Padding(4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(273, 71);
            this.update_button.TabIndex = 10;
            this.update_button.Text = "Update Order";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // orderDate_picker
            // 
            this.orderDate_picker.Enabled = false;
            this.orderDate_picker.Location = new System.Drawing.Point(179, 156);
            this.orderDate_picker.Margin = new System.Windows.Forms.Padding(4);
            this.orderDate_picker.Name = "orderDate_picker";
            this.orderDate_picker.Size = new System.Drawing.Size(225, 22);
            this.orderDate_picker.TabIndex = 54;
            this.orderDate_picker.ValueChanged += new System.EventHandler(this.orderDate_picker_ValueChanged);
            // 
            // addProducts_button
            // 
            this.addProducts_button.BackColor = System.Drawing.Color.MidnightBlue;
            this.addProducts_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProducts_button.FlatAppearance.BorderSize = 2;
            this.addProducts_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addProducts_button.ForeColor = System.Drawing.Color.Lavender;
            this.addProducts_button.Location = new System.Drawing.Point(35, 553);
            this.addProducts_button.Margin = new System.Windows.Forms.Padding(4);
            this.addProducts_button.Name = "addProducts_button";
            this.addProducts_button.Size = new System.Drawing.Size(273, 54);
            this.addProducts_button.TabIndex = 55;
            this.addProducts_button.Text = "Add products to order";
            this.addProducts_button.UseVisualStyleBackColor = false;
            this.addProducts_button.Click += new System.EventHandler(this.addProducts_button_Click);
            // 
            // sUPPLIERORDERSTableAdapter
            // 
            this.sUPPLIERORDERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BIDDETAILSTableAdapter = null;
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
            this.tableAdapterManager.PRODUCTTYPESTableAdapter = null;
            this.tableAdapterManager.ROLETYPESTableAdapter = null;
            this.tableAdapterManager.SUPPLIERBIDSTableAdapter = null;
            this.tableAdapterManager.SUPPLIERCONTACTSTableAdapter = null;
            this.tableAdapterManager.SUPPLIERORDERSTableAdapter = this.sUPPLIERORDERSTableAdapter;
            this.tableAdapterManager.SUPPLIERPRODUCTTYPESTableAdapter = null;
            this.tableAdapterManager.SUPPLIERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BiotestCompany.SAD_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERINVITSTableAdapter = null;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // supplierID_Box
            // 
            this.supplierID_Box.Location = new System.Drawing.Point(179, 311);
            this.supplierID_Box.Margin = new System.Windows.Forms.Padding(4);
            this.supplierID_Box.MaxLength = 9;
            this.supplierID_Box.Name = "supplierID_Box";
            this.supplierID_Box.Size = new System.Drawing.Size(225, 22);
            this.supplierID_Box.TabIndex = 56;
            // 
            // Out_Butt
            // 
            this.Out_Butt.BackColor = System.Drawing.Color.MidnightBlue;
            this.Out_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Out_Butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Out_Butt.ForeColor = System.Drawing.Color.Lavender;
            this.Out_Butt.Location = new System.Drawing.Point(1423, 612);
            this.Out_Butt.Margin = new System.Windows.Forms.Padding(4);
            this.Out_Butt.Name = "Out_Butt";
            this.Out_Butt.Size = new System.Drawing.Size(156, 79);
            this.Out_Butt.TabIndex = 57;
            this.Out_Butt.Text = "Finished";
            this.Out_Butt.UseVisualStyleBackColor = false;
            this.Out_Butt.Click += new System.EventHandler(this.Out_Butt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BiotestCompany.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(-72, 450);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1817, 284);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // SupplierOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 731);
            this.Controls.Add(this.Out_Butt);
            this.Controls.Add(this.supplierID_Box);
            this.Controls.Add(this.addProducts_button);
            this.Controls.Add(this.orderDate_picker);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.orderValue_txt);
            this.Controls.Add(this.arrivalDate_label);
            this.Controls.Add(this.arrivalDate_picker);
            this.Controls.Add(this.shippingCost_txt);
            this.Controls.Add(this.orderID_txt);
            this.Controls.Add(this.supplierID_label);
            this.Controls.Add(this.shippingCost_label);
            this.Controls.Add(this.orderValue_label);
            this.Controls.Add(this.orderDate_label);
            this.Controls.Add(this.orderID_label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchBar_txt);
            this.Controls.Add(this.qualValue);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.puncValue);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.qualityScore);
            this.Controls.Add(this.punctualityScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sUPPLIERORDERSDataGridView);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SupplierOrdersForm";
            this.Text = "Supplier Orders";
            this.Load += new System.EventHandler(this.SupplierOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERORDERSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERORDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SAD_1DataSet sAD_1DataSet;
        private System.Windows.Forms.BindingSource sUPPLIERORDERSBindingSource;
        private SAD_1DataSetTableAdapters.SUPPLIERORDERSTableAdapter sUPPLIERORDERSTableAdapter;
        private SAD_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sUPPLIERORDERSDataGridView;
        private System.Windows.Forms.Label qualityScore;
        private System.Windows.Forms.Label punctualityScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label puncValue;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label qualValue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchBar_txt;
        private System.Windows.Forms.TextBox orderValue_txt;
        private System.Windows.Forms.Label arrivalDate_label;
        private System.Windows.Forms.DateTimePicker arrivalDate_picker;
        private System.Windows.Forms.TextBox shippingCost_txt;
        private System.Windows.Forms.TextBox orderID_txt;
        private System.Windows.Forms.Label supplierID_label;
        private System.Windows.Forms.Label shippingCost_label;
        private System.Windows.Forms.Label orderValue_label;
        private System.Windows.Forms.Label orderDate_label;
        private System.Windows.Forms.Label orderID_label;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.DateTimePicker orderDate_picker;
        private System.Windows.Forms.Button addProducts_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn punctualityScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualityScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox supplierID_Box;
        private System.Windows.Forms.Button Out_Butt;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}