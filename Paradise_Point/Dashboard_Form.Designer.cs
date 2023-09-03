namespace Paradise_Point
{
    partial class Dashboard_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Form));
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBookClient = new System.Windows.Forms.Button();
            this.btnBookAct = new System.Windows.Forms.Button();
            this.btnAllocateStaff = new System.Windows.Forms.Button();
            this.btnReqReport = new System.Windows.Forms.Button();
            this.btnMaintainClient = new System.Windows.Forms.Button();
            this.btnMaintainUnit = new System.Windows.Forms.Button();
            this.btnMaintainEmployee = new System.Windows.Forms.Button();
            this.btnMaintainAct = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip9 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(91, 30);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(75, 16);
<<<<<<< HEAD
=======
            this.lblUserName.Size = new System.Drawing.Size(69, 15);
>>>>>>> 243653aa62b1c6366da3bf4040e19d7aee83b3e4
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Bob Burger";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnBookClient
            // 
            this.btnBookClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookClient.BackgroundImage")));
            this.btnBookClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBookClient.Location = new System.Drawing.Point(37, 114);
            this.btnBookClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookClient.Name = "btnBookClient";
            this.btnBookClient.Size = new System.Drawing.Size(192, 57);
            this.btnBookClient.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnBookClient, "This button will navigate you to the Booking Client form where you can book a cli" +
        "ent");
            this.btnBookClient.UseVisualStyleBackColor = true;
            this.btnBookClient.Click += new System.EventHandler(this.btnBookClient_Click);
            // 
            // btnBookAct
            // 
            this.btnBookAct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookAct.BackgroundImage")));
            this.btnBookAct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBookAct.Location = new System.Drawing.Point(37, 197);
            this.btnBookAct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookAct.Name = "btnBookAct";
            this.btnBookAct.Size = new System.Drawing.Size(192, 57);
            this.btnBookAct.TabIndex = 3;
            this.toolTip2.SetToolTip(this.btnBookAct, "This button will navigate you to the Booking Activity form where you can book an " +
        "activity");
            this.btnBookAct.UseVisualStyleBackColor = true;
            this.btnBookAct.Click += new System.EventHandler(this.btnBookAct_Click);
            // 
            // btnAllocateStaff
            // 
            this.btnAllocateStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAllocateStaff.BackgroundImage")));
            this.btnAllocateStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllocateStaff.Location = new System.Drawing.Point(37, 276);
            this.btnAllocateStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllocateStaff.Name = "btnAllocateStaff";
            this.btnAllocateStaff.Size = new System.Drawing.Size(192, 57);
            this.btnAllocateStaff.TabIndex = 4;
            this.toolTip3.SetToolTip(this.btnAllocateStaff, "This button will navigate you to the Allocating Staff form where you can assign s" +
        "taff to activities");
            this.btnAllocateStaff.UseVisualStyleBackColor = true;
            this.btnAllocateStaff.Click += new System.EventHandler(this.btnAllocateStaff_Click_1);
            // 
            // btnReqReport
            // 
            this.btnReqReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReqReport.BackgroundImage")));
            this.btnReqReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReqReport.Location = new System.Drawing.Point(37, 354);
            this.btnReqReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReqReport.Name = "btnReqReport";
            this.btnReqReport.Size = new System.Drawing.Size(192, 57);
            this.btnReqReport.TabIndex = 5;
            this.toolTip4.SetToolTip(this.btnReqReport, "This button will navigate you to the Request Report form where you can view activ" +
        "ies with their participants");
            this.btnReqReport.UseVisualStyleBackColor = true;
            this.btnReqReport.Click += new System.EventHandler(this.btnReqReport_Click);
            // 
            // btnMaintainClient
            // 
            this.btnMaintainClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaintainClient.BackgroundImage")));
            this.btnMaintainClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaintainClient.Location = new System.Drawing.Point(360, 114);
            this.btnMaintainClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaintainClient.Name = "btnMaintainClient";
            this.btnMaintainClient.Size = new System.Drawing.Size(192, 57);
            this.btnMaintainClient.TabIndex = 6;
            this.toolTip5.SetToolTip(this.btnMaintainClient, "This button will navigate you to the Maintain Clients form where you can add,dele" +
        "te or update client information");
            this.btnMaintainClient.UseVisualStyleBackColor = true;
            this.btnMaintainClient.Click += new System.EventHandler(this.btnMaintainClient_Click);
            // 
            // btnMaintainUnit
            // 
            this.btnMaintainUnit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaintainUnit.BackgroundImage")));
            this.btnMaintainUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaintainUnit.Location = new System.Drawing.Point(360, 197);
            this.btnMaintainUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaintainUnit.Name = "btnMaintainUnit";
            this.btnMaintainUnit.Size = new System.Drawing.Size(192, 57);
            this.btnMaintainUnit.TabIndex = 7;
            this.toolTip6.SetToolTip(this.btnMaintainUnit, "This button will navigate you to the Maintain Units form where you can add, delet" +
        "e or update unit information");
            this.btnMaintainUnit.UseVisualStyleBackColor = true;
            this.btnMaintainUnit.Click += new System.EventHandler(this.btnMaintainUnit_Click_1);
            // 
            // btnMaintainEmployee
            // 
            this.btnMaintainEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaintainEmployee.BackgroundImage")));
            this.btnMaintainEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaintainEmployee.Location = new System.Drawing.Point(360, 276);
            this.btnMaintainEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaintainEmployee.Name = "btnMaintainEmployee";
            this.btnMaintainEmployee.Size = new System.Drawing.Size(192, 57);
            this.btnMaintainEmployee.TabIndex = 8;
            this.toolTip7.SetToolTip(this.btnMaintainEmployee, "This button will navigate you to the Maintain Employee form where you can add, de" +
        "lete or update information of employees");
            this.btnMaintainEmployee.UseVisualStyleBackColor = true;
            this.btnMaintainEmployee.Click += new System.EventHandler(this.btnMaintainEmployee_Click_1);
            // 
            // btnMaintainAct
            // 
            this.btnMaintainAct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaintainAct.BackgroundImage")));
            this.btnMaintainAct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaintainAct.Location = new System.Drawing.Point(360, 354);
            this.btnMaintainAct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaintainAct.Name = "btnMaintainAct";
            this.btnMaintainAct.Size = new System.Drawing.Size(192, 57);
            this.btnMaintainAct.TabIndex = 9;
            this.toolTip8.SetToolTip(this.btnMaintainAct, "This button will navigate you to the Maintain Activity form where you can add, de" +
        "lete and update activity information");
            this.btnMaintainAct.UseVisualStyleBackColor = true;
            this.btnMaintainAct.Click += new System.EventHandler(this.btnMaintainAct_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.Location = new System.Drawing.Point(596, 497);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(192, 57);
            this.btnLogOut.TabIndex = 10;
            this.toolTip9.SetToolTip(this.btnLogOut, "This button will log you out of the system");
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Location = new System.Drawing.Point(648, 14);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(140, 41);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Dashboard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnMaintainAct);
            this.Controls.Add(this.btnMaintainEmployee);
            this.Controls.Add(this.btnMaintainUnit);
            this.Controls.Add(this.btnMaintainClient);
            this.Controls.Add(this.btnReqReport);
            this.Controls.Add(this.btnAllocateStaff);
            this.Controls.Add(this.btnBookAct);
            this.Controls.Add(this.btnBookClient);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "Dashboard_Form";
            this.Text = "Dashboard_Form";
            this.Load += new System.EventHandler(this.Dashboard_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBookClient;
        private System.Windows.Forms.Button btnBookAct;
        private System.Windows.Forms.Button btnAllocateStaff;
        private System.Windows.Forms.Button btnReqReport;
        private System.Windows.Forms.Button btnMaintainClient;
        private System.Windows.Forms.Button btnMaintainUnit;
        private System.Windows.Forms.Button btnMaintainEmployee;
        private System.Windows.Forms.Button btnMaintainAct;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip9;
    }
}