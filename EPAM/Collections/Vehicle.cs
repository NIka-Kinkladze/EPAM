using VehicleParts;

namespace vehicles
{
    // Base class Vechiles (spelling should be corrected to "Vehicles") is empty and can be used as a common base for all vehicle types if needed.
    public class Vehicles
    {
        public Engine? engine { get; set; }
        public Chasis? chasis { get; set; }
        public Transmission? transmission { get; set; }
        public string? Model { get; set; }
    }

    // PassengerCar class represents a passenger car and inherits from Vechiles
    public class PassengerCar : Vehicles
    {
    }

    // Bus class represents a bus and inherits from Vechiles
    public class Bus : Vehicles
    {
    }

    // Scooter class represents a scooter and inherits from Vechiles
    public class Scooter : Vehicles
    {
    }

    // Truck class represents a truck and inherits from Vechiles
    public class Truck : Vehicles
    {
    }
}