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
            //------------------------------------------------------------------------------Exercise 1

            int x = 9;
            int y = 8;
            int addition = x + y;
            Console.WriteLine($"{x} plus {y} is {addition}");

            int subtraction = x - y;
            Console.WriteLine($"{x} minus {y} is {subtraction}");

            int multiplication = x * y;
            Console.WriteLine($"{x} times {y} is {multiplication}");
            
            int a = 17;
            int b = 4;
            int quotient = a / b;
            //Console.WriteLine($"{a} divided by {b} is {quotient}");

            int remainder = a % b;
            //Console.WriteLine(remainder);

            Console.WriteLine($"{a} / {b} is {quotient} with a remainder of {remainder}");




            //------------------------------------------------------------------------------Exercise 2
            // Create a method that will Calculate the area of a circle based on its radius. Name the method AreaOfCircle.
            // use this formula Math.PI * Math.Pow(r, 2) and return the area of type double
            // the method will also accept r as a parameter
            // Allow a user to input a value for r in the console using the following code:
            //            var radius = double.Parse(Console.ReadLine());


            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaofCircle(radius)}");
        }
        public static double AreaofCircle(double radius)
        {
            return (Math.PI * Math.Pow(radius, 2));
        }
    }
}
