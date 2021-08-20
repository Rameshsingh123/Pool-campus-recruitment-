using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoolCampus
{
    public partial class HomePage : System.Web.UI.Page
    {
        BLL obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            CityCount();
            CollegeCount();
            CompanyCount();
        }

      

        private void CompanyCount()
        {
            try
            {
                obj = new BLL();
                lblCompanyCount.Text = obj.Company_Count().ToString();
            }
            catch
            {
            }
        }

        private void CollegeCount()
        {
            try
            {
                obj = new BLL();
                lblCollegeCount.Text = obj.CollegeCount().ToString();
            }
            catch
            {
            }
        }

        private void CityCount()
        {
            try
            {
                obj = new BLL();
                lblCityCount.Text = obj.CityCount().ToString();
            }
            catch
            {
            }
        }
    }
}