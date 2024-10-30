using System;

namespace Exercises
{
    public class MultipleVariables
    {
        public static int MultiVariableInt()
        {
            int firstNum = 1;
            int secondNum = 10;
            int thirdNum = 20;

            //Follows standard order of operation: expected 11
            int totalSum = firstNum + secondNum + thirdNum;

            return totalSum;
        }
    }
}
