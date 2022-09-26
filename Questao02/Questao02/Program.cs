using System;
using System.Globalization;

class URI {

    static void Main(string[] args) {

        Console.WriteLine("Digite o número 1: ");
        double numero1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o número 2: ");
        double numero2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o número 3: ");
        double numero3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o número 4: ");
        double numero4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        double mediaAritmetica = (numero1+numero2+numero3+numero4) / 4;

        Console.WriteLine("A média é:  " + mediaAritmetica.ToString("F1"));
    }

}
