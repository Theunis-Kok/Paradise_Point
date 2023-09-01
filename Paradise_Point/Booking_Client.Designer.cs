namespace Paradise_Point
{
    partial class Booking_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking_Client));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbUnitNum = new System.Windows.Forms.ComboBox();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDays = new System.Windows.Forms.Label();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.lblDateLeave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "CellPhone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // btnBook
            // 
            this.btnBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBook.BackgroundImage")));
            this.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBook.Location = new System.Drawing.Point(98, 347);
            this.btnBook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(120, 49);
            this.btnBook.TabIndex = 5;
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Location = new System.Drawing.Point(481, 6);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(108, 35);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // cmbID
            // 
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(138, 82);
            this.cmbID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(212, 21);
            this.cmbID.TabIndex = 8;
            this.cmbID.SelectedIndexChanged += new System.EventHandler(this.cmbID_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(138, 129);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(212, 20);
            this.txtName.TabIndex = 9;
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(138, 177);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(212, 20);
            this.txtSurname.TabIndex = 10;
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Enabled = false;
            this.txtCellPhone.Location = new System.Drawing.Point(138, 224);
            this.txtCellPhone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(212, 20);
            this.txtCellPhone.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(138, 270);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // cmbUnitNum
            // 
            this.cmbUnitNum.FormattingEnabled = true;
            this.cmbUnitNum.Location = new System.Drawing.Point(411, 81);
            this.cmbUnitNum.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUnitNum.Name = "cmbUnitNum";
            this.cmbUnitNum.Size = new System.Drawing.Size(138, 21);
            this.cmbUnitNum.TabIndex = 13;
            this.cmbUnitNum.SelectedIndexChanged += new System.EventHandler(this.cmbUnitNum_SelectedIndexChanged);
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Location = new System.Drawing.Point(411, 118);
            this.lblUnitName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(41, 15);
            this.lblUnitName.TabIndex = 14;
            this.lblUnitName.Text = "label6";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(11, 6);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 35);
            this.btnBack.TabIndex = 15;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(411, 182);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(98, 15);
            this.lblDays.TabIndex = 16;
            this.lblDays.Text = "Number of Days:";
            // 
            // nudDays
            // 
            this.nudDays.Location = new System.Drawing.Point(414, 201);
            this.nudDays.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(135, 20);
            this.nudDays.TabIndex = 17;
            this.nudDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDays.ValueChanged += new System.EventHandler(this.nudDays_ValueChanged);
            // 
            // lblDateLeave
            // 
            this.lblDateLeave.AutoSize = true;
            this.lblDateLeave.Location = new System.Drawing.Point(416, 229);
            this.lblDateLeave.Name = "lblDateLeave";
            this.lblDateLeave.Size = new System.Drawing.Size(36, 15);
            this.lblDateLeave.TabIndex = 18;
            this.lblDateLeave.Text = "Date:";
            // 
            // Booking_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 436);
            this.Controls.Add(this.lblDateLeave);
            this.Controls.Add(this.nudDays);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblUnitName);
            this.Controls.Add(this.cmbUnitNum);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCellPhone);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Booking_Client";
            this.Text = "Booking_Client";
            this.Load += new System.EventHandler(this.Booking_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbUnitNum;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.Label lblDateLeave;
    }
}