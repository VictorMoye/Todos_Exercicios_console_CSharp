using System;

namespace menbrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine("Hello World!");
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            double Circ = calc.Circuferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circuferencia: {0}", Circ.ToString());
            Console.WriteLine("Volume: {0}", volume.ToString());
            Console.WriteLine("Valor de PI: {0}", calc.Pi.ToString()); 
        }

        

    }
}
