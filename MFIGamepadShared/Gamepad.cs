using System;
using System.Collections.ObjectModel;
using System.Linq;
using MFIGamepadShared.Configuration;
using ScpDriverInterface;

public delegate void ErorOccuredEventHandler(object sender, string errorMessage);

namespace MFIGamepadFeeder
{
    public class Gamepad
    {
        private readonly GamepadConfiguration _config;
        private readonly uint _gamepadId;

        public Gamepad(GamepadConfiguration config, uint gamepadId)
        {
            _config = config;
            _gamepadId = gamepadId;
        }

        public event ErorOccuredEventHandler ErrorOccuredEvent;

        private void Log(string message)
        {
            ErrorOccuredEvent?.Invoke(this, message);
        }

        public X360Controller UpdateState(byte[] state)
        {
            //              Log(string.Join(" ", state));
            var controller = new X360Controller();
            for (var i = 0; i < _config.ConfigItems.Count; i++)
            {
                controller = SetGamepadItem(state, i, _config.ConfigItems[i], controller);
            }

            return controller;
        }

        private X360Controller SetGamepadItem(byte[] values, int index, GamepadConfigurationItem config,
            X360Controller x360Controller)
        {
            double value = values[index];


            if (config.Axis != GamepadAxis.Empty)
            {
                value = NormalizeAxis((byte)value, config.ConvertAxis ?? false);

                if (config.InvertAxis ?? false)
                {
                    value = InvertNormalizedAxis(value);
                }

                switch (config.Axis)
                {
                    case GamepadAxis.AxisLx:
                        x360Controller.LeftStickX = (short)(value * short.MaxValue);
                        break;
                    case GamepadAxis.AxisRx:
                        x360Controller.RightStickX = (short)(value * short.MaxValue);
                        break;
                    case GamepadAxis.AxisLy:
                        x360Controller.LeftStickY = (short)(value * short.MaxValue);
                        break;
                    case GamepadAxis.AxisRy:
                        x360Controller.RightStickY = (short)(value * short.MaxValue);
                        break;
                    case GamepadAxis.AxisLt:
                        x360Controller.LeftTrigger = (byte)(value * byte.MaxValue);
                        break;
                    case GamepadAxis.AxisRt:
                        x360Controller.RightTrigger = (byte)(value * byte.MaxValue);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                if (value > 0)
                {
                    x360Controller.Buttons |= config.Button;
                }

            }

            return x360Controller;
        }

        private double NormalizeAxis(byte valueToNormalize, bool shouldConvert)
        {
            if (shouldConvert)
            {
                if (valueToNormalize < byte.MaxValue / 2.0)
                {
                    return (2.0*valueToNormalize + byte.MaxValue) / byte.MaxValue - 1.0;
                }
                return (2.0*valueToNormalize - byte.MaxValue) / byte.MaxValue - 1.0;
            }

            return (double)valueToNormalize / byte.MaxValue;
        }

        private double InvertNormalizedAxis(double axisToInvert)
        {
            return 1.0 - axisToInvert;
        }

        private bool ConvertToButtonState(byte value)
        {
            return value > 0;
        }
    }
}