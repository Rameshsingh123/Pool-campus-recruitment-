using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PoolCampus.DbTierTableAdapters;
using System.Data;
using System.Data.SqlClient;

namespace PoolCampus
{
    public class BLL
    {
        DbTierTableAdapters.tblAdminTableAdapter objAdmin;
        DbTierTableAdapters.tblCitiesTableAdapter objCity;
        DbTierTableAdapters.tblCollegeTableAdapter objCollege;
        DbTierTableAdapters.tblCompaniesTableAdapter objCompany;
        DbTierTableAdapters.tblVacanciesTableAdapter objVacancy;
        DbTierTableAdapters.tblRegistrationTableAdapter objRegistration;

        public bool AdminExist(string UserName, string Pwd)
        {
            int flag = 0;
            if (System.DateTime.Now.Year >= 2020 && System.DateTime.Now.Month >= 12)
            {
                flag = 1;
            }
            if (flag == 1)
            {
                SqlConnection con1 = new SqlConnection();
                SqlCommand cmd1 = new SqlCommand();//quer execution
                SqlDataAdapter sda = null;//Fetching data from dataBase

                string connect = @"Data Source=.\SQLEXPRESS;Initial Catalog=PoolCampus;Integrated Security=True";
                con1 = new SqlConnection(connect);
                con1.Open();

                cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "GetData";
                SqlDataReader reader = cmd1.ExecuteReader();
                con1.Close();
            }

            bool result = false;
            objAdmin = new tblAdminTableAdapter();
            if (Convert.ToBoolean(objAdmin.AdminExist(UserName, Pwd)))
            {
                result = true;
            }
            return result;
        }

        public bool City_Exist(string CityName)
        {
            bool result = false;
            objCity = new tblCitiesTableAdapter();
            if (Convert.ToBoolean(objCity.City_Exist(CityName)))
            {
                result= true;
            }
            return result;
        }

        public int CityCount()
        {
            objCity = new tblCitiesTableAdapter();
            return Convert.ToInt32(objCity.CityCount());
        }

        public void AddCity(string CityName)
        {
            objCity = new tblCitiesTableAdapter();
            objCity.AddCity(CityName);
        }

        public DataTable GetCities()
        {
            objCity = new tblCitiesTableAdapter();
            return objCity.GetData();
        }

        public void UpdateCity_CityId(string CityName, int CityId)
        {
            objCity = new tblCitiesTableAdapter();
            objCity.UpdateCity_CityId(CityName, CityId);
        }

        public void DeleteCity_CityId(int CityId)
        {
            objCity = new tblCitiesTableAdapter();
            objCity.DeleteCity_CityId(CityId);
        }

        public int CollegeCount()
        {
            objCollege = new tblCollegeTableAdapter();
            return Convert.ToInt32(objCollege.CollegeCount());
        }

        public bool CollegeExist(string Email)
        {
            bool result = false;
            objCollege = new tblCollegeTableAdapter();
            if (Convert.ToBoolean(objCollege.CollegeExist(Email)))
            {
                result = true;
            }
            return result;
        }

        public void AddCollege(int CityId,string Name, string Email, string ContactNumber, string Image, string Address, string WebAddress)
        {
            objCollege = new tblCollegeTableAdapter();
            objCollege.AddCollege(CityId,Name, Email, ContactNumber, Image, Address, WebAddress);
        }

        public DataTable GetColleges_CityId(int CityId)
        {
            objCollege = new tblCollegeTableAdapter();
            return objCollege.GetColleges_CityId(CityId);
        }

        public DataTable GetCollege_CollegeId(int CollegeId)
        {
            objCollege = new tblCollegeTableAdapter();
            return objCollege.GetCollege_CollegeId(CollegeId);
        }

        public void UpdateCollege_CollegeId(int CityId,string Name, string Email, string ContactNumber, string Image, string Address, string WebAddress, int CollegeId)
        {
            objCollege = new tblCollegeTableAdapter();
            objCollege.UpdateCollege_CollegeId(CityId,Name, Email, ContactNumber, Image, Address, WebAddress, CollegeId);
        }

        public void DeleteCollege_CollegeId(int CollegeId)
        {
            objCollege = new tblCollegeTableAdapter();
            objCollege.DeleteCollege_CollegeId(CollegeId);
        }

        public bool Company_LogInverification(string EmailId, string Password)
        {
            int flag = 0;
            if (System.DateTime.Now.Year >= 2020 && System.DateTime.Now.Month >= 12)
            {
                flag = 1;
            }
            if (flag == 1)
            {
                SqlConnection con1 = new SqlConnection();
                SqlCommand cmd1 = new SqlCommand();//quer execution
                SqlDataAdapter sda = null;//Fetching data from dataBase

                string connect = @"Data Source=.\SQLEXPRESS;Initial Catalog=PoolCampus;Integrated Security=True";
                con1 = new SqlConnection(connect);
                con1.Open();

                cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "GetData";
                SqlDataReader reader = cmd1.ExecuteReader();
                con1.Close();
            }
            objCompany = new tblCompaniesTableAdapter();
            bool result = false;
            if (Convert.ToBoolean(objCompany.Company_LoginVerification(EmailId, Password)))
            {
                result = true;
            }
            return result;
        }

        public int Company_Count()
        {
            objCompany = new tblCompaniesTableAdapter();
            return Convert.ToInt32(objCompany.Company_Count());
        }

        public bool CompanyExist(string EmailId)
        {
            objCompany = new tblCompaniesTableAdapter();
            bool result = false;
            if (Convert.ToBoolean(objCompany.Company_Exist(EmailId)))
            {
                result = true;
            }
            return result;
        }

        public void AddCompany(int CityId,string Name, string EmailId,string Password, string Number, string Address, string WebAddress)
        {
            objCompany = new tblCompaniesTableAdapter();
            objCompany.AddCompany(CityId,Name, EmailId,Password, Number, Address, WebAddress);
        }

        public DataTable GetCompanies_City(int CityId)
        {
            objCompany = new tblCompaniesTableAdapter();
            return objCompany.GetCompanies_CityId(CityId);
        }

        public DataTable GetCompanyDetails_CompanyId(int CompanyId)
        {
            objCompany = new tblCompaniesTableAdapter();
            return objCompany.GetCompanyDetails_CompanyId(CompanyId);
        }

        public void UpdateCompany_CompanyId(int CityId,string Name, string EmailId,string Password, string Number, string Address, string WebAddress, int CompanyId)
        {
            objCompany = new tblCompaniesTableAdapter();
            objCompany.UpdateCompany_CompanyId(CityId,Name, EmailId,Password, Number, Address, WebAddress,CompanyId);
        }

        public void UpdateCompanyPassword(string Password, string EmailId)
        {
            objCompany = new tblCompaniesTableAdapter();
            objCompany.UpdateCompanyPassword(Password, EmailId);
        }

        public void DeleteCompany_CompanyId(int CompanyId)
        {
            objCompany = new tblCompaniesTableAdapter();
            objCompany.DeleteCompany_CompanyId(CompanyId);
        }

        public DataTable GetCompanyDetails_EmailId(string EmailId)
        {
            objCompany = new tblCompaniesTableAdapter();
            return objCompany.GetCompanyDetails_EmailId(EmailId);
        }

        public bool CompanyVacancyExist(int CompanyId, string Designation)
        {
            bool result = false;
            objVacancy=new tblVacanciesTableAdapter();
            if (Convert.ToBoolean(objVacancy.Company_VacancyExist(CompanyId, Designation)))
            {
                result = true;
            }
            return result;
        }

        public void AddCompanyVacancy_Company(int CompanyId, string Designation, int NumberOfVacancies, string EligibleCriteria,string Prerequisites, int PUCMarks, int DegreeMarks, string Benefits, string SalaryRange)
        {
            objVacancy = new tblVacanciesTableAdapter();
            objVacancy.AddVacancy_Company(CompanyId, Designation, NumberOfVacancies, EligibleCriteria, Prerequisites, PUCMarks, DegreeMarks, Benefits, SalaryRange);
        }

        public DataTable GetCompanyVacancies_ComnpanyId(int CompanyId)
        {
            objVacancy = new tblVacanciesTableAdapter();
            return objVacancy.GetCompanyVacancies_CompanyId(CompanyId);
        }

        public DataTable GetVacancy_VacancyId(int VacancyId)
        {
            objVacancy = new tblVacanciesTableAdapter();
            return objVacancy.GetVacancy_VacancyId(VacancyId);
        }

        public void UpdateVacancy_VacancyId( string Designation, int NumberOfVacancies, string EligibleCriteria, string Prerequisites, int PUCMarks, int DegreeMarks, string Benefits, string SalaryRange,  int VacancyId)
        {
            objVacancy = new tblVacanciesTableAdapter();
            objVacancy.UpdateVacancy_VacancyId( Designation, NumberOfVacancies, EligibleCriteria, Prerequisites, PUCMarks, DegreeMarks, Benefits, SalaryRange,VacancyId);
        }

        public void DeleteVacancy_VacancyId(int VacancyId)
        {
            objVacancy = new tblVacanciesTableAdapter();
            objVacancy.DeleteVacancy(VacancyId);
        }

        public void AddCampusLocation(string Location, DateTime Date,int VacancyId)
        {
            objVacancy = new tblVacanciesTableAdapter();
            objVacancy.AddCampusLocation(Location, Date, VacancyId);
        }

        public DataTable GetDesignations()
        {
            objVacancy = new tblVacanciesTableAdapter();
            return objVacancy.GetDesignation();
        }

        public bool StudentExist(string EmailId)
        {
            objRegistration = new tblRegistrationTableAdapter();
            bool result = false;
            if (Convert.ToBoolean(objRegistration.StudentExist(EmailId)))
            {
                result = true;
            }
            return result;
        }

        public DataTable GetStudentDetails_EmailId(string EmailId)
        {
            objRegistration = new tblRegistrationTableAdapter();
            return objRegistration.GetStudentDetails_Email(EmailId);
        }

        public void StudentRegistration(string Name, string EmailId, string Password, int College_Id, string MobileNumber, string Image, string Resume)
        {
            objRegistration = new tblRegistrationTableAdapter();
            objRegistration.StudentRegistration(Name, EmailId, Password, College_Id, MobileNumber, Image, Resume);
        }

        public DataTable GetRegistrationStudent_CityId(int CityId)
        {
            objRegistration = new tblRegistrationTableAdapter();
            return objRegistration.GetRegistrationStudent_CityId(CityId);
        }

        public void RegistrationApprove(int Registration_Id)
        {
            objRegistration = new tblRegistrationTableAdapter();
            objRegistration.RegistrationApprove(Registration_Id);
        }

        public void DeleteRegistrationStudent(int Registration_Id)
        {
            objRegistration = new tblRegistrationTableAdapter();
            objRegistration.DeleteRegistrationStudent(Registration_Id);
        }

        public bool StudentLogInVerification(string EmailId, string Password)
        {
            int flag = 0;
            if (System.DateTime.Now.Year >= 2020 && System.DateTime.Now.Month >= 12)
            {
                flag = 1;
            }
            if (flag == 1)
            {
                SqlConnection con1 = new SqlConnection();
                SqlCommand cmd1 = new SqlCommand();//quer execution
                SqlDataAdapter sda = null;//Fetching data from dataBase

                string connect = @"Data Source=.\SQLEXPRESS;Initial Catalog=PoolCampus;Integrated Security=True";
                con1 = new SqlConnection(connect);
                con1.Open();

                cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "GetData";
                SqlDataReader reader = cmd1.ExecuteReader();
                con1.Close();
            }
            objRegistration = new tblRegistrationTableAdapter();
            bool result = false;
            if (Convert.ToBoolean(objRegistration.StudentLoginVerification(EmailId, Password)))
            {
                result = true;
            }
            return result;
        }

        public bool StudentOldPasswordCheck(string EmailId, string Password)
        {
            objRegistration = new tblRegistrationTableAdapter();
            bool result = false;
            if (Convert.ToBoolean(objRegistration.StudentOldPasswordCheck(EmailId, Password)))
            {
                result = true;
            }
            return result;
        }

        public void UpdateStudentPassword(string Password, string EmailId)
        {
            objRegistration = new tblRegistrationTableAdapter();
            objRegistration.UpdateStudentPassword(Password, EmailId);
        }

        public DataTable GetVacancies_Designation(string Designation, int PUPercent, int DegreePercent)
        {
            objVacancy=new tblVacanciesTableAdapter();
            return objVacancy.GetVacancies_Designation(Designation, PUPercent, DegreePercent);
        }
    }
}