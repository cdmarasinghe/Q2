using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q2
{
    class Program
    {
        public void gess()
        {
            int i = 0;

            do
            {
                Console.WriteLine("Enter a guessing number betwween 1 to 100");
                String n = Console.ReadLine();
                i = Convert.ToInt32(n);

                if (i > 0 && i <= 100)
                {
                    if (i == 42)
                        Console.WriteLine("Correct");
                    else
                        Console.WriteLine("Incorrect");
                }
                else
                    Console.WriteLine("Your number shold be in 1 to 100");
            }
            while (i != 42);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.gess();
        }
    }
}
