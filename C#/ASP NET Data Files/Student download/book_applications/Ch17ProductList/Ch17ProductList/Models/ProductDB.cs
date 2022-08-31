using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// make sure to include these using directives
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

[DataObject(true)]
public static class ProductDB
{
    [DataObjectMethod(DataObjectMethodType.Select)]
    public static IEnumerable GetAllCategories()
    {
        SqlConnection con = new SqlConnection(GetConnectionString());
        string sql = "SELECT CategoryID, LongName "
            + "FROM Categories ORDER BY LongName";
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        return dr;
    }

    [DataObjectMethod(DataObjectMethodType.Select)]
    public static IEnumerable GetProductsByCategory(string CategoryID)
    {
        SqlConnection con = new SqlConnection(GetConnectionString());
        string sql = "SELECT ProductID, Name, "
            + "UnitPrice, OnHand "
            + "FROM Products "
            + "WHERE CategoryID = @CategoryID "
            + "ORDER BY Name";
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("CategoryID", CategoryID);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        return dr;
    }

    private static string GetConnectionString()
    {
        return ConfigurationManager.ConnectionStrings
            ["HalloweenConnection"].ConnectionString;
    }
}
