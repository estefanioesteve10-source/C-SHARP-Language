/*
   Escreva um programa em C# que leia os valores de a, b e c de uma equação do segundo grau (ax² + bx + c = 0) e calcule as raízes reais da equação utilizando a fórmula de Bhaskara. 
   O programa deve verificar se as raízes são reais ou complexas e exibir o resultado apropriado.
*/
using System;

class Program
{
    static double Quadrado(double x)
    {
        return x * x;
    }

    static void Main()
    {
        Console.Write("Qual é o valor de a? ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Qual é o valor de b? ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Qual é o valor de c? ");
        double c = double.Parse(Console.ReadLine());

        double delta = Quadrado(b) - 4 * a * c;

        if (delta < 0)
        {
            Console.WriteLine("A equação não possui raízes reais.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"A equação possui uma raiz real: X é {x:F2}");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"X1 é {x1:F2}");
            Console.WriteLine($"X2 é {x2:F2}");
        }
    }
}