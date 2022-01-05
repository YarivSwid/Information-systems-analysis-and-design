namespace BiotestCompany
{
    partial class ChatMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Messages_txt = new System.Windows.Forms.TextBox();
            this.NewM_txt = new System.Windows.Forms.TextBox();
            this.Send_Butt = new System.Windows.Forms.Button();
            this.times_txt = new System.Windows.Forms.TextBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.newChat_Butt = new System.Windows.Forms.Button();
            this.newGroup_Butt = new System.Windows.Forms.Button();
            this.chatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getMyChatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_1DataSet1 = new BiotestCompany.SAD_1DataSet1();
            this.getMyChatsTableAdapter = new BiotestCompany.SAD_1DataSet1TableAdapters.GetMyChatsTableAdapter();
            this.sAD_1DataSet = new BiotestCompany.SAD_1DataSet();
            this.getCustomerContactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCustomerContactsTableAdapter = new BiotestCompany.SAD_1DataSetTableAdapters.GetCustomerContactsTableAdapter();
            this.tableAdapterManager = new BiotestCompany.SAD_1DataSetTableAdapters.TableAdapterManager();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMyChatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerContactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chatIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.openingDTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getMyChatsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(143, 317);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Messages_txt
            // 
            this.Messages_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Messages_txt.Location = new System.Drawing.Point(205, 69);
            this.Messages_txt.Multiline = true;
            this.Messages_txt.Name = "Messages_txt";
            this.Messages_txt.ReadOnly = true;
            this.Messages_txt.Size = new System.Drawing.Size(419, 403);
            this.Messages_txt.TabIndex = 3;
            this.Messages_txt.TextChanged += new System.EventHandler(this.Messages_txt_TextChanged);
            // 
            // NewM_txt
            // 
            this.NewM_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NewM_txt.Location = new System.Drawing.Point(205, 486);
            this.NewM_txt.MaxLength = 50;
            this.NewM_txt.Name = "NewM_txt";
            this.NewM_txt.Size = new System.Drawing.Size(341, 24);
            this.NewM_txt.TabIndex = 4;
            // 
            // Send_Butt
            // 
            this.Send_Butt.BackColor = System.Drawing.Color.MidnightBlue;
            this.Send_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Send_Butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Send_Butt.ForeColor = System.Drawing.Color.Lavender;
            this.Send_Butt.Location = new System.Drawing.Point(552, 478);
            this.Send_Butt.Name = "Send_Butt";
            this.Send_Butt.Size = new System.Drawing.Size(72, 39);
            this.Send_Butt.TabIndex = 5;
            this.Send_Butt.Text = "Send";
            this.Send_Butt.UseVisualStyleBackColor = false;
            this.Send_Butt.Click += new System.EventHandler(this.Send_Butt_Click);
            // 
            // times_txt
            // 
            this.times_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.times_txt.Location = new System.Drawing.Point(630, 69);
            this.times_txt.Multiline = true;
            this.times_txt.Name = "times_txt";
            this.times_txt.ReadOnly = true;
            this.times_txt.Size = new System.Drawing.Size(129, 403);
            this.times_txt.TabIndex = 6;
            this.times_txt.TextChanged += new System.EventHandler(this.times_txt_TextChanged);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // newChat_Butt
            // 
            this.newChat_Butt.BackColor = System.Drawing.Color.MidnightBlue;
            this.newChat_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newChat_Butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.newChat_Butt.ForeColor = System.Drawing.Color.Lavender;
            this.newChat_Butt.Location = new System.Drawing.Point(27, 392);
            this.newChat_Butt.Name = "newChat_Butt";
            this.newChat_Butt.Size = new System.Drawing.Size(143, 37);
            this.newChat_Butt.TabIndex = 7;
            this.newChat_Butt.Text = "New Chat";
            this.newChat_Butt.UseVisualStyleBackColor = false;
            this.newChat_Butt.Click += new System.EventHandler(this.newChat_Butt_Click);
            // 
            // newGroup_Butt
            // 
            this.newGroup_Butt.BackColor = System.Drawing.Color.MidnightBlue;
            this.newGroup_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newGroup_Butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.newGroup_Butt.ForeColor = System.Drawing.Color.Lavender;
            this.newGroup_Butt.Location = new System.Drawing.Point(27, 435);
            this.newGroup_Butt.Name = "newGroup_Butt";
            this.newGroup_Butt.Size = new System.Drawing.Size(143, 37);
            this.newGroup_Butt.TabIndex = 8;
            this.newGroup_Butt.Text = "New Group Chat";
            this.newGroup_Butt.UseVisualStyleBackColor = false;
            this.newGroup_Butt.Click += new System.EventHandler(this.newGroup_Butt_Click);
            // 
            // chatIDDataGridViewTextBoxColumn
            // 
            this.chatIDDataGridViewTextBoxColumn.DataPropertyName = "chatID";
            this.chatIDDataGridViewTextBoxColumn.HeaderText = "chatID";
            this.chatIDDataGridViewTextBoxColumn.Name = "chatIDDataGridViewTextBoxColumn";
            this.chatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.chatIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // managerDataGridViewTextBoxColumn
            // 
            this.managerDataGridViewTextBoxColumn.DataPropertyName = "manager";
            this.managerDataGridViewTextBoxColumn.HeaderText = "manager";
            this.managerDataGridViewTextBoxColumn.Name = "managerDataGridViewTextBoxColumn";
            this.managerDataGridViewTextBoxColumn.ReadOnly = true;
            this.managerDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Open Chats";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.ToolTipText = "?";
            // 
            // openingDTDataGridViewTextBoxColumn
            // 
            this.openingDTDataGridViewTextBoxColumn.DataPropertyName = "openingDT";
            this.openingDTDataGridViewTextBoxColumn.HeaderText = "openingDT";
            this.openingDTDataGridViewTextBoxColumn.Name = "openingDTDataGridViewTextBoxColumn";
            this.openingDTDataGridViewTextBoxColumn.ReadOnly = true;
            this.openingDTDataGridViewTextBoxColumn.Visible = false;
            // 
            // getMyChatsBindingSource
            // 
            this.getMyChatsBindingSource.DataMember = "GetMyChats";
            this.getMyChatsBindingSource.DataSource = this.sAD_1DataSet1;
            // 
            // sAD_1DataSet1
            // 
            this.sAD_1DataSet1.DataSetName = "SAD_1DataSet1";
            this.sAD_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getMyChatsTableAdapter
            // 
            this.getMyChatsTableAdapter.ClearBeforeFill = true;
            // 
            // sAD_1DataSet
            // 
            this.sAD_1DataSet.DataSetName = "SAD_1DataSet";
            this.sAD_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getCustomerContactsBindingSource
            // 
            this.getCustomerContactsBindingSource.DataMember = "GetCustomerContacts";
            this.getCustomerContactsBindingSource.DataSource = this.sAD_1DataSet;
            // 
            // getCustomerContactsTableAdapter
            // 
            this.getCustomerContactsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BUSINESSMEETINGSTableAdapter = null;
            this.tableAdapterManager.CHATPARTSTableAdapter = null;
            this.tableAdapterManager.CHATSTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.SUPPLIERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BiotestCompany.SAD_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERINVITSTableAdapter = null;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BiotestCompany.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(-15, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1183, 378);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(201, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 78;
            this.label1.Text = "Messages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(626, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 79;
            this.label2.Text = "Sent at";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(23, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 80;
            this.label3.Text = "Your Chats";
            // 
            // ChatMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newGroup_Butt);
            this.Controls.Add(this.newChat_Butt);
            this.Controls.Add(this.times_txt);
            this.Controls.Add(this.Send_Butt);
            this.Controls.Add(this.NewM_txt);
            this.Controls.Add(this.Messages_txt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ChatMainForm";
            this.Text = "ChatMainForm";
            this.Load += new System.EventHandler(this.ChatMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMyChatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerContactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SAD_1DataSet sAD_1DataSet;
        private System.Windows.Forms.BindingSource getCustomerContactsBindingSource;
        private SAD_1DataSetTableAdapters.GetCustomerContactsTableAdapter getCustomerContactsTableAdapter;
        private SAD_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource getMyChatsBindingSource;
        private SAD_1DataSet1 sAD_1DataSet1;
        private SAD_1DataSet1TableAdapters.GetMyChatsTableAdapter getMyChatsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Messages_txt;
        private System.Windows.Forms.TextBox NewM_txt;
        private System.Windows.Forms.Button Send_Butt;
        private System.Windows.Forms.TextBox times_txt;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button newGroup_Butt;
        private System.Windows.Forms.Button newChat_Butt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}