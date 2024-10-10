namespace Lists_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(); // Creates an empty List
            int better5 = 0;
            int rand;
            Random generator = new Random();
            rand = generator.Next();
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(rand);
                if (numbers[i] >= 5)
                {
                    better5 += 1;
                }
                
            }
            Console.WriteLine();
            Console.Write(numbers[0] + " ");
            Console.Write(numbers[1] + " ");
            Console.Write(numbers[2] + " ");
            Console.Write(numbers[3] + " ");
            Console.Write(numbers[4] + " ");
            Console.Write(numbers[5] + " ");
            Console.Write(numbers[6] + " ");
            Console.Write(numbers[7] + " ");
            Console.Write(numbers[8] + " ");
            Console.Write(numbers[9] + " ");
            Console.Write(numbers[10] + " ");
            Console.Write(numbers[11] + " ");
            Console.Write(numbers[12] + " ");
            Console.Write(numbers[13] + " ");
            Console.Write(numbers[14] + " ");
            Console.Write(numbers[15] + " ");
            Console.Write(numbers[16] + " ");
            Console.Write(numbers[17] + " ");
            Console.Write(numbers[18] + " ");
            Console.Write(numbers[19] + " ");



            Console.WriteLine();
            Console.WriteLine("The largest number is " + numbers.Max()); 
            Console.WriteLine("The smallest number is " + numbers.Min()); 
            Console.WriteLine("The sum is " + numbers.Sum());
            Console.WriteLine("The average is " + numbers.Average());
            Console.WriteLine("There were " + better5 + " numbers greater than 5");

            Console.ReadLine(); // Keeps the program from ending  

        }
    }
}
