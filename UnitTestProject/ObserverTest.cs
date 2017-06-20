using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverPattern;

namespace UnitTestProject
{
    [TestClass]
    public class ObserverTest
    {
        [TestMethod]
        public void CurrentConsditionTest()
        {
            WeatherDataPublisher weatherDataProvider = new WeatherDataPublisher();
            weatherDataProvider.ChangeWeatherData(1, 2, 3);

            CurrentConditionSubscriber curntSubscriber = new CurrentConditionSubscriber();
            weatherDataProvider.RegistorObserver(curntSubscriber);

            weatherDataProvider.ChangeWeatherData(4, 5, 6);

            SeccondConditionSubscriber SecSubscriber = new SeccondConditionSubscriber();
            weatherDataProvider.RegistorObserver(SecSubscriber);

            weatherDataProvider.ChangeWeatherData(40, 50, 60);

            //weatherDataProvider.RemoveObserver(curntSubscriber);

            weatherDataProvider.ChangeWeatherData(70, 80, 90);
        }
    }
}
