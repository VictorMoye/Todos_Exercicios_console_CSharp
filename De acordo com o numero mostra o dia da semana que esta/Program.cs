using System;

namespace Construa_um_algoritmo_que_leia_um_número_inteiro_de_1_a_7_e_informe_o_dia_da_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("algoritmo que leia um número inteiro de 1 a 7 e informe o dia da " +
                                "semana correspondente, sendo domingo o dia de número 1.Se o número não" +
                                    "corresponder a um dia da semana, mostre uma mensagem de erro. ");
            Console.WriteLine("Informe o dia da semana");
            int dia = int.Parse(Console.ReadLine());
            if (dia <= 0 || dia >= 8)
            {

                Console.WriteLine("Dia invalidos eles preciasam ser entre 1 e 7");
            }            
            else
            {
                switch (dia)
                {
                    case 1:
                        Console.WriteLine("O dia {0} referesse a DOMINGO ", dia);
                        break;
                    case 2:
                        Console.WriteLine("O dia {0} referesse a Segunda ", dia);
                        break;
                    case 3:
                        Console.WriteLine("O dia {0} referesse a Terça ", dia);
                        break;
                    case 4:
                        Console.WriteLine("O dia {0} referesse a Quarta ", dia);
                        break;
                    case 5:
                        Console.WriteLine("O dia {0} referesse a Quinta ", dia);
                        break;
                    case 6:
                        Console.WriteLine("O dia {0} referesse a Sexta ", dia);
                        break;
                    case 7:
                        Console.WriteLine("O dia {0} referesse a Sabado ", dia);
                        break;
                }

            }

        }
    }
}
