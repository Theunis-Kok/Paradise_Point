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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking_Activity));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbActivities = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.nudNumPartisipants = new System.Windows.Forms.NumericUpDown();
            this.errorClientID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorActivities = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNumParticipant = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTime = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumPartisipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorClientID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumParticipant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 454);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 558);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 363);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of participants";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 662);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // cmbActivities
            // 
            this.cmbActivities.FormattingEnabled = true;
            this.cmbActivities.Location = new System.Drawing.Point(336, 248);
            this.cmbActivities.Margin = new System.Windows.Forms.Padding(4);
            this.cmbActivities.Name = "cmbActivities";
            this.cmbActivities.Size = new System.Drawing.Size(362, 33);
            this.cmbActivities.TabIndex = 5;
            this.cmbActivities.SelectedIndexChanged += new System.EventHandler(this.cmbActivities_SelectedIndexChanged);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(336, 450);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(362, 31);
            this.txtDate.TabIndex = 6;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(336, 544);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(362, 31);
            this.txtTime.TabIndex = 7;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(330, 662);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(27, 25);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "R";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Location = new System.Drawing.Point(160, 771);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(314, 83);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBook.BackgroundImage")));
            this.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBook.Location = new System.Drawing.Point(638, 771);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(314, 83);
            this.btnBook.TabIndex = 11;
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Location = new System.Drawing.Point(898, 19);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(236, 67);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::Paradise_Point.Properties.Resources.Back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(24, 19);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(250, 67);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Client ID";
            // 
            // cmbID
            // 
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(336, 135);
            this.cmbID.Margin = new System.Windows.Forms.Padding(6);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(362, 33);
            this.cmbID.TabIndex = 16;
            // 
            // nudNumPartisipants
            // 
            this.nudNumPartisipants.Location = new System.Drawing.Point(440, 348);
            this.nudNumPartisipants.Margin = new System.Windows.Forms.Padding(6);
            this.nudNumPartisipants.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudNumPartisipants.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumPartisipants.Name = "nudNumPartisipants";
            this.nudNumPartisipants.Size = new System.Drawing.Size(262, 31);
            this.nudNumPartisipants.TabIndex = 17;
            this.nudNumPartisipants.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumPartisipants.ValueChanged += new System.EventHandler(this.nudNumPartisipants_ValueChanged);
            // 
            // errorClientID
            // 
            this.errorClientID.ContainerControl = this;
            // 
            // errorActivities
            // 
            this.errorActivities.ContainerControl = this;
            // 
            // errorNumParticipant
            // 
            this.errorNumParticipant.ContainerControl = this;
            // 
            // errorDate
            // 
            this.errorDate.ContainerControl = this;
            // 
            // errorTime
            // 
            this.errorTime.ContainerControl = this;
            // 
            // errDate
            // 
            this.errDate.ContainerControl = this;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // Booking_Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1154, 985);
            this.Controls.Add(this.nudNumPartisipants);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.cmbActivities);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Booking_Activity";
            this.Text = "Booking_Activity";
            this.Load += new System.EventHandler(this.Booking_Activity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumPartisipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorClientID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumParticipant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
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
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.NumericUpDown nudNumPartisipants;
        private System.Windows.Forms.ErrorProvider errorClientID;
        private System.Windows.Forms.ErrorProvider errorActivities;
        private System.Windows.Forms.ErrorProvider errorNumParticipant;
        private System.Windows.Forms.ErrorProvider errorDate;
        private System.Windows.Forms.ErrorProvider errorTime;
        private System.Windows.Forms.ErrorProvider errDate;
        private System.Windows.Forms.ErrorProvider err;
    }
}