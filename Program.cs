

Console.WriteLine("Informar nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Informar endereco: ");
string Nome = Console.ReadLine();

Console.WriteLine("Pessoa fisica (f) ou juridica (j)?: ");
string tipo = Console.ReadLine();

if(tipo == "f"){

    object endereco = null;
    Controle_Clientes.PessoaFisica pf = new Controle_Clientes.PessoaFisica() {
        nome = nome,
        endereco = (string)endereco,
    };
    Console.WriteLine("Informar o CPF");
    pf.cpf = Console.ReadLine();

      Console.WriteLine("Informar o RG");
    pf.rg = Console.ReadLine();

      Console.WriteLine("Informar o valor de compra: ");
    float valor = float.Parse(Console.ReadLine());

    pf.Pagar_Imposto(valor);

    Console.WriteLine("----------Pessoa Fisica----------");
    Console.WriteLine("Nome: " + pf.nome);
     Console.WriteLine("Endereço: " + pf.endereco);
      Console.WriteLine("CPF: " + pf.cpf);
       Console.WriteLine("RG: " + pf.rg);
        Console.WriteLine("Valor de Compra: " + pf.valor.ToString("C"));
         Console.WriteLine("Imposto: " + pf.valorImposto);
          Console.WriteLine("Total a pagar: " + pf.total.ToString("C"));
}
 else if(tipo == "j") {

}
