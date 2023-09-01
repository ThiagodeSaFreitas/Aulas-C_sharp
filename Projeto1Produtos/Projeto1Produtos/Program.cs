using Projeto1Produtos;
using System;
using System.Globalization;

namespace Course {
    internal class Program {
        static void Main(string[] args) {
            
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("_____________________________________________________________");
            Console.Write("Digite o número de produtos que será adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine("_____________________________________________________________");
            Console.Write("Digite o número de produtos que será removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
