using MarsRover.Core.Enums;

namespace MarsRover.Core
{
    public class ToLeftAction : IMovement
    {
        public Coordinate Action(IVehicle vehicle, MovementType expectedMovementType)
        {
            switch (vehicle.Coordinate.DirectionType)
            {
                case DirectionType.East:
                    vehicle.Coordinate.UpdateDirection(DirectionType.North);
                    break;
                case DirectionType.South:
                    vehicle.Coordinate.UpdateDirection(DirectionType.East);
                    break;
                case DirectionType.North:
                    vehicle.Coordinate.UpdateDirection(DirectionType.West);
                    break;
                case DirectionType.West:
                    vehicle.Coordinate.UpdateDirection(DirectionType.South);
                    break;
            }

            return vehicle.Coordinate;
        }

        #region Mappings

        MovementType IMovement.MovementType => MovementType.Left;

        #endregion
    }
}
