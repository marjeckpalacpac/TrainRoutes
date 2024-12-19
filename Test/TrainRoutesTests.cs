using ConsoleTrainRoutes.Services;

namespace Test
{
    public class TrainRoutesTests
    {
        private readonly ITrainRoutesService _trainRoutes;

        public TrainRoutesTests()
        {
            _trainRoutes = new TrainRoutesService();
        }

        [Fact]
        public void TestRouteDistance()
        {
            // Test #1
            Assert.Equal(9, _trainRoutes.CalculateRouteDistance(new List<string> { "A", "B", "C" }));

            // Test #2
            Assert.Equal(5, _trainRoutes.CalculateRouteDistance(new List<string> { "A", "D" }));

            // Test #3
            Assert.Equal(13, _trainRoutes.CalculateRouteDistance(new List<string> { "A", "D", "C" }));

            // Test #4
            Assert.Equal(22, _trainRoutes.CalculateRouteDistance(new List<string> { "A", "E", "B", "C", "D" }));

            // Test #5
            Assert.Equal(-1, _trainRoutes.CalculateRouteDistance(new List<string> { "A", "E", "D" }));
        }
    }
}