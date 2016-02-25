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
            // UserStoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 626);
            this.Controls.Add(this.picturBox);
            this.Name = "UserStoryMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picturBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturBox;
    }
}

