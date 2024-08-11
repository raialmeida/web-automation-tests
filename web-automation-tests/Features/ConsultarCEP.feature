Feature: Consultar CEP nos Correios

Scenario: Verificar CEP inexistente
	Given que estou na página inicial dos Correios
	When eu procurar pelo CEP "80700000"
	Then devo ver a mensagem "Dados não encontrado"

Scenario: Verificar CEP existente
	Given que estou na página inicial dos Correios
	When eu procurar pelo CEP "01013-001"
	Then devo ver o endereço "Rua Quinze de Novembro - lado ímpar, São Paulo/SP"
