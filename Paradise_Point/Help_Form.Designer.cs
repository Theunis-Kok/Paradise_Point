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
            this.lstHelp.Items.AddRange(new object[] {
            "Maintain of Anything",
            resources.GetString("lstHelp.Items"),
            resources.GetString("lstHelp.Items1"),
            resources.GetString("lstHelp.Items2"),
            "",
            "Allocating Staff ",
            "",
            "1. Accessing Employee Allocation",
            "This form is designed to allocate staff members to different activities.",
            "2. Selecting Clients and Activities",
            "Upon launching the form, it will load available activities and staff members.",
            "Activities are listed with associated dropdowns for staff allocation.",
            "3. Displaying Activity Information",
            "If there are activities to allocate staff to (at least one), the form will displa" +
                "y the activity\'s name in labels.",
            "The corresponding staff allocation dropdown will also be visible.",
            "4. Choosing Staff Members",
            "Use the dropdowns to select staff members for each activity.",
            "Staff members should be allocated according to the corresponding activity.",
            "5. Cancelling Changes",
            "If you want to cancel your changes and reset the staff allocation, click the \"Can" +
                "cel\" button.",
            "This will revert the allocations to their previous state.",
            "9. Saving and Displaying Roster",
            "After allocating staff members to activities, click the \"Save\" button.",
            "A list will appear, displaying the roster for the current week.",
            "The roster will show each activity and the staff member allocated to it.",
            "7. Back to Dashboard",
            "To return to the main dashboard or home screen, click the \"Back\" button.",
            "",
            "Booking Client ",
            "",
            "1. Selecting a Client",
            "Locate and use the \"ID\" dropdown (combobox) to choose a client from the available" +
                " options.",
            "After selecting an ID, the associated unit number and location will be displayed " +
                "beneath the combobox.",
            "2. Choosing Booking Details",
            "Use the \"Unit Number\" field to select the desired unit number for the client\'s bo" +
                "oking.",
            "Observe that the location for the chosen unit number is automatically displayed.",
            "3. Setting the Booking Duration",
            "Utilize the \"Number of Days\" input field to specify the duration of the client\'s " +
                "stay.",
            "Ensure that the date displayed reflects the date the client should check out base" +
                "d on the selected number of days.",
            "",
            "",
            "4. Confirming the Booking",
            "Double-check that all the necessary information (client ID, unit number, number o" +
                "f days) is correctly filled in.",
            "Click the \"Book\" button to proceed with the booking.",
            "5. Successful Booking",
            "If all information is valid, a confirmation message will appear indicating that t" +
                "he client has been successfully booked.",
            "",
            "",
            "Booking Activity ",
            "Paradise Point Activity Booking Help:",
            "",
            "Select a Client ID from the dropdown.",
            "Choose a Client ID from the list provided in the dropdown menu.",
            "",
            "Choose an Activity name from the next dropdown.",
            "Select the desired Activity name from the available options in the dropdown.",
            "",
            "Adjust the number of participants if needed.",
            "Use the number input field to specify the number of participants for the activity" +
                ". You can increase or decrease this number as required.",
            "",
            "Enter the date and time for the activity in the following two text boxes.",
            "In the date textbox, input the date of the activity in the format yyyy-MM-dd.",
            "In the time textbox, enter the time of the activity.",
            "",
            "The total price will be calculated automatically and displayed.",
            "The system will automatically calculate the total price for the booking based on " +
                "the activity selected and the number of participants. The calculated price will " +
                "be displayed.",
            "",
            "Click the \'Book\' button to confirm the booking.",
            "To confirm the booking, click the \'Book\' button. This will save your booking info" +
                "rmation.",
            "",
            "Use the \'Cancel\' button to clear the form.",
            "If you wish to clear the form and start over, click the \'Cancel\' button. This wil" +
                "l reset the form fields.",
            "",
            "Click \'Back\' to return to the main dashboard.",
            "To navigate back to the main dashboard or the previous screen, click the \'Back\' b" +
                "utton.",
            "",
            "For assistance or issues, contact the resort staff.",
            "",
            "If you encounter any difficulties or need assistance, don\'t hesitate to reach out" +
                " to the resort staff for support. They are available to help you with any questi" +
                "ons or concerns you may have.",
            "",
            "",
            "",
            "",
            "",
            "Request Report",
            "",
            "Paradise Point Request Report Help:",
            "",
            "Viewing Activity Participation:",
            "On the first tab, you can view a chart displaying the number of participants for " +
                "each activity.",
            "The chart shows a breakdown of how many participants are registered for each acti" +
                "vity offered at Paradise Point.",
            "",
            "Top Three Most Popular Activities:",
            "Switch to the second tab to see a chart highlighting the top three activities wit" +
                "h the most participants.",
            "These activities have the highest number of participants, making them the most po" +
                "pular choices among guests.",
            "",
            "Navigating Back to the Dashboard:",
            "To return to the main dashboard, click the \'Back to Dashboard\' button located at " +
                "the top of the form.",
            "",
            "Loading Data on Form Load:",
            "The charts are automatically populated with data when the form is loaded.",
            "You don\'t need to perform any additional actions to view the reports.",
            "",
            "Additional Information:",
            "If you have any questions or encounter issues while using the report features, fe" +
                "el free to contact the resort staff for assistance.",
            "They are available to provide help and address any concerns you may have.",
            ""});
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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