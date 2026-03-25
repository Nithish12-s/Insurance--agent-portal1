using System;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        SqlConnection con = SqlHelper.GetConnection();
        string q = "select * from login where username='"+txtUser.Text+"' and password='"+txtPass.Text+"'";
        SqlDataReader dr = SqlHelper.ExecuteReader(con, CommandType.Text, q);

        if (dr.Read())
        {
            if (txtUser.Text == "Admin")
                Response.Redirect("AdminHome.aspx");
            else
                Response.Redirect("CustomerHome.aspx");
        }
        else
        {
            Response.Write("Invalid Login");
        }
    }
}