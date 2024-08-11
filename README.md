# Projeto de Automação de Testes com Selenium e SpecFlow

Este projeto é uma automação de testes de aplicação web utilizando Selenium para a automação e SpecFlow para especificações de testes em estilo BDD (Behavior-Driven Development). O framework de teste utilizado é o NUnit.

## Requisitos

Antes de começar, certifique-se de que você tem os seguintes itens instalados:

- [Visual Studio](https://visualstudio.microsoft.com/pt-br/) (para desenvolvimento em C#)
- [.NET SDK](https://dotnet.microsoft.com/pt-br/download/visual-studio-sdks) (para executar o projeto)

## Instalação

1. **Clone o repositório:**

```
git clone https://github.com/raialmeida/web-automation-tests
```

## Execução 

Compilar o projeto.
```
dotnet build
```
Executar os testes.
```
dotnet test
````
## Estrutura do Projeto

- Features/: Contém arquivos .feature que descrevem os cenários de teste em linguagem Gherkin.
- Steps/: Contém as definições de passos correspondentes aos cenários nos arquivos .feature.
- Pages/: Contém os métodos de cada pages.
- Core/: Contém classes auxiliares que facilitam a execução de testes.
