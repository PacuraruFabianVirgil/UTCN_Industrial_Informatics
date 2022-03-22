public class Program
{
    static void Main(String[] args)
    {
        String numbers = " ";
        while (numbers == " ")
        {
            Console.WriteLine("Write the numbers on the same line separated by space: ");
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            numbers = Console.ReadLine();
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            numbers = numbers + " ";
        }
        int number = 0, counter = 0, sum = 0, product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if ((numbers[i] == ' ')&&(number!=0))
            {
                counter = counter+1;
                sum = sum+number;
                product = product*number;
                number = 0;
            } else
            {
                number = number*10 + Convert.ToInt32(new String(numbers[i],1));
            }
        }
        double arithmeticMean = Convert.ToDouble(sum)/counter;
        double geometricMean = Math.Pow(Convert.ToDouble(product), 1/Convert.ToDouble(counter));
        Console.WriteLine("The arithmetric mean is: " + Convert.ToString(arithmeticMean));
        Console.WriteLine("The geometric mean is: " + Convert.ToString(geometricMean));
    }
}