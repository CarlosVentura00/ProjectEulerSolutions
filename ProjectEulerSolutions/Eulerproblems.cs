﻿using System;

namespace ProjectEulerSolutions
{
    class Eulerproblems
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose one of the available problems by typing one of the numbers (1, 2)");
            int Choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (Choice)
            {
                case 1:
                    Console.WriteLine("The sum of the multiples of 3 and 5 below 1000 is: " + Exercise1().ToString());
                    break;
                case 2:
                    Console.WriteLine("\n The sum of even-valued terms to 4000000 is: " + Exercise2().ToString());
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

        /*Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, 
         * the first 10 terms will be: 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

        By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
        find the sum of the even-valued terms.*/
        public static int Exercise2()
        {
            int maxRange = 4000000;
            int sumPairs = 0;
            int secondSequenceNumber = 1;
            int firstSequenceNumber = 0;
            int sequence = 0;

            while (sequence <= maxRange)
            {

                sequence = firstSequenceNumber + secondSequenceNumber;
                firstSequenceNumber = secondSequenceNumber;
                secondSequenceNumber = sequence;

                Console.WriteLine(sequence);

                //sum of the pairs in the sequence
                if (sequence % 2 == 0)
                {
                    sumPairs += sequence;
                }
            }

            return sumPairs;
        }


    }
}
