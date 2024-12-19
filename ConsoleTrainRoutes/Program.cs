using ConsoleTrainRoutes.Services;

try
{
    ITrainRoutesService service = new TrainRoutesService();

    Console.WriteLine($"Test #1: {service.CalculateRouteDistance(new List<string> { "A", "B", "C" })}");
    Console.WriteLine($"Test #2: {service.CalculateRouteDistance(new List<string> { "A", "D" })}");
    Console.WriteLine($"Test #3: {service.CalculateRouteDistance(new List<string> { "A", "D", "C" })}");
    Console.WriteLine($"Test #4: {service.CalculateRouteDistance(new List<string> { "A", "E", "B", "C", "D" })}");
}
catch (Exception ex)
{

    Console.WriteLine($"Error: {ex.Message}");
}