using System;
using System.Collections.Generic;

namespace ManusChallenege
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            List<string> connections = new List<string>();

            Random random = new Random();

            Console.WriteLine("How many cities would you want to build?");
            int count = Convert.ToInt32(Console.ReadLine());
            cities.Add("city " + 0 + " :");

            for (int i = 0; i <= count; i++)
            {
                int prev = cities.Count - 2;
                int randomCity = random.Next(0, cities.Count);

                cities.Add("city " + (i + 1) + " :");

                if (randomCity == -1 && prev == 0)
                {
                    connections.Add("[" + prev.ToString() + "]");
                }
                else if (prev == -1)
                {
                    connections.Add("[" + (cities.Count - 1) + "]");
                }
                if (randomCity == prev || randomCity == -1 || randomCity == i)
                {
                    randomCity = random.Next(1, cities.Count - 1);
                }
                if (prev > -1)
                {
                    connections.Add("[" + prev.ToString() + ", " + randomCity.ToString() + "]");
                }

                if (connections.Count > i && connections.Count > randomCity && randomCity != prev && randomCity != i)
                {
                    connections[randomCity] = connections[randomCity].Insert((connections[randomCity].Length - 1), ", " + i.ToString());
                }
            }

            for (int i = 0; i < cities.Count; i++)
            {
                if (connections.Count > i)
                {
                    Console.WriteLine(cities[i] + connections[i]);
                }
            }
            Console.ReadLine();
        }
        /// This is the code i wrote following a tutorial for another project, using this script i was able to find a path using A* algorithm ///
        ///and it worked on a 3d visulizing scene using Unity .. im not that experienced with path finding and i need a lot more practice but i think i can do it if i had a bit more time///
        /// i commented it out s ou could check the first half of the challenge that i worte .///
        


        //private void FindPath(string[] graph, string start, string end)
        //{
        //    List<string> openCities = new List<string>();
        //    List<string> closedCities = new List<string>();

        //    openCities.Add(start);

        //    //checking if the current city is the closest to the target city, if not find the closest and make it the current city
        //    while (openCities.Count > 0)
        //    {
        //        string currentCity = openCities[0];

        //        for (int i = 1; i < openCities.Count; i++)
        //        {
        //            if (openCities[i].fCost < currentCity.fCost || openCities[i].fCost == currentCity.fCost && openCities[i].hCost < currentCity.hCost)
        //            {
        //                currentCity = openCities[i];
        //            }
        //        }

        //        openCities.Remove(currentCity);
        //        closedCities.Add(currentCity);

        //        if (currentCity == targetCity)
        //        {
        //            ShortestPath(startCity, targetCity);
        //            return;
        //        }

        //        //to check if the neigbour city spaces are available for building or not
        //        foreach (City neigbour in grid.GetNeighbourCities(currentCity))
        //        {
        //            if (!neigbour.walkable || closedCities.Contains(neigbour))
        //            {
        //                continue;
        //            }

        //            int newMovmentCostToNeigbour = currentCity.gCost + GetDistance(currentCity, neigbour);
        //            if (newMovmentCostToNeigbour < neigbour.gCost || !openCities.Contains(neigbour))
        //            {
        //                neigbour.gCost = newMovmentCostToNeigbour;
        //                neigbour.hCost = GetDistance(neigbour, targetCity);
        //                neigbour.parent = currentCity;

        //                if (!openCities.Contains(neigbour))
        //                {
        //                    openCities.Add(neigbour);
        //                }
        //                //else
        //                //{
        //                //    openCities.UpdateItem(neigbour);
        //                //}
        //            }
        //        }
        //        private void ShortestPath(City startCity, City targetCity)
        //        {
        //            List<City> path = new List<City>();
        //            City currentCity = targetCity;

        //            while (currentCity != startCity)
        //            {
        //                path.Add(currentCity);
        //                currentCity = currentCity.parent;
        //            }
        //            //to reverse the path finding use
        //            path.Reverse();

        //            grid.path = path;
        //        }
        //    }
        //}
    }
}
