using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRetangulo
{
    class Retangulo
    {
        public double Largura;
        public double Altura; 

        public double Area()
        {
            return Largura * Altura; 
        }
        public double Perimetro()
        {
          return  2 * (Largura * Altura);
        }
        public double Diadonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
