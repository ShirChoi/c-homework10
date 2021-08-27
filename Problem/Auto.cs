using System;

namespace Problem.Autos {
    public class Auto : Transport {
        public double TankCapacity {get; protected set;}

        public Auto(string name, double speed, double tankCapacity, double mass) 
            : base(name, speed, mass)
        {
            TankCapacity = tankCapacity;
        }

        public new void GetInfo() {
            base.GetInfo();

            Console.WriteLine($"tank capacity: {TankCapacity} liters");
        }
    }

    public class PassangerCar : Auto { // легковое авто
        public int PassangerCapacity {get; private set;}

        public PassangerCar(string name, double speed, double tankCapacity, double mass, int passangerCapacity) 
            : base(name, speed, tankCapacity, mass)
        {
            PassangerCapacity = passangerCapacity;
        }

        public new void GetInfo() {
            base.GetInfo();
            Console.WriteLine($"passanger capacity: {PassangerCapacity} people");
        }
    }

    public class Truck : Auto { // грузовое авто 
        public double CargoWeight {get; private set;} //вес переносимого груза

        public Truck(string name, double speed, double tankCapacity, double mass, double cargoWeight) 
            : base(name, speed, tankCapacity, mass)
        {
            CargoWeight = cargoWeight;
        }

        public new void GetInfo() {
            base.GetInfo();
            Console.WriteLine($"cargo weight: {CargoWeight} tonns");
        }
    }
}