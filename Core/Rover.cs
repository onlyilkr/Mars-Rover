using MarsRover.Core.Enums;
using System.Collections.Generic;

namespace MarsRover.Core
{
    public class Rover : IVehicle
    {
        private Coordinate Coordinate { get; set; }
        private Map Map { get; set; }
        private List<MovementType> Commands { get; set; }

        public Rover() { }
        public IVehicle CreateVehicle(RequestModel requestModel, Map map)
        {
            Map = map;
            Coordinate = requestModel.Coordinate;
            Commands = requestModel.Commands;

            return this;
        }

        #region Mappings

        Coordinate IVehicle.Coordinate => Coordinate;
        Map IVehicle.Map => Map;
        List<MovementType> IVehicle.Commands => Commands;

        #endregion

    }
}
