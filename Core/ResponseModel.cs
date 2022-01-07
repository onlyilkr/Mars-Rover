using MarsRover.Extension;

namespace MarsRover.Core
{
    public class ResponseModel
    {
        public Coordinate Coordinate { get; }

        public ResponseModel(IVehicle vehicle)
        {
            Coordinate = vehicle.Coordinate;
            
        }

        public string GetCurrentPosition()
        {
            return string.Join(" ", Coordinate.AxisX, Coordinate.AxisY, Coordinate.DirectionType.GetDescription());
        }

    }
}
