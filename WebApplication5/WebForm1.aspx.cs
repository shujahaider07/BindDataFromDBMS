using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
                BindGridEMployeeData();
            }

        }
        public void BindData()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "select name  from EmployeesDetails";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "Name";
            //   DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();

            DropDownList1.Items.Insert(0, new ListItem("--Select Employee--", "0"));



        }

        public void BindDesgination()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "select * from EmployeesDetails";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DropDownList2.DataSource = dt;
            DropDownList2.DataTextField = "Desgination";

            DropDownList2.DataBind();

            DropDownList2.Items.Insert(0, new ListItem("--Select Desgination--", "0"));



        }

        public void BindAttributes()
        {
            int id = Convert.ToInt32(DropDownList1.SelectedIndex);

            SqlConnection sql = new SqlConnection(cs);
            String qry = "select * from employeeRelated where id = @id";
            SqlCommand cmd = new SqlCommand(qry, sql);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DropDownList3.DataSource = dt;
            DropDownList3.DataValueField = "id";
            DropDownList3.DataTextField = "Behaviour";

            DropDownList3.DataBind();

            DropDownList3.Items.Insert(0, new ListItem("--Check Your Attribute--", "0"));



        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
            BindDesgination();

            BindAttributes();
        }


        public void BindSearch()
        {
            try
            {
                SqlConnection sql = new SqlConnection(cs);
                String qry = "select name, desgination , age , Email from EmployeesDetails where id = @id";
                SqlCommand cmd = new SqlCommand(qry, sql);
                cmd.Parameters.AddWithValue("@id", SearchTxt.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Nametxt.Text = dt.Rows[0]["name"].ToString();
                DesgiantionTxt.Text = dt.Rows[0]["Desgination"].ToString();
                Agetxt.Text = dt.Rows[0]["age"].ToString();
                Emailtxt.Text = dt.Rows[0]["Email"].ToString();

            }
            catch (Exception ex)
            {
                Response.Write(ex);

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BindSearch();
            BindGridEMployeeData();
        }
        
        public void BindGridEMployeeData()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "select name, desgination , age , Email from EmployeesDetails where id = @id";
            SqlCommand cmd = new SqlCommand(qry, sql);
            cmd.Parameters.AddWithValue("@id", SearchTxt.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}