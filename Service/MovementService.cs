using MarsRover.Core;
using MarsRover.Core.Enums;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover.Service
{
    public class MovementService : IMovementService
    {
        private readonly Dictionary<MovementType, IMovement> movementServices;

        public MovementService(IList<IMovement> movements)
        {
           movementServices = movements.ToDictionary(mv => mv.MovementType, mv => mv);
        }

        public IVehicle Move(IVehicle vehicle)
        {
            vehicle.Commands.ForEach(cm =>
            {
                movementServices[cm].Action(vehicle, cm);
            });

            return vehicle;
        }

    }
}
