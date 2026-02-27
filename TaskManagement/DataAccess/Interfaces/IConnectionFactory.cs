using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement.DataAccess.Interfaces
{
    public interface IConnectionFactory
    {
        NpgsqlConnection CreateConnection();
    }
}
