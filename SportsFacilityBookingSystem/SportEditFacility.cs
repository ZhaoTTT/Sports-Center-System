using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFacilityBookingSystem
{
    public partial class SportEditFacility : Form
    {
        public SportEditFacility()
        {
            InitializeComponent();
        }
        NewSportsEntities ctx= new NewSportsEntities();
        List <FacilityDetail>fdList;
        List<AddFacility> afList;
        int posn = 0;
        SqlConnection cn;
        SqlCommand cm;

        private void SportEditFacility_Load(object sender, EventArgs e)
        {
            List<int> lst = ctx.AddFacilities.Select(x => x.FacilityCode).ToList();
            for(int i = 0; i < lst.Count; i++)
            {
                cbFC.Items.Add(lst[i]);
            }
            
        }


        private void btnFCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnupdateF_Click(object sender, EventArgs e)
        {
            string conS = "data source=(local);integrated security=SSPI;initial catalog=Team02A";
            cn = new SqlConnection(conS);
            cm = new SqlCommand();
            cm.CommandText = "Select * from AddFacility";
            cm.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cm);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            cn.Open();
            da.Fill(ds, "AddFacility");
            this.cbFC.SelectedIndexChanged -= new System.EventHandler(this.cbFC_SelectedIndexChanged);
            this.cbFN.SelectedIndexChanged -= new System.EventHandler(this.cbFN_SelectedIndexChanged);
            cbFC.DataSource = ds.Tables["AddFacility"];
            cbFN.DataSource = ds.Tables["AddFacility"];
            //BadC.DataBindings = ds.Tables["FacilityDetail"];
            //

            cbFC.DisplayMember = "FacilityCode";
            cbFN.DisplayMember = "FacilityName";
            
            //

            
            var qry = from x in ctx.AddFacilities select x;
            afList = qry.ToList<AddFacility>();
            afList[posn].FacilityName = cbFN.Text;

            var qry1 = from x in ctx.FacilityDetails select x;
            fdList = qry1.ToList<FacilityDetail>();
            fdList[posn].BadConditionQuantity = Convert.ToInt32(BadC.Text);

            ctx.SaveChanges();


            cn.Close();           

        }

        private void cbFC_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var qtd = from x in ctx.TransactionDetails select x;
            //tdList = qtd.ToList<TransactionDetail>();
            var qaf = from x in ctx.AddFacilities select x;
            afList = qaf.ToList<AddFacility>();

            posn = cbFC.SelectedIndex;
            cbFN.Text = afList[posn].FacilityName.ToString();
            //BadC.Text = tdList[posn].BadConditionQuantity.ToString();//transactiondetails table has no records which leads to error
        }

        private void cbFN_SelectedIndexChanged(object sender, EventArgs e)
        {
           // var qtd = from x in ctx.TransactionDetails select x;
            //tdList = qtd.ToList<TransactionDetail>();
            var qaf = from x in ctx.AddFacilities select x;
            afList = qaf.ToList<AddFacility>();

            posn = cbFN.SelectedIndex;
            cbFC.Text = afList[posn].FacilityCode.ToString();
            //BadC.Text = tdList[posn].BadConditionQuantity.ToString();
        }
    }
}
