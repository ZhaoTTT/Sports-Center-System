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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnManageMember_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.ShowDialog();
        }

        private void btnManageFacility_Click(object sender, EventArgs e)
        {
            Facility_Information facility_Information = new Facility_Information();
            facility_Information.ShowDialog();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            SportBookingSystem bookingSystem = new SportBookingSystem();
            bookingSystem.ShowDialog();
        }

        private void btnSlot_Click(object sender, EventArgs e)
        {
            SportSlot sportSlot = new SportSlot();
            sportSlot.ShowDialog();
        }
    }
}
