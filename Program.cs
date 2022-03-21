using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write out the results of addition, subtraction, multiplication, division, and modulus operations.
            //for division, create two integer variables called a and b.
            //Create a third integer variable and name it quotient (the result of a division) that stores the result of
            //the division of a and b, and
            //another integer variable named remainder that stores the remainder (using the % operator).
            //Write out the results using Console.WriteLine or Console.Write to write out the results in
            //the following form: if a = 17 and b = 4, print the following:
            //            The result should say: 17 / 4 is 4 remainder 1
            //----------------------------Exercise 1

            int x = 9;
            int y = 8;
            int addition = x + y;
            Console.WriteLine(addition);

            int subtraction = x - y;
            Console.WriteLine(subtraction);

            int multiplication = x* y;
            Console.WriteLine(multiplication);
            
            int a = 17;
            int b = 4;
            int quotient = a / b;
            Console.WriteLine(quotient);

            int remainder=a % b;
            Console.WriteLine(remainder);

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");






        }
    }
}
