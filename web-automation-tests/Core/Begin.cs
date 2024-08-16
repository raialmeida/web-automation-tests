using Allure.Net.Commons;
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
        private readonly bool isHeadless =
            Environment.GetEnvironmentVariable("HEADLESS_MODE")?.Trim().ToLower() == "true";

        [BeforeTestRun]
        public static void CleanAllureResults()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [BeforeScenario]
        public void StartTest()
        {
            var chromeOptions = new ChromeOptions();

            if (isHeadless)
            {
                chromeOptions.AddArgument("--headless");
                chromeOptions.AddArgument("--no-sandbox");
                chromeOptions.AddArgument("--disable-dev-shm-usage");
            }

            ChromeDriver driver = new(chromeOptions);
            driver.Navigate().GoToUrl("https://www.correios.com.br");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void FinishTest()
        {
            var driver = container.Resolve<IWebDriver>();
            driver?.Quit();
        }
    }
}
