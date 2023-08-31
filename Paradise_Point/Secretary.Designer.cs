namespace Paradise_Point
{
    partial class Secretary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Secretary));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnBookClient = new System.Windows.Forms.Button();
            this.btnBookAct = new System.Windows.Forms.Button();
            this.btnMaintainClient = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(459, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 253);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(135, 298);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(120, 25);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Bob Burger";
            // 
            // btnBookClient
            // 
            this.btnBookClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookClient.BackgroundImage")));
            this.btnBookClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBookClient.Location = new System.Drawing.Point(140, 422);
            this.btnBookClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBookClient.Name = "btnBookClient";
            this.btnBookClient.Size = new System.Drawing.Size(285, 88);
            this.btnBookClient.TabIndex = 3;
            this.btnBookClient.UseVisualStyleBackColor = true;
            // 
            // btnBookAct
            // 
            this.btnBookAct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookAct.BackgroundImage")));
            this.btnBookAct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBookAct.Location = new System.Drawing.Point(140, 606);
            this.btnBookAct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBookAct.Name = "btnBookAct";
            this.btnBookAct.Size = new System.Drawing.Size(285, 88);
            this.btnBookAct.TabIndex = 4;
            this.btnBookAct.UseVisualStyleBackColor = true;
            // 
            // btnMaintainClient
            // 
            this.btnMaintainClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaintainClient.BackgroundImage")));
            this.btnMaintainClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaintainClient.Location = new System.Drawing.Point(639, 422);
            this.btnMaintainClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaintainClient.Name = "btnMaintainClient";
            this.btnMaintainClient.Size = new System.Drawing.Size(285, 88);
            this.btnMaintainClient.TabIndex = 5;
            this.btnMaintainClient.UseVisualStyleBackColor = true;
            this.btnMaintainClient.Click += new System.EventHandler(this.btnMaintainClient_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Location = new System.Drawing.Point(962, 34);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(220, 69);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.Location = new System.Drawing.Point(897, 802);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(285, 88);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Secretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 908);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnMaintainClient);
            this.Controls.Add(this.btnBookAct);
            this.Controls.Add(this.btnBookClient);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Secretary";
            this.Text = "Secretary";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnBookClient;
        private System.Windows.Forms.Button btnBookAct;
        private System.Windows.Forms.Button btnMaintainClient;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnLogOut;
    }
}