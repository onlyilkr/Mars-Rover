using MarsRover.Core.Enums;

namespace MarsRover.Core
{
    public interface IMovement
    {
        MovementType MovementType { get; }
        Coordinate Action(IVehicle vehicle, MovementType expectedMovementType);
    }
}
