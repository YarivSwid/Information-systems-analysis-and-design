namespace BiotestCompany
{
    partial class ProductsCRUDform
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchUser_Button = new System.Windows.Forms.Button();
            this.uSERSDataGridView = new System.Windows.Forms.DataGridView();
            this.AddUser_Button = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userAddSerialBox = new System.Windows.Forms.TextBox();
            this.userAddFirstNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductAddNumUnitsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please choose from the following options";
            // 
            // searchUser_Button
            // 
            this.searchUser_Button.Location = new System.Drawing.Point(175, 72);
            this.searchUser_Button.Name = "searchUser_Button";
            this.searchUser_Button.Size = new System.Drawing.Size(75, 23);
            this.searchUser_Button.TabIndex = 35;
            this.searchUser_Button.Text = "Search";
            this.searchUser_Button.UseVisualStyleBackColor = true;
            // 
            // uSERSDataGridView
            // 
            this.uSERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uSERSDataGridView.Location = new System.Drawing.Point(29, 100);
            this.uSERSDataGridView.Name = "uSERSDataGridView";
            this.uSERSDataGridView.Size = new System.Drawing.Size(807, 146);
            this.uSERSDataGridView.TabIndex = 34;
            // 
            // AddUser_Button
            // 
            this.AddUser_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AddUser_Button.Location = new System.Drawing.Point(286, 383);
            this.AddUser_Button.Name = "AddUser_Button";
            this.AddUser_Button.Size = new System.Drawing.Size(49, 23);
            this.AddUser_Button.TabIndex = 33;
            this.AddUser_Button.Text = "Add";
            this.AddUser_Button.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 361);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 31;
            this.textBox1.Text = "Serial number or type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Role";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(29, 387);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(165, 21);
            this.comboBox4.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Date of birth";
            // 
            // userAddSerialBox
            // 
            this.userAddSerialBox.Location = new System.Drawing.Point(29, 335);
            this.userAddSerialBox.Name = "userAddSerialBox";
            this.userAddSerialBox.Size = new System.Drawing.Size(165, 20);
            this.userAddSerialBox.TabIndex = 27;
            this.userAddSerialBox.Text = "Serial ID";
            // 
            // userAddFirstNameBox
            // 
            this.userAddFirstNameBox.Location = new System.Drawing.Point(29, 283);
            this.userAddFirstNameBox.Name = "userAddFirstNameBox";
            this.userAddFirstNameBox.Size = new System.Drawing.Size(165, 20);
            this.userAddFirstNameBox.TabIndex = 25;
            this.userAddFirstNameBox.Text = "Serial number (?)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(26, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Search products";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(26, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Add product";
            // 
            // ProductAddNumUnitsBox
            // 
            this.ProductAddNumUnitsBox.Location = new System.Drawing.Point(29, 309);
            this.ProductAddNumUnitsBox.Name = "ProductAddNumUnitsBox";
            this.ProductAddNumUnitsBox.Size = new System.Drawing.Size(165, 20);
            this.ProductAddNumUnitsBox.TabIndex = 26;
            this.ProductAddNumUnitsBox.Text = "Number of units";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(483, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "בעיקרון צריך לחשוב אם יש כזה קרוד, אולי יתווסף אוטומטית כשיוצרים הזמנה או אנא עאר" +
    "ף";
            // 
            // ProductsCRUDform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchUser_Button);
            this.Controls.Add(this.uSERSDataGridView);
            this.Controls.Add(this.AddUser_Button);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userAddSerialBox);
            this.Controls.Add(this.ProductAddNumUnitsBox);
            this.Controls.Add(this.userAddFirstNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductsCRUDform";
            this.Text = "ProductsCRUDform";
            ((System.ComponentModel.ISupportInitialize)(this.uSERSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchUser_Button;
        private System.Windows.Forms.DataGridView uSERSDataGridView;
        private System.Windows.Forms.Button AddUser_Button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userAddSerialBox;
        private System.Windows.Forms.TextBox userAddFirstNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductAddNumUnitsBox;
        private System.Windows.Forms.Label label3;
    }
}