using System;

namespace Problem.Airplanes {
    public class Airplane : Transport {
        public double MaxFlightHeight {get; private set;}

        public Airplane(string name, double speed, double mass, double maxFlightHeight) 
            : base(name, speed, mass)
        {
            MaxFlightHeight = maxFlightHeight;
        }

        public new void GetInfo() {
            base.GetInfo(); 
            Console.WriteLine($"max flight height: {MaxFlightHeight} km");
        }
    }

    public class CargoAirplane : Airplane { // грузовой самолёт
        public double CargoWeight {get; private set;} //вес переносимого груза
        public CargoAirplane(string name, double speed, double mass, double maxFlightHeight, double cargoWeight) 
            : base(name, speed, mass, maxFlightHeight)
        {
            CargoWeight = cargoWeight;
        }

        public new void GetInfo() {
            base.GetInfo();
            Console.WriteLine($"max cargo weight: {CargoWeight} tonns");
        }
    }

    public class PassangerPlane : Airplane {
        public int PassangerCapacity {get; private set;}

        public PassangerPlane(string name, double speed, double mass, double maxFlightHeight, int passangerCapacity) 
            : base(name, speed, mass, maxFlightHeight)
        {
            PassangerCapacity = passangerCapacity;
        }
        
        public new void GetInfo() {
            base.GetInfo();
            Console.WriteLine($"passanger capacity: {PassangerCapacity} people");
        }
    }
}    