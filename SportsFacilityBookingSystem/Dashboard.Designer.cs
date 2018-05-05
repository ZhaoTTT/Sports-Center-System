namespace SportFacilityBookingSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnManageFacility = new System.Windows.Forms.Button();
            this.btnManageMember = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSlot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManageFacility
            // 
            this.btnManageFacility.Location = new System.Drawing.Point(114, 500);
            this.btnManageFacility.Name = "btnManageFacility";
            this.btnManageFacility.Size = new System.Drawing.Size(143, 112);
            this.btnManageFacility.TabIndex = 3;
            this.btnManageFacility.Text = "Manage Facility";
            this.btnManageFacility.UseVisualStyleBackColor = true;
            this.btnManageFacility.Click += new System.EventHandler(this.btnManageFacility_Click);
            // 
            // btnManageMember
            // 
            this.btnManageMember.Location = new System.Drawing.Point(114, 122);
            this.btnManageMember.Name = "btnManageMember";
            this.btnManageMember.Size = new System.Drawing.Size(143, 129);
            this.btnManageMember.TabIndex = 2;
            this.btnManageMember.Text = "Manage Memeber";
            this.btnManageMember.UseVisualStyleBackColor = true;
            this.btnManageMember.Click += new System.EventHandler(this.btnManageMember_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(879, 511);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(118, 112);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(864, 121);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(133, 130);
            this.btnBooking.TabIndex = 4;
            this.btnBooking.Text = "Booking System";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(386, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSlot
            // 
            this.btnSlot.Location = new System.Drawing.Point(486, 511);
            this.btnSlot.Name = "btnSlot";
            this.btnSlot.Size = new System.Drawing.Size(131, 101);
            this.btnSlot.TabIndex = 7;
            this.btnSlot.Text = "Slot";
            this.btnSlot.UseVisualStyleBackColor = true;
            this.btnSlot.Click += new System.EventHandler(this.btnSlot_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 802);
            this.Controls.Add(this.btnSlot);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnManageFacility);
            this.Controls.Add(this.btnManageMember);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageFacility;
        private System.Windows.Forms.Button btnManageMember;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSlot;
    }
}