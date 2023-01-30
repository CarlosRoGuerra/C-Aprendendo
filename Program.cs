// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
namespace Curso
{
    class Program{
        static void Main(string[] args) {
            string Produto1 = "computador";
            string Produto2 = "Mesa de escritório";

            byte idade =3;
            int codigo = 5290;
            char genero = 'M';
            
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 52.234567;
            
            System.Console.WriteLine($"{Produto1}, cujo o preco é {preco1}");
            System.Console.WriteLine($"{Produto2}, cujo o preco é {preco2}");

            System.Console.WriteLine($"{idade} anos de idade, codigo {codigo} e genero {genero}");

            System.Console.WriteLine($"{media:F8}");
            System.Console.WriteLine($"{media:F3}");
            System.Console.WriteLine(media.ToString("F3",CultureInfo.InvariantCulture));

            //Exemplos
            //System.Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F1} reais", nome, idade, saldo);//PLaceHoders
            //System.Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2}reais");//interpolação
            //System.Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F1")+ " reais");//concatenação
        }
    }
}
