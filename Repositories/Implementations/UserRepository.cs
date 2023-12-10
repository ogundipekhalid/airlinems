using AirLineManagmentApp.models.entities;
using AirlineMS.Context;
using AirlineMS.Repositories.Interfaces;
using Dapper;
using MySql.Data.MySqlClient;

namespace AirlineMS.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContext context;
        public UserRepository(DbContext _context)
        {
            context = _context;
        }

        public User Create(User user)
        {
            context.CreateUserTable();
            string querry = $"insert into user(Name, Email, Pin, Gender, PhoneNumber, Role) values('{user.Name}', '{user.Email}', {user.Pin}, {user.Gender}, '{user.PhoneNumber}', '{user.Role}')";
            using(var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                var asd = connection.Execute(querry);
                return user;
            }  
        }

        public User Get(string email)
        {
            string query = $"SELECT * FROM user where Email = {email}";
            using(var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                var user = connection.QueryFirstOrDefault<User>(query);
                return user;
            }
        }

        public User Get(int id)
        {
            string query = $"SELECT * FROM user where Id = {id}";
            using(var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                var user = connection.QuerySingleOrDefault<User>(query);
                return user;
            }
        }

        public IList<User> GetAll()
        {
            string query = $"SELECT * FROM user";
            using(var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                var users = connection.Query<User>(query);
                return users.ToList();
            }
        }
    }
}