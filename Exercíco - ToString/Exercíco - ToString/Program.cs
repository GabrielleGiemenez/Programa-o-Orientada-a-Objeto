using System;

namespace Exercíco___ToString
{
    class Program

    static void main(string[] args)
    {
        Console.Write("Digite a cotação do dolar:")
        double cotação = double.Parse(Console.ReadLine());

        Console.WriteLine("\n Digite a quantidade de dolars que se quer comprar: ");
        double valor = double.Parse(Console.ReadLine());

        double total = Conversor.ConversorProReal(valor, cotação);
        Console.WriteLine("\n O Valor a ser pago em reais é: " + total.ToString("F2"));

    }
}
