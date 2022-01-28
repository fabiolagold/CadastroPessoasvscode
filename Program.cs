using System;

namespace CadastroPessoasVsCode
{
    class Program
    {
         static void Main(string[] args)
        {
            PessoaFisica novaPf = new PessoaFisica();

            novaPf.nome = "Fabiola";

            Console.WriteLine($"Nome: {novaPf.nome}");

        }
    }
}
