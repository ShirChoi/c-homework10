using System;

namespace Problem {
    class Program {
        static void Main(string[] args) {
            #region cars
            Console.WriteLine($"{new string('-', 15)}Cars{new string('-', 15)}");
            Autos.Truck truck = new Autos.Truck(name: "Kamaz", speed: 76.8, tankCapacity: 125.0, mass: 9.03, cargoWeight: 8.6);
            truck.GetInfo();

            Console.WriteLine();

            Autos.PassangerCar car = new Autos.PassangerCar(name: "Zhiguli", speed: 80.0, tankCapacity: 39.0, mass: 0.95, passangerCapacity: 5);
            car.GetInfo();
            #endregion
            
            #region planes
            Console.WriteLine($"{new string('-', 14)}Planes{new string('-', 14)}");
        
            Airplanes.CargoAirplane cargoPlane = new Airplanes.CargoAirplane(name: "MD-11", speed: 945.0, mass: 128.8, maxFlightHeight: 12.6, cargoWeight: 143.2);
            cargoPlane.GetInfo();

            Console.WriteLine();

            Airplanes.PassangerPlane passangerPlane = new Airplanes.PassangerPlane(name: "Boing 747", speed: 955.0, mass: 442.2, maxFlightHeight: 13.75, passangerCapacity: 818);
            passangerPlane.GetInfo();
            #endregion

            #region trains
            Console.WriteLine($"{new string('-', 14)}Trains{new string('-', 14)}");

            Trains.Train train = new Trains.Train(name: "Sinkansen E5", speed: 312.7, mass: 35.2, passangerCapacity: 1235, carriageAmount: 12);
            train.GetInfo();
            #endregion
        }
    }
}
