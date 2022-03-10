using System;

namespace ClassLibrary
{
    public class RentedVehicle
    {
        public int Id { get; set; }

        public User Client { get; set; }

        public DateTime RentStart { get; set; }

        public DateTime? RentEnd { get; set; }
    }
}
