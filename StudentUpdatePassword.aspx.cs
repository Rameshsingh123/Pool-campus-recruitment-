using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoolCampus
{
    public partial class StudentUpdatePassword : System.Web.UI.Page
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
                if (obj.StudentOldPasswordCheck(Session["EmailId"].ToString(), txtOldPwd.Text))
                {
                    obj.UpdateStudentPassword(txtConPwd.Text, Session["EmailId"].ToString());
                    txtConPwd.Text = txtNewPwd.Text = txtOldPwd.Text = "";
                    Response.Write("<script>alert('Password Updated...')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Wrong Old Password')</script>");
                }
            }
            catch
            {
            }
        }
    }
}