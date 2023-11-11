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

        string conn = ConfigurationManager.ConnectionStrings["Myconnection"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {

            //Page Load

            //GetRecords();

            //insertRecord();
        }


        public void GetRecords()
        {
            // ADO.net : 

            SqlConnection sqlConnection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("Select * from tblUser", sqlConnection); // Inline SQL query 
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adpt.Fill(dataSet);

            grdView.DataSource = dataSet;
            grdView.DataBind();

        }

        public void insertRecord()
        {

            SqlConnection sqlConnection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("Insert into  [dbo].[Employee] values('Hello Brother', 'Hello Brother')", sqlConnection); // Inline SQL query 

            sqlConnection.Open();
            cmd.ExecuteNonQuery(); // Operations I / U /D
            sqlConnection.Close();


        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {

            var email = txtUsername.Text;
            var txtPassword1 = txtPassword.Text;
            var txtConfirmPassword1 = txtConfirmPassword.Text;

            SqlConnection sqlConnection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("Insert into  [dbo].[Employee] values("+ email + ", 'Hello Brother')", sqlConnection); // Inline SQL query 

            sqlConnection.Open();
            cmd.ExecuteNonQuery(); // Operations I / U /D
            sqlConnection.Close();

        }




        // I U D


    }
}