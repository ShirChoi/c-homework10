using System;

namespace Problem.Trains {
    public class Train : Transport {
        public int PassangerCapacity {get; private set;}
        public int CarriageAmount {get; private set;} // количество вагонов

        public Train(string name, double speed, double mass, int passangerCapacity, int carriageAmount)
            : base(name, speed, mass) 
        {
            PassangerCapacity = passangerCapacity;
            CarriageAmount = carriageAmount;
        }

        public new void GetInfo() {
            base.GetInfo();
            Console.WriteLine($"passanger capacity: {PassangerCapacity} people");
            Console.WriteLine($"carriage amount: {CarriageAmount} wagons");
        }
    }
}