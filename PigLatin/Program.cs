using System;
using System.Linq;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine("enter a word");
            string input = Console.ReadLine();

            if (input.Any(Char.IsWhiteSpace))
            {
                Console.Write(TranslateSentance(input));
            }
            
            Console.Write(TranslateWord(input));
            

        }
        
        public static string TranslateWord(string word)
        {
            
            int firstVowelIndex = word.IndexOfAny(new char[] {'a', 'e', 'i', 'o', 'u'});

            string firstPart = word.Substring(0,firstVowelIndex);
            string secondPart = word.Substring(firstVowelIndex);
            
            //if index == zero, then word begins with a vowel... so just add 'yay' to the end of the word
            if (firstVowelIndex == 0)
            {
                return word + "yay";
            }
            
            return secondPart.ToLower() + firstPart.ToLower() + "ay";
            
        }

        public static string TranslateSentance (string sentance)
        {
            string[] sentanceWords = sentance.Split(' ');
            string[] newSentance = new string[5];
            for (int i = 0; i < sentanceWords.Length; i++)
            {
                newSentance[i] = sentanceWords[i].ToUpper();
                TranslateWord(newSentance[5]);
            }
            string upperCaseString = String.Join(" ", newSentance);
            Console.WriteLine(upperCaseString);

            return sentance.ToUpper();
        }
    }
}
