using System;
using System.Linq;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine("enter a sentance");
            string input = Console.ReadLine();

            Console.WriteLine(TranslatePunctuation(input));
            

        }
        
        public static string TranslateWord(string word)
        {
            
            int firstVowelIndex = word.IndexOfAny(new char[] {'a', 'e', 'i', 'o', 'u', 'y'});
            string firstPart = word.Substring(0,firstVowelIndex);
            string secondPart = word.Substring(firstVowelIndex);
            
            //if index == zero, then word begins with a vowel... so just add 'yay' to the end of the word
            if (firstVowelIndex <= 0)
            {
                return word + "yay";
            }
            
            return secondPart.ToLower() + firstPart.ToLower() + "ay";
            
        }

        public static string TranslateSentance (string sentance)
        {
            string[] words = sentance.Split(' ');
            string[] translatedWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                translatedWords[i] = TranslateWord(words[i]);
            }
            return String.Join(' ', translatedWords);
        }

        private static string TranslatePunctuation (string punctuation)
        {
            //int punctuationIndex = punctuation.IndexOfAny(new char[] { '.', ',', '!', '?' });
            string[] allPunctuation = punctuation.Split('.', ',', '!', '?');
            string[] translatedPunctuation = new string[allPunctuation.Length];

            for (int i = 0; i < allPunctuation.Length; i++)
            {
                translatedPunctuation[i] = TranslateWord(allPunctuation[i]);
            }
            return String.Join('.', ',', '!', '?', translatedPunctuation);

        }
    }
}
