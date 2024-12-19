using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTrainRoutes.Data
{
    public class Route
    {
        public string From { get; set; }
        public string To { get; set; }
        public int Distance { get; set; }

        public static List<Route> Routes { get; } = new List<Route>()
        {
            new Route { From = "A", To = "B", Distance = 5 },
            new Route { From = "B", To = "C", Distance = 4 },
            new Route { From = "C", To = "D", Distance = 8 },
            new Route { From = "D", To = "C", Distance = 8 },
            new Route { From = "D", To = "E", Distance = 6 },
            new Route { From = "A", To = "D", Distance = 5 },
            new Route { From = "C", To = "E", Distance = 2 },
            new Route { From = "E", To = "B", Distance = 3 },
            new Route { From = "A", To = "E", Distance = 7 }
        };
    }
}
