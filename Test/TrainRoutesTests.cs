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

        [Fact]
        public void TestTripCounting()
        {
            // Test #6
            Assert.Equal(2, _trainRoutes.CountTripsWithMaxStops("C", "C", 3));

            // Test #7
            Assert.Equal(3, _trainRoutes.CountTripsWithExactStops("A", "C", 4));
        }

        [Fact]
        public void TestShortestRoutes()
        {
            // Test #8
            Assert.Equal(9, _trainRoutes.FindShortestRoute("A", "C"));

            // Test #9
            Assert.Equal(9, _trainRoutes.FindShortestRoute("B", "B"));
        }

        [Fact]
        public void TestMaxDistanceTrips()
        {
            // Test #10
            Assert.Equal(7, _trainRoutes.CountTripsWithMaxDistance("C", "C", 30));
        }
    }
}