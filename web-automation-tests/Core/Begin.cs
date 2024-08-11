using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace web_automation_tests.Core
{
    public class Begin
    {
        public required IWebDriver driver;
        public bool driverQuit = true;

        [BeforeScenario]
        public void StartTest()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.correios.com.br");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driverQuit = true;
        }

        [AfterScenario]
        public void FinshTest()
        {
            if (driverQuit) driver.Quit();
        }
    }
}
