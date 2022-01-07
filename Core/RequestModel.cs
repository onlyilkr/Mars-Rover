using MarsRover.Core.Enums;
using MarsRover.Extension;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover.Core
{
    public class RequestModel
    {
        public Coordinate Coordinate { get; }
        public List<MovementType> Commands { get; }

        public RequestModel(string coordinate, string directions)
        {
            var coordinates = coordinate.Replace(" ", string.Empty).ToUpper().ToCharArray().Select(cd => cd.ToString()).ToList();
            if (!coordinates.Count.Equals(3) || coordinates.Last().ToUpper().ToDirectionType() == default)
                throw new RequestModelException.CoordinateIsNotCorrect();

            var commands = directions.Replace(" ", string.Empty).ToUpper().ToCharArray().Select(cd => cd.ToString()).ToList();
            if(commands.Any(c => c.ToMovementType() == default))
                throw new RequestModelException.NotValidCommand();

            Coordinate = new Coordinate(int.Parse(coordinates[0]), int.Parse(coordinates[1]), coordinates[2].ToDirectionType());
            Commands = commands.Select(cm => cm.ToMovementType()).ToList();
        }
    }
}
