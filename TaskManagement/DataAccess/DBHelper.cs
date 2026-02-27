using Npgsql;
using Npgsql.PostgresTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TaskManagement.DataAccess.Interfaces;

namespace TaskManagement.DataAccess
{
    //public static class DBHelper
    //{
    //    private static string connectionString =
    //        "Host=localhost;Port=5432;Database=Datadb;Username=postgres;Password=1234";

    //    public static NpgsqlConnection GetConnection()
    //    {
    //        return new NpgsqlConnection(connectionString);
    //    }

    //}

    public class DBHelper : IDataAccess
    {
        private readonly IConnectionFactory _connectionFactory;

        public DBHelper(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public NpgsqlDataReader ExecuteReader(string sql, Dictionary<string, object> parameters)
        {
            var conn = _connectionFactory.CreateConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(sql, conn);
            foreach (var param in parameters)
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            return cmd.ExecuteReader();
        }

        public int ExecuteNonQuery(string sql, Dictionary<string, object> parameters)
        {
            using var conn = _connectionFactory.CreateConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(sql, conn);
            foreach (var param in parameters)
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            return cmd.ExecuteNonQuery();
        }

        public object ExecuteScalar(string sql, Dictionary<string, object> parameters)
        {
            using var conn = _connectionFactory.CreateConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(sql, conn);
            foreach (var param in parameters)
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            return cmd.ExecuteScalar();
        }
    }

}
