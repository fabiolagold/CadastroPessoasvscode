using System;

namespace CadastroPessoasVsCode
{
    class Program
    {
         static void Main(string[] args)
        {
            
            console.clear();
            console.WriteLine(@$"
=========================================================            
|          Bem vindo sistema de cadastro de             |
|               pessoas Fisica e jurica                 |
=========================================================
");          
        
            BarraCarregamento("Carregando");

            string opção;
            do
            {
                console.clear();
                console.WriteLine(@$"
                
==========================================================               
|         Escolha uma das opções abaixo                  |
|--------------------------------------------------------|
|         1- Pessoa Física                               |
|         2- Pessoa Jurídica                             |
|                                                        |
|         0- Sair                                        |
==========================================================
                
")
                opção = Console.ReadLine();

                switch (opção)
                {
                    case "1":
            
                        PessoaFisica pfmetodos = new PessoaFisica();

                        PessoaFisica novaPf = new PessoaFisica();
                         Endereco novoEndPf = new Endereco();

                        novaPf.nome = "Fabiola";
                        novaPf.dataNascimento = new DateTime(2000,01,01);
                        novaPf.cpf = "8769564590";
                        novaPf.rendimento = 5000.5f;

                        novoEndPf.logradouro = "Alameda barao de limeira";
                        novoEndPf.numero = 539;
                        novoEndPf.complemento = "SENAI Informatica";
                        novoEndPf.enderecoComercial = True;

                        novaPf.endereco = novoEndPf;

                        Console.Clear();
                        console..WriteLine(@$"
 Nome: {novaPf.nome}
 cpf: {novaPf.cpf}
 Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
 complemento: {novaPf.endereco.complemento}
 taxa de imposto a ser paga: {pfMetodos.PagarImposto(novaPf.rendimento).ToString("c")}
");  
                        console.writeLine($"Aperte 'Enter' para continuar");
                        console.ReadLine();

                        break;
                    
                    case"2": 

                        
                        PessoaFisica pfmetodos = new PessoaFisica();

                        PessoaFisica novaPf = new PessoaFisica();
                         Endereco novoEndPf = new Endereco();

                        novaPf.nome = "Fabiola";
                        novaPf.dataNascimento = new DateTime(2000,01,01);
                        novaPf.cpf = "8769564590";
                        novaPf.rendimento = 5000.5f;

                        novoEndPf.logradouro = "Alameda barao de limeira";
                        novoEndPf.numero = 539;
                        novoEndPf.complemento = "SENAI Informatica";
                        novoEndPf.enderecoComercial = True;

                        novaPf.endereco = novoEndPf;

                     //   string cnpjválido = pjMetodos.ValidarCnpj(novapj.cnpj) ? "válido" : "inválido"
                        if (pjMetodos.validarCnpj(novaPj.cnpj)) 
                        {
                            cnpjVálido = "Válido";
                        }else
                        {
                            cnpjVálido = "inválido";
                        }   

                        Console.Clear();
                        console..WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razãoSocial}
CNPJ : {novaPj.cnpj}
Cnpj valido: {pjMetodos.ValidarCnpj(novapj.cnpj) ? "válido" : "inválido"}
taxa de imposto a ser paga : {pfMetodos.PagarImposto(novaPj.rendimento).ToString("c")}
");
                        console.writeLine($"Aperte 'Enter' para continuar");
                        console.ReadLine();

                        break;

                    case "0":
                        console.clear();
                        console.WriteLine(@$"Obrigado por utilizar nosso sistema");

                        BarraCarregamento("Finalizando");

                        break;

                    default:
                        console.writeLine($"Opção invalida, por favor digite uma opção valida");
                        thread.Sleep(2000);

                        break;
                }            
            } while (opção != "0");
                }

            static void BarraCarregamento(StringContent textoCarregamento)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{TextoCarregamento}");
                Thread.Sleep(500);

                for (var contador = 0; contador < 10; contador++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }
            }   
            Console.ResetColor();
         }
    }
}            












            
