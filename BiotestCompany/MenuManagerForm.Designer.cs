namespace BiotestCompany
{
    partial class MenuManagerForm
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.toUsersButton = new System.Windows.Forms.Button();
            this.toClientsButton = new System.Windows.Forms.Button();
            this.toSuppliersButton = new System.Windows.Forms.Button();
            this.to = new System.Windows.Forms.Button();
            this.toChatButton = new System.Windows.Forms.Button();
            this.toProfile_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MainLabel.Location = new System.Drawing.Point(31, 26);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(270, 16);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Please choose from the following options";
            this.MainLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // toUsersButton
            // 
            this.toUsersButton.Location = new System.Drawing.Point(34, 65);
            this.toUsersButton.Name = "toUsersButton";
            this.toUsersButton.Size = new System.Drawing.Size(81, 23);
            this.toUsersButton.TabIndex = 1;
            this.toUsersButton.Text = "Users";
            this.toUsersButton.UseVisualStyleBackColor = true;
            this.toUsersButton.Click += new System.EventHandler(this.toUsers_Click);
            // 
            // toClientsButton
            // 
            this.toClientsButton.Location = new System.Drawing.Point(34, 94);
            this.toClientsButton.Name = "toClientsButton";
            this.toClientsButton.Size = new System.Drawing.Size(81, 23);
            this.toClientsButton.TabIndex = 2;
            this.toClientsButton.Text = "Clients";
            this.toClientsButton.UseVisualStyleBackColor = true;
            this.toClientsButton.Click += new System.EventHandler(this.toClients_Click);
            // 
            // toSuppliersButton
            // 
            this.toSuppliersButton.Location = new System.Drawing.Point(34, 123);
            this.toSuppliersButton.Name = "toSuppliersButton";
            this.toSuppliersButton.Size = new System.Drawing.Size(81, 23);
            this.toSuppliersButton.TabIndex = 3;
            this.toSuppliersButton.Text = "Suppliers";
            this.toSuppliersButton.UseVisualStyleBackColor = true;
            this.toSuppliersButton.Click += new System.EventHandler(this.toSuppliers_Click);
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(34, 152);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(81, 23);
            this.to.TabIndex = 4;
            this.to.Text = "Products";
            this.to.UseVisualStyleBackColor = true;
            this.to.Click += new System.EventHandler(this.toProducts_Click);
            // 
            // toChatButton
            // 
            this.toChatButton.Location = new System.Drawing.Point(616, 455);
            this.toChatButton.Name = "toChatButton";
            this.toChatButton.Size = new System.Drawing.Size(75, 23);
            this.toChatButton.TabIndex = 5;
            this.toChatButton.Text = "Chat";
            this.toChatButton.UseVisualStyleBackColor = true;
            // 
            // toProfile_Button
            // 
            this.toProfile_Button.Location = new System.Drawing.Point(641, 12);
            this.toProfile_Button.Name = "toProfile_Button";
            this.toProfile_Button.Size = new System.Drawing.Size(75, 23);
            this.toProfile_Button.TabIndex = 10;
            this.toProfile_Button.Text = "My Profile";
            this.toProfile_Button.UseVisualStyleBackColor = true;
            // 
            // MenuManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 506);
            this.Controls.Add(this.toProfile_Button);
            this.Controls.Add(this.toChatButton);
            this.Controls.Add(this.to);
            this.Controls.Add(this.toSuppliersButton);
            this.Controls.Add(this.toClientsButton);
            this.Controls.Add(this.toUsersButton);
            this.Controls.Add(this.MainLabel);
            this.Name = "MenuManagerForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button toUsersButton;
        private System.Windows.Forms.Button toClientsButton;
        private System.Windows.Forms.Button toSuppliersButton;
        private System.Windows.Forms.Button to;
        private System.Windows.Forms.Button toChatButton;
        private System.Windows.Forms.Button toProfile_Button;
    }
}