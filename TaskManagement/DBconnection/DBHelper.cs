using Npgsql;
using Npgsql.PostgresTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace TaskManagement.DBconnection
{  
    public static class DBHelper
    {
        private static string connectionString =
            "Host=localhost;Port=5432;Database=Datadb;Username=postgres;Password=1234";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }





    }
}
