using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Dapper;
using Microsoft.Data.SqlClient;
using TheSatoshiEra.Models;

namespace TheSatoshiEra.DataAccess
{
    public class UserTypesRepository
    {
        readonly string _connectionString;
        public UserTypesRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("TheSatoshiEra");
        }

        internal IEnumerable<UserTypes> GetUserTypes()
        {
           using var db = new SqlConnection(_connectionString);
            var UserTypes = db.Query<UserTypes>(@"SELECT * FROM UserTypes");
            return UserTypes;
        }
    }
}
