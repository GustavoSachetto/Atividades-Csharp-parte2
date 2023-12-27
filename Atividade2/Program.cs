using Atividade2.Models;

// Com construtor
Pessoa p1 = new Pessoa("Gustavo", 17);
p1.Apresentar();

// Com construtor com nome do parâmetro
Pessoa p2 = new Pessoa(nome: "Fernando", idade: 17);
p2.Apresentar();

// Sem construtor
Pessoa p3 = new Pessoa();
p3.Nome = "João";
p3.Idade = 16;
p3.Apresentar();

// Sem construtor
Curso c1 = new Curso();
c1.Nome = "Informatica";
c1.Alunos = new List<Pessoa>();
c1.AdicionarAluno(p1);
c1.AdicionarAluno(p2);
c1.AdicionarAluno(p3);
c1.ListarAlunos();
c1.RemoverAluno(p2);
c1.ListarAlunos();