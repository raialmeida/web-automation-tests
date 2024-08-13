using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace web_automation_tests.Core
{
    [Binding]
    public class Begin(IObjectContainer container)
    {

        private readonly IObjectContainer container = container;

        [BeforeScenario]
        public void StartTest()
        {
            ChromeDriver driver = new();
            driver.Navigate().GoToUrl("https://www.correios.com.br");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void FinshTest()
        {
            var driver = container.Resolve<IWebDriver>();
            driver?.Quit();
        }
    }
}
