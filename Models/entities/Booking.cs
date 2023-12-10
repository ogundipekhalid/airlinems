namespace AirLineManagmentApp.models.entities
{
    public class Booking : BaseEntity
    {
        public int PassengerId{ get;set;}
        public int FlightId{ get;set;}
        public int SeatNumber{ get;set;}

        // public Booking(int id,bool isDeleted,int passengerId,int flightId,int seatNumber):base(id,isDeleted)
        // {
        //     Id = id;
        //     IsDeleted = isDeleted;
        //     PassengerId = passengerId;
        //     FlightId = flightId;
        //     SeatNumber = seatNumber;

        // }
    }
}