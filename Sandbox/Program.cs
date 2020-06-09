using System;
using System.Collections.Generic;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 101; i++)
            {

                var result = (i % 3 == 0 && i % 5 == 0) ? "fizzbuzz" : (i % 3 == 0) ? "fizz" : (i % 5 == 0) ? "buzz" : i.ToString();
                Console.WriteLine(result);

            }


            


            Console.ReadLine();


        }

    }
}
