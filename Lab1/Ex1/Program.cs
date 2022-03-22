public class Program
{
    static void Main (String[] args)
    {
        Console.WriteLine("How many Fibonacci numbers do you want to see?");
        int numberOfTerms = Convert.ToInt32(Console.ReadLine());
        int firstNumber = 0;
        int secondNumber = 1;
        Console.Write(Convert.ToString(firstNumber) + " " + Convert.ToString(secondNumber));
        int counter = 2;
        while (counter < numberOfTerms)
        {
            int auxiliaryNumber = secondNumber;
            secondNumber = firstNumber + secondNumber;
            firstNumber = auxiliaryNumber;
            Console.Write(" " + Convert.ToString(secondNumber));
            counter++;
        }
        Console.WriteLine();
    }
}