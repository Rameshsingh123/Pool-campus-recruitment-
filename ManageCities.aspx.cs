using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PoolCampus
{
    public partial class ManageCities : System.Web.UI.Page
    {
        BLL obj;
        public static int Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCities();
        }

        private void LoadCities()
        {
            try
            {
                obj = new BLL();
                DataTable tab = new DataTable();
                tab = obj.GetCities();
                if (tab.Rows.Count > 0)
                {
                    lblMsg.Text = "";
                    GridView1.DataSource = tab;
                    GridView1.DataBind();
                }
                else
                {
                    GridView1.Controls.Clear();
                    lblMsg.Text = "no records found...";
                }
            }
            catch
            {
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSubmit.Text != "Update")
                {
                    obj = new BLL();
                    if (!obj.City_Exist(txtCity.Text))
                    {
                        obj.AddCity(txtCity.Text);
                        txtCity.Text = "";
                        LoadCities();
                        Response.Write("<script>alert('City Added Successfully')</script>");
                    }
                    else
                    {
                        txtCity.Text = "";
                        Response.Write("<script>alert('City Already Created...')</script>");
                    }
                }
                else
                {
                    obj.UpdateCity_CityId(txtCity.Text,Id);
                    txtCity.Text = "";
                    LoadCities();
                    btnSubmit.Text = "Submit";
                    Response.Write("<script>alert('City Updated Successfully')</script>");
                }
            }
            catch
            {
            }
        }

        protected void lnkEdit_Click(object sender, EventArgs e)
        {
            GridViewRow gr = (GridViewRow)((LinkButton)sender).Parent.Parent;
            txtCity.Text = gr.Cells[0].Text;
            Id = int.Parse(((LinkButton)sender).CommandArgument);
            btnSubmit.Text = "Update";
        }

        protected void lnkDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((LinkButton)sender).CommandArgument);
            obj.DeleteCity_CityId(id);
            LoadCities();
            Response.Write("<script>alert('City Deleted Sucessfully')</script>");
        }
    }
}