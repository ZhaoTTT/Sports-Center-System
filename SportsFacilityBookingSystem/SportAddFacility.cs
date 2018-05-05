using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFacilityBookingSystem
{
    public partial class SportAddFacility : Form
    {
        public SportAddFacility()
        {
            InitializeComponent();
        }
        NewSportsEntities ctx = new NewSportsEntities();

        private void lbFC_Click(object sender, EventArgs e)
        {

        }

        private void SportAddFacility_Load(object sender, EventArgs e)
        {
            int maxCode = ctx.AddFacilities.Select(x => x.FacilityCode).Max();
            tbaddFC.Text = Convert.ToString(maxCode + 1);
        }

        private void btnFCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnaddF_Click(object sender, EventArgs e)
        {
            AddFacility f = new AddFacility();
            FacilityDetail fd = new FacilityDetail();

            f.FacilityCode = Convert.ToInt32(tbaddFC.Text);
            f.FacilityName = tbaddFN.Text;
            f.Venue = tbaddV.Text;
            f.MaxCount = Convert.ToInt32(tbaddMC.Text);
            
            fd.FacilityCode = Convert.ToInt32(tbaddFC.Text);
            fd.FacilityName= tbaddFN.Text;               

            ///
            ///
            ctx.AddFacilities.Add(f);
            ctx.FacilityDetails.Add(fd);


            ctx.SaveChanges();

            MessageBox.Show("Add Successful");


        }
    }
}
