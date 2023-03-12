using Encontro_Remoto.classes;

Utils.BarraCarregamento("Carregando");
Console.Clear();

Console.WriteLine(@$"


            =================================================
            | Bem vindo  ao sistema de cadastro de Pessoas  |
            =================================================

");
Thread.Sleep(2500);

string? opcao;

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
            //PESSOA JURIDICA***************************

            PessoaJuridica novoPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            Console.WriteLine(novoPj.ValidarCnpj("123655498462198484"));

            novoPj.nome = "Amanda";
            novoPj.cnpj = "4564651131357";
            novoPj.rendimento = 6000;


            novoEndPj.logradouro = "Rua Flores";
            novoEndPj.numero = 180;
            novoEndPj.complemento = "Escola Sesi";
            novoEndPj.endComercial = true;

            novoPj.endereco = novoEndPj;

            Console.WriteLine(@$"
            Nome: {novoPj.nome}
            Endereço: {novoEndPj.logradouro}, Número: {novoEndPj.numero}
            CNPJ: {novoPj.cnpj} - valido: {novoPj.ValidarCnpj("123655498462198484")}
            ");

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




