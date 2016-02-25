namespace MarkusUserStorys
{
    partial class UserStoryMain
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
            this.picturBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picturBox
            // 
            this.picturBox.Location = new System.Drawing.Point(132, 90);
            this.picturBox.Name = "picturBox";
            this.picturBox.Size = new System.Drawing.Size(786, 472);
            this.picturBox.TabIndex = 0;
            this.picturBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 143);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserStoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picturBox);
            this.Name = "UserStoryMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picturBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturBox;
        private System.Windows.Forms.Button button1;
    }
}

