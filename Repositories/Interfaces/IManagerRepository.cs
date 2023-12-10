using AirLineManagmentApp.models.entities;

namespace AirlineMS.Repositories.Interfaces
{
    public interface IManagerRepository
    {
        public Manager Create(Manager manager);
        public Manager Get(int id);
        public Manager Get(string email);
        public IList<Manager> GetAll();
    }
}