namespace SportFacilityBookingSystem
{
    partial class SportAddFacility
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
            this.lbFC = new System.Windows.Forms.Label();
            this.lbFN = new System.Windows.Forms.Label();
            this.tbaddFC = new System.Windows.Forms.TextBox();
            this.tbaddFN = new System.Windows.Forms.TextBox();
            this.btnaddF = new System.Windows.Forms.Button();
            this.btnFCancel = new System.Windows.Forms.Button();
            this.tbaddMC = new System.Windows.Forms.TextBox();
            this.tbaddV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFC
            // 
            this.lbFC.AutoSize = true;
            this.lbFC.Location = new System.Drawing.Point(71, 26);
            this.lbFC.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbFC.Name = "lbFC";
            this.lbFC.Size = new System.Drawing.Size(83, 12);
            this.lbFC.TabIndex = 0;
            this.lbFC.Text = "Facility Code";
            this.lbFC.Click += new System.EventHandler(this.lbFC_Click);
            // 
            // lbFN
            // 
            this.lbFN.AutoSize = true;
            this.lbFN.Location = new System.Drawing.Point(71, 66);
            this.lbFN.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbFN.Name = "lbFN";
            this.lbFN.Size = new System.Drawing.Size(83, 12);
            this.lbFN.TabIndex = 1;
            this.lbFN.Text = "Facility Name";
            // 
            // tbaddFC
            // 
            this.tbaddFC.Location = new System.Drawing.Point(185, 23);
            this.tbaddFC.Margin = new System.Windows.Forms.Padding(1);
            this.tbaddFC.Multiline = true;
            this.tbaddFC.Name = "tbaddFC";
            this.tbaddFC.Size = new System.Drawing.Size(110, 21);
            this.tbaddFC.TabIndex = 2;
            // 
            // tbaddFN
            // 
            this.tbaddFN.Location = new System.Drawing.Point(185, 63);
            this.tbaddFN.Margin = new System.Windows.Forms.Padding(1);
            this.tbaddFN.Multiline = true;
            this.tbaddFN.Name = "tbaddFN";
            this.tbaddFN.Size = new System.Drawing.Size(110, 23);
            this.tbaddFN.TabIndex = 3;
            // 
            // btnaddF
            // 
            this.btnaddF.Location = new System.Drawing.Point(112, 176);
            this.btnaddF.Margin = new System.Windows.Forms.Padding(1);
            this.btnaddF.Name = "btnaddF";
            this.btnaddF.Size = new System.Drawing.Size(52, 28);
            this.btnaddF.TabIndex = 4;
            this.btnaddF.Text = "Add";
            this.btnaddF.UseVisualStyleBackColor = true;
            this.btnaddF.Click += new System.EventHandler(this.btnaddF_Click);
            // 
            // btnFCancel
            // 
            this.btnFCancel.Location = new System.Drawing.Point(204, 176);
            this.btnFCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnFCancel.Name = "btnFCancel";
            this.btnFCancel.Size = new System.Drawing.Size(51, 28);
            this.btnFCancel.TabIndex = 5;
            this.btnFCancel.Text = "Cancel";
            this.btnFCancel.UseVisualStyleBackColor = true;
            this.btnFCancel.Click += new System.EventHandler(this.btnFCancel_Click);
            // 
            // tbaddMC
            // 
            this.tbaddMC.Location = new System.Drawing.Point(185, 135);
            this.tbaddMC.Margin = new System.Windows.Forms.Padding(1);
            this.tbaddMC.Multiline = true;
            this.tbaddMC.Name = "tbaddMC";
            this.tbaddMC.Size = new System.Drawing.Size(110, 23);
            this.tbaddMC.TabIndex = 9;
            // 
            // tbaddV
            // 
            this.tbaddV.Location = new System.Drawing.Point(185, 101);
            this.tbaddV.Margin = new System.Windows.Forms.Padding(1);
            this.tbaddV.Multiline = true;
            this.tbaddV.Name = "tbaddV";
            this.tbaddV.Size = new System.Drawing.Size(110, 21);
            this.tbaddV.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "MaxCourt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Venue";
            // 
            // SportAddFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 225);
            this.Controls.Add(this.tbaddMC);
            this.Controls.Add(this.tbaddV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFCancel);
            this.Controls.Add(this.btnaddF);
            this.Controls.Add(this.tbaddFN);
            this.Controls.Add(this.tbaddFC);
            this.Controls.Add(this.lbFN);
            this.Controls.Add(this.lbFC);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "SportAddFacility";
            this.Text = "AddFacility";
            this.Load += new System.EventHandler(this.SportAddFacility_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFC;
        private System.Windows.Forms.Label lbFN;
        private System.Windows.Forms.TextBox tbaddFC;
        private System.Windows.Forms.TextBox tbaddFN;
        private System.Windows.Forms.Button btnaddF;
        private System.Windows.Forms.Button btnFCancel;
        private System.Windows.Forms.TextBox tbaddMC;
        private System.Windows.Forms.TextBox tbaddV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}