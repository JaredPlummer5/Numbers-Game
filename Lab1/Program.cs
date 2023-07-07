using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            StartSequence();
            Console.ReadLine();
        }

        static void StartSequence()
        {
            int[] numberArray = new int[4];
            int[] populateResult = Populate(numberArray);
            for (int i = 0; i < populateResult.Length; i++)
            {
                Console.WriteLine("Array " + populateResult[i] + " ");
            }

            try
            {
                int sum = GetSum(populateResult);

                int product = GetProduct(populateResult, sum);
                GetQuotient(product);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static int[] Populate(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                int nums = Convert.ToInt32(Console.ReadLine());
                array[i] = nums;
            }

            return array;
        }

        static int GetSum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            if (sum < 20)
            {
                throw new Exception($"Value of {sum} is too low");
            }

            Console.WriteLine("The sum is " + sum);
            return sum;
        }

        static int GetProduct(int[] array, int sum)
        {
            Console.WriteLine($"Pick a random number between 1 and {array.Length}");

            int randomIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            if (randomIndex < 0 || randomIndex >= array.Length)
            {
                throw new IndexOutOfRangeException("Invalid index. Array index is out of range.");
            }

            int randomNumber = array[randomIndex];
            Console.WriteLine("Random number is: {0}", randomNumber);

            int product = randomNumber * sum;
            Console.WriteLine("This is the product: " + product);

            return product;
        }

        static decimal GetQuotient(int product)
        {
            Console.WriteLine("Enter a number to divide the product by: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            decimal quotient = (decimal)product / divisor;
            Console.WriteLine("This is your quotient: " + quotient);
            return quotient;
        }
    }
}
