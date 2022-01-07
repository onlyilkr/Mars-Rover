using MarsRover.Core.Enums;

namespace MarsRover.Core
{
    public class Coordinate
    {
        public int AxisX { get; private set; }
        public int AxisY { get; private set; }
        public DirectionType DirectionType { get; private set; }

        public Coordinate(int axisX, int axisY, DirectionType directionType)
        {
            AxisX = axisX;
            AxisY = axisY;
            DirectionType = directionType;
        }

        public Coordinate UpdateDirection(DirectionType directionType)
        {
            DirectionType = directionType;

            return this;
        }

        public Coordinate UpdateAxisX(int valueToAdd)
        {
            AxisX += valueToAdd;

            return this;
        }

        public Coordinate UpdateAxisY(int valueToAdd)
        {
            AxisY += valueToAdd;

            return this;
        }
    }
}
