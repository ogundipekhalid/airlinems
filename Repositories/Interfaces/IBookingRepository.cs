using AirLineManagmentApp.models.entities;

namespace AirlineMS.Repositories.Interfaces
{
    public interface IBookingRepository
    {
        public Booking Create(Booking booking);
        public Booking Get(int id);
        public Booking Get(string email);
        public IList<Booking> GetAll();
    }
}