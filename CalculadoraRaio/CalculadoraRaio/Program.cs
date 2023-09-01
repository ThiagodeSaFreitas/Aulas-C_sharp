// See https://aka.ms/new-console-template for more information
using CalculadoraRaio;
using System.Globalization;

Console.WriteLine("Entre com o valor do raio: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double circ = Calculadora.Circunferencia(raio);
double vol = Calculadora.Volume(raio);

Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));



