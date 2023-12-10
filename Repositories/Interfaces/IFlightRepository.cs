using AirLineManagmentApp.models.entities;

namespace AirlineMS.Repositories.Interfaces
{
    public interface IFlightRepository
    {
        public Flight Create(Flight flight);
        public Flight Get(int id);
        public Flight Get(string email);
        public IList<Flight> GetAll();
    }
}