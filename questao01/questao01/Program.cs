using System;
using System.Globalization;

class URI {

    static void Main(string[] args) {

        Console.WriteLine("Digite a nota 1: ");
        double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite a nota 2: ");
        double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double media = (nota1 + nota2) / 2;

        Console.WriteLine("A média é:  " + media.ToString("F1"));
    }

}

