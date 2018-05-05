using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFacilityBookingSystem
{
    public partial class Facility_Information : Form
    {
        public Facility_Information()
        {
            InitializeComponent();
        }

        NewSportsEntities ctx = new NewSportsEntities();

        private void btnFacilityAdd_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            toolStripStatusLabel1.Text = "Add";

            int rowsNo=dataGridView1.Rows.Count;

            SportAddFacility addFacility = new SportAddFacility();
            addFacility.ShowDialog();

            var q = from x in ctx.AddFacilities orderby x.FacilityCode select x;
            dataGridView1.DataSource = q.ToList();

            if (dataGridView1.Rows.Count > rowsNo)
            {
                timer1.Enabled = true;
                toolStripStatusLabel1.Text = "Add Successful";
            }
        }

        private void btnFacilityEdit_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            toolStripStatusLabel1.Text = "Edit";

            SportEditFacility editFacility = new SportEditFacility();
            editFacility.ShowDialog();      

        }

        private void btnFacilityCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Facility_Information_Load(object sender, EventArgs e)
        {
            var q = from x in ctx.AddFacilities orderby x.FacilityCode select x;
            dataGridView1.DataSource = q.ToList();
        }

        private void btnFacilityDelete_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            toolStripStatusLabel1.Text = "Delete";

            int nRow = Convert.ToInt32(textBox1.Text);

            AddFacility afDelete = ctx.AddFacilities.Where(x => x.FacilityCode == nRow).First();
            ctx.AddFacilities.Remove(afDelete);

            ctx.SaveChanges();
            textBox1.Text = "";
            
            MessageBox.Show("Delete Successful");
            timer1.Enabled = true;
            toolStripStatusLabel1.Text = "Delete Successful";

            var q = from x in ctx.AddFacilities orderby x.FacilityCode select x;
            dataGridView1.DataSource = q.ToList();
        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            string rowChoose = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = rowChoose;

            string rowChoose1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            timer1.Enabled = true;
            toolStripStatusLabel1.Text = rowChoose + "   " + rowChoose1;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            toolStripStatusLabel1.Text = "";
        }
    }
}
