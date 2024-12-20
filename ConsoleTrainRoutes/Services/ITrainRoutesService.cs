using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTrainRoutes.Services
{
    public interface ITrainRoutesService
    {
        int CalculateRouteDistance(List<string> towns);
        int CountTripsWithMaxStops(string start, string end, int maxStops);
        int CountTripsWithExactStops(string start, string end, int exactStops);
    }
}
