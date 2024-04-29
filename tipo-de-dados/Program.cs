using System;
using tipoDados.Models;

namespace tipoDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro("UNO", "FIAT", 20000.00);
            carro1.Comprar();
        }
    }
}
