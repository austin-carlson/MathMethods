using System;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            var sum = Add(10, 20);

            Console.WriteLine(sum);

            var difference = Subtract(10, 20);

            Console.WriteLine(difference);

            var product = Multiply(10, 20);

            Console.WriteLine(product);

            var quotient = Divide(10, 20);

            Console.WriteLine(quotient);

            
            
       
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;   
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        { 
            return num1 % num2; 
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }


}
