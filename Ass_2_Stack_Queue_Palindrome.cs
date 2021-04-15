using System;
using System.Collections;
using System.Collections.Generic;

namespace SPractical_Assignment_Data_Structure
{
    /*Write a program where the verification of the palindrome is provided.  
    Testing palindrome sentences
    Rewrite the algorithm of the assignment using Stack and ArrayBlockingQueue classes*/
    class Program24
    {
        static void Main(string[] args)
        {
            string sentence = "Was it a car or a cat I saw?";
            CheckLinkedList(sentence);
        }
        static void CheckLinkedList(string sentence)
        {
            LinkedList<char> linkedList = new LinkedList<char>();

            foreach (char character in sentence)
            {
                // Make sure we are working with lower-case characters,
                // by transforming A-Z into a-z.
                char c = character;
                if (c >= 'A' && c <= 'Z')
                {
                    c = (char)(c - 'A' + 'a');
                }

                // Skip over characters that are not a-z.
                // This would be spaces, punctuation, etc.
                if (c < 'a' || c > 'z')
                {
                    continue;
                }

                linkedList.AddLast(c);
            }

            bool isPalindrome = true;
            while (linkedList.Count > 1)
            {
                if (linkedList.First.Value != linkedList.Last.Value)
                {
                    isPalindrome = false;
                    break;
                }

                linkedList.RemoveFirst();
                linkedList.RemoveLast();
            }

            Console.Write("LinkedList : ");
            Console.WriteLine(isPalindrome ? "Yes" : "No");
        }
    }
}