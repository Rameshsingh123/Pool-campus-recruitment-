using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PoolCampus
{
    public partial class AddCompany : System.Web.UI.Page
    {
        BLL obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                LoadCities();
                if (Request.QueryString["CompanyId"] != null)
                {
                    obj = new BLL();
                    DataTable tab = new DataTable();
                    tab = obj.GetCompanyDetails_CompanyId(int.Parse(Request.QueryString["CompanyId"]));
                    ddlCity.SelectedValue = tab.Rows[0]["City_Id"].ToString();
                    txtName.Text = tab.Rows[0]["Name"].ToString();
                    txtEmail.Text = tab.Rows[0]["EmailId"].ToString();
                    txtPwd.Text = tab.Rows[0]["Password"].ToString();
                    txtNumber.Text = tab.Rows[0]["ContactNumber"].ToString();
                    txtAddress.Text = tab.Rows[0]["Address"].ToString();
                    txtWebAddress.Text = tab.Rows[0]["WebAddress"].ToString();
                    btnSubmit.Text = "Update";
                }
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                obj = new BLL();
                if (btnSubmit.Text == "Submit")
                {
                    if (!obj.CompanyExist(txtEmail.Text))
                    {
                        obj.AddCompany(int.Parse(ddlCity.SelectedValue), txtName.Text, txtEmail.Text, txtPwd.Text, txtNumber.Text, txtAddress.Text, txtWebAddress.Text);
                        txtAddress.Text = txtEmail.Text = txtName.Text = txtNumber.Text = txtWebAddress.Text = txtPwd.Text = "";
                        ddlCity.SelectedIndex = 0;
                        Response.Write("<script>alert('Company Added Successfully')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Email Already Exist')</script>");
                    }
                }
                else
                {
                    obj.UpdateCompany_CompanyId(int.Parse(ddlCity.SelectedValue), txtName.Text, txtEmail.Text, txtPwd.Text, txtNumber.Text, txtAddress.Text, txtWebAddress.Text, int.Parse(Request.QueryString["CompanyId"]));
                    txtAddress.Text = txtEmail.Text = txtName.Text = txtNumber.Text = txtWebAddress.Text = txtPwd.Text = "";
                    ddlCity.SelectedIndex = 0;
                    btnSubmit.Text = "Submit";
                    Response.Write("<script>alert('Company Updated Successfully')</script>");
                }
            }
            catch
            {
            }
        }
    }
}