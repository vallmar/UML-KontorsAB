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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserStoryMain));
            this.picturBox = new System.Windows.Forms.PictureBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.imageListUserStorys = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picturBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picturBox
            // 
            this.picturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picturBox.Location = new System.Drawing.Point(132, 66);
            this.picturBox.Name = "picturBox";
            this.picturBox.Size = new System.Drawing.Size(1124, 663);
            this.picturBox.TabIndex = 0;
            this.picturBox.TabStop = false;
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(715, 750);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 23);
            this.btnForward.TabIndex = 1;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(532, 750);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // imageListUserStorys
            // 
            this.imageListUserStorys.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListUserStorys.ImageStream")));
            this.imageListUserStorys.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListUserStorys.Images.SetKeyName(0, "Dragon.jpg");
            this.imageListUserStorys.Images.SetKeyName(1, "Treasure.png");
            this.imageListUserStorys.Images.SetKeyName(2, "ADMINUSER.png");
            // 
            // UserStoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 794);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.picturBox);
            this.Name = "UserStoryMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserStoryMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturBox;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ImageList imageListUserStorys;
    }
}

