
using StaticExercise;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the temp in F you want to convert?");
        var fahtemp = Convert.ToDouble(Console.ReadLine());
        double convertToCel = TempConverter.FahrenheitToCelcius(fahtemp);

        Console.WriteLine($"That equals {convertToCel} degrees Celsius");

        Console.WriteLine("What is the temp in C you want to convert?");
        var CelTemp = Convert.ToDouble(Console.ReadLine());
        double convertTofah = TempConverter.CelsiusToFahrenheit(CelTemp);

        Console.WriteLine($"That equals to {convertTofah} degrees fahrenheit");
    }
}
}
