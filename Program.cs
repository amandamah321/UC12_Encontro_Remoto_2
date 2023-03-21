using Encontro_Remoto.classes;

List<PessoaJuridica> listaPj = new List<PessoaJuridica>();


Utils.BarraCarregamento("Carregando");
Console.Clear();

Console.WriteLine(@$"


            =================================================
            | Bem vindo  ao sistema de cadastro de Pessoas  |
            =================================================

");
Thread.Sleep(2500);

string? opcao;
string? opcaoPj;

Console.ForegroundColor = ConsoleColor.Red;

Console.Write("Carregando");

for (var contador = 0; contador < 6; contador++)
{

    Console.Write($"***");
    Thread.Sleep(500);
}

Console.ResetColor();



do
{
    Console.Clear();
    Console.Write(@$"

            =================================================
            |            Escolha uma opção abaixo           |
            |               e pressione Enter               |
            =================================================
            |                                               |
            |             1- Pessoa  Jurídica               |
            |             2- Pessoa  Fisica                 |
            |                                               |
            |                  0 - Sair                     |
            |                                               |
            =================================================
");

    opcao = Console.ReadLine();
    //Console.WriteLine($"Voçê escolheu: {opcao}");

    switch (opcao)
    {
        case "1":

            do

            {



                Console.Clear();
                Console.Write(@$"

            =================================================
            |            Escolha uma opção abaixo :         |
            =================================================
            |                                               |
            |        1- Cadastrar Pessoa  Jurídica          |
            |          2- Listar Pessoa  Jurídica           |
            |                                               |
            |         0 - Voltar ao Menu anterior           |
            |                                               |
            =================================================
        ");

                opcaoPj = Console.ReadLine();

                switch (opcaoPj)
                {
                    case "1":

                        PessoaJuridica novoPj = new PessoaJuridica();
                        Endereco novoEndPj = new Endereco();

                        Console.Clear();
                        Console.WriteLine($"Digite o nome da Razão Social");
                        novoPj.razaoSocial = Console.ReadLine();

                        Console.WriteLine($"Digite o CNPJ da empresa");
                        novoPj.cnpj = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento da empresa");
                        string? rendEntrada = Console.ReadLine();

                        float.TryParse(rendEntrada, out float rendConvertido);
                        novoPj.rendimento = (int)rendConvertido;


                        Console.WriteLine($"Digite o nome da Rua");
                        novoEndPj.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número do imóvel");
                        string? numEntrada = Console.ReadLine();
                        int.TryParse(numEntrada, out int numConvertido);
                        novoEndPj.numero = numConvertido;

                        novoPj.endereco = novoEndPj;

                        listaPj.Add(novoPj);

                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Console.WriteLine($"Pressione qualquer tecla para continuar");
                        Console.ReadLine();



                        /* novoPj.nome = "Amanda";
                         novoPj.cnpj = "4564651131357";
                         novoPj.rendimento = 6000;


                         novoEndPj.logradouro = "Rua Flores";
                         novoEndPj.numero = 180;
                         novoEndPj.complemento = "Escola Sesi";
                         novoEndPj.endComercial = true;

                         */
                        Thread.Sleep(500);
                        break;

                    case "2":

                        Console.Clear();


                        if (listaPj.Count > 0)
                        {
                            foreach (PessoaJuridica cadaPj in listaPj)
                            {

                                Console.Clear();


                                Console.WriteLine(@$"
                            Nome da Razão Social: {cadaPj.nome}
                            Endereço: {cadaPj.endereco.logradouro}, Número: {cadaPj.endereco.numero}
                            CNPJ: {cadaPj.cnpj} - valido: {cadaPj.ValidarCnpj(cadaPj.cnpj)}
                            ");

                                Console.WriteLine($"Pressione qualquer tecla para continuar");
                                Console.ReadLine();

                            }
                        }
                        else
                        {

                            Console.WriteLine($"Sem dados para exibir, lista vazia");
                            Thread.Sleep(3000);
                        }





                        Thread.Sleep(500);
                        break;

                    case "0":
                        Console.WriteLine("Voltando ao menu inicial");

                        break;

                    default:
                        Console.WriteLine($"digite o valor  correto");
                        Thread.Sleep(2500);
                        break;
                }

            } while (opcaoPj != "0");

            Thread.Sleep(500);

            Thread.Sleep(2500);
            break;

        case "2":
            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEndPF = new Endereco();

            novaPf.nome = "Amanda";
            novaPf.cpf = "4564651131357";
            novaPf.rendimento = 6000;
            novaPf.dataNasc = new DateTime(2000, 01, 01);


            novoEndPF.logradouro = "Rua Flores";
            novoEndPF.numero = 180;
            novoEndPF.complemento = "Escola Sesi";
            novoEndPF.endComercial = true;

            novaPf.endereco = novoEndPF;

            Console.WriteLine(@$"
            Nome: {novaPf.nome}
            Endereço: {novoEndPF.logradouro}, Número: {novoEndPF.numero}
            Maior de idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}");

            Thread.Sleep(2500);
            break;

        case "0":
            Utils.BarraCarregamento("Finalizando");
            Console.Clear();
            break;


        default:
            Console.WriteLine($"digite o valor  correto");
            Thread.Sleep(2500);
            break;
    }

} while (opcao != "0");








//Console.WriteLine(novoPj.ValidarCnpj("123655498462198484"));

//var cnpj = 76773415000160;
//novoPj.ValidarCnpj(cnpj);

//----------------------------------------------------------------


// Console.WriteLine(novaPf.nome);


// Console.WriteLine($"Nome: {novaPf.nome} - CPF: {novaPf.cpf}");


// float impostoPagar = novaPf.calcularImposto(novaPf.rendimento);

// Console.WriteLine(impostoPagar);

// Console.WriteLine($"R$ {impostoPagar: 0.00}");

// /*-------------------------------------------------------------*/

// PessoaJuridica novaPj = new PessoaJuridica();
// Console.WriteLine(novaPj.calcularImposto(6600.5f));

// /*-------------------------------------------------------------*/


// DateTime temp = new DateTime(2000, 01, 01);
// Console.WriteLine(novaPf.ValidarDataNasc("01/01/2006"));




