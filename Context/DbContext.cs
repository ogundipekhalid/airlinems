using Dapper;
using MySql.Data.MySqlClient;

namespace AirlineMS.Context
{
    public class DbContext
    {
        public string connectionStrings = "Server=localhost;User=root;Database=airlineapp;Password=adebayoawwal119";

        private void Execution(string querry)
        {
            using(var connection = new MySqlConnection(connectionStrings))
            {
                connection.Open();
                connection.Execute(querry);
            }
        }
        public void CreateSchema()
        {
            var querry = "create schema if not exists airlineapp";
            var connectionString = "Server=localhost;User=root;Password=adebayoawwal119";
            using(var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(querry);
            }
        }

        public void CreateUserTable()
        {
            var querry = @"create table if not exists user(Id int auto_increment, IsDeleted bool,Name varchar(225) not null,Email varchar(225) unique, Pin int not null,Gender enum('male', 'female'),PhoneNumber varchar(12),Role varchar(225),primary key(Id))";
            Execution(querry);
        }

        public void CreatePassengerTable()
        {
            var querry = @"create table if not exists passenger(Id int auto_increment, IsDeleted bool,UserId int,Wallet double,primary key(Id), foreign key(UserId) references User(Id))";
            Execution(querry);
        }

        public void CreateManagerTable()
        {
            var querry = @"create table if not exists manager(Id int auto_increment, IsDeleted bool,UserId int,Wallet double,primary key(Id), foreign key(UserId) references User(Id))";
            Execution(querry);
        }

        public void CreateFlightTable()
        {
            var querry = @"create table if not exists flight(Id int auto_increment, IsDeleted bool, Destination varchar(255), TakeOffPoint varchar(255), TakeOffTime datetime, LandingTime datetime, Capacity int, Passengers varchar(255), primary key(Id))";
            Execution(querry);
        }

        public void CreateBookingTable()
        {
            var querry = @"create table if not exists flight(Id int auto_increment, IsDeleted bool, PassengerId int, FlightId int,  SeatNumber int, primary key(Id), foreign key(PassengerId) references Passenger(Id), foreign key(FlightId) references Flight(Id))";
            Execution(querry);
        }

    }
}