using BAL;
using BusinesssObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class About : Page
    {
        // Presentation Layer
        // Business Access layer
        // Data Access Layer
        string conn = ConfigurationManager.ConnectionStrings["Myconnection"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {

            // Web
            // State management
            //2 >> 

                //1. Client side
                    //ViewState
                    // hidden Field
                    // Query String
                    // Cookie

                //2. Server side
                 //Session
                 // Application



            if (!IsPostBack)
            {
                //GetRecordsUsingSP();
            }

            //Page Load



            //insertRecord();
        }


        public void GetRecords()
        {
            // ADO.net : 

            //SqlConnection sqlConnection = new SqlConnection(conn);
            //SqlCommand cmd = new SqlCommand("Select * from tblUser", sqlConnection); // Inline SQL query 
            //SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            //DataSet dataSet = new DataSet();
            //adpt.Fill(dataSet);

            //grdView.DataSource = dataSet;
            //grdView.DataBind();

        }

        public void GetRecordsUsingSP()
        {

            // Dis
            //Connected 
            // ADO.net : 

            //SqlConnection sqlConnection = new SqlConnection(conn);
            //SqlCommand cmd = new SqlCommand("EmpEntry", sqlConnection); // Inline SQL query 
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@Action", "Select");
            //sqlConnection.Open();
            //// Connected !!!
            //using (var reader = cmd.ExecuteReader())
            //{
            //    if (reader.Read())
            //    {
            //        var abc = reader.GetInt32(reader.GetOrdinal("EmpId"));
            //    }
            //}
            //sqlConnection.Close();
            //SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            //DataSet dataSet = new DataSet();
            //DataTable dataTable = new DataTable();
            //adpt.Fill(dataSet);

            //grdView.DataSource = dataSet.Tables[1];
            //grdView.DataBind();

        }


        public void insertRecord()
        {

            //SqlConnection sqlConnection = new SqlConnection(conn);
            //SqlCommand cmd = new SqlCommand("Insert into  [dbo].[Employee] values('Hello Brother', 'Hello Brother')", sqlConnection); // Inline SQL query 
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@Action", "Select");
            //sqlConnection.Open();
            //cmd.ExecuteNonQuery(); // Operations I / U /D
            //sqlConnection.Close();





        }

        //N tier archi

        //1 Pre
        //2 BL
        //3

        protected void btnSignup_Click(object sender, EventArgs e)
        {

            Session["UserId"] = 10;


            HttpCookie httpCookie = new HttpCookie("MyCustomC");
            httpCookie.Secure = true;
            httpCookie.Expires = DateTime.Now.AddMinutes(20);
            httpCookie.Value = "Jigar Thakkar";
            Response.Cookies.Add(httpCookie);


            HiddenField1.Value = "Jigar";

            //ViewState["MyViewState"] = "Jigar";

            //UserBO userBO = new UserBO();
            //userBO.UserId = 1;
            //userBO.UserName = txtUsername.Text;


            //UserBAL userBAL = new UserBAL();
            //userBAL.SaveUserData(userBO);


            //var email = txtUsername.Text;
            //var txtPassword1 = txtPassword.Text;
            //var txtConfirmPassword1 = txtConfirmPassword.Text;

            //SqlConnection sqlConnection = new SqlConnection(conn);
            //SqlCommand cmd = new SqlCommand("Insert into  [dbo].[Employee] values(" + email + ", 'Hello Brother')", sqlConnection); // Inline SQL query 

            //sqlConnection.Open();
            //cmd.ExecuteNonQuery(); // Operations I / U /D
            //sqlConnection.Close();

        }

        protected void btnSignup0_Click(object sender, EventArgs e)
        {
            var abv = Response.Cookies["MyCustomC"];

            var abc = HiddenField1.Value;

            Response.Redirect("contact.aspx");
            //var abc = ViewState["MyViewState"].ToString();
        }




        // I U D


    }
}