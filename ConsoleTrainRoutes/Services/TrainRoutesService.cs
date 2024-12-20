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
    }
}
