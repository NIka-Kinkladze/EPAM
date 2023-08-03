using System.Xml.Linq;
using VehicleParts;
using vehicles;

namespace VehicleProvider
{
    public class vehicleProvider
    {
        // Method to demonstrate information about all vehicles created and their characteristics
        public static void GetAllVehicles()
        {
            // Create a list to store different vehicles
            List<Vehicles> vehicles = new List<Vehicles>();

            // Create instances of different vehicles with specific characteristics
            PassengerCar car = new PassengerCar()
            {
                engine = new Engine() { Power = 1000, SerialNumber = 123412, Type = "Gasoline", Volume = "low" },
                chasis = new Chasis() { WheelsNumber = 4, Number = "VV-566-TT", PermissableLoad = 500 },
                transmission = new Transmission() { Type = "Manual", Manufacturer = "Dodge", NumberOfGears = 6 },

            };

            Scooter scooter = new Scooter()
            {
                engine = new Engine() { Power = 50, SerialNumber = 176412, Type = "Electric", Volume = "Very low" },
                chasis = new Chasis() { WheelsNumber = 2, Number = "BB-566-FF", PermissableLoad = 50 },
                transmission = new Transmission() { Type = "Automatic", Manufacturer = "Honda", NumberOfGears = 2 },

            };

            Bus bus = new Bus()
            {
                engine = new Engine() { Power = 1900, SerialNumber = 186542, Type = "Gasoline", Volume = "High" },
                chasis = new Chasis() { WheelsNumber = 8, Number = "KK-243-RR", PermissableLoad = 1500 },
                transmission = new Transmission() { Type = "Manual", Manufacturer = "Mercedes", NumberOfGears = 6 },

            };

            Truck truck = new Truck()
            {
                engine = new Engine() { Power = 2000, SerialNumber = 654729, Type = "Diesel", Volume = "very high" },
                chasis = new Chasis() { WheelsNumber = 6, Number = "GG-642-TT", PermissableLoad = 2000 },
                transmission = new Transmission() { Type = "Manual", Manufacturer = "Ford", NumberOfGears = 6 },

            };

            // Add the created vehicles to the list
            vehicles.Add(car);
            vehicles.Add(scooter);
            vehicles.Add(truck);
            vehicles.Add(bus);

            // Iterate through each vehicle in the list and print their characteristics based on their types
            foreach (var vechile in vehicles)
            {
                if (vechile is PassengerCar)
                {
                    // Print information about the PassengerCar
                    Console.WriteLine("Passenger car:");
                    Console.WriteLine("              Engine: ");
                    Console.WriteLine("                     Power: " + ((PassengerCar)vechile).engine?.Power);
                    Console.WriteLine("                     Type: " + ((PassengerCar)vechile).engine?.Type);
                    Console.WriteLine("                     Volume: " + ((PassengerCar)vechile).engine?.Volume);
                    Console.WriteLine("                     SerialNumber: " + ((PassengerCar)vechile).engine?.SerialNumber);
                    Console.WriteLine("              Chasis: ");
                    Console.WriteLine("                     Wheels number: " + ((PassengerCar)vechile).chasis?.WheelsNumber);
                    Console.WriteLine("                     Number: " + ((PassengerCar)vechile).chasis?.Number);
                    Console.WriteLine("                     Permissable load: " + ((PassengerCar)vechile).chasis?.PermissableLoad);
                    Console.WriteLine("              Transmission: ");
                    Console.WriteLine("                           Type: " + ((PassengerCar)vechile).transmission?.Type);
                    Console.WriteLine("                           Number of gears: " + ((PassengerCar)vechile).transmission?.NumberOfGears);
                    Console.WriteLine("                           Manufacturer: " + ((PassengerCar)vechile).transmission?.Manufacturer);
                    Console.WriteLine();
                }
                else if (vechile is Truck)
                {
                    // Print information about the Truck
                    Console.WriteLine("Truck:");
                    Console.WriteLine("              Engine: ");
                    Console.WriteLine("                     Power: " + ((Truck)vechile).engine?.Power);
                    Console.WriteLine("                     Type: " + ((Truck)vechile).engine?.Type);
                    Console.WriteLine("                     Volume: " + ((Truck)vechile).engine?.Volume);
                    Console.WriteLine("                     SerialNumber: " + ((Truck)vechile).engine?.SerialNumber);
                    Console.WriteLine("              Chasis: ");
                    Console.WriteLine("                     Wheels number: " + ((Truck)vechile).chasis?.WheelsNumber);
                    Console.WriteLine("                     Number: " + ((Truck)vechile).chasis?.Number);
                    Console.WriteLine("                     Permissable load: " + ((Truck)vechile).chasis?.PermissableLoad);
                    Console.WriteLine("              Transmission: ");
                    Console.WriteLine("                           Type: " + ((Truck)vechile).transmission?.Type);
                    Console.WriteLine("                           Number of gears: " + ((Truck)vechile).transmission?.NumberOfGears);
                    Console.WriteLine("                           Manufacturer: " + ((Truck)vechile).transmission?.Manufacturer);
                    Console.WriteLine();
                }
                else if (vechile is Bus)
                {
                    // Print information about the Bus
                    Console.WriteLine("Bus:");
                    Console.WriteLine("              Engine: ");
                    Console.WriteLine("                     Power: " + ((Bus)vechile).engine?.Power);
                    Console.WriteLine("                     Type: " + ((Bus)vechile).engine?.Type);
                    Console.WriteLine("                     Volume: " + ((Bus)vechile).engine?.Volume);
                    Console.WriteLine("                     SerialNumber: " + ((Bus)vechile).engine?.SerialNumber);
                    Console.WriteLine("              Chasis: ");
                    Console.WriteLine("                     Wheels number: " + ((Bus)vechile).chasis?.WheelsNumber);
                    Console.WriteLine("                     Number: " + ((Bus)vechile).chasis?.Number);
                    Console.WriteLine("                     Permissable load: " + ((Bus)vechile).chasis?.PermissableLoad);
                    Console.WriteLine("              Transmission: ");
                    Console.WriteLine("                           Type: " + ((Bus)vechile).transmission?.Type);
                    Console.WriteLine("                           Number of gears: " + ((Bus)vechile).transmission?.NumberOfGears);
                    Console.WriteLine("                           Manufacturer: " + ((Bus)vechile).transmission?.Manufacturer);
                    Console.WriteLine();
                }
                else if (vechile is Scooter)
                {
                    // Print information about the Scooter
                    Console.WriteLine("Scooter:");
                    Console.WriteLine("              Engine: ");
                    Console.WriteLine("                     Power: " + ((Scooter)vechile).engine?.Power);
                    Console.WriteLine("                     Type: " + ((Scooter)vechile).engine?.Type);
                    Console.WriteLine("                     Volume: " + ((Scooter)vechile).engine?.Volume);
                    Console.WriteLine("                     SerialNumber: " + ((Scooter)vechile).engine?.SerialNumber);
                    Console.WriteLine("              Chasis: ");
                    Console.WriteLine("                     Wheels number: " + ((Scooter)vechile).chasis?.WheelsNumber);
                    Console.WriteLine("                     Number: " + ((Scooter)vechile).chasis?.Number);
                    Console.WriteLine("                     Permissable load: " + ((Scooter)vechile).chasis?.PermissableLoad);
                    Console.WriteLine("              Transmission: ");
                    Console.WriteLine("                           Type: " + ((Scooter)vechile).transmission?.Type);
                    Console.WriteLine("                           Number of gears: " + ((Scooter)vechile).transmission?.NumberOfGears);
                    Console.WriteLine("                           Manufacturer: " + ((Scooter)vechile).transmission?.Manufacturer);
                    Console.WriteLine();
                }
            }
            // 1. All information about all vehicles an engine capacity of which is more than 1.5 liters;
            XDocument engineCapacityXml = new XDocument(new XElement("Vehicles"));
            foreach (var vehicle in vehicles)
            {
                if (vehicle.engine != null && vehicle.engine.Volume == "Very high")
                {
                    engineCapacityXml.Root.Add(new XElement(vehicle.GetType().Name,
                        new XElement("Model", vehicle.Model),
                        new XElement("Engine",
                            new XElement("Power", vehicle.engine.Power),
                            new XElement("Volume", vehicle.engine.Volume),
                            new XElement("Type", vehicle.engine.Type),
                            new XElement("SerialNumber", vehicle.engine.SerialNumber))));
                }
            }
            engineCapacityXml.Save("engine_capacity.xml");

            // 2. Engine type, serial number and power rating for all buses and trucks;
            XDocument busesAndTrucksXml = new XDocument(new XElement("Vehicles"));
            foreach (var vechile in vehicles)
            {
                if (vechile is Bus || vechile is Truck)
                {
                    busesAndTrucksXml.Root.Add(new XElement(vechile.GetType().Name,
                        new XElement("Model", vechile.Model),
                        new XElement("Engine",
                            new XElement("Power", vechile.engine.Power),
                            new XElement("Type", vechile.engine.Type),
                            new XElement("SerialNumber", vechile.engine.SerialNumber))));
                }
            }
            busesAndTrucksXml.Save("buses_and_trucks.xml");

            // 3. All information about all vehicles, grouped by transmission type.
            XDocument groupedByTransmissionXml = new XDocument(new XElement("Vehicles"));
            foreach (var vechile in vehicles)
            {
                if (vechile.transmission != null)
                {
                    XElement transmissionElement = new XElement(vechile.GetType().Name,
                        new XElement("Model", vechile.Model),
                        new XElement("Engine",
                            new XElement("Power", vechile.engine.Power),
                            new XElement("Volume", vechile.engine.Volume),
                            new XElement("Type", vechile.engine.Type),
                            new XElement("SerialNumber", vechile.engine.SerialNumber)),
                        new XElement("Chasis",
                            new XElement("WheelsNumber", vechile.chasis.WheelsNumber),
                            new XElement("Number", vechile.chasis.Number),
                            new XElement("PermissableLoad", vechile.chasis.PermissableLoad)),
                        new XElement("Transmission",
                            new XElement("Type", vechile.transmission.Type),
                            new XElement("NumberOfGears", vechile.transmission.NumberOfGears),
                            new XElement("Manufacturer", vechile.transmission.Manufacturer)));

                    // Grouping by transmission type
                    XElement existingTransmissionElement = groupedByTransmissionXml.Root.Element(vechile.transmission?.Type);
                    if (existingTransmissionElement != null)
                    {
                        existingTransmissionElement.Add(transmissionElement);
                    }
                    else
                    {
                        groupedByTransmissionXml.Root.Add(new XElement(vechile.transmission.Type, transmissionElement));
                    }
                }
            }
            groupedByTransmissionXml.Save("grouped_by_transmission.xml");

            Console.ReadKey();
        }
    }
    
}