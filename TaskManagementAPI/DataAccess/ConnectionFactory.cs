using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagementAPI.DataAccess.Interfaces;

namespace TaskManagementAPI.DataAccess
{
    public class ConnectionFactory:IConnectionFactory
    {
        private readonly string _connectionstring;

        public ConnectionFactory(IConfiguration configuration)
        {
            _connectionstring = configuration.GetConnectionString("DefaultConnection");
        }

        public NpgsqlConnection CreateConnection()
        {
            return new NpgsqlConnection(_connectionstring);
        }
    }
}
