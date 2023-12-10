namespace AirLineManagmentApp.models.entities
{
    public class Flight :BaseEntity
    {
        public string Destination{ get;set; }
        public string TakeOffPoint { get; set;}
        public DateTime TakeOffTime{ get;set;}
        public DateTime LandingTime{ get;set;}
        public int Capacity{ get; set; }
        public List<Passenger> Passengers = new List<Passenger>();

    }
}