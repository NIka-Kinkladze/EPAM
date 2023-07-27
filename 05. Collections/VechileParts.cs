// Namespace containing classes for vehicle parts (Engine, Chasis, Transmission)
namespace vechileparts
{
    // Engine class representing the engine of a vehicle
    public class Engine
    {
        public int Power { get; set; }
        public string Volume { get; set; }
        public string Type { get; set; }
        public int SerialNumber { get; set; }
    }

    // Chasis class representing the chassis of a vehicle
    public class Chasis
    {
        public int WheelsNumber { get; set; }
        public string Number { get; set; }
        public int PermissableLoad { get; set; }
    }

    // Transmission class representing the transmission system of a vehicle
    public class Transmission
    {
        public string Type { get; set; }
        public int NumberOfGears { get; set; }
        public string Manufacturer { get; set; }
    }
}