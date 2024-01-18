using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
namespace SeleniumWebDriverProject.Tests
{
    public class SeleniumTests
    {
        [Test]
        public void FirstSeleniumTest()
        {
            var edgeOptions = new EdgeOptions();


            IWebDriver driver = new EdgeDriver(@"C:\edgedriver_win64\msedgedriver.exe", edgeOptions);
            //IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://localhost:7093");
            //Assert.That(driver.Title, Is.EqualTo("Selenium"));
            driver.Quit();
        }
    }
}
