Feature: Consultar rastreamento nos Correios

  Scenario: Verificar código de rastreamento inválido
    Given que estou na página de rastreamento dos Correios
    When eu procurar pelo código "SS987654321BR"
    Then devo ver o alerta "Objeto não encontrado na base de dados dos Correios."
