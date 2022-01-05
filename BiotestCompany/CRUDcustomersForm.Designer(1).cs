namespace BiotestCompany
{
    partial class CRUDcustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDcustomersForm));
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Out_Butt = new System.Windows.Forms.Button();
            this.District_Box = new System.Windows.Forms.ComboBox();
            this.Building_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchBar_txt = new System.Windows.Forms.TextBox();
            this.Room_txt = new System.Windows.Forms.TextBox();
            this.DeliveryAddress_txt = new System.Windows.Forms.TextBox();
            this.OrgName_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sAD_1DataSet = new BiotestCompany.SAD_1DataSet();
            this.cUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERSTableAdapter = new BiotestCompany.SAD_1DataSetTableAdapters.CUSTOMERSTableAdapter();
            this.tableAdapterManager = new BiotestCompany.SAD_1DataSetTableAdapters.TableAdapterManager();
            this.cUSTOMERSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(828, 95);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clean";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(485, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Search by name";
            // 
            // Out_Butt
            // 
            this.Out_Butt.BackColor = System.Drawing.Color.MidnightBlue;
            this.Out_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Out_Butt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Out_Butt.ForeColor = System.Drawing.Color.Lavender;
            this.Out_Butt.Location = new System.Drawing.Point(984, 518);
            this.Out_Butt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Out_Butt.Name = "Out_Butt";
            this.Out_Butt.Size = new System.Drawing.Size(146, 60);
            this.Out_Butt.TabIndex = 9;
            this.Out_Butt.Text = "Finished";
            this.Out_Butt.UseVisualStyleBackColor = false;
            this.Out_Butt.Click += new System.EventHandler(this.Out_Butt_Click);
            // 
            // District_Box
            // 
            this.District_Box.BackColor = System.Drawing.Color.GhostWhite;
            this.District_Box.ForeColor = System.Drawing.Color.MidnightBlue;
            this.District_Box.FormattingEnabled = true;
            this.District_Box.Location = new System.Drawing.Point(220, 274);
            this.District_Box.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.District_Box.Name = "District_Box";
            this.District_Box.Size = new System.Drawing.Size(170, 21);
            this.District_Box.TabIndex = 6;
            // 
            // Building_txt
            // 
            this.Building_txt.BackColor = System.Drawing.Color.GhostWhite;
            this.Building_txt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Building_txt.Location = new System.Drawing.Point(220, 212);
            this.Building_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Building_txt.Name = "Building_txt";
            this.Building_txt.Size = new System.Drawing.Size(170, 22);
            this.Building_txt.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(38, 209);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 21);
            this.label9.TabIndex = 43;
            this.label9.Text = "Building number";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.ForeColor = System.Drawing.Color.Lavender;
            this.button3.Location = new System.Drawing.Point(611, 380);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Update_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(490, 380);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Add_butt_Click);
            // 
            // SearchBar_txt
            // 
            this.SearchBar_txt.BackColor = System.Drawing.Color.GhostWhite;
            this.SearchBar_txt.Location = new System.Drawing.Point(611, 107);
            this.SearchBar_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SearchBar_txt.Name = "SearchBar_txt";
            this.SearchBar_txt.Size = new System.Drawing.Size(210, 22);
            this.SearchBar_txt.TabIndex = 0;
            this.SearchBar_txt.TextChanged += new System.EventHandler(this.SearchBar_txt_TextChanged);
            // 
            // Room_txt
            // 
            this.Room_txt.BackColor = System.Drawing.Color.GhostWhite;
            this.Room_txt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Room_txt.Location = new System.Drawing.Point(220, 243);
            this.Room_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Room_txt.Name = "Room_txt";
            this.Room_txt.Size = new System.Drawing.Size(170, 22);
            this.Room_txt.TabIndex = 5;
            this.Room_txt.TextChanged += new System.EventHandler(this.Room_txt_TextChanged);
            this.Room_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.room_txt_KeyPress);
            // 
            // DeliveryAddress_txt
            // 
            this.DeliveryAddress_txt.BackColor = System.Drawing.Color.GhostWhite;
            this.DeliveryAddress_txt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DeliveryAddress_txt.Location = new System.Drawing.Point(220, 182);
            this.DeliveryAddress_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DeliveryAddress_txt.Name = "DeliveryAddress_txt";
            this.DeliveryAddress_txt.Size = new System.Drawing.Size(170, 22);
            this.DeliveryAddress_txt.TabIndex = 3;
            // 
            // OrgName_txt
            // 
            this.OrgName_txt.BackColor = System.Drawing.Color.GhostWhite;
            this.OrgName_txt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.OrgName_txt.Location = new System.Drawing.Point(220, 154);
            this.OrgName_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OrgName_txt.Name = "OrgName_txt";
            this.OrgName_txt.Size = new System.Drawing.Size(170, 22);
            this.OrgName_txt.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(38, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "District";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(38, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Delivery address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(38, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Organization name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Customer Information";
            // 
            // sAD_1DataSet
            // 
            this.sAD_1DataSet.DataSetName = "SAD_1DataSet";
            this.sAD_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERSBindingSource
            // 
            this.cUSTOMERSBindingSource.DataMember = "CUSTOMERS";
            this.cUSTOMERSBindingSource.DataSource = this.sAD_1DataSet;
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
            this.tableAdapterManager.CONTACTSTableAdapter = null;
            this.tableAdapterManager.CUSTOMERBIDSTableAdapter = null;
            this.tableAdapterManager.CUSTOMERCONTACTSTableAdapter = null;
            this.tableAdapterManager.CUSTOMERINVITSTableAdapter = null;
            this.tableAdapterManager.CUSTOMERORDERSTableAdapter = null;
            this.tableAdapterManager.CUSTOMERSTableAdapter = this.cUSTOMERSTableAdapter;
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
            this.tableAdapterManager.SUPPLIERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BiotestCompany.SAD_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERINVITSTableAdapter = null;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // cUSTOMERSDataGridView
            // 
            this.cUSTOMERSDataGridView.AutoGenerateColumns = false;
            this.cUSTOMERSDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.cUSTOMERSDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cUSTOMERSDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.cUSTOMERSDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cUSTOMERSDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cUSTOMERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cUSTOMERSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.cUSTOMERSDataGridView.DataSource = this.cUSTOMERSBindingSource;
            this.cUSTOMERSDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cUSTOMERSDataGridView.Location = new System.Drawing.Point(488, 154);
            this.cUSTOMERSDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cUSTOMERSDataGridView.Name = "cUSTOMERSDataGridView";
            this.cUSTOMERSDataGridView.Size = new System.Drawing.Size(653, 220);
            this.cUSTOMERSDataGridView.TabIndex = 49;
            this.cUSTOMERSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cUSTOMERSDataGridView_CellContentClick);
            this.cUSTOMERSDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uSERSDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "custID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "orgName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Organization";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "district";
            this.dataGridViewTextBoxColumn3.HeaderText = "District";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "deliveryAddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "DeliveryAddress";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "buildingNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "BuildingNumber";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "roomNumber";
            this.dataGridViewTextBoxColumn6.HeaderText = "RoomNumber";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 103;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(38, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Room number";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiotestCompany.Properties.Resources._843256_medical_512x512_96034;
            this.pictureBox1.Location = new System.Drawing.Point(974, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BiotestCompany.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(-6, 337);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1363, 231);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // CRUDcustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1166, 606);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cUSTOMERSDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Out_Butt);
            this.Controls.Add(this.District_Box);
            this.Controls.Add(this.Building_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchBar_txt);
            this.Controls.Add(this.Room_txt);
            this.Controls.Add(this.DeliveryAddress_txt);
            this.Controls.Add(this.OrgName_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "CRUDcustomersForm";
            this.Text = "CRUDcustomersForm";
            this.Load += new System.EventHandler(this.CRUDcustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Out_Butt;
        private System.Windows.Forms.ComboBox District_Box;
        private System.Windows.Forms.TextBox Building_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchBar_txt;
        private System.Windows.Forms.TextBox Room_txt;
        private System.Windows.Forms.TextBox DeliveryAddress_txt;
        private System.Windows.Forms.TextBox OrgName_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private SAD_1DataSet sAD_1DataSet;
        private System.Windows.Forms.BindingSource cUSTOMERSBindingSource;
        private SAD_1DataSetTableAdapters.CUSTOMERSTableAdapter cUSTOMERSTableAdapter;
        private SAD_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cUSTOMERSDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}