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
    public class UsersRepository
    {

        readonly string _connectionString;

        public UsersRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("TheSatoshiEra");
        }

        internal User GetById(Guid userId)
        {
            using var db = new SqlConnection(_connectionString);
            var sql = @"Select * From Users where id = @id";
            var user = db.QuerySingleOrDefault<User>(sql, new { id = userId });
            if (user == null) return null;
            return user;
        }

        internal IEnumerable<User> GetUsers()
        {
            using var db = new SqlConnection(_connectionString);

            var users = db.Query<User>(@"SELECT * FROM Users");
            return users;
        }

        internal void Add (User newUser)
        {
            using var db = new SqlConnection(_connectionString);
            Guid id = new Guid();
            var sql = @"INSERT INTO [dbo].[Users]
                        ([FirstName],
                         [LastName],
                         [UserTypeId],
                         [Email],
                         [ProfilePic])
                         OUTPUT inserted.Id
                         VALUES
                         (@FirstName,
                          @LastName,
                          @UserTypeId,
                          @Email,
                          @ProfilePic)";
            id = db.ExecuteScalar<Guid>(sql, newUser);
            newUser.id = id;
        }

        internal User UpdateUser(Guid userId, User user)
        {
            using var db = new SqlConnection(_connectionString);
            var sql = @"UPDATE Users 
                        Set FirstName = @FirstName, 
                        LastName = @LastName,
                        UserTypeId = @UserTypeId,
                        Email = @Email
                        OUTPUT Inserted.*
                        WHERE Id = @id";
            user.id = userId;
            var userUpdate = db.QueryFirstOrDefault<User>(sql, user);
            return userUpdate;
        }

        internal void Delete(Guid id)
        {
            using var db = new SqlConnection(_connectionString);
            var sql = @" DELETE FROM Users WHERE Id = @id";
            db.Execute(sql, new { id });
        }
    }

}

