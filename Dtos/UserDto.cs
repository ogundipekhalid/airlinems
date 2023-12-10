using AirLineManagmentApp.models.enums;

namespace AirlineMS.Dtos
{
    public class UserDto
    {
        public int Id{ get;set;}
        public string Name{ get;set;}
        public string Email{ get;set;}
        public Gender Gender{ get;set;}
        public string PhoneNumber{ get;set;}
        public string Role{ get;set;}
        public bool IsDeleted{ get;set;}
    }

    public class LoginUserRequestModel
    {
        public string Email{ get;set;}
        public int Pin{ get;set;}
    }
}