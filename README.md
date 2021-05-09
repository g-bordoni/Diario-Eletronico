# Diário Eletrônico

Inspirado no [repositório](https://github.com/gabrielfbarros/csharp-examples) das aulas sobre **C#** e **.NET** ministradas pelo Gabriel Barros, o objetivo
desse projeto é criar um Diário Eletrônico automatizado para professores.

Atualmente ele é baseado em 3 classes principais:
* Alunos: que armazena o nome, presença e notas de um dado estudante;
* Diario: que semelhantemente a uma BST estrutura os objetos em função da ordenação alfabética;
* Node: as estruturas elementares que compoem o Diario.

O objetivo dessas estruturas é possibilitar que uma ordenação da impressão do diário seja sempre a mesma. Logo, mesmo que ao longo de um ano letivo
o professor insira novos estudantes ou modifique seus atributos, a impressão do diário será sempre alfabética.

------
## Funcionamento:

#### Criando Diário:
~~~C#
//Nesse caso da turma A1 pertencente a prof. Julia 
Diario turmaA1 = new Diario("julia neres","A1");
~~~

#### Criando Aluno:
~~~C#
Aluno aluno = new Aluno("marco antonio");
~~~

#### Possíveis inserções sobre o aluno:

~~~C#
float[] notas = {3.5F,6.9F,8.0F};
aluno.setNotas(notas);

string[] presenca = {"P","A","A","A","P"};
aluno.setPresenca(presenca);

aluno.insertNovaAula("A");
aluno.insertNovaAvalicao(8.8F);
~~~

#### Saida:
~~~C#
turmaA1.insertNode(aluno);

turmaA1.print();
~~~
~~~
------------------------------------------
DIÁRIO DE CLASSE
PROF.: JULIA NERES		TURMA: A1
------------------------------------------

ALUNO:			ASSIDUIDADE:	NOTAS:
MARCO ANTONIO			33%		3,50	6,90	8,00	8,80

~~~

#### Saída após adicionado outros alunos:

~~~
------------------------------------------------
DIÁRIO DE CLASSE
PROF.: JULIA NERES		TURMA: A1
------------------------------------------------

ALUNO:			ASSIDUIDADE:	NOTAS:
ANA CRUZ			60%		3,30	6,40	4,00
BEATRIZ CARLA			60%		3,80	6,40	1,00
JOAO PERA			40%		3,40	6,90	6,00
LUCIANO LUCAS			100%		3,60	6,10	7,00
MARCO ANTONIO			33%		3,50	6,90	8,00	8,80
NATAN LUZ			80%		8,60	4,50
PEDRO SILVA			40%		3,50	6,90	8,00
~~~

