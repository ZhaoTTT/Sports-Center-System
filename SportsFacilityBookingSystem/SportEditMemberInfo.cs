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
    public partial class SportEditMemberInfo : Form
    {
        public SportEditMemberInfo()
        {
            InitializeComponent();
        }

        private void EditMemberInfo_Load(object sender, EventArgs e)
        {
            this.Height = 1000;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
