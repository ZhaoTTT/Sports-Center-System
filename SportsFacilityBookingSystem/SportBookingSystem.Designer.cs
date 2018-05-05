namespace SportFacilityBookingSystem
{
    partial class SportBookingSystem
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
            this.lbBookingID = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbBookFacilityCode = new System.Windows.Forms.Label();
            this.lbBookDate = new System.Windows.Forms.Label();
            this.lbSlot = new System.Windows.Forms.Label();
            this.lbRemark = new System.Windows.Forms.Label();
            this.tbbookingTransactionID = new System.Windows.Forms.TextBox();
            this.tbBookRemark = new System.Windows.Forms.TextBox();
            this.cbMemberID = new System.Windows.Forms.ComboBox();
            this.cbFC = new System.Windows.Forms.ComboBox();
            this.btnBookbrowse = new System.Windows.Forms.Button();
            this.btnbookFC = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbBSlot = new System.Windows.Forms.ComboBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnBcancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBookingID
            // 
            this.lbBookingID.AutoSize = true;
            this.lbBookingID.Location = new System.Drawing.Point(87, 33);
            this.lbBookingID.Name = "lbBookingID";
            this.lbBookingID.Size = new System.Drawing.Size(263, 29);
            this.lbBookingID.TabIndex = 0;
            this.lbBookingID.Text = "Booking Transaction ID";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(218, 112);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(132, 29);
            this.lbMemberID.TabIndex = 1;
            this.lbMemberID.Text = "Member ID";
            // 
            // lbBookFacilityCode
            // 
            this.lbBookFacilityCode.AutoSize = true;
            this.lbBookFacilityCode.Location = new System.Drawing.Point(197, 197);
            this.lbBookFacilityCode.Name = "lbBookFacilityCode";
            this.lbBookFacilityCode.Size = new System.Drawing.Size(153, 29);
            this.lbBookFacilityCode.TabIndex = 2;
            this.lbBookFacilityCode.Text = "Facility Code";
            // 
            // lbBookDate
            // 
            this.lbBookDate.AutoSize = true;
            this.lbBookDate.Location = new System.Drawing.Point(281, 291);
            this.lbBookDate.Name = "lbBookDate";
            this.lbBookDate.Size = new System.Drawing.Size(69, 29);
            this.lbBookDate.TabIndex = 3;
            this.lbBookDate.Text = "Date ";
            // 
            // lbSlot
            // 
            this.lbSlot.AutoSize = true;
            this.lbSlot.Location = new System.Drawing.Point(295, 373);
            this.lbSlot.Name = "lbSlot";
            this.lbSlot.Size = new System.Drawing.Size(55, 29);
            this.lbSlot.TabIndex = 4;
            this.lbSlot.Text = "Slot";
            // 
            // lbRemark
            // 
            this.lbRemark.AutoSize = true;
            this.lbRemark.Location = new System.Drawing.Point(253, 514);
            this.lbRemark.Name = "lbRemark";
            this.lbRemark.Size = new System.Drawing.Size(97, 29);
            this.lbRemark.TabIndex = 5;
            this.lbRemark.Text = "Remark";
            // 
            // tbbookingTransactionID
            // 
            this.tbbookingTransactionID.Location = new System.Drawing.Point(400, 30);
            this.tbbookingTransactionID.Multiline = true;
            this.tbbookingTransactionID.Name = "tbbookingTransactionID";
            this.tbbookingTransactionID.Size = new System.Drawing.Size(314, 57);
            this.tbbookingTransactionID.TabIndex = 6;
            // 
            // tbBookRemark
            // 
            this.tbBookRemark.Location = new System.Drawing.Point(400, 467);
            this.tbBookRemark.Multiline = true;
            this.tbBookRemark.Name = "tbBookRemark";
            this.tbBookRemark.Size = new System.Drawing.Size(300, 134);
            this.tbBookRemark.TabIndex = 7;
            // 
            // cbMemberID
            // 
            this.cbMemberID.FormattingEnabled = true;
            this.cbMemberID.Location = new System.Drawing.Point(400, 112);
            this.cbMemberID.Name = "cbMemberID";
            this.cbMemberID.Size = new System.Drawing.Size(195, 37);
            this.cbMemberID.TabIndex = 8;
            // 
            // cbFC
            // 
            this.cbFC.FormattingEnabled = true;
            this.cbFC.Location = new System.Drawing.Point(400, 197);
            this.cbFC.Name = "cbFC";
            this.cbFC.Size = new System.Drawing.Size(195, 37);
            this.cbFC.TabIndex = 9;
            // 
            // btnBookbrowse
            // 
            this.btnBookbrowse.Location = new System.Drawing.Point(638, 112);
            this.btnBookbrowse.Name = "btnBookbrowse";
            this.btnBookbrowse.Size = new System.Drawing.Size(39, 37);
            this.btnBookbrowse.TabIndex = 10;
            this.btnBookbrowse.Text = "....";
            this.btnBookbrowse.UseVisualStyleBackColor = true;
            // 
            // btnbookFC
            // 
            this.btnbookFC.Location = new System.Drawing.Point(638, 197);
            this.btnbookFC.Name = "btnbookFC";
            this.btnbookFC.Size = new System.Drawing.Size(39, 37);
            this.btnbookFC.TabIndex = 11;
            this.btnbookFC.Text = "...";
            this.btnbookFC.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(400, 286);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // cbBSlot
            // 
            this.cbBSlot.FormattingEnabled = true;
            this.cbBSlot.Items.AddRange(new object[] {
            "9 am",
            "10 am",
            "11 am",
            "12 am",
            "1 pm",
            "2 pm",
            "3 pm",
            "4 pm",
            "5 pm",
            "6 pm",
            "7 pm",
            "8 pm",
            ""});
            this.cbBSlot.Location = new System.Drawing.Point(400, 365);
            this.cbBSlot.Name = "cbBSlot";
            this.cbBSlot.Size = new System.Drawing.Size(130, 37);
            this.cbBSlot.TabIndex = 13;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(324, 671);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(116, 69);
            this.btnBook.TabIndex = 14;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            // 
            // btnBcancel
            // 
            this.btnBcancel.Location = new System.Drawing.Point(571, 671);
            this.btnBcancel.Name = "btnBcancel";
            this.btnBcancel.Size = new System.Drawing.Size(129, 69);
            this.btnBcancel.TabIndex = 15;
            this.btnBcancel.Text = "Cancel";
            this.btnBcancel.UseVisualStyleBackColor = true;
            // 
            // BookingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 868);
            this.Controls.Add(this.btnBcancel);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.cbBSlot);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnbookFC);
            this.Controls.Add(this.btnBookbrowse);
            this.Controls.Add(this.cbFC);
            this.Controls.Add(this.cbMemberID);
            this.Controls.Add(this.tbBookRemark);
            this.Controls.Add(this.tbbookingTransactionID);
            this.Controls.Add(this.lbRemark);
            this.Controls.Add(this.lbSlot);
            this.Controls.Add(this.lbBookDate);
            this.Controls.Add(this.lbBookFacilityCode);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.lbBookingID);
            this.Name = "BookingSystem";
            this.Text = "BookingSystem";
            this.Load += new System.EventHandler(this.BookingSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBookingID;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbBookFacilityCode;
        private System.Windows.Forms.Label lbBookDate;
        private System.Windows.Forms.Label lbSlot;
        private System.Windows.Forms.Label lbRemark;
        private System.Windows.Forms.TextBox tbbookingTransactionID;
        private System.Windows.Forms.TextBox tbBookRemark;
        private System.Windows.Forms.ComboBox cbMemberID;
        private System.Windows.Forms.ComboBox cbFC;
        private System.Windows.Forms.Button btnBookbrowse;
        private System.Windows.Forms.Button btnbookFC;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbBSlot;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnBcancel;
    }
}