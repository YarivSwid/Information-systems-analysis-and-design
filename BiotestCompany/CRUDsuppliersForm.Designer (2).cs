namespace BiotestCompany
{
    partial class CRUDsuppliersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDsuppliersForm));
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Out_Butt = new System.Windows.Forms.Button();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Update_Butt = new System.Windows.Forms.Button();
            this.add_Butt = new System.Windows.Forms.Button();
            this.SearchBar_txt = new System.Windows.Forms.TextBox();
            this.Country_txt = new System.Windows.Forms.TextBox();
            this.CompanyName_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sAD_1DataSet = new BiotestCompany.SAD_1DataSet();
            this.sUPPLIERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUPPLIERSTableAdapter = new BiotestCompany.SAD_1DataSetTableAdapters.SUPPLIERSTableAdapter();
            this.tableAdapterManager = new BiotestCompany.SAD_1DataSetTableAdapters.TableAdapterManager();
            this.sUPPLIERSDataGridView = new System.Windows.Forms.DataGridView();
            this.supplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.EditNotes_Butt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(848, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clean";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(389, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "Search by name ID or country";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Out_Butt
            // 
            this.Out_Butt.BackColor = System.Drawing.Color.MidnightBlue;
            this.Out_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Out_Butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Out_Butt.ForeColor = System.Drawing.Color.Lavender;
            this.Out_Butt.Location = new System.Drawing.Point(1027, 483);
            this.Out_Butt.Name = "Out_Butt";
            this.Out_Butt.Size = new System.Drawing.Size(117, 64);
            this.Out_Butt.TabIndex = 7;
            this.Out_Butt.Text = "Finished";
            this.Out_Butt.UseVisualStyleBackColor = false;
            this.Out_Butt.Click += new System.EventHandler(this.Out_Butt_Click);
            // 
            // Email_txt
            // 
            this.Email_txt.BackColor = System.Drawing.Color.GhostWhite;
            this.Email_txt.Location = new System.Drawing.Point(173, 196);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(170, 20);
            this.Email_txt.TabIndex = 4;
            this.Email_txt.TextChanged += new System.EventHandler(this.Email_txt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(42, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 21);
            this.label9.TabIndex = 61;
            this.label9.Text = "Official Email";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Update_Butt
            // 
            this.Update_Butt.BackColor = System.Drawing.Color.MidnightBlue;
            this.Update_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_Butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Update_Butt.ForeColor = System.Drawing.Color.Lavender;
            this.Update_Butt.Location = new System.Drawing.Point(499, 353);
            this.Update_Butt.Name = "Update_Butt";
            this.Update_Butt.Size = new System.Drawing.Size(79, 35);
            this.Update_Butt.TabIndex = 6;
            this.Update_Butt.Text = "Update";
            this.Update_Butt.UseVisualStyleBackColor = false;
            this.Update_Butt.Click += new System.EventHandler(this.Update_Butt_Click);
            // 
            // add_Butt
            // 
            this.add_Butt.BackColor = System.Drawing.Color.MidnightBlue;
            this.add_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Butt.FlatAppearance.BorderSize = 2;
            this.add_Butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.add_Butt.ForeColor = System.Drawing.Color.Lavender;
            this.add_Butt.Location = new System.Drawing.Point(393, 353);
            this.add_Butt.Name = "add_Butt";
            this.add_Butt.Size = new System.Drawing.Size(79, 35);
            this.add_Butt.TabIndex = 5;
            this.add_Butt.Text = "Add";
            this.add_Butt.UseVisualStyleBackColor = false;
            this.add_Butt.Click += new System.EventHandler(this.add_Butt_Click);
            // 
            // SearchBar_txt
            // 
            this.SearchBar_txt.BackColor = System.Drawing.Color.GhostWhite;
            this.SearchBar_txt.Location = new System.Drawing.Point(631, 69);
            this.SearchBar_txt.Name = "SearchBar_txt";
            this.SearchBar_txt.Size = new System.Drawing.Size(211, 20);
            this.SearchBar_txt.TabIndex = 0;
            this.SearchBar_txt.TextChanged += new System.EventHandler(this.SearchBar_txt_TextChanged);
            // 
            // Country_txt
            // 
            this.Country_txt.BackColor = System.Drawing.Color.GhostWhite;
            this.Country_txt.Location = new System.Drawing.Point(173, 160);
            this.Country_txt.Name = "Country_txt";
            this.Country_txt.Size = new System.Drawing.Size(170, 20);
            this.Country_txt.TabIndex = 3;
            this.Country_txt.TextChanged += new System.EventHandler(this.Country_txt_TextChanged);
            // 
            // CompanyName_txt
            // 
            this.CompanyName_txt.BackColor = System.Drawing.Color.GhostWhite;
            this.CompanyName_txt.Location = new System.Drawing.Point(173, 126);
            this.CompanyName_txt.Name = "CompanyName_txt";
            this.CompanyName_txt.Size = new System.Drawing.Size(170, 20);
            this.CompanyName_txt.TabIndex = 2;
            this.CompanyName_txt.TextChanged += new System.EventHandler(this.CompanyName_txt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(42, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 54;
            this.label7.Text = "Ranks:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(57, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Punctuality";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(42, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "Country";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(42, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Company name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 50;
            this.label1.Text = "Supplier Information";
            // 
            // sAD_1DataSet
            // 
            this.sAD_1DataSet.DataSetName = "SAD_1DataSet";
            this.sAD_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sUPPLIERSBindingSource
            // 
            this.sUPPLIERSBindingSource.DataMember = "SUPPLIERS";
            this.sUPPLIERSBindingSource.DataSource = this.sAD_1DataSet;
            // 
            // sUPPLIERSTableAdapter
            // 
            this.sUPPLIERSTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SUPPLIERORDERSTableAdapter = null;
            this.tableAdapterManager.SUPPLIERPRODUCTTYPESTableAdapter = null;
            this.tableAdapterManager.SUPPLIERSTableAdapter = this.sUPPLIERSTableAdapter;
            this.tableAdapterManager.UpdateOrder = BiotestCompany.SAD_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERINVITSTableAdapter = null;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // sUPPLIERSDataGridView
            // 
            this.sUPPLIERSDataGridView.AutoGenerateColumns = false;
            this.sUPPLIERSDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.sUPPLIERSDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sUPPLIERSDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.sUPPLIERSDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sUPPLIERSDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sUPPLIERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sUPPLIERSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.sUPPLIERSDataGridView.DataSource = this.sUPPLIERSBindingSource;
            this.sUPPLIERSDataGridView.Location = new System.Drawing.Point(393, 126);
            this.sUPPLIERSDataGridView.Name = "sUPPLIERSDataGridView";
            this.sUPPLIERSDataGridView.Size = new System.Drawing.Size(758, 216);
            this.sUPPLIERSDataGridView.TabIndex = 67;
            this.sUPPLIERSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sUPPLIERSDataGridView_CellContentClick_1);
            this.sUPPLIERSDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sUPPLIERSDataGridView_CellDoubleClick);
            // 
            // supplierID
            // 
            this.supplierID.DataPropertyName = "supplierID";
            this.supplierID.HeaderText = "supplierID";
            this.supplierID.Name = "supplierID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "companyName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CompanyName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "country";
            this.dataGridViewTextBoxColumn3.HeaderText = "Country";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "officialEmail";
            this.dataGridViewTextBoxColumn4.HeaderText = "Official Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "punctualityRank";
            this.dataGridViewTextBoxColumn5.HeaderText = "PunctualityRank";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "qualityRank";
            this.dataGridViewTextBoxColumn6.HeaderText = "Quality Rank";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "totalRank";
            this.dataGridViewTextBoxColumn7.HeaderText = "Total Rank";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(57, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Quality";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(57, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 69;
            this.label8.Text = "Total";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(41, 460);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 21);
            this.label10.TabIndex = 70;
            this.label10.Text = "Notes about supplier:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(146, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 71;
            this.label11.Text = "label11";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(146, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 72;
            this.label12.Text = "label12";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(146, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 73;
            this.label13.Text = "label13";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(222, 460);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 74;
            this.label14.Text = "label14";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // EditNotes_Butt
            // 
            this.EditNotes_Butt.BackColor = System.Drawing.Color.MidnightBlue;
            this.EditNotes_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditNotes_Butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EditNotes_Butt.ForeColor = System.Drawing.Color.Lavender;
            this.EditNotes_Butt.Location = new System.Drawing.Point(45, 493);
            this.EditNotes_Butt.Name = "EditNotes_Butt";
            this.EditNotes_Butt.Size = new System.Drawing.Size(109, 45);
            this.EditNotes_Butt.TabIndex = 75;
            this.EditNotes_Butt.Text = "Edit notes";
            this.EditNotes_Butt.UseVisualStyleBackColor = false;
            this.EditNotes_Butt.Click += new System.EventHandler(this.EditNotes_Butt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BiotestCompany.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(-52, 303);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1363, 231);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiotestCompany.Properties.Resources._843256_medical_512x512_96034;
            this.pictureBox1.Location = new System.Drawing.Point(995, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // CRUDsuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1188, 595);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EditNotes_Butt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sUPPLIERSDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Out_Butt);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Update_Butt);
            this.Controls.Add(this.add_Butt);
            this.Controls.Add(this.SearchBar_txt);
            this.Controls.Add(this.Country_txt);
            this.Controls.Add(this.CompanyName_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CRUDsuppliersForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.CRUDsuppliersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Out_Butt;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Update_Butt;
        private System.Windows.Forms.Button add_Butt;
        private System.Windows.Forms.TextBox SearchBar_txt;
        private System.Windows.Forms.TextBox Country_txt;
        private System.Windows.Forms.TextBox CompanyName_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private SAD_1DataSet sAD_1DataSet;
        private System.Windows.Forms.BindingSource sUPPLIERSBindingSource;
        private SAD_1DataSetTableAdapters.SUPPLIERSTableAdapter sUPPLIERSTableAdapter;
        private SAD_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sUPPLIERSDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button EditNotes_Butt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}