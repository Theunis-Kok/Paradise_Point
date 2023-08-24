namespace Paradise_Point
{
    partial class Help_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help_Form));
            this.lstHelp = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstHelp
            // 
            this.lstHelp.FormattingEnabled = true;
            this.lstHelp.ItemHeight = 16;
            this.lstHelp.Location = new System.Drawing.Point(51, 31);
            this.lstHelp.Name = "lstHelp";
            this.lstHelp.Size = new System.Drawing.Size(519, 276);
            this.lstHelp.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(51, 335);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(159, 48);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Help_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 405);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstHelp);
            this.Name = "Help_Form";
            this.Text = "Help_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstHelp;
        private System.Windows.Forms.Button btnBack;
    }
}