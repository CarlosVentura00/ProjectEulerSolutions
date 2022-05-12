using System;

namespace ProjectEulerSolutions
{
    class Eulerproblems
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Coose one of the available problems by typing one of the numbers (1)");
            int Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Console.WriteLine("The sum of the multiples of 3 and 5 below 1000 is:" + Exercise1().ToString());
                    break;
            }
                
        }

        //Exercise description: If we list all the natural numbers below 10 that are multiples of 3 or 5,
        //we get 3, 5, 6 and 9. The sum of these multiples is 23.

        //Find the sum of all the multiples of 3 or 5 below 1000.
        public static int Exercise1()
        {
            int sum = 0;

            for (int iteration = 1; iteration <= 999; iteration++)
            {
                if(iteration % 3 == 0 || iteration % 5 == 0)
                {
                    sum += iteration;
                }
                
            }

            return sum;
        }


    }
}
