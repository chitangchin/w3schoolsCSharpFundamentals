using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Identifiers
    {
        public static int IdentifyPractice()
        {
            //Bad Practice to make hard to understand variable names:
            int x = 1;
            int y = 2;
            int z = 3;
            int a = (x + y + z) / 3;
            Console.WriteLine(a);

            //Best practice to clearly define your variables for readability
            int firstNum = 1;
            int secondNum = 2;
            int thirdNum = 3;

            int totalAverage = (firstNum + secondNum + thirdNum) / 3;

            return totalAverage;
        }
    }
}
