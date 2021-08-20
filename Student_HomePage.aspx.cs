using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PoolCampus
{
    public partial class Student_HomePage : System.Web.UI.Page
    {
        BLL obj = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tab = new DataTable();
                tab = obj.GetStudentDetails_EmailId(Session["EmailId"].ToString());
                int Hour = DateTime.Now.Hour;
                if (Hour < 12)
                {
                    lblMsg.Text = "Good Morning " + tab.Rows[0]["Name"] + "!!!";
                    lblMsg.Font.Size = 25;
                }
                else if (Hour >= 12 & Hour < 16)
                {
                    lblMsg.Text = "Good Afternoon " + tab.Rows[0]["Name"] + "!!!";
                    lblMsg.Font.Size = 25;
                }
                else
                {
                    lblMsg.Text = "Good Evening " + tab.Rows[0]["Name"] + "!!!";
                    lblMsg.Font.Size = 25;
                }
            }
            catch
            {
            }
        }
    }
}