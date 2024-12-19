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
    }
}
