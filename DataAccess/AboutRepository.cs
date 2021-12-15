using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using TheSatoshiEra.Models;

namespace TheSatoshiEra.DataAccess
{
    public class AboutRepository
    {
        readonly string _connectionString;

        public AboutRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("TheSatoshiEra");
        }

        internal IEnumerable<About> ReadAbout()
        {
            using var db = new SqlConnection(_connectionString);
            var About = db.Query<About>(@"SELECT * FROM About");
            return About;
        }
    }
}
