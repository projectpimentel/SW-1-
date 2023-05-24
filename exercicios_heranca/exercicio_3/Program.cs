﻿namespace exercicio_3;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica n1 = new ContratoPessoaFisica();
        ContratoPessoaJuridica n2 = new ContratoPessoaJuridica();
       
        n1.Nome = "Gustavo"; 
        n1.Email = "gustavo.p.costa2007@gmail.com";
        n1.Telefone = "941615717";
        n1.cpf = "434621748-60";
        n1.Idade = 16;
        n1.Prazo = 10;


        n2.Email = "felipepazini@gmail.com";
        n2.Nome = "Felipe";
        n2.Telefone = "947447701";
        n2.cnpj = "72.152.569/0001-00";
        n2.ie = "563.249.853.476";
        n2.NomeEmpresa = "Felipee";
        n2.Prazo = 10;
        

        Console.WriteLine("os dados da Pessoa Física sao: " + n1.MostraDados());
        Console.WriteLine("os dados da Pessoa Jurídica sao: " + n2.MostraDados());
        Console.WriteLine("************************************");
        Console.WriteLine("O valor da prestação da Pessoa Física é de: " + n1.calcularPrestacao());
        Console.WriteLine("O valor da prestação da Pessoa Jurídica é de: " + n2.calcularPrestacao());
    }
}