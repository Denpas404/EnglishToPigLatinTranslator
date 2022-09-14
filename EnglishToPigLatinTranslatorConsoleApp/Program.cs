using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnglishToPigLatinTranslatorClassLibrary;

namespace EnglishToPigLatinTranslatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Translator translator = new Translator();
            List<string> listOfWords = new List<string>() { "have", "cram", "take", "shrimp", "trebuchet", "ate", "apple", "oaken", "eagle"};
            List<string> listOfSentences = new List<string>() { "I like to eat honey waffles.", "Do you think it is going to rain today?" };

            foreach (var item in listOfWords)
            {
                Console.WriteLine(translator.TranslateToPigLatinSingleWords(item));
            }

            Console.WriteLine("\n");

            foreach (var item in listOfSentences)
            {
                Console.WriteLine(translator.TranslateSentence(item));
            }

           

            Console.ReadKey();
        }
    }
}
