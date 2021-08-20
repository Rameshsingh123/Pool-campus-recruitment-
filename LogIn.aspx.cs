using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoolCampus
{
    public partial class LogIn : System.Web.UI.Page
    {
        BLL obj;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                obj = new BLL();
                if (Request.Form["Type"].ToString()== "Admin")
                {
                    if (obj.AdminExist(Request.Form["Email"].ToString(), Request.Form["Password"].ToString()))
                    {
                        Response.Redirect("Admin_WelcomePage.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid User Credentials')</script>");
                    }
                }
                else if (Request.Form["Type"].ToString() == "Company")
                {
                    if (obj.Company_LogInverification(Request.Form["Email"].ToString(), Request.Form["Password"].ToString()))
                    {
                        Session["EmailId"] = Request.Form["Email"].ToString();
                        Response.Redirect("Company_HomePage.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid User Credentials')</script>");
                    }
                }
                else if (Request.Form["Type"].ToString() == "Student")
                {
                    if (obj.StudentLogInVerification(Request.Form["Email"].ToString(), Request.Form["Password"].ToString()))
                    {
                        Session["EmailId"] = Request.Form["Email"].ToString();
                        Response.Redirect("Student_HomePage.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid User Credentials')</script>");
                    }
                }
            }
            catch
            {
            }
        }
    }
}