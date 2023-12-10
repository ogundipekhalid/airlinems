using AirLineManagmentApp.models.enums;

namespace AirlineMS.Dtos
{
    public class ManagerDto
    {
        public int Id{ get;set;}
        public int UserId{ get;set;}
        public string Name{ get;set;}
        public string Email{ get;set;}
        public Gender Gender{ get;set;}
        public string PhoneNumber{ get;set;}
        public string Role{ get;set;}
        public double Wallet{ get; set;}
        public bool IsDeleted{ get;set;}
    }
    public class CreateManagerRequestModel
    {
        public string Name{ get;set;}
        public string Email{ get;set;}
        public int Pin{ get;set;}
        public Gender Gender{ get;set;}
        public string PhoneNumber{ get;set;}
    }
    public class UpdateManagerRequestModel
    {
        public string Name{ get;set;}
        public Gender Gender{ get;set;}
        public string PhoneNumber{ get;set;}
    }
}