using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PoolCampus
{
    public partial class StudentViewVacancies : System.Web.UI.Page
    {
        BLL obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                LoadDesignation();
            }
        }

        private void LoadDesignation()
        {
            try
            {
                string cs=string.Format(@"Data Source=.\SQLEXPRESS;Initial Catalog=PoolCampus;Integrated Security=True");
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("select Distinct Designation from tblVacancies",con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable tab = new DataTable();
                adp.Fill(tab);  
                ddlDesignation.DataSource = tab;
                ddlDesignation.DataTextField = "Designation";
                ddlDesignation.DataValueField = "Designation";
                ddlDesignation.DataBind();
                ddlDesignation.Items.Insert(0, "--Select--");
            }
            catch
            {
            }
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                obj = new BLL();
                DataTable tab = new DataTable();
                tab = obj.GetVacancies_Designation(ddlDesignation.SelectedItem.Text, int.Parse(txtPUPercentage.Text), int.Parse(txtDegreePercentage.Text));
                if (tab.Rows.Count > 0)
                {
                    lblMsg.Text = "";
                    GridView1.DataSource = tab;
                    GridView1.DataBind();
                }
                else
                {
                    GridView1.Controls.Clear();
                    lblMsg.Text = "no records found";
                }
            }
            catch
            {
            }
        }
    }
}