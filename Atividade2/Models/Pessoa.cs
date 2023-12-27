using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade2.Models
{
    public class Pessoa
    {
        public Pessoa() // Construtor Vazio
        {

        }
        public Pessoa(string nome, int idade) // Construtor
        {
            Nome = nome;
            Idade = idade;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($" Meu nome é: {Nome} e tenho: {Idade} anos");
        }
    }
}