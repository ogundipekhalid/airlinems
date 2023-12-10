using AirLineManagmentApp.models.entities;
using AirlineMS.Context;
using AirlineMS.Repositories.Interfaces;
using Dapper;
using MySql.Data.MySqlClient;

namespace AirlineMS.Repositories.Implementations
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly DbContext context;
        public PassengerRepository(DbContext _context)
        {
            context = _context;
        }
        public Passenger Create(Passenger passenger)
        {
            context.CreateUserTable();
            string querry = $"insert into passenger(UserId, FlightId, Wallet) values({passenger.UserId}, {passenger.FlightId}, {passenger.Wallet})";
            using(var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                connection.Execute(querry);
                return passenger;
            } 
        }

        public Passenger Get(int id)
        {
            string query = $"select * from passenger inner join user on passenger.UserId = user.Id where user.Id = {id}";
            using(var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                var passenger = connection.QueryFirstOrDefault<Passenger>(query);
                return passenger;
            }
        }

        public Passenger Get(string email)
        {
            string query = $"select * from passenger inner join user on passenger.UserId = user.Id where user.Email = {email}";
            using(var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                var passenger = connection.QueryFirstOrDefault<Passenger>(query);
                return passenger;
            }
        }

        public IList<Passenger> GetAll()
        {
            string query = $"select * from passenger inner join user on passenger.UserId = user.Id";
            using(var connection = new MySqlConnection(context.connectionStrings))
            {
                connection.Open();
                var passenger = connection.Query<Passenger>(query);
                return passenger.ToList();
            }
        }
    }
}