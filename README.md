# Projeto de Automação de Testes com Selenium e SpecFlow

Este projeto é uma automação de testes de aplicação web utilizando Selenium para a automação e SpecFlow para especificações de testes na linguagem Gherkin. O framework de execução do teste utilizado é o NUnit.

## Requisitos

Antes de começar, certifique-se de que você tem os seguintes itens instalados:

- [Visual Studio](https://visualstudio.microsoft.com/pt-br/) (para desenvolvimento em C#)
- [.NET SDK](https://dotnet.microsoft.com/pt-br/download/visual-studio-sdks) (para executar o projeto)

## Observação sobre Captcha:
**A aplicação do correios incluem validação via CAPTCHA, que não pode ser automatizada pelo Selenium. Nestes casos, será necessário inserir o CAPTCHA manualmente durante a execução do teste. A automação aguarda 15 segundos e o teste continuará automaticamente após a resolução manual.**

CAPTCHA (Completely Automated Public Turing test to tell Computers and Humans Apart) é projetado exatamente para impedir que robôs ou scripts automatizados interajam com a aplicação. Isso significa que tentar automatizar a resolução de CAPTCHA:

- Vai contra a proposta do próprio CAPTCHA: Ele existe para bloquear automações.
- Pode gerar falsos positivos ou bloqueios na aplicação, se forem usados métodos de "bypass".
- Não é confiável nem sustentável: Soluções de terceiros que quebram CAPTCHA podem deixar de funcionar a qualquer momento.
- Complica a manutenção do teste: Qualquer mudança no tipo de CAPTCHA pode quebrar a automação

## Instalação

1. **Clone o repositório:**

```
git clone https://github.com/raialmeida/web-automation-tests
```

## Execução do Testes

Compilar o projeto:

```
dotnet build
```
Executar os testes:
```
dotnet test
```
Para executar os testes no container docker, utilize o seguinte comando:
```
docker-compose run --rm selenium-specflow-front dotnet test
```

## Estrutura do Projeto

- Features/: Contém arquivos .feature que descrevem os cenários de teste em linguagem Gherkin.
- Steps/: Contém as definições de passos correspondentes aos cenários nos arquivos .feature.
- Pages/: Contém os métodos de cada pages.
- Core/: Contém classes auxiliares que facilitam a execução de testes.
- allure-results/: Report dos testes (Será criada automaticamente quando os testes finalizar).

## Integração Contínua

Este projeto está configurado para execução automática de testes em ambientes de Integração Contínua (CI) utilizando **Jenkins** e **Azure DevOps**.

### Jenkins
- Configurado para executar os testes na plataforma do Jenkins (Testes em container Docker).

### Azure DevOps
- Pipeline configurada para build e execução de testes automatizados.
- Permite integração com repositórios Git, garantindo que os testes rodem em pull requests e merges.
- Relatórios e logs dos testes ficam disponíveis diretamente no Azure DevOps, facilitando análise e rastreabilidade.
