// Namespace for the coordinate structure and the IFlyable interface
namespace InterfacesAndStructures
{
    public struct Coordinate
    {
        public double X;
        public double Y;
        public double Z;

        public Coordinate(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }

    // IFlyable interface with methods to FlyTo and GetFlyTime
    public interface IFlyable
    {
        void FlyTo(Coordinate newPoint);
        double GetFlyTime(Coordinate newPoint);
    }
}
