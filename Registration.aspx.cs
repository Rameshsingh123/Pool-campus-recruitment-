using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace PoolCampus
{
    public partial class Registration : System.Web.UI.Page
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
            LoadCollege();
        }

        private void LoadCollege()
        {
            try
            {
                obj = new BLL();
                DataTable tab = new DataTable();
                tab = obj.GetColleges_CityId(int.Parse(ddlCity.SelectedValue));
                ddlCollege.DataSource = tab;
                ddlCollege.DataTextField = "Name";
                ddlCollege.DataValueField = "College_Id";
                ddlCollege.DataBind();
                ddlCollege.Items.Insert(0, "--Select--");
            }
            catch
            {
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                obj = new BLL();
                string Image = FileUpload1.FileName;
                string Resume = FileUpload2.FileName;
                if (!FileUpload1.HasFile && !FileUpload2.HasFile)
                {
                    Response.Write("<script>alert('Upload File...')</script>");
                }
                else
                {
                    string imageExt = Path.GetExtension(Image).ToLower();
                    if (imageExt == ".jpg" | imageExt == ".jpeg" | imageExt == ".png" | imageExt == ".gif")
                    {
                        string resumeExt = Path.GetExtension(Resume).ToLower();
                        if (resumeExt == ".pdf")
                        {
                            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Photos/" + Image));
                            string Image1 = "~/Photos/" + Image.ToString();
                            FileUpload2.PostedFile.SaveAs(Server.MapPath("~/Photos/" + Resume));
                            string Resume1 = "~/Photos/" + Resume.ToString();
                            obj.StudentRegistration(Request.Form["name"].ToString(), Request.Form["email-address"].ToString(), Request.Form["password"].ToString(), int.Parse(ddlCollege.SelectedValue), Request.Form["mobile-number"].ToString(), Image1, Resume1);
                            ddlCity.SelectedIndex = ddlCollege.SelectedIndex = 0;
                            Response.Write("<script>alert('Registration Successful...')</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('Select only pdf for resume...')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Select only image files for photo...')</script>");
                    }
                }
            }
            catch
            {
            }
        }
    }
}