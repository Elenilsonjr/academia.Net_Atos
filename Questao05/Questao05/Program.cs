using System;
using System.Globalization;



//Escreva um programa em C# e no Visual Studio para calcular
//o consumo médio de um automóvel 
//(medido em Km/l), sendo que são conhecidos a distância
//total percorrida e o volume de combustível 
//consumido para percorrê-la (medido em l).

class URI {

    static void Main(string[] args) {

        double distanciaTotal = 45;

        double combustivelGasto = 150;

        double mediaConsumo = distanciaTotal / combustivelGasto;

        Console.WriteLine("A média de consumo é:  " + mediaConsumo.ToString("F1"));
    }

}
