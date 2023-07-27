using VechileParts;

// Namespace for vehicle classes: PassengerCar, Truck, Bus, Scooter
namespace Vechile
{
    public class PassengerCar
    {
        // Properties for passenger car details
        public Engine engine { get; set; }
        public Chasis chasis { get; set; }
        public Transmission transmission { get; set; }
        public string Model { get; set; }
    }
    public class Truck
    {
        // Properties for truck details
        public Engine engine { get; set; }
        public Chasis chasis { get; set; }
        public Transmission transmission { get; set; }
        public string Model { get; set; }
    }

    public class Bus
    {
        // Properties for bus details
        public Engine engine { get; set; }
        public Chasis chasis { get; set; }
        public Transmission transmission { get; set; }
        public string Model { get; set; }
    }

    class Scooter
    {
        // Properties for scooter details
        public Engine engine { get; set; }
        public Chasis chasis { get; set; }
        public Transmission transmission { get; set; }
        public string Model { get; set; }
    }
}
