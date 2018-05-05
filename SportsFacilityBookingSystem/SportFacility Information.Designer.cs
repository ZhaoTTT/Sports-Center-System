namespace SportFacilityBookingSystem
{
    partial class Facility_Information
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
            this.btnFacilityAdd = new System.Windows.Forms.Button();
            this.btnFacilityCancel = new System.Windows.Forms.Button();
            this.btnFacilityEdit = new System.Windows.Forms.Button();
            this.btnFacilityDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFacilityAdd
            // 
            this.btnFacilityAdd.Location = new System.Drawing.Point(31, 43);
            this.btnFacilityAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btnFacilityAdd.Name = "btnFacilityAdd";
            this.btnFacilityAdd.Size = new System.Drawing.Size(58, 26);
            this.btnFacilityAdd.TabIndex = 10;
            this.btnFacilityAdd.Text = "Add";
            this.btnFacilityAdd.UseVisualStyleBackColor = true;
            this.btnFacilityAdd.Click += new System.EventHandler(this.btnFacilityAdd_Click);
            // 
            // btnFacilityCancel
            // 
            this.btnFacilityCancel.Location = new System.Drawing.Point(315, 254);
            this.btnFacilityCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnFacilityCancel.Name = "btnFacilityCancel";
            this.btnFacilityCancel.Size = new System.Drawing.Size(52, 31);
            this.btnFacilityCancel.TabIndex = 9;
            this.btnFacilityCancel.Text = "Cancel";
            this.btnFacilityCancel.UseVisualStyleBackColor = true;
            this.btnFacilityCancel.Click += new System.EventHandler(this.btnFacilityCancel_Click);
            // 
            // btnFacilityEdit
            // 
            this.btnFacilityEdit.Location = new System.Drawing.Point(92, 43);
            this.btnFacilityEdit.Margin = new System.Windows.Forms.Padding(1);
            this.btnFacilityEdit.Name = "btnFacilityEdit";
            this.btnFacilityEdit.Size = new System.Drawing.Size(54, 26);
            this.btnFacilityEdit.TabIndex = 8;
            this.btnFacilityEdit.Text = "Edit";
            this.btnFacilityEdit.UseVisualStyleBackColor = true;
            this.btnFacilityEdit.Click += new System.EventHandler(this.btnFacilityEdit_Click);
            // 
            // btnFacilityDelete
            // 
            this.btnFacilityDelete.Location = new System.Drawing.Point(149, 43);
            this.btnFacilityDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btnFacilityDelete.Name = "btnFacilityDelete";
            this.btnFacilityDelete.Size = new System.Drawing.Size(52, 26);
            this.btnFacilityDelete.TabIndex = 7;
            this.btnFacilityDelete.Text = "Delete";
            this.btnFacilityDelete.UseVisualStyleBackColor = true;
            this.btnFacilityDelete.Click += new System.EventHandler(this.btnFacilityDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(336, 163);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 12;
            this.textBox1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 285);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(398, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(20, 17);
            this.toolStripStatusLabel1.Text = "   ";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Facility_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 307);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFacilityAdd);
            this.Controls.Add(this.btnFacilityCancel);
            this.Controls.Add(this.btnFacilityEdit);
            this.Controls.Add(this.btnFacilityDelete);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Facility_Information";
            this.Text = "Facility_Information";
            this.Load += new System.EventHandler(this.Facility_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFacilityAdd;
        private System.Windows.Forms.Button btnFacilityCancel;
        private System.Windows.Forms.Button btnFacilityEdit;
        private System.Windows.Forms.Button btnFacilityDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}