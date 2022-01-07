using System.ComponentModel;

namespace MarsRover.Core.Enums
{
    public enum MovementType
    {
        Undefined,
        [Description("L")]
        Left,
        [Description("R")]
        Right,
        [Description("M")]
        Forward
    }
}
