using AirLineManagmentApp.models.entities;

namespace AirlineMS.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public User Create(User user);
        public User Get(int id);
        public User Get(string email);
        public IList<User> GetAll();
    }
}