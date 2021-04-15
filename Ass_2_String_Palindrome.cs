using System;
using System.Text.RegularExpressions;

namespace Practical_Assignment_Data_Structure
{
    class Palindrome
    {
        static void Main(string[] args)
        {
        /*Write a program where the verification of the palindrome is provided. 
        Palindrome is the sentence which reads the same backward as forward         
        Create the algorithm which will process the sentence and return the result 
        - is this sentence a palindrome or not. 
        Testing palindrome sentences*/
            Regex nonLetters = new Regex("[^A-Za-z]");

            string[] inputs = {
                "Mom",
                "Was it a car or a cat I saw?",
                "Madam, in Eden, I’m Adam.",
                "Yo, banana boy!",
                "Failure condition."
            };

            foreach (string input in inputs)
            {
                bool isPalindrome = true;
                string lowerInput = nonLetters.Replace(input, "").ToLower();
                // делаем все буквы прописными .ToLower()
                //а также избавляемся при помощи .Replace(input, "") от вех пробелов и знаков препинания
                //получаем lowerInput ="wasitacaroracatIsaw"
                for (int i = 0; i < lowerInput.Length / 2; i++)
                //делим на 2,чтобы слово поделить пополам по центру
                {
                    int leftIndex = 0 + i;
                    char left = lowerInput[leftIndex];

                    int rightIndex = (lowerInput.Length - 1) - i;
                    char right = lowerInput[rightIndex];

                    if (left != right)
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                Console.WriteLine($"{input} : {isPalindrome}");
            }
        }
    }
}
