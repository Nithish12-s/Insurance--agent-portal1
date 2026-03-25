using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class SqlHelper
{
    public static SqlConnection GetConnection()
    {
        return new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
    }

    public static SqlDataReader ExecuteReader(SqlConnection con, CommandType type, string query)
    {
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.CommandType = type;
        con.Open();
        return cmd.ExecuteReader();
    }

    public static void ExecuteNonQuery(SqlConnection con, CommandType type, string query)
    {
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.CommandType = type;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
}