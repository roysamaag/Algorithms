using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Strings
    {
        public bool NeedleInHayStack(string hayStack, string needle)
        {
            needle = needle.ToLower();
            hayStack = hayStack.ToLower();

            for (int i = 0; i <= hayStack.Length - needle.Length; i++)
            {
                Console.WriteLine(hayStack.Substring(i, needle.Length));

                if (hayStack.Substring(i, needle.Length).Equals(needle))
                {
                    return true;
                }
                
            }
            return false;
        }

        public string ReverseStringByWords(string sentence)
        {
            string reversedString = string.Empty;
            if (!string.IsNullOrWhiteSpace(sentence))
            {
                string[] words = sentence.Split(' ');

                for (int i = words.Length - 1; i >= 0; i--)
                {
                    reversedString = reversedString + " " + words[i];
                }
            }
            return reversedString;
        }

        public bool IsPalindrome(string sentence)
        {
            sentence = sentence.Replace(" ", "").Replace(",","").ToLower();
            for (int i = 0; i <= sentence.Length - 1; i++)
            {
                if (sentence[i] <= sentence[sentence.Length-1 - i])
                {
                    if (sentence[i] != sentence[sentence.Length-1 - i])
                        return false;
                }
            }
            return true;
        }

        public bool IsPalindromeByChar(string sentence)
        {
            sentence = sentence.ToLower();
            int index = 0;
            int lastIndex = sentence.Length - 1;

            while (index < lastIndex)
            {
                char forwardChar = sentence[index];
                char reverseChar = sentence[lastIndex];
                while (forwardChar == ' ' || forwardChar == ',')
                {
                    index++;
                    forwardChar = sentence[index];
                }
                while (reverseChar == ' ' || reverseChar == ',')
                {
                    lastIndex--;
                    reverseChar = sentence[lastIndex];
                }

                if (forwardChar != reverseChar)
                    return false;

                index++;
                lastIndex--;
            }

            return true;
        }

        public string ReverseStringQuick(String str)
        {
            if (str.Length <= 1)
            {
                return str;
            }

            return ReverseStringQuick(str.Substring(1))  + str.Substring(0,1);
        }


        public string ReverseStringByChars(string sentence)
        {
            string reversedString = string.Empty;

            if (!string.IsNullOrWhiteSpace(sentence))
            {
                for (int i = sentence.Length - 1; i >= 0; i--)
                {
                    reversedString = reversedString + sentence[i];
                }
            }
            return reversedString;
        }

        public int Occurs(string Sentence, string text)
        {
            int count = 0;
            text = text.ToLower();
            Sentence = Sentence.ToLower();

            for (int i = 0; i <= Sentence.Length - text.Length; i++)
            {
                Console.WriteLine(Sentence.Substring(i, text.Length));

                if (Sentence.Substring(i, text.Length).Equals(text))
                {
                    count++;
                }
                
            }
            return count;
        }

    }
}
