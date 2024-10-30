using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class NonNumericalVariables
    {
        public static char CharFunction()
        {
            //Char should use single quotes
            char randomChar = 'a';
            return randomChar;
        }
        public static string StringFunction()
        {
            //String should use double quotes
            string helloWorld = "Hello World!";
            return helloWorld;
        }
        public static bool BoolFunction()
        {
            //Boolean has two choices: true and false
            bool randomBool = true;
            randomBool = false;
            return randomBool;
        }
    }
}
