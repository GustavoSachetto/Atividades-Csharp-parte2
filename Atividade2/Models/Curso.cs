using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade2.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        public void AdicionarAluno(Pessoa aluno) 
        {
            Alunos.Add(aluno);
        }
        public bool RemoverAluno(Pessoa aluno) 
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Curso: {Nome}");
            for (int i = 0; i < Alunos.Count; i++)
            {
                Console.WriteLine($"Aluno: {i}, Nome: {Alunos[i].Nome}, Idade: {Alunos[i].Idade} ");
            }
        }
        public int QuantidadeAlunos()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
    }
}