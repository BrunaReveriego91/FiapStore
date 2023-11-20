CODE FIRST:
	Abordagem que utiliza o código como primeira fonte para criação do banco de dados.
	
	Data Annotations: São atributos adicionados na entidade demonstrando nome da tabela, nome das propriedades, inclusive validações , como se uma propriedades
	é nullable ou não.
	
	Fluent API: Abordagem mais robusta pois permite que você faça todo mapeamento usando métodos e de uma forma mais concisa sem poluir muito o código da entidade.
	
DATABASE FIRST:
		
	É uma Abordagem de implementação que, ao contrário do Code First, é feita a criação das tabelas através do banco de dados.
	Após feito isso, há duas opções:
	
	Construir o modelo de entidades na mão;
	
	Scaffold: Fazer a engenharia reversa do código do banco de dados sem escrever todo o código do zero.
	
DbContext: 
	É a mistura dos padrões UoW (Unit of Work) e Repository.
	
	É responsável por disponibilizar os métodos que fazem leitura e gravação no banco de dados.
	
	O objetivo é simplificar a interação de sua aplicação com seu banco de dados.
	
	O DbContext é responsável por diversas funções como:
	
	-Configurar seu modelo de dados.
	-Consultar e persistir dados no banco.
	-Fazer toda rastreabilidade de objetos.
	-Materializar resultados de consultas realizadas.
	-Cache de primeiro nível.
	
	