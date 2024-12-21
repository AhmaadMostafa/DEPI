using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TemperatureConversion
    {
        #region Problem 8
        public static double ConvertToFahrenheit(double celsius) => (celsius * 9 / 5) + 32;
        public static double ConvertToCelsius(double fahrenheit) => (fahrenheit - 32) * 5 / 9;

        #endregion
    }
}
