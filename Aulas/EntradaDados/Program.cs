using System;
using System.Globalization;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, nomeCompleto;
            int    qtde, idade;
            double preco, altura;
            

            Console.WriteLine("Entre com seu nome completo:");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa:");
            qtde = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com o seu ultomo nome, idade e altura(mesma linha): ");
            string[] info = Console.ReadLine().Split(" ");
            nomeCompleto = info[0];
            idade = int.Parse(info[1]);
            altura = double.Parse(info[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(nome);
            Console.WriteLine(qtde);
            Console.WriteLine(preco);
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

        }
    }
}
