using System;
using Microsoft.Extensions.Logging.Abstractions;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController(new NullLogger<WeatherForecastController>());

        [Fact]
        public void GetReturnsByName()
        {
            var returnValue = controller.Get("1");
            Assert.Equal("Gabriel Emmanuel", returnValue);
        }
        
        [Fact]
        public void Test1()
        {

        }
    }
}
