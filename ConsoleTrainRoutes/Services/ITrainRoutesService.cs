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
    }
}
