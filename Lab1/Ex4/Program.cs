public class Program
{
    static void Main(String[] args)
    {
        Console.Write("Write your height in cm: ");
        int height = Convert.ToInt32(Console.ReadLine());
        Console.Write("Write your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        char sex = ' ';
        while ((sex != 'b') && (sex != 'f'))
        {
            Console.Write("Choose your sex (b/f): ");
            try
            {
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                sex = Convert.ToChar(Console.ReadLine()[0]);
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
            } catch (IndexOutOfRangeException)
            {
                sex = ' ';
            }
            switch (sex)
            {
                case 'b':
                    CalculateKg.forMale(height, age);
                    break;
                case 'f':
                    CalculateKg.forFemale(height, age);
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
                }
            }
        }
}

abstract class CalculateKg
{
    public static void forMale(double height, double age)
    {
        double kilograms = height - 100 - (height - 150) / 4 + (age - 20) / 4;
        printMessage(Convert.ToString(kilograms));
    }
    public static void forFemale(double height, double age)
    {
        double kilograms = height - 100 - (height - 150) / 2.5 + (age - 20) / 6;
        printMessage(Convert.ToString(kilograms));
    }
    public static void printMessage (String message)
    {
        Console.WriteLine("Your ideal weigth is: " + message + " kg");
    }
}