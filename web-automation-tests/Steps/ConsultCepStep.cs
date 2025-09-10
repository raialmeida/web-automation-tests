using OpenQA.Selenium;
using TechTalk.SpecFlow;
using web_automation_tests.Pages;

namespace web_automation_tests.Steps
{
    [Binding]
    public class ConsultCepStep(IWebDriver driver) : ConsultCepPage(driver)
    {

        [Given(@"que estou na página inicial dos Correios")]
        public void DadoQueEstouNaPaginaInicialDosCorreios()
        {
            SearchCEP();
            SwitchToNewTab(driver);
        }

        [When(@"eu procurar pelo CEP ""(.*)""")]
        public void QuandoEuProcurarPeloCEP(string cep)
        {
            TypeCep(cep);
            TypeCaptcha();
            ClickBtnSearch();
        }

        [Then(@"devo ver a mensagem ""(.*)""")]
        public void EntaoDevoVerAMensagem(string mensagem)
        {
            ValidateMessageResultAlert(mensagem);
        }

        [Then(@"devo ver o endereço ""(.*)""")]
        public void ThenDevoVerOResultado(string text)
        {
            ValidateAddress(text);
        }
    }
}
