using System;
using System.Globalization;

class URI {

    static void Main(string[] args) {

        
        Console.WriteLine("Digite a temperatura em Celsius ");
        double temperaturaCelsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        
        double conversaoF = (9*temperaturaCelsius+160)/5;
        

        Console.WriteLine("A temperatura em Fahrenheit é " + conversaoF.ToString("F1"));
    }

}
