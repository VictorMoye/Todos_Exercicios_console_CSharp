using System;

namespace ProjetoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Retangulo x = new Retangulo();

            Console.Write("Informe a largura do retangulo: ");
            x.Largura = int.Parse(Console.ReadLine());

            Console.Write("/n Informe a Altura do retangulo: ");
            x.Altura = int.Parse(Console.ReadLine());

            Console.Write("Area = {0}", x.Area());
            Console.WriteLine("Perimetro = {0}", x.Perimetro());
            Console.WriteLine("Diagonal = {0}", x.Diadonal());
        }
    }
}
