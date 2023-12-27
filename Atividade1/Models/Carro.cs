using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade1.Models
{
    public class Carro
    {
        private string _modelo;
        private int _ano;
        public string Modelo 
        { 
            get
            {
                return _modelo.ToUpper();
            } 

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O modelo não pode ser vazio!");
                }
                _modelo = value;
            }
        }
        public string Versao { get; set; }

        public string ModeloVersao => $"{Modelo} {Versao}";
        public int Ano 
        { 
            get => _ano; 
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O ano não pode ser negativo!");
                }
                _ano = value;
            } 
        }
        public void Apresentar() {
            Console.WriteLine($"[Carro] modelo: {ModeloVersao}, Lançado em: {Ano}.");
        }
    }
}