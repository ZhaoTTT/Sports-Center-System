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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SportEditMemberInfo Einfo = new SportEditMemberInfo();
            Einfo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SportRegisterMember rm = new SportRegisterMember();
            rm.ShowDialog();
        }

        private void gridscreen_Load(object sender, EventArgs e)
        {

        }
    }
}
