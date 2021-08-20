using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PoolCampus
{
    public partial class Admin_ViewColleges : System.Web.UI.Page
    {
        BLL obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                LoadCities();
            }
        }

        private void LoadCities()
        {
            try
            {
                obj = new BLL();
                DataTable tab = new DataTable();
                tab = obj.GetCities();
                ddlCity.DataSource = tab;
                ddlCity.DataTextField = "CityName";
                ddlCity.DataValueField = "City_Id";
                ddlCity.DataBind();
                ddlCity.Items.Insert(0, "--Select--");
            }
            catch
            {
            }
        }

        private void LoadColleges()
        {
            try
            {
                obj = new BLL();
                DataTable tab = new DataTable();
                tab = obj.GetColleges_CityId(int.Parse(ddlCity.SelectedValue));
                if (tab.Rows.Count > 0)
                {
                    lblMsg.Text = "";
                    GridView1.DataSource = tab;
                    GridView1.DataBind();
                }
                else
                {
                    GridView1.Controls.Clear();
                    lblMsg.Text = "no records found...";
                }
            }
            catch
            {
            }
        }

        protected void lnkEdit_Click(object sender, EventArgs e)
        {
            int CollegeId = int.Parse(((LinkButton)sender).CommandArgument);
            Response.Redirect("AddCollege.aspx?CollegeId=" + CollegeId);
        }

        protected void lnkDelete_Click(object sender, EventArgs e)
        {
            int CollegeId = int.Parse(((LinkButton)sender).CommandArgument);
            obj = new BLL();
            obj.DeleteCollege_CollegeId(CollegeId);
            LoadColleges();
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadColleges();
        }
    }
}