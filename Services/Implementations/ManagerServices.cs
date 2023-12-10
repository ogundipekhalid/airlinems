using AirLineManagmentApp.models.entities;
using AirlineMS.Dtos;
using AirlineMS.Repositories.Interfaces;
using AirlineMS.Services.Interfaces;

namespace AirlineMS.Services.Implementations
{
    public class ManagerServices : IManagerServices
    {
        private readonly IManagerRepository _managerRepository;
        private readonly IUserRepository _userRepository;
        public ManagerServices(IManagerRepository managerRepository, IUserRepository userRepository)
        {
            _managerRepository = managerRepository;
            _userRepository = userRepository;
        }
        public bool Delete(int id)
        {
            var manager = _managerRepository.Get(id);
            if(manager != null)
            {
                manager.IsDeleted = true;
                return true;
            }
            return false;
        }

        public ManagerDto Register(CreateManagerRequestModel model)
        {
            var userExist = _userRepository.Get(model.Email);
            if (userExist != null)
            {
                Console.WriteLine("user already exist");
                return null;
            }
            var user = new User();
            user.Name = model.Name;
            user.Email = model.Email;
            user.Pin = model.Pin;
            user.PhoneNumber = model.PhoneNumber;
            user.Gender = model.Gender;
            user.Role = "Manager";

            _userRepository.Create(user);

            var manager = new Manager();
            manager.UserId = user.Id;
            manager.Wallet = 0;

            _managerRepository.Create(manager);


            return new ManagerDto
            {
                Id = manager.Id,
                UserId = user.Id,
                Name = user.Name,
                Email = user.Email,
                Gender = user.Gender,
                PhoneNumber = user.PhoneNumber,
                Role = user.Role,
                Wallet = manager.Wallet
            };


        }

        public ManagerDto Update(UpdateManagerRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}