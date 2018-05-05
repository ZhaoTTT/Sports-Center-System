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
    public partial class SportRegisterMember : Form
    {
        public SportRegisterMember()
        {
            InitializeComponent();
        }

        private void lbMemberID_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 800;
            this.Width = 800;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Width = 200;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
