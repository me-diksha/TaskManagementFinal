using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagementAPI.DataAccess.Interfaces
{
    public interface IDataAccess
    {
        NpgsqlDataReader ExecuteReader(string sql, Dictionary<string, object> parameters);
        NpgsqlDataReader ExecuteReader(string sql);
        int ExecuteNonQuery(string sql, Dictionary<string, object> parameters);
        object ExecuteScalar(string sql, Dictionary<string, object> parameters);
    }
}
