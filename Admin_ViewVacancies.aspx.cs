using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PoolCampus
{
    public partial class Admin_ViewVacancies : System.Web.UI.Page
    {
        BLL obj;
        CheckBox chk;
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

        protected void ddlCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadVacancies();
        }

        private void LoadVacancies()
        {
            try
            {
                obj = new BLL();
                DataTable tab = new DataTable();
                tab = obj.GetCompanyVacancies_ComnpanyId(int.Parse(ddlCompany.SelectedValue));
                if (tab.Rows.Count > 0)
                {
                    lblMsg.Text = "";
                    //GridView1.Controls.Clear();
                    GridView1.DataSource = tab;
                    GridView1.DataBind();
                }
                else
                {
                    GridView1.Controls.Clear();
                    lblMsg.Text = "no vacancies...";
                }
            }
            catch
            {
            }
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCompanies();
        }

        private void LoadCompanies()
        {
            try
            {
                obj = new BLL();
                DataTable tab = new DataTable();
                tab = obj.GetCompanies_City(int.Parse(ddlCity.SelectedValue));
                ddlCompany.DataSource = tab;
                ddlCompany.DataTextField = "Name";
                ddlCompany.DataValueField = "Company_Id";
                ddlCompany.DataBind();
                ddlCompany.Items.Insert(0, "--Select--");
            }
            catch
            {
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Visible = true;
            (((sender as CheckBox).Parent.Parent) as GridViewRow).FindControl("TextBox1").Visible = (sender as CheckBox).Checked;
            (((sender as CheckBox).Parent.Parent) as GridViewRow).FindControl("TextBox2").Visible = (sender as CheckBox).Checked;
        }

        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                int Count = 0;
                obj = new BLL();
                foreach (GridViewRow row in GridView1.Rows)
                {
                    chk = row.FindControl("CheckBox1") as CheckBox;
                    if (chk.Checked)
                    {
                        Count++;
                        string Location = (row.FindControl("TextBox1") as TextBox).Text;
                        DateTime Date = DateTime.Parse((row.FindControl("TextBox2") as TextBox).Text);
                        int VacancyId=int.Parse(chk.Text);
                        obj.AddCampusLocation(Location, Date, VacancyId);
                    }
                    chk.Checked = false;
                    ((TextBox)row.FindControl("TextBox1")).Visible = false;
                    ((TextBox)row.FindControl("TextBox2")).Visible = false;
                }
                if (Count > 0)
                {
                    btnSaveChanges.Visible = false;
                    Response.Write("<script>alert('Changes Saved')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Select Something...')</script>");
                }
            }
            catch
            {
            }
        }
    }
}