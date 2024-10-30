using System;

namespace Exercises
{
    public class Output
    {
        public static string Main()
        {
            //Multiline string to concat
            string firstPartSentence = "Hello ";
            string secondPartSentence = "World";
            string thirdPartSentence = "!";

            Console.WriteLine(firstPartSentence + secondPartSentence + thirdPartSentence);

            string fullSentence = firstPartSentence + secondPartSentence + thirdPartSentence;

            return fullSentence;
        }
    }
}
