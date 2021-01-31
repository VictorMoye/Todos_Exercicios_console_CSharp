using System;
using System.Globalization;
namespace Projeto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto x = new Produto();
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("Informe o nome do produto: ");
            x.Nome = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto: ");
            x.preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade no estoque: ");
            x.quantidade = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Dados do produto: {0}", x);
           
            Console.WriteLine("Digite o Número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            x.AdicionarProdutos(qte);
           
            Console.WriteLine("Dados atualizados: {0}", x);
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            x.RemoverProdutos(qte);
            
            Console.WriteLine("Dados atualizados: {0}", x.ToString());
        }

    }
}
