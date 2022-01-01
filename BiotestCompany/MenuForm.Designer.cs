namespace BiotestCompany
{
    partial class MenuForm
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
            this.ButtUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtUsers
            // 
            this.ButtUsers.Location = new System.Drawing.Point(148, 246);
            this.ButtUsers.Name = "ButtUsers";
            this.ButtUsers.Size = new System.Drawing.Size(111, 41);
            this.ButtUsers.TabIndex = 0;
            this.ButtUsers.Text = "Manage Users";
            this.ButtUsers.UseVisualStyleBackColor = true;
            this.ButtUsers.Click += new System.EventHandler(this.ButtUsers_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 475);
            this.Controls.Add(this.ButtUsers);
            this.Name = "MenuForm";
            this.Text = "ManuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtUsers;
    }
}