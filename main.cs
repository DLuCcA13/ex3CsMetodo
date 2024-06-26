/* Crie um método chamado Somar que receba dois inteiros como parâmetros e retorne a soma desses dois números. */
using System;

class Program
{
    static int Somar(int n1Soma, int n2Soma)
    {
        return n1Soma + n2Soma;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número");
        int n2 = int.Parse(Console.ReadLine());
        int resultado = Somar(n1, n2);
        Console.WriteLine("O resultado da soma foi de " + resultado);
    }
}