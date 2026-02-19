using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.DataAccess.Interfaces
{
    public interface IDataAccess
    {
        NpgsqlDataReader ExecuteReader(string sql, Dictionary<string, object> parameters);
        int ExecuteNonQuery(string sql, Dictionary<string, object> parameters);
        object ExecuteScalar(string sql, Dictionary<string, object> parameters);
    }
}
