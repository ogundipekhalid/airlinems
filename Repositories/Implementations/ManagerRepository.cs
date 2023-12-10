using AirLineManagmentApp.models.entities;
using AirlineMS.Context;
using AirlineMS.Repositories.Interfaces;
using Dapper;
using MySql.Data.MySqlClient;

namespace AirlineMS.Repositories.Implementations
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly DbContext context;
        public ManagerRepository(DbContext _context)
        {
            context = _context;
        }
        public Manager Create(Manager manager)
        {
            context.CreateUserTable();
            string querry = $"insert into manager(UserId, Wallet) values({manager.UserId}, {manager.Wallet})";
            using(var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                connection.Execute(querry);
                return manager;
            } 
        }

        public Manager Get(string email)
        {
            string query = $"select * from manager inner join user on manager.UserId = user.Email where user.Id = {email}";
            using(var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                var manager = connection.QueryFirstOrDefault<Manager>(query);
                return manager;
            }
        }

        public Manager Get(int id)
        {
            string query = $"select * from manager inner join user on manager.UserId = user.Id where user.Id = {id}";
            using(var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                var manager = connection.QueryFirstOrDefault<Manager>(query);
                return manager;
            }
        }

        public IList<Manager> GetAll()
        {
            string query = $"select * from manager inner join user on manager.UserId = user.Id";
            using(var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                var manager = connection.Query<Manager>(query);
                return manager.ToList();
            }
        }
    }
}