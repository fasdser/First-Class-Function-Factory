using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Class_Function_Factory
{
    internal class Program
    {
       /* Write a function, factory, that takes a number as its parameter and returns another function.

The returned function should take an array of numbers as its parameter, and return an array of those numbers multiplied by the number that was passed into the first function.

In the example below, 5 is the number passed into the first function.So it returns a function that takes an array and multiplies all elements in it by five.

Translations and comments (and upvotes) welcome!

Example
Func<int[], int[]> fives = FunctionFactory.factory(5);    // returns a function - fives
        int[] myArray = new int[] { 1, 2, 3 };
        fives(myArray);                  //returns [5, 10, 15];*/
        static void Main(string[] args)
        {
        }

        public static Func<int[], int[]> factory(int x)
        {
            Func<int[], int[]> func = (a) => {
                int[] res = new int[a.Length];
                for (int i = 0; i < a.Length; i++) res[i] = a[i] * x;
                return res;
            };
            return func;
        }

        public static Func<int[], int[]> factory1(int x)
        {
            return (a) => { return a.Select(n => n * x).ToArray(); };
        }
    }
}
