using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagementAPI.DataAccess.Interfaces
{
    public interface IConnectionFactory
    {
        NpgsqlConnection CreateConnection();
    }
}
