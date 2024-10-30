using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class DisplayVariables
    {
        public static string ConsoleWriteLine()
        {
            Console.WriteLine("Add the string you want to print here");
            return "This is how you display text on the console window";
        }
        public static string VariableConsoleWriteLine()
        {
            string test = "You can use this in a Console.WriteLine";
            Console.WriteLine(test);
            return test;
        }
        public static string ConcatConsoleWriteLine()
        {
            string test = "You can also ";
            string test2 = "add together variables of the same type!";
            Console.WriteLine(test + test2);
            return test + test2;
        }
    }
}
