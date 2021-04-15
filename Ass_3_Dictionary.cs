using System;
using System.Linq;
using System.Collections.Generic;

namespace SPractical_Assignment_Data_Structure
{
    class Program3
    {
     /* Create a Dictionary for the product price page where all products will be as the key 
      and the price as the value. 
      ● Save at least 8 products in the HashMap*/
        static void Main(string[] args) 
        {
          Dictionary<string, decimal> AllPrices = new Dictionary<string, decimal>();
          AllPrices.Add("Unsleeve dress", 10.0m);
          AllPrices.Add("Long dress", 15.0m);
          AllPrices.Add("Midi dress", 33.0m);
          AllPrices.Add("Short dress", 0.5m);
          AllPrices["Print dress"] = 7.0m;
          AllPrices["Plane dress"] =  26.0m;
          AllPrices["Just dress"] = 100.0m;
          AllPrices["Viscose dress"] = 17.3m;
          foreach (KeyValuePair<string, decimal> row in AllPrices)
           {
             Console.WriteLine($"{row.Key} : {row.Value}");
           }
          //Find out how many products are under 1 eur.
          int CountUnderOne = 0;
          foreach (KeyValuePair<string, decimal> row in AllPrices)
           {
             decimal price = row.Value; 
             if (price < 1)
              {
                 CountUnderOne++;
              }
           }
           Console.WriteLine($"{CountUnderOne} product(s) cost under 1 Euro");
         /*● Find out which product price is the lowest. 
           ● Find out which product price is the largest.*/
            decimal lowestPrice = Decimal.MaxValue;
            decimal highestPrice = Decimal.MinValue;
            foreach (decimal price in AllPrices.Values)
            {
                if (price < lowestPrice)
                {
                    lowestPrice = price;
                }
                if (price > highestPrice)
                {
                    highestPrice = price;
                }
            }
            foreach (KeyValuePair<string, decimal> row in AllPrices)
            {
                string productName = row.Key;
                decimal price = row.Value;

                if (price == lowestPrice)
                {
                    Console.WriteLine($"{productName} has the lowest price ({price.ToString("0.00")})");
                }
                else if (price == highestPrice)
                {
                    Console.WriteLine($"{productName} has the highest price ({price.ToString("0.00")})");
                }
            }
            /* Create a new Dictionarywith other products. 
            Merge both Dictionaries and print out how many products are in the merged HashMap*/
            Dictionary<string, decimal> morePrices = new Dictionary<string, decimal>();
            morePrices.Add("Skirt midi", 12.0m);
            morePrices.Add("Skirt mini", 5.0m);

            foreach (KeyValuePair<string, decimal> row in morePrices)
            {
                AllPrices.Add(row.Key, row.Value);
            }
            Console.WriteLine($"We have {AllPrices.Count} product(s) with prices!");

            //● *Sort all values in ascending order.

            foreach (KeyValuePair<string, decimal> row in AllPrices.OrderBy(row => row.Value))
            {
                Console.WriteLine($"{row.Key} : {row.Value.ToString("0.00")}");
            }
        }

    }
}
