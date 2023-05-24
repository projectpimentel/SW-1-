namespace exercicio_2;
class Program
{
      static void Main(string[] args)
    {
        ContatoPessoaFisica n1 = new ContatoPessoaFisica();
        ContatoPessoaJuridica n2 = new ContatoPessoaJuridica();

        n1.Nome = "Gustavo";
        n1.Email = "gustavo.p.costa2007@gmail.com";
        n1.Telefone = "941615717";
        n1.CPF = "434621748-60";
        n1.Idade = 16;

        n2.Nome = "Felipe";
        n2.Email = "felipepazini0@gmail.com";
        n2.Telefone = "94744-7707";
        n2.CNPJ = "454268558-30";
        n2.IE = "2452442455";
        n2.NomeDaEmpresa = "Void";

        Console.WriteLine(n1.MostrarDados());
        Console.WriteLine();
        Console.WriteLine(n2.MostrarDados());
    }
}
