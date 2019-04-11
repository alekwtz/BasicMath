using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicMath
{
    public class BasicMaths
    {
      
       public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Substract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public double Multiply(double num1, double num2)
        {
            // To trace error while testing,  writing + operator instead of * operator.
            return num1 * num2;
        }

        static void Main(string[] args)
        {
            BasicMaths b = new BasicMaths();
            
            Console.WriteLine("Adding 2 to 5 = {0}", b.Add(2, 5));
            Console.WriteLine("Substract 3 from 8 = {0}", b.Substract(8,3));
            Console.WriteLine("Multiply 4 with 5 = {0}", b.Multiply(4,5));
            Console.WriteLine("Divide 12 with 3 = {0}", b.Divide(12, 3));
        }
    }
}
