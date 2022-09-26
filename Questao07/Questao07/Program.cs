using System;
using System.Globalization;

class URI {

    static void Main(string[] args) {

        Console.WriteLine();
        string numeroVendedor = Console.ReadLine();

        Console.WriteLine();
        double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        double totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double percentual = totalVendas * 0.18;
        double soma = salarioFixo + percentual;

        Console.WriteLine(numeroVendedor + "salário total = R$ " + soma.ToString("F2"));
    }

}
