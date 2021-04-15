using System;   

namespace Practical_Assignment_Data_Structure
{
   class StringArray
{     
      static void Main(string[] args)      
    {        
        string[] words = {
        "Computer", 
        "Plate", 
        "Chair", 
        "Girl",
        "Boy", 
        "Cat", 
        "Dog", 
        "Shirt", 
        "Determination" 
        };
        // b. Find out how many values are starting with ‘C’;
            int countStartingWithC = 0;
            foreach (string word in words)
            {
                if (word.StartsWith('C'))
                {
                    countStartingWithC++;
                }
            }
            Console.WriteLine($"{countStartingWithC} word(s) start with 'C'.");

            // c. Find out how many values are ending with “e”;
            int countEndingWithE = 0;
            foreach (string word in words)
            {
                if (word.EndsWith('e'))
                {
                    countEndingWithE++;
                }
            }
            Console.WriteLine($"{countEndingWithE} word(s) end with 'e'.");

            // d. Find out how many values are with length 5;
            int countLength5 = 0;
            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    countLength5++;
                }
            }
            Console.WriteLine($"{countLength5} word(s) have a length of 5.");

            // e. Find out how many values consist of the character “e”;
            int countContainsE = 0;
            foreach (string word in words)
            {
                if (word.Contains('e'))
                {
                    countContainsE++;
                }
            }
            Console.WriteLine($"{countContainsE} word(s) contain character 'e'.");

            // f. Find out is there any element which consists of the subString “te”;
            foreach (string word in words)
            {
                if (word.Contains("te"))
                {
                    Console.WriteLine($"'{word}' contains substring 'te'.");
                }
            }

            // g. * Calculate a histogram of values related to length of value.
            int longestLength = 0;
            foreach (string word in words)
            {
                if (word.Length > longestLength)
                {
                    longestLength = word.Length;
                }
            }
            int[] histogram = new int[longestLength + 1];
            foreach (string word in words)
            {
                histogram[word.Length]++;
            }
            for (int length = 1; length <= longestLength; length++)
            {
                int count = histogram[length];
                if (count > 0)
                {
                    Console.WriteLine($"{count} word(s) are of length {length}.");
                }
            }
        }
    }
}
  