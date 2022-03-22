public class Program
{
    static void Main (String[] args)
    {
        int choice = 0;
        while ((choice != 1) && (choice != 2))
        {
            Console.WriteLine("Select your conversion type:");
            Console.WriteLine("1. Convert from Celsius to Fahrenheit");
            Console.WriteLine("2. Convert from Fahrenheit to Celsius");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Conversion.celsiusToFahrenheit();
                    break;
                case 2:
                    Conversion.fahrenheitToCelsius();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
    }
}

abstract class Conversion
{
    public static void celsiusToFahrenheit()
    {
        Console.WriteLine("Write your value in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = celsius*9/5+32;
        Console.WriteLine("The value in Fahrenheit is: " + Convert.ToString(fahrenheit));
    }
    public static void fahrenheitToCelsius()
    {
        Console.WriteLine("Write your value in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (fahrenheit-32)*5/9;
        Console.WriteLine("The value in Celsius is: " + Convert.ToString(celsius));
    }
}