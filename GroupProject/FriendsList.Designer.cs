
namespace GroupProject
{
    partial class FriendsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendsList));
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.friendsPictureBox = new System.Windows.Forms.PictureBox();
            this.homePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.BackColor = System.Drawing.Color.White;
            this.searchPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("searchPictureBox.Image")));
            this.searchPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("searchPictureBox.InitialImage")));
            this.searchPictureBox.Location = new System.Drawing.Point(841, 30);
            this.searchPictureBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(109, 91);
            this.searchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPictureBox.TabIndex = 16;
            this.searchPictureBox.TabStop = false;
            // 
            // friendsPictureBox
            // 
            this.friendsPictureBox.BackColor = System.Drawing.Color.White;
            this.friendsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.friendsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("friendsPictureBox.Image")));
            this.friendsPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("friendsPictureBox.InitialImage")));
            this.friendsPictureBox.Location = new System.Drawing.Point(1011, 33);
            this.friendsPictureBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.friendsPictureBox.Name = "friendsPictureBox";
            this.friendsPictureBox.Size = new System.Drawing.Size(109, 91);
            this.friendsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.friendsPictureBox.TabIndex = 15;
            this.friendsPictureBox.TabStop = false;
            // 
            // homePictureBox
            // 
            this.homePictureBox.BackColor = System.Drawing.Color.White;
            this.homePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("homePictureBox.Image")));
            this.homePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("homePictureBox.InitialImage")));
            this.homePictureBox.Location = new System.Drawing.Point(1169, 30);
            this.homePictureBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.homePictureBox.Name = "homePictureBox";
            this.homePictureBox.Size = new System.Drawing.Size(109, 91);
            this.homePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homePictureBox.TabIndex = 14;
            this.homePictureBox.TabStop = false;
            // 
            // FriendsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 856);
            this.Controls.Add(this.searchPictureBox);
            this.Controls.Add(this.friendsPictureBox);
            this.Controls.Add(this.homePictureBox);
            this.Name = "FriendsList";
            this.Text = "FriendsList";
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox searchPictureBox;
        private System.Windows.Forms.PictureBox friendsPictureBox;
        private System.Windows.Forms.PictureBox homePictureBox;
    }
}