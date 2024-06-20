# Gerador de Testes

## Sum�rio Executivo:
___
 Mariana prepara diversos exerc�cios para suas filhas que est�o na **1� e 2� s�ries**.  Ela gostaria de informatizar esses exerc�cios, para gerar testes aleat�rios. Cada teste  gerado deve ser guardado (acompanhado de suas quest�es), com a indica��o de sua  data de gera��o. Na gera��o de um teste, � preciso informar o n�mero de quest�es  desejadas e qual a disciplina pertence ao teste.

Para cada **disciplina**, cadastra-se: uma lista de quest�es objetivas, e mat�rias pertencentes. 
O gabarito tamb�m �  cadastrado a fim de facilitar a corre��o do teste. Cada mat�ria faz parte de uma �nica  disciplina. A s�rie est� ligada � mat�ria. 
___
## Requisitos Funcionais
### 1 - M�dulo de Disciplinas
#### Requisito 1.1: Cadastrar Novas Disciplinas
Crit�rios:
- O registro de **Disciplina** � composto por:
	- Nome
	- Mat�rias
	- Quest�es

- O campo nome � obrigat�rio
- N�o pode registrar uma disciplina com o mesmo nome
- A disciplina deve armazenar informa��es sobre as mat�rias que ser�o relacionadas � ela posteriormente 

#### Requisito 1.2: Editar Disciplinas
	Crit�rios:
- Os crit�rios de valida��o s�o os mesmos do Requisito 1.1
#### Requisito 1.3: Excluir Disciplinas
	Crit�rios:
- N�o deve ser poss�vel excluir disciplinas com mat�rias e testes relacionados.
#### Requisito 1.4 Visualizar Todas as Disciplinas.
	Crit�rios:
- Deve exibir: Id e Nome
___
### 2 - M�dulo de Mat�rias
#### Requisito 2.1: Cadastrar Mat�rias.
	Crit�rios:
- O registro de **mat�ria** � composto por:
	- Nome
	- **Disciplina**
	- S�rie

- Todos os campos s�o obrigat�rios
- N�o pode registrar uma mat�ria com o mesmo nome

#### Requisito 2.2: Editar Mat�rias.
	Crit�rios:
- Os crit�rios de valida��o s�o os mesmos do do Requisito 2.1
#### Requisito 2.3: Excluir Mat�rias.
	Crit�rios:
- N�o deve ser poss�vel excluir mat�rias sendo utilizadas em quest�es.
#### Requisito 2.4: Visualizar Todas as Mat�rias.
	Crit�rios:
- Deve exibir: Id, Nome, Disciplina e S�rie

___

### 3 - M�dulo de Quest�es
#### Requisito 3.1: Cadastrar Quest�es.
	Crit�rios:
- O registro de quest�o � composto por:
	- **Mat�ria**
	- Enunciado
	- Alternativas

- Todos os campos s�o obrigat�rios
- Cada quest�o deve ter um m�nimo e m�ximo de alternativas (m�ximo sugerido: 4) 

#### Requisito 3.2: Editar Quest�es.
	Crit�rios:
- Os crit�rios de valida��o s�o os mesmos do Requisito 3.1
#### Requisito 3.3: Excluir Quest�es.
	Crit�rios:
- N�o deve ser poss�vel excluir uma quest�o relacionada a um teste.
#### Requisito 3.5: Visualizar Todas as Quest�es.
	Crit�rios:
- Deve exibir: Id, Enunciado, Mat�ria e Resposta Correta
#### Requisito 3.6: Configurar Alternativas da Quest�o.
	Crit�rios:
- Deve permitir adicionar alternativas � quest�o
- Deve permitir remover alternativas � quest�o
- N�o permitir o cadastro de quest�es sem uma alternativa correta
- N�o deve permitir o cadastro de mais de uma alternativa correta
- No m�nimo duas alternativas devem ser configuradas

___
### 4 - M�dulo de Testes
#### Requisito 4.1: Gerar Testes.
	Crit�rios:
- O registro de teste � composto por:
	- T�tulo
	- **Disciplina**,
	- **Mat�ria** e S�rie 
	- Quantidade de quest�es

- Deve ser informado a quantidade de quest�es que dever�o ser geradas
- N�o pode registrar um teste com o mesmo nome
- A quantidade de quest�es informada deve ser menor ou igual a quantidade de quest�es cadastradas
- As mat�rias devem ser carregadas a partir da disciplina selecionada
- N�o deve permitir selecionar uma mat�ria que n�o perten�a a disciplina selecionada.
- Caso a disciplina seja alterada, o campo mat�ria deve ficar em branco
- Caso seja �Prova de Recupera��o� deve considerar as quest�es de todas as mat�rias da disciplina selecionada
- Todos os campos s�o obrigat�rios.
- As quest�es devem ser selecionadas de forma aleat�ria


#### Requisito 4.2: Duplicar Testes.
	Crit�rios:
- Deve permitir duplicar testes
- Na duplica��o do teste o t�tulo, disciplina, quantidade de quest�es, s�rie, prova de recupera��o e mat�ria dever�o vir preenchidos
- N�o pode duplicar um teste com o mesmo nome
- Na duplica��o do teste, as quest�es devem vir em branco
 
#### Requisito 4.3: Excluir Testes.
	Crit�rios:
- Deve permitir excluir testes existentes
#### Requisito 4.4: Visualizar Todos os Testes.
Crit�rios:
- Deve exibir: Id, T�tulo, Disciplina, Mat�ria (ou informar se � recupera��o) e Quantidade de Quest�es
#### Requisito 4.5: Visualizar Detalhes sobre Testes.
Crit�rios:
- Deve ser poss�vel visualizar os testes individualmente, com informa��es detalhadas incluindo as quest�es.

#### Requisito 4.6: Gerar PDF dos Testes.
	Crit�rios:
- O arquivo PDF do Teste deve apresentar: T�tulo, Disciplina, Mat�ria, as quest�es e suas as alternativas
#### Requisito 4.7: Gerar PDF do Gabarito dos Testes.
	Crit�rios:
- O arquivo PDF do Gabarito do Teste deve apresentar: T�tulo, Disciplina, Mat�ria, as quest�es e suas alternativas (com a alternativa correta assinalada)

___
## Requisitos N�o Funcionais

### Persist�ncia das informa��es
Crit�rios:
- Os dados devem ser salvos e recuperados em arquivo.

### Arquitetural 
Crit�rios:
- Deve-se trabalhar utilizando o modelo MVC
- Exemplo de nomenclatura dentro do projeto: ModuloDisciplina

### Interfaces com Usu�rio
Crit�rios:	
- [x] A visualiza��o dos registros deve ser apresentada utilizando o componente DataGridView
- [x] As telas de cadastro devem aparecer centralizadas
- [x] N�o deve permitir redimensionar telas de cadastro
- [x] N�o deve permitir minimizar ou maximizar telas de cadastro
- [x] As telas de cadastro devem ser dialogs
- [x] As telas de cadastro devem ter um t�tulo
- [x] Os elementos das telas de cadastro devem seguir um padr�o de posicionamento
- [x] Os elementos das telas de cadastro devem estar alinhados
- [x] O nome do sistema deve ser apresentado na tela principal
- [x] As notifica��es para usu�rio devem ser apresentadas seguindo um padr�o
- [x] As telas de cadastro devem ter uma op��o que fecha a janela e n�o grava as altera��es
- [x] As telas de cadastro devem ter uma op��o que grava as altera��es
- [x] A tabula��o dos campos deve seguir uma sequ�ncia l�gica iniciando pelos campos superiores
- [x] As altera��es realizadas devem ser gravadas e devem manter uma refer�ncia �nica em todas as telas
- [x] As telas de listagem devem permitir selecionar apenas um registro
___
##	Requisitos
- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.
___
## Como Usar

**Clone o reposit�rio:**
```bash
https://github.com/8Bitss/GeradorDeTestes.git
```

**Acesse a pasta do projeto:**
```bash
cd GeradorTestes
```

**Restaure as depend�ncias:**
```bash
dotnet restore
```
***Navegue at� a pasta do projeto que deseja executar:***
```bash
cd GeradorDeTestesWinApp
```

**Execute o projeto:**
```bash
dotnet run
```