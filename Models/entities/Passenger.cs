namespace AirLineManagmentApp.models.entities
{
    public class Passenger : BaseEntity
    {
        public int UserId{get; set;}
        public int FlightId{get; set;}
        public double Wallet{ get;set;}
    }
}