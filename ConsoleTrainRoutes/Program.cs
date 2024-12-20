using ConsoleTrainRoutes.Services;

try
{
    ITrainRoutesService service = new TrainRoutesService();

    Console.WriteLine($"Test #1: {service.CalculateRouteDistance(new List<string> { "A", "B", "C" })}");
    Console.WriteLine($"Test #2: {service.CalculateRouteDistance(new List<string> { "A", "D" })}");
    Console.WriteLine($"Test #3: {service.CalculateRouteDistance(new List<string> { "A", "D", "C" })}");
    Console.WriteLine($"Test #4: {service.CalculateRouteDistance(new List<string> { "A", "E", "B", "C", "D" })}");
    Console.WriteLine($"Test #5: {service.CalculateRouteDistance(new List<string> { "A", "E", "D" })}");
    Console.WriteLine($"Test #6: {service.CountTripsWithMaxStops("C", "C", 3)}");
    Console.WriteLine($"Test #7: {service.CountTripsWithExactStops("A", "C", 4)}");
    Console.WriteLine($"Test #8: {service.FindShortestRoute("A", "C")}");
    Console.WriteLine($"Test #9: {service.FindShortestRoute("B", "B")}");
}
catch (Exception ex)
{

    Console.WriteLine($"Error: {ex.Message}");
}