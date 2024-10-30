using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Constants
    {
        public static int ConstantFunction()
        {
            //This is immutable which means you cannot reassign a value to the variable
            const int youCantChangeMe = 10;

            //x = 11 this will give an error

            return youCantChangeMe;
        }
    }
}
