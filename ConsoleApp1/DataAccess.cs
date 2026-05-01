using System;
using System.Data;
using Microsoft.Data.SqlClient;

public class DataAccess
{
    private readonly string _connectionString;

    public DataAccess(string connectionString)
    {
        _connectionString = connectionString;
    }

    public int ExecuteNonQuery(string query, SqlParameter[] parameters)
    {
        using (SqlConnection conn = new SqlConnection(_connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            if (parameters != null)
            {
                foreach (SqlParameter p in parameters)
                {
                    if (p.Value == null)
                    {
                        p.Value = DBNull.Value;
                    }
                }

                cmd.Parameters.AddRange(parameters);
            }

            conn.Open();
            return cmd.ExecuteNonQuery();
        }
    }

    public DataTable ExecuteQuery(string query)
    {
        using (SqlConnection conn = new SqlConnection(_connectionString))
        using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
        {
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
