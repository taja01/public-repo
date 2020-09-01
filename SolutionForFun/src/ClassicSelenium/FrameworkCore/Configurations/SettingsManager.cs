using ClassicSelenium.FrameworkCore.Configurations.Enums;
using NUnit.Framework;
using System;

namespace ClassicSelenium.FrameworkCore.Configurations
{
    static class SettingsManager
    {
        private static Browser? browser;
        private static Env? environment;
        private static Device? device;

        public static Browser Browser
        {
            get
            {

                if (browser != null)
                {
                    return browser.Value;
                }

                browser = Parse<Browser>("Browser");

                return browser.Value;
            }
        }

        public static Env Environment
        {
            get
            {
                if (environment != null)
                {
                    return environment.Value;
                }

                environment = Parse<Env>("Environment");

                return environment.Value;
            }
        }

        public static Device Device
        {
            get
            {
                if (device != null)
                {
                    return device.Value;
                }

                device = Parse<Device>("Device");

                return device.Value;
            }
        }

        private static T Parse<T>(string parameter)
        {
            if (!TestContext.Parameters.Exists(parameter))
            {
                throw new ArgumentException($"The parameter '{parameter}' was not found, please provide a value for this parameter.");
            }

            var stringValue = TestContext.Parameters[parameter];
            if (Enum.TryParse(typeof(T), stringValue, out var result))
            {
                return (T)result;
            }
            else
            {
                throw new NotSupportedException($"Not supported {parameter}:  '{stringValue}'");
            }
        }
    }
}
