using Flyers;
using InterfacesAndStructures;

// Namespace for the main execution of the program
namespace ExecutionMethod
{
    internal class Execution
    {
        public static void exetution()
        {
            // Define the initial and destination positions for the objects
            Coordinate initialPosition = new Coordinate(0, 0, 0);
            Coordinate destination = new Coordinate(10, 10, 10);

            // Create instances of Bird, Airplane, and Drone
            Bird bird = new Bird(initialPosition);
            Airplane airplane = new Airplane(initialPosition);
            Drone drone = new Drone(initialPosition);

            // Calculate and display the fly time to the destination for each object
            Console.Write("Bird:");
            Console.WriteLine($"Fly time to destination: {bird.GetFlyTime(destination)} hours");

            Console.Write("\nAirplane:");
            Console.WriteLine($"Fly time to destination: {airplane.GetFlyTime(destination)} hours");

            Console.Write("\nDrone:");
            Console.WriteLine($"Fly time to destination: {drone.GetFlyTime(destination)} hours");

            Console.ReadLine();
        }
    }
}
