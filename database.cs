﻿using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Cls_database
/// </summary>
public class database
{
    
	public database()
	{
	}

    public static DataTable GetTable(string query)
    {
        //string dbcon = ConfigurationManager.ConnectionStrings["Sebis"].ConnectionString;
        //SqlConnection con = new SqlConnection(dbcon);
        try
        {
        DataTable dt = new DataTable();
        
        //con.Open();
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = new SqlCommand(query, Connection.GetConnection());
        adapter.Fill(dt);
       // con.Close();
	Connection.conn.Close();
        return dt;
           }
        catch (Exception)
        {
             throw;
        }
    }

    public static void ExecuteQuery(string query)
    {
        //string dbcon = ConfigurationManager.ConnectionStrings["Sebis"].ConnectionString;
        //SqlConnection con = new SqlConnection(dbcon);
        //con.Open();
        try
        {
        SqlCommand cmd = new SqlCommand(query, Connection.GetConnection());
        cmd.CommandTimeout = 50000000;
        cmd.ExecuteNonQuery();
	Connection.conn.Close();
         }
        catch (Exception)
        {
             throw;
        }
 

    }
   
}
