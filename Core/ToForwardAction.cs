using MarsRover.Core.Enums;

namespace MarsRover.Core
{
    public class ToForwardAction : IMovement
    {
        public Coordinate Action(IVehicle vehicle, MovementType expectedMovementType)
        {
            switch (vehicle.Coordinate.DirectionType)
            {
                case DirectionType.East:
                    if(vehicle.Map.IsValidBounds(vehicle.Coordinate.AxisX + 1, vehicle.Coordinate.AxisY))
                        vehicle.Coordinate.UpdateAxisX(+1);
                    break;
                case DirectionType.West:
                    if (vehicle.Map.IsValidBounds(vehicle.Coordinate.AxisX - 1, vehicle.Coordinate.AxisY))
                        vehicle.Coordinate.UpdateAxisX(-1);
                    break;
                case DirectionType.South:
                    if (vehicle.Map.IsValidBounds(vehicle.Coordinate.AxisX, vehicle.Coordinate.AxisY - 1))
                        vehicle.Coordinate.UpdateAxisY(-1);
                    break;
                case DirectionType.North:
                    if (vehicle.Map.IsValidBounds(vehicle.Coordinate.AxisX, vehicle.Coordinate.AxisY + 1))
                        vehicle.Coordinate.UpdateAxisY(+1);
                    break;
            }

            return vehicle.Coordinate;
        }

        #region Mappings

        MovementType IMovement.MovementType => MovementType.Forward;

        #endregion
    }
}
