using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PoolCampus
{
    public partial class Company_AddVacancies : System.Web.UI.Page
    {
        BLL obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                if (Request.QueryString["VacancyId"] != null)
                {
                    obj = new BLL();
                    DataTable tab = new DataTable();
                    tab = obj.GetVacancy_VacancyId(int.Parse(Request.QueryString["VacancyId"]));
                    txtDesignation.Text = tab.Rows[0]["Designation"].ToString();
                    txtVacancies.Text = tab.Rows[0]["NumberOfVacancies"].ToString();
                    txtEligible.Text = tab.Rows[0]["EligibleCriteria"].ToString();
                    txtPrerequisites.Text = tab.Rows[0]["Prerequisites"].ToString();
                    txtPUCPercent.Text = tab.Rows[0]["PUCMarks_Percent"].ToString();
                    txtDegreePercent.Text = tab.Rows[0]["DegreeMarks_Percent"].ToString();
                    txtBenefits.Text = tab.Rows[0]["Benefits"].ToString();
                    txtSalary.Text = tab.Rows[0]["Salary_Range"].ToString();
                    btnSubmit.Text = "Update";
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSubmit.Text == "Submit")
                {
                    obj = new BLL();
                    DataTable tab = new DataTable();
                    tab = obj.GetCompanyDetails_EmailId(Session["EmailId"].ToString());
                    if (!obj.CompanyVacancyExist(int.Parse(tab.Rows[0]["Company_Id"].ToString()), txtDesignation.Text))
                    {
                        obj.AddCompanyVacancy_Company(int.Parse(tab.Rows[0]["Company_Id"].ToString()), txtDesignation.Text, int.Parse(txtVacancies.Text), txtEligible.Text, txtPrerequisites.Text, int.Parse(txtPUCPercent.Text), int.Parse(txtDegreePercent.Text), txtBenefits.Text, txtSalary.Text);
                        txtBenefits.Text = txtDegreePercent.Text = txtDesignation.Text = txtEligible.Text = txtPrerequisites.Text = txtPUCPercent.Text = txtSalary.Text = txtVacancies.Text = "";
                        Response.Write("<script>alert('Vacancy Added Successfully')</script>");
                    }
                    else
                    {
                        txtBenefits.Text = txtDegreePercent.Text = txtDesignation.Text = txtEligible.Text = txtPrerequisites.Text = txtPUCPercent.Text = txtSalary.Text = txtVacancies.Text = "";
                        Response.Write("<script>alert('Vacancy Already Added')</script>");
                    }
                }
                else
                {
                    obj = new BLL();
                    obj.UpdateVacancy_VacancyId(txtDesignation.Text, int.Parse(txtVacancies.Text), txtEligible.Text, txtPrerequisites.Text, int.Parse(txtPUCPercent.Text), int.Parse(txtDegreePercent.Text), txtBenefits.Text, txtSalary.Text, int.Parse(Request.QueryString["VacancyId"]));
                    txtBenefits.Text = txtDegreePercent.Text = txtDesignation.Text = txtEligible.Text = txtPrerequisites.Text = txtPUCPercent.Text = txtSalary.Text = txtVacancies.Text = "";
                    btnSubmit.Text = "Submit";
                    Response.Write("<script>alert('Vacancy Updated Sucessfully')</script>");
                }
            }
            catch
            {
            }
        }
    }
}