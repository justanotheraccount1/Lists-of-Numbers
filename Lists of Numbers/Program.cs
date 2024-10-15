namespace Lists_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(); // Creates an empty List
            int better5 = 0;
            int rand;
            int counter = -1;
            bool done = false;
            Random generator = new Random();
            while (!done)
            {
                numbers.Add((generator.Next(41) * 2));
                counter += 1;


                if (numbers[counter] <= 50)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(numbers[counter]);
                }

                    if (counter > 20) 
                    done = true;
                
            }
            Console.WriteLine();
            Console.WriteLine();
            counter = -1;
            for (int i = 0; i < 20; i++)
            {
                counter += 1;
                if (numbers[counter] == 10)
                    Console.Write("TEN, ");
                else if (numbers[counter] == 20)
                    Console.Write("TWENTY, ");
                else if (numbers[counter] == 30)
                    Console.Write("THIRTY, ");
                else if (numbers[counter] == 40)
                    Console.Write("FOURTY, ");
                else
                    Console.Write(numbers[counter] + ", ");


            }



            Console.WriteLine();
            Console.WriteLine("The largest number is " + numbers.Max()); 
            Console.WriteLine("The smallest number is " + numbers.Min()); 
            Console.WriteLine("The sum is " + numbers.Sum());
            Console.WriteLine("The average is " + numbers.Average());

            Console.ReadLine(); // Keeps the program from ending  

        }
    }
}
