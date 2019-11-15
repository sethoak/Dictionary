using System;
using System.Collections.Generic;

namespace Csharp_Common_Type_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("PC Fan Boy", "Someone who loves PC and hates consoles");
            wordsAndDefinitions.Add("Starvin' Marvin", "A character from South Park");
            wordsAndDefinitions.Add("Tuba", "A musical instrument");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            string value1 = wordsAndDefinitions["Awesome"];
            Console.WriteLine(value1);
            string value2 = wordsAndDefinitions["PC Fan Boy"];
            Console.WriteLine(value2);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
            }
        }
    }
}
