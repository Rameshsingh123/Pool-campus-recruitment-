using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoolCampus
{
    public partial class Admin_WelcomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WelCome();
        }

        private void WelCome()
        {
            try
            {
                int Hour = DateTime.Now.Hour;
                if (Hour < 12)
                {
                    lblMsg.Text = "Good Morning Admin!";
                    lblMsg.Font.Size = 25;
                }
                else if (Hour >= 12 & Hour < 16)
                {
                    lblMsg.Text = "Good Afternoon Admin!";
                    lblMsg.Font.Size = 25;
                }
                else
                {
                    lblMsg.Text = "Good Evening Admin!";
                    lblMsg.Font.Size = 25;
                }
            }
            catch
            {
            }
        }
    }
}