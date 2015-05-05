using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = "My name is Shawn";
            Console.WriteLine("Before:");
            Console.WriteLine(inputString);
            Console.WriteLine("After:");
            Console.WriteLine(StringReverse(inputString));
            Console.ReadKey();
        }

        public static string StringReverse(string input)
        {
            if (input == null)
                throw new ArgumentNullException("input");
            if (input.Length < 0)
                throw new ArgumentOutOfRangeException("length", "{0} cannot be negative");

            int i = 0;
            int j = input.Length - 1;
            var objArray = input.ToArray();
            while (i < j)
            {
                var temp = objArray[i];
                objArray[i] = objArray[j];
                objArray[j] = temp;
                i++;
                j--;
            }
            return new string(objArray);
        }
    }
}
