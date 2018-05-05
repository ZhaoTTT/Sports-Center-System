namespace SportFacilityBookingSystem
{
    partial class SportEditFacility
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
            this.btnFCancel = new System.Windows.Forms.Button();
            this.btnupdateF = new System.Windows.Forms.Button();
            this.lbFN = new System.Windows.Forms.Label();
            this.lbFC = new System.Windows.Forms.Label();
            this.BadC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFC = new System.Windows.Forms.ComboBox();
            this.cbFN = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnFCancel
            // 
            this.btnFCancel.Location = new System.Drawing.Point(228, 149);
            this.btnFCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnFCancel.Name = "btnFCancel";
            this.btnFCancel.Size = new System.Drawing.Size(51, 28);
            this.btnFCancel.TabIndex = 11;
            this.btnFCancel.Text = "Cancel";
            this.btnFCancel.UseVisualStyleBackColor = true;
            this.btnFCancel.Click += new System.EventHandler(this.btnFCancel_Click);
            // 
            // btnupdateF
            // 
            this.btnupdateF.Location = new System.Drawing.Point(129, 149);
            this.btnupdateF.Margin = new System.Windows.Forms.Padding(1);
            this.btnupdateF.Name = "btnupdateF";
            this.btnupdateF.Size = new System.Drawing.Size(52, 28);
            this.btnupdateF.TabIndex = 10;
            this.btnupdateF.Text = "Update";
            this.btnupdateF.UseVisualStyleBackColor = true;
            this.btnupdateF.Click += new System.EventHandler(this.btnupdateF_Click);
            // 
            // lbFN
            // 
            this.lbFN.AutoSize = true;
            this.lbFN.Location = new System.Drawing.Point(99, 71);
            this.lbFN.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbFN.Name = "lbFN";
            this.lbFN.Size = new System.Drawing.Size(83, 12);
            this.lbFN.TabIndex = 7;
            this.lbFN.Text = "Facility Name";
            // 
            // lbFC
            // 
            this.lbFC.AutoSize = true;
            this.lbFC.Location = new System.Drawing.Point(99, 31);
            this.lbFC.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbFC.Name = "lbFC";
            this.lbFC.Size = new System.Drawing.Size(83, 12);
            this.lbFC.TabIndex = 6;
            this.lbFC.Text = "Facility Code";
            // 
            // BadC
            // 
            this.BadC.Location = new System.Drawing.Point(187, 106);
            this.BadC.Margin = new System.Windows.Forms.Padding(1);
            this.BadC.Multiline = true;
            this.BadC.Name = "BadC";
            this.BadC.Size = new System.Drawing.Size(110, 23);
            this.BadC.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bad Condition";
            // 
            // cbFC
            // 
            this.cbFC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFC.FormattingEnabled = true;
            this.cbFC.Location = new System.Drawing.Point(187, 31);
            this.cbFC.Name = "cbFC";
            this.cbFC.Size = new System.Drawing.Size(110, 20);
            this.cbFC.TabIndex = 14;
            this.cbFC.SelectedIndexChanged += new System.EventHandler(this.cbFC_SelectedIndexChanged);
            // 
            // cbFN
            // 
            this.cbFN.FormattingEnabled = true;
            this.cbFN.Location = new System.Drawing.Point(187, 71);
            this.cbFN.Name = "cbFN";
            this.cbFN.Size = new System.Drawing.Size(110, 20);
            this.cbFN.TabIndex = 15;
            this.cbFN.SelectedIndexChanged += new System.EventHandler(this.cbFN_SelectedIndexChanged);
            // 
            // SportEditFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 307);
            this.Controls.Add(this.cbFN);
            this.Controls.Add(this.cbFC);
            this.Controls.Add(this.BadC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFCancel);
            this.Controls.Add(this.btnupdateF);
            this.Controls.Add(this.lbFN);
            this.Controls.Add(this.lbFC);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "SportEditFacility";
            this.Text = "EditFacility";
            this.Load += new System.EventHandler(this.SportEditFacility_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFCancel;
        private System.Windows.Forms.Button btnupdateF;
        private System.Windows.Forms.Label lbFN;
        private System.Windows.Forms.Label lbFC;
        private System.Windows.Forms.TextBox BadC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFC;
        private System.Windows.Forms.ComboBox cbFN;
    }
}