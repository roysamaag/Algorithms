﻿using System;
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