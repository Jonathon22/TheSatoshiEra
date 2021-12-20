using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using TheSatoshiEra.Models;
using Microsoft.Extensions.Configuration;

namespace TheSatoshiEra.DataAccess
{
    public class TutorialVideosRepository
    {
        readonly string _connectionString;

        public TutorialVideosRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("TheSatoshiEra");
        }

        internal IEnumerable<TutorialVideos> GetVideos()
        {
            using var db = new SqlConnection(_connectionString);
            var GetVids = db.Query<TutorialVideos>(@"SELECT * FROM TutorialVideos");
            return GetVids;
        }

    }
}
