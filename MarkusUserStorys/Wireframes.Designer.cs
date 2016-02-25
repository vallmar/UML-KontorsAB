namespace MarkusUserStorys
{
    partial class Wireframes
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
            this.btnUserDesktop = new System.Windows.Forms.Button();
            this.btnUserMobile = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnAdminDesktop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserDesktop
            // 
            this.btnUserDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDesktop.Location = new System.Drawing.Point(12, 31);
            this.btnUserDesktop.Name = "btnUserDesktop";
            this.btnUserDesktop.Size = new System.Drawing.Size(225, 62);
            this.btnUserDesktop.TabIndex = 0;
            this.btnUserDesktop.Text = "Desktop";
            this.btnUserDesktop.UseVisualStyleBackColor = true;
            this.btnUserDesktop.Click += new System.EventHandler(this.btnUserDesktop_Click);
            // 
            // btnUserMobile
            // 
            this.btnUserMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserMobile.Location = new System.Drawing.Point(12, 99);
            this.btnUserMobile.Name = "btnUserMobile";
            this.btnUserMobile.Size = new System.Drawing.Size(225, 62);
            this.btnUserMobile.TabIndex = 1;
            this.btnUserMobile.Text = "Mobile";
            this.btnUserMobile.UseVisualStyleBackColor = true;
            this.btnUserMobile.Click += new System.EventHandler(this.btnUserMobile_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(103, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(98, 185);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(52, 17);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "Admin";
            // 
            // btnAdminDesktop
            // 
            this.btnAdminDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDesktop.Location = new System.Drawing.Point(13, 207);
            this.btnAdminDesktop.Name = "btnAdminDesktop";
            this.btnAdminDesktop.Size = new System.Drawing.Size(225, 62);
            this.btnAdminDesktop.TabIndex = 3;
            this.btnAdminDesktop.Text = "Desktop";
            this.btnAdminDesktop.UseVisualStyleBackColor = true;
            this.btnAdminDesktop.Click += new System.EventHandler(this.btnAdminDesktop_Click);
            // 
            // Wireframes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 287);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnAdminDesktop);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnUserMobile);
            this.Controls.Add(this.btnUserDesktop);
            this.Name = "Wireframes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wireframes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserDesktop;
        private System.Windows.Forms.Button btnUserMobile;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnAdminDesktop;
    }
}