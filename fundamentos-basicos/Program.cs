using System;
using dotnet_bootcamp.Models;

namespace dotnet_bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("MC Poze");
            
            pessoa1.Idade = 12;
            pessoa1.Apresentar();

        }
    }
}
