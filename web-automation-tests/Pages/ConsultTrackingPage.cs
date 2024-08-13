using OpenQA.Selenium;
using web_automation_tests.Core;

namespace web_automation_tests.Pages
{
    public class ConsultTrackingPage(IWebDriver driver) : DSL(driver)
    {

        public void SearchTracking()
        {
            try
            {
                // Captura o identificador da janela atual
                string originalWindow = driver.CurrentWindowHandle;

                // Clica no botão que abre uma nova janela
                ClickOnElementByXpath("//button[@class='bt-link-ic']/i[@class='ic-busca-out']");

                // Captura todos os identificadores das janelas abertas
                var windowHandles = driver.WindowHandles;

                // Alterna para a nova janela
                foreach (var handle in windowHandles)
                {
                    if (handle != originalWindow)
                    {
                        driver.SwitchTo().Window(handle);
                        break;
                    }
                }
            }
            finally
            {

            }
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
