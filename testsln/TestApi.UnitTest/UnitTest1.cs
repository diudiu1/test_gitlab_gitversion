using System.Runtime.Intrinsics.X86;
using TestApi.Controllers;

namespace TestApi.UnitTest
{
    public class WeatherForecastUnitTest
    {
        private WeatherForecastController weatherForecastController;
        public WeatherForecastUnitTest()
        {
            weatherForecastController = new WeatherForecastController(null!);
        }
        [Fact]
        public void Get()
        {

            var result = weatherForecastController.Get();
            Assert.Equal(1, 1);
        }
    }
}