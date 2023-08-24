namespace Paradise_Point
{
    partial class Booking_Activity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking_Activity));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbActivities = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.dudNumParticipants = new System.Windows.Forms.DomainUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of participants";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // cmbActivities
            // 
            this.cmbActivities.FormattingEnabled = true;
            this.cmbActivities.Location = new System.Drawing.Point(222, 105);
            this.cmbActivities.Name = "cmbActivities";
            this.cmbActivities.Size = new System.Drawing.Size(243, 24);
            this.cmbActivities.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(222, 176);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(243, 22);
            this.txtDate.TabIndex = 6;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(222, 253);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(243, 22);
            this.txtTime.TabIndex = 7;
            // 
            // dudNumParticipants
            // 
            this.dudNumParticipants.Location = new System.Drawing.Point(277, 320);
            this.dudNumParticipants.Name = "dudNumParticipants";
            this.dudNumParticipants.Size = new System.Drawing.Size(188, 22);
            this.dudNumParticipants.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(222, 399);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(17, 16);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "R";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Location = new System.Drawing.Point(107, 494);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(209, 53);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            this.btnBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBook.BackgroundImage")));
            this.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBook.Location = new System.Drawing.Point(425, 494);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(209, 53);
            this.btnBook.TabIndex = 11;
            this.btnBook.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Location = new System.Drawing.Point(599, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(158, 43);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // Booking_Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 630);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.dudNumParticipants);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.cmbActivities);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Booking_Activity";
            this.Text = "Booking_Activity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbActivities;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.DomainUpDown dudNumParticipants;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnHelp;
    }
}