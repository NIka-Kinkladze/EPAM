using vechileparts;
namespace vechiles
{
    // Base class Vechiles (spelling should be corrected to "Vehicles") is empty and can be used as a common base for all vehicle types if needed.
    public class Vechiles
    {

    }

    // PassengerCar class represents a passenger car and inherits from Vechiles
    public class PassengerCar : Vechiles
    {
        public Engine engine { get; set; }
        public Transmission transmission { get; set; }
        public Chasis chasis { get; set; }

    }

    // Bus class represents a bus and inherits from Vechiles
    public class Bus : Vechiles
    {
        public Engine engine { get; set; }
        public Chasis chasis { get; set; }
        public Transmission transmission { get; set; }

    }

    // Scooter class represents a scooter and inherits from Vechiles
    public class Scooter : Vechiles
    {
        public Engine engine { get; set; }
        public Chasis chasis { get; set; }
        public Transmission transmission { get; set; }

    }

    // Truck class represents a truck and inherits from Vechiles
    public class Truck : Vechiles
    {
        public Engine engine { get; set; }
        public Chasis chasis { get; set; }
        public Transmission transmission { get; set; }

    }
}