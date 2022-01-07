using System.ComponentModel;

namespace MarsRover.Core.Enums
{
    public enum DirectionType
    {
        Undefined,
        [Description("N")]
        North,
        [Description("S")]
        South,
        [Description("W")]
        West,
        [Description("E")]
        East
    }
}
