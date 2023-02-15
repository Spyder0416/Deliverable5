using System;

namespace ArraySummation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number between 5 and 15:");
            int n;
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n < 5 || n > 15)
                {
                    Console.WriteLine("Error: Number is not between 5 and 15.");
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: The entered value is not a valid integer.");
                return;
            }

            int[] array = PopulateArray(n);

            Console.Write("The elements of the arrays are: ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            int sum = SumArrayElements(array);
            Console.WriteLine("The sum is: " + sum);
        }

        static int[] PopulateArray(int length)
        {
            int[] array = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(10, 51);
            }
            return array;
        }

        static int SumArrayElements(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum;
        }
    }
}
