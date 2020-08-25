using System;

namespace Calculator.Business
{
    public class DegreeConverter
    {
        public decimal ToFahrenheit(decimal celsius)
        {
            return Math.Round(((celsius * 9 / 5) + 32),2);
        }

        public decimal ToCelsius(decimal fahrenheit)
        {
            return Math.Round(((fahrenheit - 32) * 5 / 9),2);
        }

    }
}
