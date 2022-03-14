using Ex1;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class RentalCompany : LegalPersonSeller
    {
        public List<RentedVehicle> VehicleType { get; set; }

        public RentalCompany(List<RentedVehicle> vehicleType)
        {
            vehicleType.Add(new Car(1, new User(), DateTime.Now));
            vehicleType.Add(new Motorcycle());
            vehicleType.Add(new Truck());

            VehicleType = vehicleType;
        }
    }
}
