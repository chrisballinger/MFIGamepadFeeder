using System.Collections.ObjectModel;
using MFIGamepadShared.Configuration;
using ScpDriverInterface;

namespace MFIGamepadConfigCreator
{
    internal class ConfigCreator
    {
        public GamepadConfiguration GetNimbusConfiguration()
        {
            var configItems = new Collection<GamepadConfigurationItem>
            {
                new GamepadConfigurationItem
                {
                    InvertAxis = null,
                    ConvertAxis = null,
                    Button = X360Buttons.None,
                    Axis = GamepadAxis.Empty
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = null,
                    ConvertAxis = null,
                    Button = X360Buttons.Up,
                    Axis = GamepadAxis.Empty
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = null,
                    ConvertAxis = null,
                    Button = X360Buttons.Right,
                    Axis = GamepadAxis.Empty
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = null,
                    ConvertAxis = null,
                    Button = X360Buttons.Down,
                    Axis = GamepadAxis.Empty
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = null,
                    ConvertAxis = null,
                    Button = X360Buttons.Left,
                    Axis = GamepadAxis.Empty
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = null,
                    ConvertAxis = null,
                    Button = X360Buttons.A,
                    Axis = GamepadAxis.Empty
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = null,
                    ConvertAxis = null,
                    Button = X360Buttons.B,
                    Axis = GamepadAxis.Empty
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = null,
                    ConvertAxis = null,
                    Button = X360Buttons.X,
                    Axis = GamepadAxis.Empty
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = null,
                    ConvertAxis = null,
                    Button = X360Buttons.Y,
                    Axis = GamepadAxis.Empty
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = null,
                    ConvertAxis = null,
                    Button = X360Buttons.LeftBumper,
                    Axis = GamepadAxis.Empty
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = null,
                    ConvertAxis = null,
                    Button = X360Buttons.RightBumper,
                    Axis = GamepadAxis.Empty
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = false,
                    ConvertAxis = false,
                    Button = X360Buttons.None,
                    Axis = GamepadAxis.AxisLt
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = false,
                    ConvertAxis = false,
                    Button = X360Buttons.None,
                    Axis = GamepadAxis.AxisRt
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = null,
                    ConvertAxis = null,
                    Button = X360Buttons.Start,
                    Axis = GamepadAxis.Empty
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = false,
                    ConvertAxis = true,
                    Button = X360Buttons.None,
                    Axis = GamepadAxis.AxisLx
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = false,
                    ConvertAxis = true,
                    Button = X360Buttons.None,
                    Axis = GamepadAxis.AxisLy
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = false,
                    ConvertAxis = true,
                    Button = X360Buttons.None,
                    Axis = GamepadAxis.AxisRx
                },
                new GamepadConfigurationItem
                {
                    InvertAxis = false,
                    ConvertAxis = true,
                    Button = X360Buttons.None,
                    Axis = GamepadAxis.AxisRy
                }
            };

            return new GamepadConfiguration { ConfigItems = configItems };
        }
    }
}