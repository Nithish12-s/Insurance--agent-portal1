using System;
using System.Data;
using System.Data.SqlClient;

public partial class AddInsurance : System.Web.UI.Page
{
    protected void btnSave_Click(object sender, EventArgs e)
    {
        SqlConnection con = SqlHelper.GetConnection();
        string q = "insert into InsuranceMaster(company,plan1,description) values('"
        + txtCompany.Text + "','" + txtName.Text + "','" + txtDesc.Text + "')";
        SqlHelper.ExecuteNonQuery(con, CommandType.Text, q);
        Response.Write("Saved");
    }
}