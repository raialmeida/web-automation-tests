using OpenQA.Selenium;
using web_automation_tests.Core;

namespace web_automation_tests.Pages
{
    public class ConsultTrackingPage(IWebDriver driver) : DSL(driver)
    {

        public void SearchTracking()
        {
            ClickOnElementByXpath("//button[@class='bt-link-ic']/i[@class='ic-busca-out']");
        }

        public void TypeTrackingNumber(string number)
        {
            TypeTextById("objeto", number);
        }

        public void CkickBtnSearch()
        {
            ClickOnElementById("b-pesquisar");
        }

        public void ValidadeAlert(string alert)
        {
            ValidateTextByCSS("#alerta", alert);
        }

        public void TypeCaptcha()
        {
            ValidateCaptcha();
        }
    }
}
