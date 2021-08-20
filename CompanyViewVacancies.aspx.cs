using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PoolCampus
{
    public partial class CompanyViewVacancies : System.Web.UI.Page
    {
        BLL obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadVacancies();
        }

        private void LoadVacancies()
        {
            try
            {
                obj = new BLL();
                DataTable tab = new DataTable();
                tab = obj.GetCompanyDetails_EmailId(Session["EmailId"].ToString());
                DataTable buffer = new DataTable();
                buffer = obj.GetCompanyVacancies_ComnpanyId(int.Parse(tab.Rows[0]["Company_Id"].ToString()));
                if (buffer.Rows.Count > 0)
                {
                    lblMsg.Text = "";
                    GridView1.DataSource = buffer;
                    GridView1.DataBind();
                }
                else
                {
                    GridView1.Controls.Clear();
                    lblMsg.Text = "no vancies...";
                }
            }
            catch
            {
            }
        }

        protected void lnkEdit_Click(object sender, EventArgs e)
        {
            int VacancyId = int.Parse(((LinkButton)sender).CommandArgument);
            Response.Redirect("Company_AddVacancies.aspx?VacancyId=" + VacancyId);
        }

        protected void lnkDelete_Click(object sender, EventArgs e)
        {
            obj = new BLL();
            int VacancyId = int.Parse(((LinkButton)sender).CommandArgument);
            obj.DeleteVacancy_VacancyId(VacancyId);
            LoadVacancies();
        }
    }
}