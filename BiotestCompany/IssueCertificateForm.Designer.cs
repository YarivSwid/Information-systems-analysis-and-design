namespace BiotestCompany
{
    partial class IssueCertificateForm
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
            this.clear_butt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBar_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sAD_1DataSet = new BiotestCompany.SAD_1DataSet();
            this.cUSTOMERORDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERORDERSTableAdapter = new BiotestCompany.SAD_1DataSetTableAdapters.CUSTOMERORDERSTableAdapter();
            this.tableAdapterManager = new BiotestCompany.SAD_1DataSetTableAdapters.TableAdapterManager();
            this.cUSTOMERORDERSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manualPricing_lbl = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERORDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERORDERSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // clear_butt
            // 
            this.clear_butt.BackColor = System.Drawing.Color.MidnightBlue;
            this.clear_butt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clear_butt.ForeColor = System.Drawing.Color.Lavender;
            this.clear_butt.Location = new System.Drawing.Point(662, 61);
            this.clear_butt.Name = "clear_butt";
            this.clear_butt.Size = new System.Drawing.Size(75, 32);
            this.clear_butt.TabIndex = 27;
            this.clear_butt.Text = "Clean";
            this.clear_butt.UseVisualStyleBackColor = false;
            this.clear_butt.Click += new System.EventHandler(this.clear_butt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Order Information";
            // 
            // SearchBar_txt
            // 
            this.SearchBar_txt.Location = new System.Drawing.Point(566, 67);
            this.SearchBar_txt.Name = "SearchBar_txt";
            this.SearchBar_txt.Size = new System.Drawing.Size(79, 20);
            this.SearchBar_txt.TabIndex = 26;
            this.SearchBar_txt.TextChanged += new System.EventHandler(this.SearchBar_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(490, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Order ID";
            // 
            // sAD_1DataSet
            // 
            this.sAD_1DataSet.DataSetName = "SAD_1DataSet";
            this.sAD_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERORDERSBindingSource
            // 
            this.cUSTOMERORDERSBindingSource.DataMember = "CUSTOMERORDERS";
            this.cUSTOMERORDERSBindingSource.DataSource = this.sAD_1DataSet;
            // 
            // cUSTOMERORDERSTableAdapter
            // 
            this.cUSTOMERORDERSTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.CUSTOMERORDERSTableAdapter = this.cUSTOMERORDERSTableAdapter;
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
            this.tableAdapterManager.SUPPLIERORDERSTableAdapter = null;
            this.tableAdapterManager.SUPPLIERPRODUCTTYPESTableAdapter = null;
            this.tableAdapterManager.SUPPLIERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BiotestCompany.SAD_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERINVITSTableAdapter = null;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // cUSTOMERORDERSDataGridView
            // 
            this.cUSTOMERORDERSDataGridView.AllowUserToAddRows = false;
            this.cUSTOMERORDERSDataGridView.AllowUserToDeleteRows = false;
            this.cUSTOMERORDERSDataGridView.AutoGenerateColumns = false;
            this.cUSTOMERORDERSDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.cUSTOMERORDERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cUSTOMERORDERSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4});
            this.cUSTOMERORDERSDataGridView.DataSource = this.cUSTOMERORDERSBindingSource;
            this.cUSTOMERORDERSDataGridView.Location = new System.Drawing.Point(493, 103);
            this.cUSTOMERORDERSDataGridView.Name = "cUSTOMERORDERSDataGridView";
            this.cUSTOMERORDERSDataGridView.ReadOnly = true;
            this.cUSTOMERORDERSDataGridView.Size = new System.Drawing.Size(244, 173);
            this.cUSTOMERORDERSDataGridView.TabIndex = 30;
            this.cUSTOMERORDERSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cUSTOMERORDERSDataGridView_CellContentClick);
            this.cUSTOMERORDERSDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cUSTOMERORDERSDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "customerOrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "customerOrderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "basedOnCustBid";
            this.dataGridViewTextBoxColumn4.HeaderText = "basedOnCustBid";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // manualPricing_lbl
            // 
            this.manualPricing_lbl.AutoSize = true;
            this.manualPricing_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.manualPricing_lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.manualPricing_lbl.Location = new System.Drawing.Point(37, 199);
            this.manualPricing_lbl.Name = "manualPricing_lbl";
            this.manualPricing_lbl.Size = new System.Drawing.Size(83, 21);
            this.manualPricing_lbl.TabIndex = 35;
            this.manualPricing_lbl.Text = "Salesman";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl6.Location = new System.Drawing.Point(37, 232);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(48, 21);
            this.lbl6.TabIndex = 36;
            this.lbl6.Text = "Price";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl3.Location = new System.Drawing.Point(37, 133);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(116, 21);
            this.lbl3.TabIndex = 33;
            this.lbl3.Text = "Contact name";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl4.Location = new System.Drawing.Point(37, 164);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(70, 21);
            this.lbl4.TabIndex = 34;
            this.lbl4.Text = "Address";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl2.Location = new System.Drawing.Point(37, 103);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(130, 21);
            this.lbl2.TabIndex = 32;
            this.lbl2.Text = "Company name";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl1.Location = new System.Drawing.Point(37, 72);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(74, 21);
            this.lbl1.TabIndex = 31;
            this.lbl1.Text = "Order ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(187, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(187, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(187, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(187, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(187, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(187, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 42;
            this.label8.Text = "label8";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(493, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 150);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(559, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 44;
            this.button1.Text = "View product list";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 45;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl7.Location = new System.Drawing.Point(37, 330);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(116, 21);
            this.lbl7.TabIndex = 46;
            this.lbl7.Text = "Contact email";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(381, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 32);
            this.button2.TabIndex = 47;
            this.button2.Text = "Change email";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.ForeColor = System.Drawing.Color.Lavender;
            this.button3.Location = new System.Drawing.Point(40, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 32);
            this.button3.TabIndex = 48;
            this.button3.Text = "Send ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(36, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 32);
            this.label9.TabIndex = 49;
            this.label9.Text = "Shipping Certificate";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BiotestCompany.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(-39, 402);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(891, 204);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            // 
            // IssueCertificateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 590);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.manualPricing_lbl);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cUSTOMERORDERSDataGridView);
            this.Controls.Add(this.clear_butt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBar_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "IssueCertificateForm";
            this.Text = "Issue Shipping Certificate";
            this.Load += new System.EventHandler(this.IssueCertificateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERORDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERORDERSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear_butt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchBar_txt;
        private System.Windows.Forms.Label label2;
        private SAD_1DataSet sAD_1DataSet;
        private System.Windows.Forms.BindingSource cUSTOMERORDERSBindingSource;
        private SAD_1DataSetTableAdapters.CUSTOMERORDERSTableAdapter cUSTOMERORDERSTableAdapter;
        private SAD_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cUSTOMERORDERSDataGridView;
        private System.Windows.Forms.Label manualPricing_lbl;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}