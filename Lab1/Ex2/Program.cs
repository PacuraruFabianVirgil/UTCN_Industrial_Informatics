public class Program
{
    static void Main (String[] args)
    {
        Console.Write("Write the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Write the second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        char operation = ' ';
        while ((operation != '+') && (operation != '-') && (operation != '*') && (operation != '/'))
        {
            Console.Write("Write the operation ('+','-','*','/'): ");
            try
            {
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                operation = Convert.ToChar(Console.ReadLine()[0]);
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
            } catch (IndexOutOfRangeException)
            {
                operation = ' ';
            }
            switch (operation)
            {
                case '+':
                    Operations.add(firstNumber, secondNumber);
                    break;
                case '-':
                    Operations.substract(firstNumber, secondNumber);
                    break;
                case '*':
                    Operations.multiply(firstNumber, secondNumber);
                    break;
                case '/':
                    Operations.divide(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}

abstract class Operations
{
    public static void add(int firstNumber, int secondNumber)
    {
        printMessage(Convert.ToString(firstNumber + secondNumber));
    }
    public static void substract(int firstNumber, int secondNumber)
    {
        printMessage(Convert.ToString(firstNumber - secondNumber));
    }
    public static void multiply(int firstNumber, int secondNumber)
    {
        printMessage(Convert.ToString(firstNumber * secondNumber));
    }
    public static void divide(int firstNumber, int secondNumber)
    {
        printMessage(Convert.ToString(Convert.ToDouble(firstNumber) / Convert.ToDouble(secondNumber)));
    }
    public static void printMessage(String message)
    {
        Console.WriteLine("The result is: " + message);
    }
}