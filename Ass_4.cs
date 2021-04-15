using System;
using System.Linq;
using System.Collections.Generic;

namespace Practical_Assignment_Data_Structure
{
    class Program4
    {
        static void Main(string[] args)
        {
            //Create a new Graph 
            //Print out all elements of the new Graph.
            Dictionary<string, HashSet<string>> graph = new Dictionary<string, HashSet<string>>();

            AddConnection(graph, "Livingstone", "Jo'burg");
            AddConnection(graph, "Harare", "Jo'burg");
            AddConnection(graph, "Victoria Falls", "Jo'burg");
            AddConnection(graph, "Windhoek", "Jo'burg");
            AddConnection(graph, "Cape Town", "Jo'burg");
            AddConnection(graph, "PE", "Jo'burg");
            AddConnection(graph, "Durbs", "Jo'burg");
            AddConnection(graph, "Mauritius", "Jo'burg");
            AddConnection(graph, "Cape Town", "PE");
            AddConnection(graph, "Cape Town", "Durbs");
            AddConnection(graph, "Durbs", "PE");

            foreach (KeyValuePair<string, HashSet<string>> pair in graph)
            {
                string airportName = pair.Key;
                HashSet<string> connections = pair.Value;
                Console.Write($"{airportName} -> ");
                foreach (string destination in connections)
                {
                    Console.Write($"{destination}, ");
                }
                Console.WriteLine();
            }    

            // for each destination in allDestinations sum of all counts
            int countOfDirectFlights = graph.Values.Sum(destinations => destinations.Count);
            Console.WriteLine($"{countOfDirectFlights / 2} direct flight(s)");

            // Print out all airports which are connected to “Cape Town” airport with direct flight.
            HashSet<string> destinationsFromCapeTown = graph["Cape Town"];
            foreach (string airport in destinationsFromCapeTown)
            {
                Console.WriteLine($"{airport} is connected to Cape Town.");
            }

            // calculate how many direct flights are from Jo'burg airport
            HashSet<string> destinationsFromJoBurg = graph["Jo'burg"];
            Console.WriteLine($"{destinationsFromJoBurg.Count} destination(s) from Jo'burg");
               
        }
         // possibility to add flights in reverse directions
        static void AddConnection(Dictionary<string, HashSet<string>> flights,
            string airportA, string airportB)
        {
            if (!flights.ContainsKey(airportA))
            {
                flights[airportA] = new HashSet<string>();
            }
            flights[airportA].Add(airportB);

            if (!flights.ContainsKey(airportB))
            {
                flights[airportB] = new HashSet<string>();
            }
            flights[airportB].Add(airportA);

        }
    }
}