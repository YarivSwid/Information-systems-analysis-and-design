namespace BiotestCompany
{
    partial class MenuSalesmanForm
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
            this.to = new System.Windows.Forms.Button();
            this.toSuppliersButton = new System.Windows.Forms.Button();
            this.toClientsButton = new System.Windows.Forms.Button();
            this.toProfile_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose from the following options";
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(51, 127);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(81, 23);
            this.to.TabIndex = 8;
            this.to.Text = "Products";
            this.to.UseVisualStyleBackColor = true;
            // 
            // toSuppliersButton
            // 
            this.toSuppliersButton.Location = new System.Drawing.Point(51, 98);
            this.toSuppliersButton.Name = "toSuppliersButton";
            this.toSuppliersButton.Size = new System.Drawing.Size(81, 23);
            this.toSuppliersButton.TabIndex = 7;
            this.toSuppliersButton.Text = "Suppliers";
            this.toSuppliersButton.UseVisualStyleBackColor = true;
            // 
            // toClientsButton
            // 
            this.toClientsButton.Location = new System.Drawing.Point(51, 69);
            this.toClientsButton.Name = "toClientsButton";
            this.toClientsButton.Size = new System.Drawing.Size(81, 23);
            this.toClientsButton.TabIndex = 6;
            this.toClientsButton.Text = "Clients";
            this.toClientsButton.UseVisualStyleBackColor = true;
            this.toClientsButton.Click += new System.EventHandler(this.toClientsButton_Click);
            // 
            // toProfile_Button
            // 
            this.toProfile_Button.Location = new System.Drawing.Point(652, 12);
            this.toProfile_Button.Name = "toProfile_Button";
            this.toProfile_Button.Size = new System.Drawing.Size(75, 23);
            this.toProfile_Button.TabIndex = 9;
            this.toProfile_Button.Text = "My Profile";
            this.toProfile_Button.UseVisualStyleBackColor = true;
            // 
            // MenuSalesmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 512);
            this.Controls.Add(this.toProfile_Button);
            this.Controls.Add(this.to);
            this.Controls.Add(this.toSuppliersButton);
            this.Controls.Add(this.toClientsButton);
            this.Controls.Add(this.label1);
            this.Name = "MenuSalesmanForm";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button to;
        private System.Windows.Forms.Button toSuppliersButton;
        private System.Windows.Forms.Button toClientsButton;
        private System.Windows.Forms.Button toProfile_Button;
    }
}