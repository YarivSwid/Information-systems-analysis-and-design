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
            this.sAD_1DataSet = new BiotestCompany.SAD_1DataSet();
            this.sUPPLIERORDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUPPLIERORDERSTableAdapter = new BiotestCompany.SAD_1DataSetTableAdapters.SUPPLIERORDERSTableAdapter();
            this.tableAdapterManager = new BiotestCompany.SAD_1DataSetTableAdapters.TableAdapterManager();
            this.sUPPLIERORDERSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateScore = new System.Windows.Forms.Button();
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERORDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERORDERSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sAD_1DataSet
            // 
            this.sAD_1DataSet.DataSetName = "SAD_1DataSet";
            this.sAD_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sUPPLIERORDERSBindingSource
            // 
            this.sUPPLIERORDERSBindingSource.DataMember = "SUPPLIERORDERS";
            this.sUPPLIERORDERSBindingSource.DataSource = this.sAD_1DataSet;
            // 
            // sUPPLIERORDERSTableAdapter
            // 
            this.sUPPLIERORDERSTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PRODUCTTYPESTableAdapter = null;
            this.tableAdapterManager.ROLETYPESTableAdapter = null;
            this.tableAdapterManager.SUPPLIERBIDSTableAdapter = null;
            this.tableAdapterManager.SUPPLIERCONTACTSTableAdapter = null;
            this.tableAdapterManager.SUPPLIERORDERSTableAdapter = this.sUPPLIERORDERSTableAdapter;
            this.tableAdapterManager.SUPPLIERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BiotestCompany.SAD_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERINVITSTableAdapter = null;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // sUPPLIERORDERSDataGridView
            // 
            this.sUPPLIERORDERSDataGridView.AutoGenerateColumns = false;
            this.sUPPLIERORDERSDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.sUPPLIERORDERSDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sUPPLIERORDERSDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.sUPPLIERORDERSDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.sUPPLIERORDERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sUPPLIERORDERSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.sUPPLIERORDERSDataGridView.DataSource = this.sUPPLIERORDERSBindingSource;
            this.sUPPLIERORDERSDataGridView.Location = new System.Drawing.Point(12, 101);
            this.sUPPLIERORDERSDataGridView.Name = "sUPPLIERORDERSDataGridView";
            this.sUPPLIERORDERSDataGridView.Size = new System.Drawing.Size(860, 301);
            this.sUPPLIERORDERSDataGridView.TabIndex = 1;
            this.sUPPLIERORDERSDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sUPPLIERORDERSDataGridView_CellClick);
            this.sUPPLIERORDERSDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sUPPLIERORDERSDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "supplierOrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "supplierOrderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "orderDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "orderDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "arrivalDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "arrivalDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "shippingCost";
            this.dataGridViewTextBoxColumn4.HeaderText = "shippingCost";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "orderValue";
            this.dataGridViewTextBoxColumn5.HeaderText = "orderValue";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "punctualityScore";
            this.dataGridViewTextBoxColumn6.HeaderText = "punctualityScore";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "qualityScore";
            this.dataGridViewTextBoxColumn7.HeaderText = "qualityScore";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "supplierID";
            this.dataGridViewTextBoxColumn8.HeaderText = "supplierID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // updateScore
            // 
            this.updateScore.BackColor = System.Drawing.Color.MidnightBlue;
            this.updateScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updateScore.ForeColor = System.Drawing.Color.Lavender;
            this.updateScore.Location = new System.Drawing.Point(776, 432);
            this.updateScore.Name = "updateScore";
            this.updateScore.Size = new System.Drawing.Size(96, 59);
            this.updateScore.TabIndex = 2;
            this.updateScore.Text = "Update Score";
            this.updateScore.UseVisualStyleBackColor = false;
            this.updateScore.Click += new System.EventHandler(this.updateScore_Click);
            // 
            // qualityScore
            // 
            this.qualityScore.AutoSize = true;
            this.qualityScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.qualityScore.ForeColor = System.Drawing.Color.MidnightBlue;
            this.qualityScore.Location = new System.Drawing.Point(586, 420);
            this.qualityScore.Name = "qualityScore";
            this.qualityScore.Size = new System.Drawing.Size(112, 21);
            this.qualityScore.TabIndex = 26;
            this.qualityScore.Text = "Quality Score";
            // 
            // punctualityScore
            // 
            this.punctualityScore.AutoSize = true;
            this.punctualityScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.punctualityScore.ForeColor = System.Drawing.Color.MidnightBlue;
            this.punctualityScore.Location = new System.Drawing.Point(329, 420);
            this.punctualityScore.Name = "punctualityScore";
            this.punctualityScore.Size = new System.Drawing.Size(144, 21);
            this.punctualityScore.TabIndex = 25;
            this.punctualityScore.Text = "Punctuality Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Update Supplier Order\'s Score";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(275, 408);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 140);
            this.trackBar1.TabIndex = 33;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // puncValue
            // 
            this.puncValue.AutoSize = true;
            this.puncValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.puncValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.puncValue.Location = new System.Drawing.Point(345, 453);
            this.puncValue.Name = "puncValue";
            this.puncValue.Size = new System.Drawing.Size(32, 21);
            this.puncValue.TabIndex = 34;
            this.puncValue.Text = "AA";
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar2.Location = new System.Drawing.Point(526, 408);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 140);
            this.trackBar2.TabIndex = 35;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // qualValue
            // 
            this.qualValue.AutoSize = true;
            this.qualValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.qualValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.qualValue.Location = new System.Drawing.Point(583, 451);
            this.qualValue.Name = "qualValue";
            this.qualValue.Size = new System.Drawing.Size(32, 21);
            this.qualValue.TabIndex = 36;
            this.qualValue.Text = "AA";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(395, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 31);
            this.button2.TabIndex = 39;
            this.button2.Text = "Clean";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Search By Order ID";
            // 
            // SearchBar_txt
            // 
            this.SearchBar_txt.Location = new System.Drawing.Point(171, 66);
            this.SearchBar_txt.Name = "SearchBar_txt";
            this.SearchBar_txt.Size = new System.Drawing.Size(211, 20);
            this.SearchBar_txt.TabIndex = 37;
            this.SearchBar_txt.TextChanged += new System.EventHandler(this.SearchBar_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(13, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Rate order No. X by supplier Y:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BiotestCompany.Properties.Resources._843256_medical_512x512_96034;
            this.pictureBox2.Location = new System.Drawing.Point(749, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // SupplierOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(897, 573);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
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
            this.Controls.Add(this.updateScore);
            this.Controls.Add(this.sUPPLIERORDERSDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierOrdersForm";
            this.Text = "Supplier Orders";
            this.Load += new System.EventHandler(this.SupplierOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERORDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERORDERSDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button updateScore;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}