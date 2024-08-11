using TechTalk.SpecFlow;
using web_automation_tests.Pages;

namespace web_automation_tests.Steps
{
    [Binding]
    public class ConsultTrackingStep : ConsultTrackingPage
    {

        [Given(@"que estou na página de rastreamento dos Correios")]
        public void GivenQueEstouNaPaginaDeRastreamentoDosCorreios()
        {
            SearchTracking();
        }

        [When(@"eu procurar pelo código ""(.*)""")]
        public void QuandoEuProcurarPeloCodigo(string codigo)
        {
            TypeTrackingNumber(codigo);
            TypeCaptcha();
            CkickBtnSearch();
        }

        [Then(@"devo ver o alerta ""(.*)""")]
        public void ThenDevoVerOResultado(string text)
        {
            ValidadeAlert(text);
        }
    }
}
