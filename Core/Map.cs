using System.Linq;

namespace MarsRover.Core
{
    public class Map
    {
        private readonly int XLimit;
        private readonly int YLimit;

        public Map(string mapSize)
        {
            var map = mapSize.Replace(" ", string.Empty).ToCharArray().Select(size => int.Parse(size.ToString())).ToList();
            if (!map.Count.Equals(2))
                throw new RequestModelException.MapSizeIsNotCorrect();

            XLimit = map[0];
            YLimit = map[1];
        }

        public bool IsValidBounds(int xAxis, int yAxis)
        {
            return (xAxis >= 0 && xAxis <= XLimit) && (yAxis >= 0 && yAxis <= YLimit);
        }

    }
}
