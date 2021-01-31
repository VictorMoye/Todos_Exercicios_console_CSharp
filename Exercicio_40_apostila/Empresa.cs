using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_40_apostila
{
    class Empresa
    {
        public float Preco_Parafuso;
        public float Preco_Porca;
        public float Preco_Arruela;

        public int Parafuso;
        public int Porcas;
        
        public int Arruelas;
        public string Nome;

        public float Total()
        {
            /* Uma empresa produz três tipos de peças mecânicas: parafusos, porcas e arruelas. 
             * Têm-se os preços unitários de cada tipo de peça e sabe-se que sobre estes preços incidem descontos de 10% para porcas, 20% para parafusos e 30% para arruelas.
             * Escreva um algoritmo que calcule o valor total da compra de um cliente. Deve ser mostrado o nome do cliente. 
             * O número de cada tipo de peça que o mesmo comprou, o total de desconto e o total a pagar pela compra.*/
            float total;
            total = (Preco_Parafuso * 20 / 100) + (Preco_Porca * 10 /100) + (Preco_Arruela * 30 / 100);
            return total;
        }
    }
}
