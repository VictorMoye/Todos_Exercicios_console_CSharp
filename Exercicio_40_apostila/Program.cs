using System;

namespace Exercicio_40_apostila
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /* Uma empresa produz três tipos de peças mecânicas: parafusos, porcas e arruelas. 
             * Têm-se os preços unitários de cada tipo de peça e sabe-se que sobre estes preços incidem descontos de 10% para porcas, 20% para parafusos e 30% para arruelas.
             * Escreva um algoritmo que calcule o valor total da compra de um cliente. Deve ser mostrado o nome do cliente. 
             * O número de cada tipo de peça que o mesmo comprou, o total de desconto e o total a pagar pela compra.*/
            Empresa x = new Empresa();

            Console.WriteLine("Antes de tudo informe os preços fixos de cada produto");
            Console.Write("Porcas: ");
            x.Preco_Porca = float.Parse(Console.ReadLine());
            Console.Write("Parafusos: ");
            x.Preco_Parafuso = float.Parse(Console.ReadLine());
            Console.Write("Arruelas: ");
            x.Preco_Arruela = float.Parse(Console.ReadLine());
            Console.WriteLine("Perfeito...");
            Console.Clear();

            Console.Write("Informe o nome do cliente: ");
            x.Nome = Console.ReadLine();

            Console.Write("Informe quantas porcas o senhor {0} comprou: ",x.Nome.ToString());
            x.Porcas = int.Parse(Console.ReadLine());
            
            Console.Write("Informe quantos parafusos o senhor {0} comprou: ", x.Nome.ToString());
            x.Parafuso = int.Parse(Console.ReadLine());
            
            Console.Write("Informe quantas arruelas o senhor {0} comprou: ", x.Nome.ToString());
            x.Arruelas = int.Parse(Console.ReadLine());

            float resp = float.Parse(x.Total);
            Console.Write("O SRº {0} Comprou {1} Arruelas, {2} Porcas, {3} Parafusos" +
                "Dando um total de R${4}", x.Nome.ToString(), x.Arruelas.ToString(), x.Porcas.ToString(), x.Parafuso.ToString());


        }
    }
}
