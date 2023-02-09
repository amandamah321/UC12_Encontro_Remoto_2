using Encontro_Remoto.classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Amanda";
novaPf.cpf = "4564651131357";
novaPf.rendimento = 6000;

Console.WriteLine(novaPf.nome);

Console.WriteLine("Nome: " + novaPf.nome + " - CPF: " + novaPf.cpf);
Console.WriteLine($"Nome: {novaPf.nome} - CPF: {novaPf.cpf}");


float impostoPagar = novaPf.calcularImposto(novaPf.rendimento);

Console.WriteLine(impostoPagar);

Console.WriteLine($"R$ {impostoPagar: 0.00}");

