using Encontro_Remoto.classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Amanda";
novaPf.cpf = "4564651131357";

Console.WriteLine(novaPf.nome);

Console.WriteLine("Nome: " + novaPf.nome + " - CPF: " + novaPf.cpf);
Console.WriteLine($"Nome: {novaPf.nome} - CPF: {novaPf.cpf}");