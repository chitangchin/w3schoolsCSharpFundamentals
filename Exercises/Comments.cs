using System;

namespace Exercises
{
    public class Comments
    {
        public static string Main()
        {
            Console.WriteLine("Testing Comments here!");
            //Console.WriteLine("This should not be seen in terminal");
            Console.WriteLine("Now you see me.");
            //Console.WriteLine("Now you don't!");

            string visible = "This string was written at 7:49pm on 10/29/2024";
            //visible = "This string was update at 7:50pm on 10/29/2024, but this is a secret!";

            /*
             * I can make a whole 
             * Paragraph
             * With multi line comments
             * yup        
             */

            return visible;
        }
    }
}
