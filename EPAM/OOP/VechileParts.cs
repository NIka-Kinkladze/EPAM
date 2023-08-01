// Namespace for the vehicle part classes: Engine, Chasis, Transmission
namespace VechileParts
{
    public class Engine
    {
        // Properties for engine details
        public int? Power { get; set; }
        public string? Volume { get; set; }
        public string? Type { get; set; }
        public int? SerialNumber { get; set; }
    }

    public class Chasis
    {
        // Properties for chassis details
        public int? WheelsNumber { get; set; }
        public String? Number { get; set; }
        public int? PermissableLoad { get; set; }
    }

    public class Transmission
    {
        // Properties for transmission details
        public string? Type { get; set; }
        public int? NumberOfGears { get; set; }
        public string? Manufacturer { get; set; }
    }
}
