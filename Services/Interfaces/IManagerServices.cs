using AirlineMS.Dtos;

namespace AirlineMS.Services.Interfaces
{
    public interface IManagerServices
    {
        public ManagerDto Register(CreateManagerRequestModel model); 
        public ManagerDto Update(UpdateManagerRequestModel model); 
        public bool Delete(int id);
    }
}