using System;
using System.Collections.Generic;

namespace dictionaries
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
            wordsAndDefinitions.Add("Cool", "The Rescue Rangers");
            wordsAndDefinitions.Add("Rad", "The Ninja Turtles");
            wordsAndDefinitions.Add("Sweet", "Getting Disney+ for free");
            wordsAndDefinitions.Add("Tubular", "Riding the crest of a sweet wave");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            string value1 = wordsAndDefinitions["Awesome"];
            Console.WriteLine(value1);
            string value2 = wordsAndDefinitions["Cool"];
            Console.WriteLine(value2);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }

            //exercise 2

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence
                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary

            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> newDictionary = new Dictionary<string, string>()
            { { "word", "dog" }, { "definition", "man's best friend" }, { "part of speech", "noun" }, { "example sentence", "The dog says woof" }
            };

            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.
                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> word in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> definition in word)
                {
                    Console.WriteLine($"{definition.Key}: {definition.Value}");
                }
            }
        }
    }
}
// using System;
// using System.Collections.Generic;

// namespace Csharp_Common_Type_Dictionary
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             /*
//     Create a dictionary with key value pairs to
//     represent words (key) and its definition (value)
// */
//             Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

//             // Add several more words and their definitions
//             wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
//             wordsAndDefinitions.Add("PC Fan Boy", "Someone who loves PC and hates consoles");
//             wordsAndDefinitions.Add("Starvin' Marvin", "A character from South Park");
//             wordsAndDefinitions.Add("Tuba", "A musical instrument");

//             /*
//                 Use square brackets to get the definition of two of the
//                 words and then output them to the console
//             */
//             string value1 = wordsAndDefinitions["Awesome"];
//             Console.WriteLine(value1);
//             string value2 = wordsAndDefinitions["PC Fan Boy"];
//             Console.WriteLine(value2);

//             /*
//                 Below, loop over the wordsAndDefinitions dictionary to get the following output:
//                     The definition of (WORD) is (DEFINITION)
//                     The definition of (WORD) is (DEFINITION)
//                     The definition of (WORD) is (DEFINITION)
//             */
//             foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
//             {
//                 Console.WriteLine($"The word {word.Key} means {word.Value}");

//             }

//             //NEW STUFF

//             // Make a new list
//             List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();
//             /*
//                 You want to track the following about each word:
//                     word, definition, part of speech, example sentence

//                 Example of one dictionary in the list:
//                 {
//                     "word": "excited",
//                     "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
//                     "part of speech": "adjective",
//                     "example sentence": "I am excited to learn C#!"
//                 }
//             */

//             // Create dictionary to represent a few words
//             Dictionary<string, string> excitedWord = new Dictionary<string, string>();
//             {
//                 {
//                     "word": "excited",
//                     "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
//                     "part of speech": "adjective",
//                     "example sentence": "I am excited to learn C#!"
//                    },
//                 {
//                     "word": "sad",
//                     "definition": "just feelin down, man",
//                     "part of speech": "adjective",
//                     "example sentence": "I am sad to not learn"
//                 },
//                 {
//                     "word": "car",
//                     "definition": "a 4 wheel vehicle with a motor",
//                     "part of speech": "noun",
//                     "example sentence": "I am going to drive my car to work"
//                 }
//             }

//             // Add each of the 4 bits of data about the word to the Dictionary
//             excitedWord.Add("word", "excited");
//             excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
//             excitedWord.Add("part of speech", "adjective");
//             excitedWord.Add("example sentence", "I am excited to learn C#");





//             // Add Dictionary to your `dictionaryOfWords` list
//             dictionaryOfWords.Add(excitedWord);


//             // create another Dictionary and add that to the list
//             Dictionary<string, string> newDictionary = new Dictionary<string, string>()
//             {
//                 {"word", "Hummer"},
//                 {"definition", "A huge vehicle that burns gas"},
//                 {"part of speech", "Pronoun"},
//                 {"example sentence", "I drive a terrible vehicle"}
//             };

//             /*
//                 Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

//                 Example output for one word in the list of dictionaries:
//                     word: excited
//                     definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
//                     part of speech: adjective
//                     example sentence: I am excited to learn C#!
//             */

//             // Iterate the List of Dictionaries
//             foreach (Dictionary<string, string> word in dictionaryOfWords)
//             {
//                 // Iterate the KeyValuePairs of the Dictionary
//                 foreach (KeyValuePair<string, string> definition in word)
//                 {
//                     Console.WriteLine($"{definition.Key}: {definition.Value}");
//                 }
//             }
//         }
//     }
// }
