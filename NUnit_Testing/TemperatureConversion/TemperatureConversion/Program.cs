using System;

namespace TemperatureConversion
{
    public class temperaturConversion
    {
        public static void Main()
        { 
        
            temperatureConversion();
        }

        public static void temperatureConversion()
        {
            int check, celsius, fahrenheit;
            Console.Write("Enter 1 to convert Celsius to Fahrenheit and " +
                "Enter 2 to convert Fahrenheit to Celsius: ");
            check = int.Parse(Console.ReadLine());

            if (check == 1)
            {
                Console.Write("Enter temperature in °C: ");
                celsius = int.Parse(Console.ReadLine());
                int fahrenheitC = (celsius * 9 / 5) + 32;
                Console.WriteLine(+celsius + "°C = " + fahrenheitC + "°F");
            }
            else if (check == 2)
            {
                Console.Write("Enter temperature in °F: ");
                fahrenheit = int.Parse(Console.ReadLine());
                int celsiusF = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine(+fahrenheit + "°F = " + celsiusF + "°C");
            }
            else
            {
                Console.WriteLine("Enter valid input.");
            }
        }
        
    }
}
