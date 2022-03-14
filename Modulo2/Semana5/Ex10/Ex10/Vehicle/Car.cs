using System;

namespace ClassLibrary
{
    public class Car : RentedVehicle
    {
        public Car(int id, User client, DateTime rentStart)
        {
            Id = id;
            Client = new User();
            RentStart = rentStart;
        }

        public void Run()
        {
            this.Acceleration = 10;
        }


    }
}
