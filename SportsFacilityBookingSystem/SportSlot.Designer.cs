namespace SportFacilityBookingSystem
{
    partial class SportSlot
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
            this.btnSlotCancel = new System.Windows.Forms.Button();
            this.btnaddSlot = new System.Windows.Forms.Button();
            this.tbSlotName = new System.Windows.Forms.TextBox();
            this.tbSlotID = new System.Windows.Forms.TextBox();
            this.lbSlotName = new System.Windows.Forms.Label();
            this.lbSlotID = new System.Windows.Forms.Label();
            this.btnSlotUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSlotCancel
            // 
            this.btnSlotCancel.Location = new System.Drawing.Point(453, 263);
            this.btnSlotCancel.Name = "btnSlotCancel";
            this.btnSlotCancel.Size = new System.Drawing.Size(119, 68);
            this.btnSlotCancel.TabIndex = 11;
            this.btnSlotCancel.Text = "Cancel";
            this.btnSlotCancel.UseVisualStyleBackColor = true;
            // 
            // btnaddSlot
            // 
            this.btnaddSlot.Location = new System.Drawing.Point(145, 264);
            this.btnaddSlot.Name = "btnaddSlot";
            this.btnaddSlot.Size = new System.Drawing.Size(121, 67);
            this.btnaddSlot.TabIndex = 10;
            this.btnaddSlot.Text = "Add";
            this.btnaddSlot.UseVisualStyleBackColor = true;
            // 
            // tbSlotName
            // 
            this.tbSlotName.Location = new System.Drawing.Point(321, 139);
            this.tbSlotName.Multiline = true;
            this.tbSlotName.Name = "tbSlotName";
            this.tbSlotName.Size = new System.Drawing.Size(251, 50);
            this.tbSlotName.TabIndex = 9;
            // 
            // tbSlotID
            // 
            this.tbSlotID.Location = new System.Drawing.Point(321, 53);
            this.tbSlotID.Multiline = true;
            this.tbSlotID.Name = "tbSlotID";
            this.tbSlotID.Size = new System.Drawing.Size(251, 45);
            this.tbSlotID.TabIndex = 8;
            // 
            // lbSlotName
            // 
            this.lbSlotName.AutoSize = true;
            this.lbSlotName.Location = new System.Drawing.Point(140, 151);
            this.lbSlotName.Name = "lbSlotName";
            this.lbSlotName.Size = new System.Drawing.Size(126, 29);
            this.lbSlotName.TabIndex = 7;
            this.lbSlotName.Text = "Slot Name";
            // 
            // lbSlotID
            // 
            this.lbSlotID.AutoSize = true;
            this.lbSlotID.Location = new System.Drawing.Point(140, 56);
            this.lbSlotID.Name = "lbSlotID";
            this.lbSlotID.Size = new System.Drawing.Size(84, 29);
            this.lbSlotID.TabIndex = 6;
            this.lbSlotID.Text = "Slot ID";
            // 
            // btnSlotUpdate
            // 
            this.btnSlotUpdate.Location = new System.Drawing.Point(304, 263);
            this.btnSlotUpdate.Name = "btnSlotUpdate";
            this.btnSlotUpdate.Size = new System.Drawing.Size(119, 68);
            this.btnSlotUpdate.TabIndex = 12;
            this.btnSlotUpdate.Text = "Update";
            this.btnSlotUpdate.UseVisualStyleBackColor = true;
            // 
            // SportSlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSlotUpdate);
            this.Controls.Add(this.btnSlotCancel);
            this.Controls.Add(this.btnaddSlot);
            this.Controls.Add(this.tbSlotName);
            this.Controls.Add(this.tbSlotID);
            this.Controls.Add(this.lbSlotName);
            this.Controls.Add(this.lbSlotID);
            this.Name = "SportSlot";
            this.Text = "SportSlot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSlotCancel;
        private System.Windows.Forms.Button btnaddSlot;
        private System.Windows.Forms.TextBox tbSlotName;
        private System.Windows.Forms.TextBox tbSlotID;
        private System.Windows.Forms.Label lbSlotName;
        private System.Windows.Forms.Label lbSlotID;
        private System.Windows.Forms.Button btnSlotUpdate;
    }
}