using System;

namespace Problem {
    public class Transport {
        public string Name {get; private set;}
        public double Speed {get; private set;}
        public double Mass {get; private set;}

        public Transport(string name, double speed, double mass) {
            Name = name;
            Speed = speed;
            Mass = mass;
        }

        public void GetInfo() {
            Console.WriteLine($"name: {Name}");
            Console.WriteLine($"speed: {Speed} km/h");
            Console.WriteLine($"mass: {Mass} tonns");
        }
    }
}