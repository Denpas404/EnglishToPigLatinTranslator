using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EnglishToPigLatinTranslatorClassLibrary
{
    public class Translator
    {
        public string TranslateToPigLatinSingleWords(string input)
        {
            char[] vowels = new[] { 'A', 'E', 'I', 'O', 'U', 'Å', 'Æ', 'Ø', 'ø', 'æ', 'å', 'a', 'e', 'i', 'o', 'u' };
            char[] vowelsExtended = vowels.Concat(new[] { 'Y', 'y' }).ToArray();
            string output = Regex.Replace(input, @"\w+", m =>
            {
                string word = m.Value;
                if (vowels.Contains(word[0])) return word + "yay";

                int indexOfVowel = word.IndexOfAny(vowelsExtended, 1);
                
                if (indexOfVowel == -1) return word + "ay";
                
                else return word.Substring(indexOfVowel) + word.Substring(0, indexOfVowel) + "ay";
            });
            return output;
        }

        public string TranslateSentence(string word)
        {
            List<string> words = word.Split(' ').ToList();
            string newWord = "";

            foreach (var item in words)
            {
                newWord += TranslateToPigLatinSingleWords(item) + " ";
            }


            return newWord.TrimEnd();
        }

    }

}
