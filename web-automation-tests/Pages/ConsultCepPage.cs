using OpenQA.Selenium;
using web_automation_tests.Core;

namespace web_automation_tests.Pages
{
    public class ConsultCepPage : DSL
    {
        public void SearchCEP()
        {
            ClickOnElementByXpath("(//a[span[text()='Busca CEP ou Endereço']])[2]");
        }
        public void TypeCep(string cep)
        {
            TypeTextById("endereco", cep);
        }

        public void TypeCaptcha()
        {
            ValidateCaptcha();
        }

        public void ClickBtnSearch()
        {
            ClickOnElementById("btn_pesquisar");
        }

        public void ValidateMessageResultAlert(string text)
        {
            ValidateTextById("mensagem-resultado-alerta", text);
        }

        public void ValidateAddress(string address)
        {
            IWebElement streetElement = GetElementXpath("//td[@data-th='Logradouro/Nome']");
            IWebElement cityElement = GetElementXpath("//td[@data-th='Localidade/UF']");

            string fullAddress = $"{streetElement.Text}, {cityElement.Text}";

            Assert.That(address, Does.Contain(fullAddress), "O texto do elemento não contém a string esperada.");
        }
    }
}
