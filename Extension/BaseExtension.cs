using MarsRover.Core.Enums;
using System;
using System.Linq;

namespace MarsRover.Extension
{
    public static class BaseExtension
    {
        public static MovementType ToMovementType(this string movementDescription)
        {
            return Enum.GetValues(typeof(MovementType)).Cast<MovementType>().FirstOrDefault(v => v.GetDescription() == movementDescription);
        }

        public static DirectionType ToDirectionType(this string directionDescription)
        {
            return Enum.GetValues(typeof(DirectionType)).Cast<DirectionType>().FirstOrDefault(v => v.GetDescription() == directionDescription);
        }
    }
}
