using AirLineManagmentApp.models.entities;
using AirlineMS.Context;
using AirlineMS.Repositories.Interfaces;

namespace AirlineMS.Repositories.Implementations
{
    public class BookingRepository : IBookingRepository
    {
        private readonly DbContext context;
        public BookingRepository(DbContext _context)
        {
            context = _context;
        }
        public Booking Create(Booking booking)
        {
            throw new NotImplementedException();
        }

        public Booking Get(int id)
        {
            throw new NotImplementedException();
        }

        public Booking Get(string email)
        {
            throw new NotImplementedException();
        }

        public IList<Booking> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}