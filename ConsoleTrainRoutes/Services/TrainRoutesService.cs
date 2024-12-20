using ConsoleTrainRoutes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTrainRoutes.Services
{
    public  class TrainRoutesService : ITrainRoutesService
    {
        public int CalculateRouteDistance(List<string> towns)
        {
            int distance = 0;

            for (int i = 0; i < towns.Count - 1; i++)
            {
                var route = Route.Routes.FirstOrDefault(r => r.From == towns[i] && r.To == towns[i + 1]);

                if (route == null) return -1; // Route does not exist

                distance += route.Distance;
            }

            return distance;
        }

        public int CountTripsWithMaxStops(string start, string end, int maxStops)
        {
            return CountTrips(start, end, 0, maxStops);
        }

        private int CountTrips(string current, string destination, int stops, int maxStops)
        {
            if (stops > maxStops) return 0;

            int count = 0;
            if (stops > 0 && current == destination) count++;

            foreach (var route in Route.Routes.Where(r => r.From == current))
            {
                count += CountTrips(route.To, destination, stops + 1, maxStops);
            }

            return count;
        }

        public int CountTripsWithExactStops(string start, string end, int exactStops)
        {
            return CountTripsExact(start, end, 0, exactStops);
        }

        private int CountTripsExact(string current, string destination, int stops, int exactStops)
        {
            if (stops > exactStops) return 0;

            int count = 0;
            if (stops == exactStops && current == destination) return 1;

            foreach (var route in Route.Routes.Where(r => r.From == current))
            {
                count += CountTripsExact(route.To, destination, stops + 1, exactStops);
            }

            return count;
        }

        public int FindShortestRoute(string start, string end)
        {
            return FindShortestRoute(start, end, new List<string>());
        }

        private int FindShortestRoute(string current, string destination, List<string> visited)
        {
            if (current == destination && visited.Any())
                return 0;

            visited.Add(current);
            int minDistance = int.MaxValue;

            foreach (var route in Route.Routes.Where(r => r.From == current))
            {
                if (!visited.Contains(route.To) || route.To == destination)
                {
                    int distance = FindShortestRoute(route.To, destination, new List<string>(visited));
                    if (distance != int.MaxValue)
                        minDistance = Math.Min(minDistance, distance + route.Distance);
                }
            }

            return minDistance;
        }

        public int CountTripsWithMaxDistance(string start, string end, int maxDistance)
        {
            return CountTripsByDistance(start, end, 0, maxDistance);
        }

        private int CountTripsByDistance(string current, string destination, int currentDistance, int maxDistance)
        {
            if (currentDistance >= maxDistance) return 0;

            int count = 0;
            if (currentDistance > 0 && current == destination) count++;

            foreach (var route in Route.Routes.Where(r => r.From == current))
            {
                count += CountTripsByDistance(route.To, destination, currentDistance + route.Distance, maxDistance);
            }

            return count;
        }
    }
}
