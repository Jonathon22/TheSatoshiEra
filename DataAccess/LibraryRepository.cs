using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using TheSatoshiEra.Models;

namespace TheSatoshiEra.DataAccess
{
    public class LibraryRepository
    {
        readonly string _connectionString;
        public LibraryRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("TheSatoshiEra");
        }

        internal IEnumerable<Library> GetLibrary()
        {
            using var db = new SqlConnection(_connectionString);
            var libraryEntries = db.Query<Library>(@"SELECT * FROM Library");
            return libraryEntries;
        }
        internal void Delete(Guid id)
        {
            using var db = new SqlConnection(_connectionString);
            var sql = (@"DELETE FROM Library WHERE Id = id");
            db.Execute(sql, new { id });
        }

        internal void Add (Library newLibrary)
        {
            using var db = new SqlConnection(_connectionString);
            Guid id = new Guid();
            var sql = @"INSERT INTO [dbo].[Library]
                                          ([UserId],
                                           [OpenedId],
                                           [Link],
                                           [Description],
                                           [CategoryId])
                                            OUTPUT inserted.Id
                                            VALUES
                                            (@UserId,
                                             @OpenedId,
                                             @Link,
                                             @Description,
                                             @CategoryId)";
            id = db.ExecuteScalar<Guid>(sql, newLibrary);
            newLibrary.id = id;
        }

        internal Library UpdateLibrary(Guid LibraryId, Library library)
        {
            using var db = new SqlConnection(_connectionString);
            var sql = @"UPDATE Library 
                        SET UserId = @UserId,
                            OpenedId = @OpenedId,
                            Link = @Link,
                            Description = @Description,
                            CategoryId = @CategoryId
                        OUTPUT Inserted.*
                        WHERE Id = @id";
            library.id = LibraryId;
            var libraryUpdate = db.QueryFirstOrDefault<Library>(sql, library);
            return libraryUpdate;
        }

        internal Library GetById(Guid LibraryId)
        {
            using var db = new SqlConnection(_connectionString);
            var sql = @"SELECT * FROM Library WHERE Id = @id";
            var libraryEntry = db.QuerySingleOrDefault<Library>(sql, new { id = LibraryId });
            if (libraryEntry == null) return null;
            return libraryEntry;
        }
    }
}
