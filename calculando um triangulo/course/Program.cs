using System;
using System.Globalization;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo(); 
            Console.WriteLine("Hello World!");

            Console.WriteLine("Informe os parametros do Triangulo: ");
            x.A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o parametro do outro triangulo: "); 
            y.A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Double areaX = x.Area();
            Double areaY = y.Area();

            Console.WriteLine("Area X = {0}", areaX.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("Area Y = {0}", areaY.ToString("F4",CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("Area X {0} maior que Area Y {1}", areaX, areaY);
            } else
                Console.WriteLine("Area Y {0} maior que Area X {1}", areaX, areaY);

        }
    }
}
