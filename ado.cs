using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


class ado
{
    static string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=flight;Integrated Security=True";
    static SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=flight;Integrated Security=True");
    public static DataTable SelectData(string Stored_Procedure, params SqlParameter[] Param)
    {
        SqlCommand SqlCmd = new SqlCommand();
        SqlCmd.CommandType = CommandType.StoredProcedure;
        SqlCmd.CommandText = Stored_Procedure;
        SqlCmd.Connection = sqlConnection;
        if (Param != null)
        {
            for (int i = 0; i < Param.Length; i++)
            {

                SqlCmd.Parameters.Add(Param[i]);
            }

        }

        SqlDataAdapter da = new SqlDataAdapter(SqlCmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        return dt;
    }

    /////////////////////////////////////////////////////////////////

    public static int ExecuteNonQuery(string stored_Name, params SqlParameter[] parameters)
    {
        SqlConnection con = new SqlConnection(ConnectionString);
        SqlCommand cmd = new SqlCommand(stored_Name, con);
        cmd.CommandType = CommandType.StoredProcedure;
        foreach (SqlParameter param in parameters)
        {
            cmd.Parameters.Add(param);
        }
        con.Open();
        int Effects = cmd.ExecuteNonQuery();
        con.Close();
        return Effects;

    }

    /////////////////////////////////////////////////////////////////

    public static SqlParameter CreateParameters(string Parameters_Name, SqlDbType Parameters_Type, object Parameters_Value)
    {
        SqlParameter sqlParam = new SqlParameter(Parameters_Name, Parameters_Type);
        sqlParam.Value = Parameters_Value;
        return sqlParam;
    }

    /////////////////////////////////////////////////////////////////

    public static SqlDataReader getdata(string stored_Name, string Tabel_Name)
    {
        SqlConnection con = new SqlConnection(ConnectionString);
        SqlCommand cmd = new SqlCommand(stored_Name, con);
        SqlDataReader reader1;
        reader1 = cmd.ExecuteReader();
        return reader1;
        //while (reader1.Read())
        //{
        //}
    }
}

