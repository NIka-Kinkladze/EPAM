using InterfacesAndStructures;

// Namespace for the classes implementing the IFlyable interface
namespace Flyers
{
    // Airplane class implementing the IFlyable interface
    public class Airplane : IFlyable
    {
        // Fields and properties for the Airplane class

        private double currentSpeed;

        public Coordinate CurrentPosition { get; set; }

        public Airplane(Coordinate currentPosition)
        {
            // Constructor for Airplane class
            CurrentPosition = currentPosition;
            currentSpeed = 200;
        }

        public void FlyTo(Coordinate newPosition)
        {
            // Method to calculate and set new position and speed for Airplane
            CurrentPosition = newPosition;
            var distance = CalculateDistance(newPosition, CurrentPosition);
            var acceleration = 10;
            var speedIncrease = 0d;

            for (var i = 10; i <= distance; i += 10)
            {
                speedIncrease += acceleration;
            }

            currentSpeed += speedIncrease;
        }

        public double GetFlyTime(Coordinate newPosition)
        {
            // Method to calculate and return the fly time for Airplane
            var distance = CalculateDistance(newPosition, CurrentPosition);
            var acceleration = 10;
            var speedIncrease = 0d;

            for (var i = 10; i <= distance; i += 10)
            {
                speedIncrease += acceleration;
            }

            var finalSpeed = currentSpeed + speedIncrease;
            return distance / finalSpeed;
        }

        private static double CalculateDistance(Coordinate position1, Coordinate position2)
        {
            // Helper method to calculate the distance between two positions
            return Math.Sqrt(Math.Pow(position2.X - position1.X, 2) + Math.Pow(position2.Y - position1.Y, 2) + Math.Pow(position2.Z - position1.Z, 2));
        }
    }

    // Drone class implementing the IFlyable interface
    public class Drone : IFlyable
    {
        // Constants for the drone's hovering behavior
        private const int HOVER_TIME = 1;     // in minutes
        private const int HOVER_INTERVAL = 10; // in minutes

        // Property to store the current position of the Drone
        public Coordinate CurrentPosition { get; set; }

        // Constructor for Drone class
        public Drone(Coordinate currentPosition)
        {
            // Initialize the Drone's current position
            CurrentPosition = currentPosition;
        }

        // Method to make the Drone fly to the specified new position
        public void FlyTo(Coordinate newPosition)
        {
            // Update the Drone's current position to the new position
            CurrentPosition = newPosition;
        }

        // Method to calculate the fly time to reach the specified new position
        public double GetFlyTime(Coordinate newPosition)
        {
            // Calculate the distance between the Drone's current position and the new position
            var distance = CalculateDistance(newPosition, CurrentPosition);

            var time = 0d;
            var elapsed = 0;

            // Fly the Drone until the distance becomes zero
            while (distance > 0)
            {
                // If the Drone has flown for HOVER_INTERVAL minutes, it hovers for HOVER_TIME minutes
                if (elapsed == HOVER_INTERVAL)
                {
                    // Convert the hover time to hours and add to the total flight time
                    time += HOVER_TIME / 60d;
                    elapsed = 0; // Reset the elapsed time
                }
                else
                {
                    // Move the Drone by a maximum of 50 meters at a time (assuming it moves at 50 km/h)
                    var moveDistance = Math.Min(distance, 50);
                    distance -= moveDistance;

                    // Add the time taken to move this distance to the total flight time
                    time += moveDistance / 50d; // Drone moves at 50 km/h
                    elapsed += 1; // Increment the elapsed time
                }
            }

            // If the Drone has flown for HOVER_INTERVAL minutes after reaching the destination, it hovers for HOVER_TIME minutes
            if (elapsed == HOVER_INTERVAL)
            {
                // Convert the hover time to hours and add to the total flight time
                time += HOVER_TIME / 60d;
            }

            return time; // Return the total flight time for the Drone
        }

        // Helper method to calculate the Euclidean distance between two 3D coordinates
        private static double CalculateDistance(Coordinate position1, Coordinate position2)
        {
            return Math.Sqrt(Math.Pow(position2.X - position1.X, 2) + Math.Pow(position2.Y - position1.Y, 2) + Math.Pow(position2.Z - position1.Z, 2));
        }
    }
    // Bird class implementing the IFlyable interface
    public class Bird : IFlyable
    {
        private double currentSpeed;

        // Property to store the current position of the Bird
        public Coordinate CurrentPosition { get; set; }

        // Constructor for Bird class
        public Bird(Coordinate currentPosition)
        {
            // Initialize the Bird's current position
            CurrentPosition = currentPosition;

            // Generate a random initial speed between 0 to 20 km/h for the Bird
            currentSpeed = new Random().Next(0, 21);
        }

        // Method to make the Bird fly to the specified new position
        public void FlyTo(Coordinate newPosition)
        {
            // Update the Bird's current position to the new position
            CurrentPosition = newPosition;
        }

        // Method to calculate the fly time to reach the specified new position
        public double GetFlyTime(Coordinate newPosition)
        {
            // Calculate the distance between the Bird's current position and the new position
            var distance = CalculateDistance(newPosition, CurrentPosition);

            // Calculate and return the fly time based on the Bird's current speed
            return distance / currentSpeed;
        }

        // Helper method to calculate the Euclidean distance between two 3D coordinates
        private static double CalculateDistance(Coordinate position1, Coordinate position2)
        {
            return Math.Sqrt(Math.Pow(position2.X - position1.X, 2) + Math.Pow(position2.Y - position1.Y, 2) + Math.Pow(position2.Z - position1.Z, 2));
        }
    }
}
