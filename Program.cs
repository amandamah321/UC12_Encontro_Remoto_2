using Encontro_Remoto.classes;

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
Maior de idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}

");



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




