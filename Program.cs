using System;

namespace CadastroPessoasVsCode
{
    class Program
    {
         static void Main(string[] args)
        {
            List<PessoaFisica> listaPf = new list<PessoaFisica>();

            console.clear();
            console.WriteLine(@$"
=========================================================            
|          Bem vindo sistema de cadastro de             |
|               pessoas Fisica e jurica                 |
=========================================================
");          
        
            BarraCarregamento("Carregando ");

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
                
");
                opção = Console.ReadLine();

                switch (opção)
                {
                    case "1":

                        string opcaoPf;
                        PessoaFisica pfmetodos = new PessoaFisica();

                         do
                         {
                             console.clear();
                             console.ForegroundColor = ConsoleColor.DarkBlue                            
                             console.WriteLine(@$"                
==========================================================               
|         Escolha uma das opções abaixo                  |
|--------------------------------------------------------|
|         1- Cadastrar uma Pessoa Física                 |
|         2- Listar Pessoas Físicas                      |
|                                                        |
|         0- Voltar ao menu anterior                     |
==========================================================

");
                        console.ResetColor();

                        opcaoPf = console.ReadLine();

                        switch (opçãoPf)
                        {
                            case"1":
                                    PessoaFisica novaPf = new PessoaFisica();
                                    Endereco novoEndPf = new Endereco();

                                    console.writeLine($"Digite o nome da pessoa que deseja cadastrar:")
                                    novaPf.nome = console.ReadLine();

                                    bool dataValida;
                                    do
                                    {

                                        console.writeLine($"Digite a data de nascimento: Ex: AAAA-MM-DD")
                                        DateTime dataNascimento = DateTime.Parse(console.ReadLine());

                                        dataValida = pfmetodos.ValidarDataNascimento(dataNascimento);

                                        if (dataValida);
                                        {
                                            novaPf.dataNascimento = dataNascimento;
                                        }
                                        else
                                        {
                                            console.ForegroundColor = ConsoleColor.DarkRed;
                                            console.writeLine($"Data digitada inválida, por favor digite uma data válida, (maior de 18 anos)");
                                            console.ResetColor();
                                        }

                                    } while (dataValida == false);

                                    console.writeLine($"Digite o CPF:")
                                    novaPf.cpf = console.ReadLine();

                                    console.writeLine($"Digite o rendimento mensal: (Digite somente numeros)";
                                    novaPf.rendimento = float.Parse (console.ReadLine());

                                    console.writeLine($"Digite o logradouro")
                                    novoEndPf.logradouro = console.ReadLine();

                                    console.writeLine($"Digite o numero");
                                    novoEndPf.numero = int.Parse(console.ReadLine());

                                    console.writeLine($"Digite o complemento (Aperte Enter para vazio)");
                                    novoEndPf.complemento = console.ReadLine();

                                    console.writeLine($"Este endereco é comercial? S/N");
                                    string enderecoComercial = console.ReadLine().toUpper();

                                    if (endComercial == "S")
                                    {
                                        novoEndPf.enderecocomercial = True; 
                                    }else
                                    {
                                        novoEndPf.enderecoComercial = False;
                                    }

                                    novaPf.endereco = novoEndPf;

                                    listaPf.Add(novaPf);

                                    console.ForegroundColor = ConsoleColor.DarkGreen;
                                    console.writeLine($"Cadastro realizado com sucesso");
                                    console.ResetColor();
                                    
                                    break;
                                
                            case"2":

                            console clear();
                            foreach (PessoaFísica cadaItem in listaPf)
                            {
                                   
                                console..WriteLine(@$"
 Nome: {cadaItem.nome}
 cpf: {cadaItem.cpf}
 Endereco: {cadaItem.endereco.logradouro}, {cadaItem.endereco.numero}
 complemento: {cadaItem.endereco.complemento}
 taxa de imposto a ser paga: {pfMetodos.PagarImposto(cadaItem.rendimento).ToString("c")}
");  
                                         }

                            
                                         console.writeLine($"Aperte 'Enter' para continuar");
                                         console.ReadLine();

                                    }else
                                    {
                                        console.ForegroundColor = ConsoleColor.DarkYellow;
                                        console.writeLine($"Lista vazia");
                                        console.ResetColor();
                                        Thread.Sleep(4000);
                                    }

                                break;

                            case"0":
                                break;

                            default:
                                console.ForegroundColor = ConsoleColor.DarkRed;
                                console.writeLine($"Opção invalida, por favor digite uma opção valida");
                                thread.Sleep(3000);
                                break;    
                        }
                        
                         } while (opçãoPf != "0");

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












            
