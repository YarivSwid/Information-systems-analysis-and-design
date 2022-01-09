namespace BiotestCompany
{
    partial class CRUDproductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDproductForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.biotestDataSet = new BiotestCompany.BiotestDataSet();
            this.biotestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_1DataSet3 = new BiotestCompany.SAD_1DataSet3();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTSTableAdapter = new BiotestCompany.SAD_1DataSet3TableAdapters.PRODUCTSTableAdapter();
            this.getAllCustomerOrderProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAllCustomerOrderProductsTableAdapter = new BiotestCompany.SAD_1DataSet3TableAdapters.GetAllCustomerOrderProductsTableAdapter();
            this.getCustomerOrderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_1DataSet = new BiotestCompany.SAD_1DataSet();
            this.getCustomerOrderDetailsTableAdapter = new BiotestCompany.SAD_1DataSetTableAdapters.getCustomerOrderDetailsTableAdapter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Out_Butt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.biotestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biotestDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllCustomerOrderProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerOrderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Location = new System.Drawing.Point(146, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // biotestDataSet
            // 
            this.biotestDataSet.DataSetName = "BiotestDataSet";
            this.biotestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biotestDataSetBindingSource
            // 
            this.biotestDataSetBindingSource.DataSource = this.biotestDataSet;
            this.biotestDataSetBindingSource.Position = 0;
            // 
            // sAD_1DataSet3
            // 
            this.sAD_1DataSet3.DataSetName = "SAD_1DataSet3";
            this.sAD_1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.sAD_1DataSet3;
            // 
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // getAllCustomerOrderProductsBindingSource
            // 
            this.getAllCustomerOrderProductsBindingSource.DataMember = "GetAllCustomerOrderProducts";
            this.getAllCustomerOrderProductsBindingSource.DataSource = this.sAD_1DataSet3;
            // 
            // getAllCustomerOrderProductsTableAdapter
            // 
            this.getAllCustomerOrderProductsTableAdapter.ClearBeforeFill = true;
            // 
            // getCustomerOrderDetailsBindingSource
            // 
            this.getCustomerOrderDetailsBindingSource.DataMember = "getCustomerOrderDetails";
            this.getCustomerOrderDetailsBindingSource.DataSource = this.sAD_1DataSet;
            // 
            // sAD_1DataSet
            // 
            this.sAD_1DataSet.DataSetName = "SAD_1DataSet";
            this.sAD_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getCustomerOrderDetailsTableAdapter
            // 
            this.getCustomerOrderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(56, 125);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(687, 290);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button1.Location = new System.Drawing.Point(410, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Out_Butt
            // 
            this.Out_Butt.BackColor = System.Drawing.Color.MidnightBlue;
            this.Out_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Out_Butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Out_Butt.ForeColor = System.Drawing.Color.Lavender;
            this.Out_Butt.Location = new System.Drawing.Point(717, 469);
            this.Out_Butt.Name = "Out_Butt";
            this.Out_Butt.Size = new System.Drawing.Size(117, 64);
            this.Out_Butt.TabIndex = 79;
            this.Out_Butt.Text = "Finished";
            this.Out_Butt.UseVisualStyleBackColor = false;
            this.Out_Butt.Click += new System.EventHandler(this.Out_Butt_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Lavender;
            this.button3.Location = new System.Drawing.Point(212, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 48);
            this.button3.TabIndex = 89;
            this.button3.Text = "Pricing Tool";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MidnightBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Lavender;
            this.button5.Location = new System.Drawing.Point(56, 478);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 48);
            this.button5.TabIndex = 87;
            this.button5.Text = "Create Customer Bid";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BiotestCompany.Properties.Resources._843256_medical_512x512_96034;
            this.pictureBox2.Location = new System.Drawing.Point(587, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiotestCompany.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(983, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // CRUDproductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(861, 544);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Out_Butt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CRUDproductForm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.CRUDproductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biotestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biotestDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllCustomerOrderProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerOrderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource biotestDataSetBindingSource;
        private BiotestDataSet biotestDataSet;
        private SAD_1DataSet3 sAD_1DataSet3;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private SAD_1DataSet3TableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private System.Windows.Forms.BindingSource getAllCustomerOrderProductsBindingSource;
        private SAD_1DataSet3TableAdapters.GetAllCustomerOrderProductsTableAdapter getAllCustomerOrderProductsTableAdapter;
        private SAD_1DataSet sAD_1DataSet;
        private System.Windows.Forms.BindingSource getCustomerOrderDetailsBindingSource;
        private SAD_1DataSetTableAdapters.getCustomerOrderDetailsTableAdapter getCustomerOrderDetailsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Out_Butt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}