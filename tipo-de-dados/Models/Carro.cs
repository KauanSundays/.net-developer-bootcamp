using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tipoDados.Models
{
    public class Carro
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public double Valor { get; set; }

        public Carro(string nome, string marca, double valor)
        {
            Nome = nome;
            Marca = marca;
            Valor = valor;
        }

        public void Comprar()
        {
            Console.WriteLine($"Parabéns, você comprou o carro {Nome} da marca {Marca} no valor de {Valor}.");
        }
    }
}