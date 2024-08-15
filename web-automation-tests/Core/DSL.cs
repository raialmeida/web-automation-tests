using OpenQA.Selenium;

namespace web_automation_tests.Core
{
    public class DSL(IWebDriver driver)
    {

        public IWebDriver driver = driver;

        public void TypeTextById(string id, string value)
        {
            driver.FindElement(By.Id(id)).SendKeys(value);
        }

        public void TypeTextByXpath(string xpath, string value)
        {
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }

        public void ClickOnElementByXpath(string xpath)
        {
            var element = driver.FindElement(By.XPath(xpath));
            ScrollElement(element);
            element.Click();
        }

        public void ClickOnElementById(string id)
        {
            driver.FindElement(By.Id(id)).Click();
        }

        public void ValidateTextById(string id, string text)
        {
            Thread.Sleep(3000);
            Assert.That(driver.FindElement(By.Id(id)).Text, Does.Contain(text));
        }

        public void ValidateTextByXpath(string xpath, string text)
        {
            Assert.That(driver.FindElement(By.XPath(xpath)).Text, Does.Contain(text));
        }

        public void ValidateTextByCSS(string css, string text)
        {
            Thread.Sleep(3000);
            Assert.That(driver.FindElement(By.CssSelector(css)).Text, Does.Contain(text));
        }

        public IWebElement GetElementXpath(string element)
        {
            return driver.FindElement(By.XPath(element));
        }

        public void ValidateCaptcha()
        {
            // Aqui vai pausar por 15 segundos para digitar o captcha manualmente no browser.
            Thread.Sleep(15000);
        }

        private void ScrollElement(IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
    }
}
