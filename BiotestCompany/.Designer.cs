namespace BiotestCompany
{
    partial class Form1
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
            this.UpdateCust_butt = new System.Windows.Forms.Button();
            this.DeleteCust_butt = new System.Windows.Forms.Button();
            this.AddCust_butt = new System.Windows.Forms.Button();
            this.search_butt = new System.Windows.Forms.Button();
            this.SearchBar_txt = new System.Windows.Forms.TextBox();
            this.Building_txt = new System.Windows.Forms.TextBox();
            this.DeliveryAdd_txt = new System.Windows.Forms.TextBox();
            this.OrgName_txt = new System.Windows.Forms.TextBox();
            this.CustID_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.District_combobox = new System.Windows.Forms.ComboBox();
            this.RoomNum_txt = new System.Windows.Forms.TextBox();
            this.biotestDataSet = new BiotestCompany.BiotestDataSet();
            this.cUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERSTableAdapter = new BiotestCompany.BiotestDataSetTableAdapters.CUSTOMERSTableAdapter();
            this.tableAdapterManager = new BiotestCompany.BiotestDataSetTableAdapters.TableAdapterManager();
            this.cUSTOMERSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Out_Butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.biotestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateCust_butt
            // 
            this.UpdateCust_butt.Location = new System.Drawing.Point(351, 297);
            this.UpdateCust_butt.Name = "UpdateCust_butt";
            this.UpdateCust_butt.Size = new System.Drawing.Size(75, 23);
            this.UpdateCust_butt.TabIndex = 39;
            this.UpdateCust_butt.Text = "Update";
            this.UpdateCust_butt.UseVisualStyleBackColor = true;
            // 
            // DeleteCust_butt
            // 
            this.DeleteCust_butt.Location = new System.Drawing.Point(473, 297);
            this.DeleteCust_butt.Name = "DeleteCust_butt";
            this.DeleteCust_butt.Size = new System.Drawing.Size(75, 23);
            this.DeleteCust_butt.TabIndex = 38;
            this.DeleteCust_butt.Text = "Delete";
            this.DeleteCust_butt.UseVisualStyleBackColor = true;
            // 
            // AddCust_butt
            // 
            this.AddCust_butt.Location = new System.Drawing.Point(230, 297);
            this.AddCust_butt.Name = "AddCust_butt";
            this.AddCust_butt.Size = new System.Drawing.Size(75, 23);
            this.AddCust_butt.TabIndex = 37;
            this.AddCust_butt.Text = "Add";
            this.AddCust_butt.UseVisualStyleBackColor = true;
            // 
            // search_butt
            // 
            this.search_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.search_butt.Location = new System.Drawing.Point(567, 40);
            this.search_butt.Name = "search_butt";
            this.search_butt.Size = new System.Drawing.Size(75, 23);
            this.search_butt.TabIndex = 36;
            this.search_butt.Text = "Search";
            this.search_butt.UseVisualStyleBackColor = true;
            // 
            // SearchBar_txt
            // 
            this.SearchBar_txt.Location = new System.Drawing.Point(350, 42);
            this.SearchBar_txt.Name = "SearchBar_txt";
            this.SearchBar_txt.Size = new System.Drawing.Size(211, 20);
            this.SearchBar_txt.TabIndex = 34;
            this.SearchBar_txt.TextChanged += new System.EventHandler(this.SearchBar_txt_TextChanged_1);
            // 
            // Building_txt
            // 
            this.Building_txt.Location = new System.Drawing.Point(142, 183);
            this.Building_txt.Name = "Building_txt";
            this.Building_txt.Size = new System.Drawing.Size(170, 20);
            this.Building_txt.TabIndex = 32;
            // 
            // DeliveryAdd_txt
            // 
            this.DeliveryAdd_txt.Location = new System.Drawing.Point(142, 151);
            this.DeliveryAdd_txt.Name = "DeliveryAdd_txt";
            this.DeliveryAdd_txt.Size = new System.Drawing.Size(170, 20);
            this.DeliveryAdd_txt.TabIndex = 31;
            // 
            // OrgName_txt
            // 
            this.OrgName_txt.Location = new System.Drawing.Point(142, 120);
            this.OrgName_txt.Name = "OrgName_txt";
            this.OrgName_txt.Size = new System.Drawing.Size(170, 20);
            this.OrgName_txt.TabIndex = 30;
            this.OrgName_txt.TextChanged += new System.EventHandler(this.OrgName_txt_TextChanged);
            // 
            // CustID_txt
            // 
            this.CustID_txt.Location = new System.Drawing.Point(141, 87);
            this.CustID_txt.Name = "CustID_txt";
            this.CustID_txt.Size = new System.Drawing.Size(170, 20);
            this.CustID_txt.TabIndex = 29;
            this.CustID_txt.TextChanged += new System.EventHandler(this.CustID_txt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "District";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Building";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Room number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Delivery address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Organization name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Customer Information";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // District_combobox
            // 
            this.District_combobox.FormattingEnabled = true;
            this.District_combobox.Location = new System.Drawing.Point(142, 250);
            this.District_combobox.Name = "District_combobox";
            this.District_combobox.Size = new System.Drawing.Size(170, 21);
            this.District_combobox.TabIndex = 41;
            // 
            // RoomNum_txt
            // 
            this.RoomNum_txt.Location = new System.Drawing.Point(142, 218);
            this.RoomNum_txt.Name = "RoomNum_txt";
            this.RoomNum_txt.Size = new System.Drawing.Size(170, 20);
            this.RoomNum_txt.TabIndex = 42;
            // 
            // biotestDataSet
            // 
            this.biotestDataSet.DataSetName = "BiotestDataSet";
            this.biotestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERSBindingSource
            // 
            this.cUSTOMERSBindingSource.DataMember = "CUSTOMERS";
            this.cUSTOMERSBindingSource.DataSource = this.biotestDataSet;
            // 
            // cUSTOMERSTableAdapter
            // 
            this.cUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BUSINESSMEETINGSTableAdapter = null;
            this.tableAdapterManager.CHATPARTSTableAdapter = null;
            this.tableAdapterManager.CHATSTableAdapter = null;
            this.tableAdapterManager.CUSTOMERINVITSTableAdapter = null;
            this.tableAdapterManager.CUSTOMERSTableAdapter = this.cUSTOMERSTableAdapter;
            this.tableAdapterManager.MESSAGESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BiotestCompany.BiotestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERINVITSTableAdapter = null;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // cUSTOMERSDataGridView
            // 
            this.cUSTOMERSDataGridView.AutoGenerateColumns = false;
            this.cUSTOMERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cUSTOMERSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.cUSTOMERSDataGridView.DataSource = this.cUSTOMERSBindingSource;
            this.cUSTOMERSDataGridView.Location = new System.Drawing.Point(350, 87);
            this.cUSTOMERSDataGridView.Name = "cUSTOMERSDataGridView";
            this.cUSTOMERSDataGridView.Size = new System.Drawing.Size(644, 184);
            this.cUSTOMERSDataGridView.TabIndex = 43;
            this.cUSTOMERSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cUSTOMERSDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "custID";
            this.dataGridViewTextBoxColumn1.HeaderText = "custID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "orgName";
            this.dataGridViewTextBoxColumn2.HeaderText = "orgName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "district";
            this.dataGridViewTextBoxColumn3.HeaderText = "district";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "deliveryAddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "deliveryAddress";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "buildingNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "buildingNumber";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "roomNumber";
            this.dataGridViewTextBoxColumn6.HeaderText = "roomNumber";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Out_Butt
            // 
            this.Out_Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Out_Butt.Location = new System.Drawing.Point(938, 365);
            this.Out_Butt.Name = "Out_Butt";
            this.Out_Butt.Size = new System.Drawing.Size(75, 23);
            this.Out_Butt.TabIndex = 44;
            this.Out_Butt.Text = "Finidhed";
            this.Out_Butt.UseVisualStyleBackColor = true;
            this.Out_Butt.Click += new System.EventHandler(this.Out_Butt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 400);
            this.Controls.Add(this.Out_Butt);
            this.Controls.Add(this.cUSTOMERSDataGridView);
            this.Controls.Add(this.RoomNum_txt);
            this.Controls.Add(this.District_combobox);
            this.Controls.Add(this.UpdateCust_butt);
            this.Controls.Add(this.DeleteCust_butt);
            this.Controls.Add(this.AddCust_butt);
            this.Controls.Add(this.search_butt);
            this.Controls.Add(this.SearchBar_txt);
            this.Controls.Add(this.Building_txt);
            this.Controls.Add(this.DeliveryAdd_txt);
            this.Controls.Add(this.OrgName_txt);
            this.Controls.Add(this.CustID_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Customers Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biotestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UpdateCust_butt;
        private System.Windows.Forms.Button DeleteCust_butt;
        private System.Windows.Forms.Button AddCust_butt;
        private System.Windows.Forms.Button search_butt;
        private System.Windows.Forms.TextBox SearchBar_txt;
        private System.Windows.Forms.TextBox Building_txt;
        private System.Windows.Forms.TextBox DeliveryAdd_txt;
        private System.Windows.Forms.TextBox OrgName_txt;
        private System.Windows.Forms.TextBox CustID_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox District_combobox;
        private System.Windows.Forms.TextBox RoomNum_txt;
        private BiotestDataSet biotestDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERSBindingSource;
        private BiotestDataSetTableAdapters.CUSTOMERSTableAdapter cUSTOMERSTableAdapter;
        private BiotestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cUSTOMERSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button Out_Butt;
    }
}