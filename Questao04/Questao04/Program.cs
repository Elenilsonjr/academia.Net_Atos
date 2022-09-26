using System;
using System.Globalization;

class URI {

    static void Main(string[] args) {

        Console.WriteLine("Digite dia: ");
        int dia = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o mês: ");
        int mes = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o ano: ");
        int ano = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        var dataFormatada = new DateTime(ano, mes, dia);


        Console.WriteLine(dataFormatada.ToString("yyyy/MM/dd"));
        Console.WriteLine(dataFormatada.ToString("yy/MM/dd"));
    }

}
