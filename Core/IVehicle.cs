using MarsRover.Core.Enums;
using System.Collections.Generic;

namespace MarsRover.Core
{
    public interface IVehicle
    {
        Coordinate Coordinate { get; }
        Map Map { get; }
        List<MovementType> Commands { get; }
        IVehicle CreateVehicle(RequestModel requestModel, Map map);
    }
}
