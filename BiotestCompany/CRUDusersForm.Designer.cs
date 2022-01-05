using System;

namespace BiotestCompany
{
    partial class CRUDusersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDusersForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Firstname_txt = new System.Windows.Forms.TextBox();
            this.Lastname_txt = new System.Windows.Forms.TextBox();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SearchBar_txt = new System.Windows.Forms.TextBox();
            this.biotestDataSet = new BiotestCompany.BiotestDataSet();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERSTableAdapter = new BiotestCompany.BiotestDataSetTableAdapters.USERSTableAdapter();
            this.tableAdapterManager = new BiotestCompany.BiotestDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.uSERSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.Serial_txt = new System.Windows.Forms.TextBox();
            this.Role_Box = new System.Windows.Forms.ComboBox();
            this.biotestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Out_Butt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.mESSAGESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mESSAGESTableAdapter = new BiotestCompany.BiotestDataSetTableAdapters.MESSAGESTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.biotestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biotestDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESSAGESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(41, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "First name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(41, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(41, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birth date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(41, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(41, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Role";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(41, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Profile picture";
            // 
            // Firstname_txt
            // 
            this.Firstname_txt.Location = new System.Drawing.Point(160, 142);
            this.Firstname_txt.Name = "Firstname_txt";
            this.Firstname_txt.Size = new System.Drawing.Size(170, 20);
            this.Firstname_txt.TabIndex = 2;
            // 
            // Lastname_txt
            // 
            this.Lastname_txt.Location = new System.Drawing.Point(160, 173);
            this.Lastname_txt.Name = "Lastname_txt";
            this.Lastname_txt.Size = new System.Drawing.Size(170, 20);
            this.Lastname_txt.TabIndex = 3;
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(160, 234);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(170, 20);
            this.Email_txt.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 266);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // SearchBar_txt
            // 
            this.SearchBar_txt.Location = new System.Drawing.Point(506, 100);
            this.SearchBar_txt.Name = "SearchBar_txt";
            this.SearchBar_txt.Size = new System.Drawing.Size(211, 20);
            this.SearchBar_txt.TabIndex = 0;
            this.SearchBar_txt.TextChanged += new System.EventHandler(this.searchUser_butt_Click);
            // 
            // biotestDataSet
            // 
            this.biotestDataSet.DataSetName = "BiotestDataSet";
            this.biotestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.biotestDataSet;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BUSINESSMEETINGSTableAdapter = null;
            this.tableAdapterManager.CHATPARTSTableAdapter = null;
            this.tableAdapterManager.CHATSTableAdapter = null;
            this.tableAdapterManager.CUSTOMERINVITSTableAdapter = null;
            this.tableAdapterManager.CUSTOMERSTableAdapter = null;
            this.tableAdapterManager.MESSAGESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BiotestCompany.BiotestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERINVITSTableAdapter = null;
            this.tableAdapterManager.USERSTableAdapter = this.uSERSTableAdapter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(369, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Add_butt_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.ForeColor = System.Drawing.Color.Lavender;
            this.button3.Location = new System.Drawing.Point(496, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Update_Click);
            // 
            // uSERSDataGridView
            // 
            this.uSERSDataGridView.AutoGenerateColumns = false;
            this.uSERSDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.uSERSDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uSERSDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.uSERSDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uSERSDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.uSERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uSERSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.uSERSDataGridView.DataSource = this.uSERSBindingSource;
            this.uSERSDataGridView.Location = new System.Drawing.Point(369, 139);
            this.uSERSDataGridView.Name = "uSERSDataGridView";
            this.uSERSDataGridView.Size = new System.Drawing.Size(844, 220);
            this.uSERSDataGridView.TabIndex = 15;
            this.uSERSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uSERSDataGridView_CellContentClick_1);
            this.uSERSDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uSERSDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "userID";
            this.dataGridViewTextBoxColumn1.HeaderText = "User ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "joinDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Join Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "firstName";
            this.dataGridViewTextBoxColumn4.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "lastName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "birthday";
            this.dataGridViewTextBoxColumn6.HeaderText = "Birthday";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "serialID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Serial ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn8.HeaderText = "Email";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "role";
            this.dataGridViewTextBoxColumn9.HeaderText = "Role";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(41, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Serial ID";
            // 
            // Serial_txt
            // 
            this.Serial_txt.Location = new System.Drawing.Point(160, 203);
            this.Serial_txt.MaxLength = 9;
            this.Serial_txt.Name = "Serial_txt";
            this.Serial_txt.Size = new System.Drawing.Size(170, 20);
            this.Serial_txt.TabIndex = 4;
            this.Serial_txt.TextChanged += new System.EventHandler(this.Serial_txt_TextChanged);
            this.Serial_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serial_txt_KeyPress);
            // 
            // Role_Box
            // 
            this.Role_Box.DataSource = this.biotestDataSetBindingSource;
            this.Role_Box.FormattingEnabled = true;
            this.Role_Box.Location = new System.Drawing.Point(160, 297);
            this.Role_Box.Name = "Role_Box";
            this.Role_Box.Size = new System.Drawing.Size(170, 21);
            this.Role_Box.TabIndex = 7;
            this.Role_Box.SelectedIndexChanged += new System.EventHandler(this.Role_Box_SelectedIndexChanged);
            // 
            // biotestDataSetBindingSource
            // 
            this.biotestDataSetBindingSource.DataSource = this.biotestDataSet;
            this.biotestDataSetBindingSource.Position = 0;
            // 
            // Out_Butt
            // 
            this.Out_Butt.BackColor = System.Drawing.Color.MidnightBlue;
            this.Out_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Out_Butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Out_Butt.ForeColor = System.Drawing.Color.Lavender;
            this.Out_Butt.Location = new System.Drawing.Point(1100, 378);
            this.Out_Butt.Name = "Out_Butt";
            this.Out_Butt.Size = new System.Drawing.Size(113, 60);
            this.Out_Butt.TabIndex = 10;
            this.Out_Butt.Text = "Finished";
            this.Out_Butt.UseVisualStyleBackColor = false;
            this.Out_Butt.Click += new System.EventHandler(this.Out_Butt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(365, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Search by name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(740, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clean";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mESSAGESBindingSource
            // 
            this.mESSAGESBindingSource.DataMember = "MESSAGES";
            this.mESSAGESBindingSource.DataSource = this.biotestDataSet;
            // 
            // mESSAGESTableAdapter
            // 
            this.mESSAGESTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BiotestCompany.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 342);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1363, 231);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiotestCompany.Properties.Resources._843256_medical_512x512_96034;
            this.pictureBox1.Location = new System.Drawing.Point(1057, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // CRUDusersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1279, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Out_Butt);
            this.Controls.Add(this.Role_Box);
            this.Controls.Add(this.Serial_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uSERSDataGridView);
            this.Controls.Add(this.SearchBar_txt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.Lastname_txt);
            this.Controls.Add(this.Firstname_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CRUDusersForm";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            this.TextChanged += new System.EventHandler(this.searchUser_butt_Click);
            ((System.ComponentModel.ISupportInitialize)(this.biotestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biotestDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESSAGESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SearchBar_txt_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Firstname_txt;
        private System.Windows.Forms.TextBox Lastname_txt;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox SearchBar_txt;
        private BiotestDataSet biotestDataSet;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private BiotestDataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private BiotestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView uSERSDataGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Serial_txt;
        private System.Windows.Forms.ComboBox Role_Box;
        private System.Windows.Forms.BindingSource biotestDataSetBindingSource;
        private System.Windows.Forms.Button Out_Butt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource mESSAGESBindingSource;
        private BiotestDataSetTableAdapters.MESSAGESTableAdapter mESSAGESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}