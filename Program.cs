using System;

namespace Ch5_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int f = 1; f <= 100; f++)

            {

                if (f % 3 == 0 && f % 5 == 0)

                {

                    Console.WriteLine($"{f} FizzBuzz");

                }

                else if (f % 3 == 0)

                {

                    Console.WriteLine($"{f} Fizz");

                }

                else if (f % 5 == 0)

                {

                    Console.WriteLine($"{f} Buzz");

                }

                else

                {

                    Console.WriteLine(f);

                }

            }  

        }
    }
}
