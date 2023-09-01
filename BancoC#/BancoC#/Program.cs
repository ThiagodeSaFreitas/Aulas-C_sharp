// See https://aka.ms/new-console-template for more information
using BancoC_;
using System.Globalization;

ContaBancaria conta;

Console.Write("Entre com o número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Entre com o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? ");
char resposta = char.Parse(Console.ReadLine());
if (resposta == 's' || resposta == 'S') {
    Console.WriteLine("Entre com o valor de depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new ContaBancaria(numero, titular, depositoInicial);
} else {
    conta = new ContaBancaria(numero, titular);
}

Console.WriteLine();
Console.WriteLine("Dados da conta: " + conta);

Console.WriteLine();
Console.WriteLine("Entre com o valor do depósito: ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(quantia);
Console.WriteLine("Dados atuaizados:");
Console.WriteLine(conta);


Console.WriteLine();
Console.WriteLine("Entre com o valor do Saque: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(quantia);
Console.WriteLine("Dados atuaizados:");
Console.WriteLine(conta);

