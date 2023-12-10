using AirLineManagmentApp.models.entities;
using AirlineMS.Context;
using AirlineMS.Repositories.Interfaces;

namespace AirlineMS.Repositories.Implementations
{
    public class FlightRepository : IFlightRepository
    {
        private readonly DbContext context;
        public FlightRepository(DbContext _context)
        {
            context = _context;
        }
        public Flight Create(Flight flight)
        {
            throw new NotImplementedException();
        }

        public Flight Get(int id)
        {
            throw new NotImplementedException();
        }

        public Flight Get(string email)
        {
            throw new NotImplementedException();
        }

        public IList<Flight> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}