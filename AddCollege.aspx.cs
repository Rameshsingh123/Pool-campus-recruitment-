using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace PoolCampus
{
    public partial class ManageCollege : System.Web.UI.Page
    {
        BLL obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                LoadCities();
                if (Request.QueryString["CollegeId"] != null)
                {
                    obj = new BLL();
                    DataTable tab = new DataTable();
                    tab = obj.GetCollege_CollegeId(int.Parse(Request.QueryString["CollegeId"]));
                    ddlCity.SelectedValue = tab.Rows[0]["City_Id"].ToString();
                    txtCollegeName.Text = tab.Rows[0]["Name"].ToString();
                    txtEmail.Text = tab.Rows[0]["EmailId"].ToString();
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
                if (btnSubmit.Text == "Submit")
                {
                    obj = new BLL();
                    if (!obj.CollegeExist(txtEmail.Text))
                    {
                        string path = Server.MapPath("~/images/" + FileUpload1.FileName);
                        string ext = Path.GetExtension(path);
                        if (FileUpload1.HasFile)
                        {
                            if (ext == ".jpg" | ext == ".jpeg" | ext == ".png" | ext == ".gif")
                            {
                                FileUpload1.SaveAs(path);
                                string Image = "~/images/" + FileUpload1.FileName;
                                obj.AddCollege(int.Parse(ddlCity.SelectedValue),txtCollegeName.Text, txtEmail.Text, txtNumber.Text, Image, txtAddress.Text, txtWebAddress.Text);
                                txtAddress.Text = txtCollegeName.Text = txtEmail.Text = txtNumber.Text = txtWebAddress.Text = "";
                                ddlCity.SelectedIndex = 0;
                                Response.Write("<script>alert('College Added Successfully')</script>");
                            }
                            else
                            {
                                Response.Write("<script>alert('Select Imagefiles Only...')</script>");
                            }
                        }
                        else
                        {
                            Response.Write("<script>alert('Select Image File...')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Email Already Exist')</script>");
                    }
                }
                else
                {
                    string path = Server.MapPath("~/images/" + FileUpload1.FileName);
                    string ext = Path.GetExtension(path).ToLower();
                    if (FileUpload1.HasFile)
                    {
                        if (ext == ".jpg" | ext == ".jpeg" | ext == ".png" | ext == ".gif")
                        {
                            obj = new BLL();
                            FileUpload1.SaveAs(path);
                            string Image = "~/images/" + FileUpload1.FileName;
                            obj.UpdateCollege_CollegeId(int.Parse(ddlCity.SelectedValue),txtCollegeName.Text, txtEmail.Text, txtNumber.Text, Image, txtAddress.Text, txtWebAddress.Text, int.Parse(Request.QueryString["CollegeId"]));
                            txtAddress.Text = txtCollegeName.Text = txtEmail.Text = txtNumber.Text = txtWebAddress.Text = "";
                            ddlCity.SelectedIndex = 0;
                            btnSubmit.Text = "Submit";
                            Response.Write("<script>alert('College Updated Successfully')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Select Image File...')</script>");
                    }
                }
            }
            catch
            {
            }
        }
    }
}