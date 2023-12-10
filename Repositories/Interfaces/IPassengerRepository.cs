using AirLineManagmentApp.models.entities;

namespace AirlineMS.Repositories.Interfaces
{
    public interface IPassengerRepository
    {
         public Passenger Create(Passenger passenger);
        public Passenger Get(int id);
        public Passenger Get(string email);
        public IList<Passenger> GetAll();
    }
}