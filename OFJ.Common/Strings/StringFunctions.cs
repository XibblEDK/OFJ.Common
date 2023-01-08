using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFJ.Common.Strings
{
    public static class StringFunctions
    {
        /// <summary>
        /// Function that checks if given sequence of brackets has the same number of opening and closing brackets.
        /// </summary>
        /// <param name="sequence">Sequence that gets checked</param>
        /// <returns>bool</returns>
        public static bool CheckBracketsSequence(string sequence)
        {
            int check = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                check = sequence[i] == '(' ? ++check : check;
            }

            return check == 0;
        }

        /// <summary>
        /// Function that adds a separator between every character in given word.
        /// </summary>
        /// <param name="word">Word that gets separated</param>
        /// <param name="separator">Char(s) that will get placed between every char in <paramref name="word"/></param>
        /// <returns>string</returns>
        public static string AddSeperator(string word, string separator)
        {
            string separatedWord = string.Empty;

            for (int i = 0; i < word.Length; i++)
            {
                separatedWord += i < word.Length - 1 ? word[i] + separator : word[i].ToString();
            }

            return separatedWord;
        }
        
        /// <summary>
        /// Function that checks if given word is palindrome
        /// </summary>
        /// <param name="str">Word to be checked</param>
        /// <returns>bool</returns>
        public static bool IsPalindrome(string str)
        {
            for (int i = 0; i <= str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Function that checks the number of char(s) that is not whitespaced in a string
        /// </summary>
        /// <param name="str">String</param>
        /// <returns>int</returns>
        public static int LengthOfAString(string str)
        {
            int length = 0;

            foreach (char c in str)
            {
                length++;
            }

            return length;
        }

        /// <summary>
        /// Function that reverses the order of the char(s) in the given string. Meaning rav reversed with this function is var.
        /// </summary>
        /// <param name="str">String to be reversed</param>
        /// <returns>string</returns>
        public static string StringInReverseOrder(string str)
        {
            string reverseString = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseString += str[i];
            }

            return reverseString;
        }

        /// <summary>
        /// Function that checks the sum of digits in a string. Meaning l0r3m 1p5um = 9.
        /// </summary>
        /// <param name="str">String to be checked</param>
        /// <returns>int</returns>
        public static int SumDigitsInString(string str)
        {
            var sum = 0;

            for (var i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    sum += (int)char.GetNumericValue(str[i]);
                }
            }

            return sum;
        }

        /// <summary>
        /// Function that converts lowercase char(s) into uppercase. This function is not only for one word but is also for a whole sentence.
        /// </summary>
        /// <param name="str">String to be converted to uppercase</param>
        /// <returns>string</returns>
        public static string MakeUppercase(string str)
        {
            int letterIndex = 0;
            string uppercaseWord = string.Empty;

            for (int i = 0; i <= str.Length; i++)
            {
                if (str[i] > 'a' && str[i] < 'z' && letterIndex % 2 == 0)
                {
                    letterIndex++;
                    uppercaseWord += (char)(str[i] - 32);
                }
                else if (str[i] != ' ')
                {
                    letterIndex++;
                    uppercaseWord += str[i];
                }
                else
                {
                    letterIndex = 0;
                    uppercaseWord += str[i];
                }
            }

            return uppercaseWord;
        }

        /// <summary>
        /// Function that mixes two string together. Meaning (word1)abc mixed with (word2)def is adbecf.
        /// </summary>
        /// <param name="word1">1st string/word</param>
        /// <param name="word2">2nd string/word</param>
        /// <returns>string</returns>
        public static string MixTwoStrings(string word1, string word2)
        {
            string mixedWord = string.Empty;

            for (int i = 0; i < (word1.Length > word2.Length ? word1.Length : word2.Length); i++)
            {
                if (i < word1.Length)
                {
                    mixedWord += word1[i];
                }
                if (i < word2.Length)
                {
                    mixedWord += word2[i];
                }
            }

            return mixedWord;
        }

        /// <summary>
        /// Function that gets the number of word inside a sentence
        /// </summary>
        /// <param name="input">Sentence</param>
        /// <returns>int</returns>
        public static int NumberOfWords(string input)
        {
            int numberOfWords = 0;
            for (int i = 1; i < input.Length; i++)
            {
                numberOfWords = (char.IsWhiteSpace(input[i]) ? numberOfWords + 1 : numberOfWords);
            }

            return numberOfWords + 1;
        }
    }
}
