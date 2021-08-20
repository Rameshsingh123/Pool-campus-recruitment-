using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PoolCampus
{
    public partial class Admin_ManageStudents : System.Web.UI.Page
    {
        BLL obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                obj = new BLL();
                DataTable tab = new DataTable();
                tab = obj.GetRegistrationStudent_CityId(int.Parse(ddlCity.SelectedValue));
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

        protected void lnkDownload_Click(object sender, EventArgs e)
        {
            string path = ((LinkButton)sender).CommandArgument;
            if (!path.Equals("null"))
            {
                string s = Server.MapPath(path);
                System.IO.FileInfo f = new System.IO.FileInfo(s);
                Response.Clear();
                Response.ContentType = "application/octet-stream";
                Response.AddHeader("content-Length", f.Length.ToString());
                Response.AddHeader("Content-Disposition", "attachment; filename=" + f.Name);
                Response.WriteFile(f.FullName);
                Response.End();
            }
        }

        protected void lnkApprove_Click(object sender, EventArgs e)
        {
            int Registration_Id = int.Parse(((LinkButton)sender).CommandArgument);
            obj = new BLL();
            obj.RegistrationApprove(Registration_Id);
            LoadData();
        }

        protected void lnkReject_Click(object sender, EventArgs e)
        {
            int Registration_Id = int.Parse(((LinkButton)sender).CommandArgument);
            obj = new BLL();
            obj.DeleteRegistrationStudent(Registration_Id);
            LoadData();
        }
    }
}