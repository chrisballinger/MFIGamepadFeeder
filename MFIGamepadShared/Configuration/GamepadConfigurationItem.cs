using ScpDriverInterface;

namespace MFIGamepadShared.Configuration
{
    public enum GamepadAxis
    {
        AxisLx,
        AxisRx,
        AxisLy,
        AxisRy,
        AxisLt,
        AxisRt,
        Empty,
    }

    public class GamepadConfigurationItem
    {
        public GamepadAxis Axis { get; set; }
        public bool? InvertAxis { get; set; }
        public bool? ConvertAxis { get; set; }
        public X360Buttons Button { get; set; }
    }
}