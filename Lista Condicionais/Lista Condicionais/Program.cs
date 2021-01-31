using System;
using System.Xml;

namespace Lista_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CriaLinha();
            Console.WriteLine("Lista de exercicios condicionais");
            string sair = "";
            while(sair != "S")
            {
                Console.WriteLine("1- Faça um programa que receba a altura e o sexo de uma pessoa e calcule e mostre seu " +
                                           "\tpeso ideal, utilizando as seguintes formulas(H é  altura):" +
                                           "\t• Homens: (72.7 ∗ h) − 58" +
                                           "\t• Mulheres: (62, 1 ∗ h) − 44, 7 \n");

                Console.WriteLine("2- Leia um numero real. Se o numero for positivo imprima a raiz quadrada. Do contrario," +
                                   "\timprima o numero ao quadrado.\n");

                Console.WriteLine("3- Vericica se o numero é impar ou par \n");

                Console.WriteLine("4- Escreva um programa que leia um numero inteiro maior do que zero e devolva, na tela, a ´" +
                                   "\tsoma de todos os seus algarismos.Por exemplo, ao numero 251 corresponder ´ a o valor ´" +
                                   "\t8(2 + 5 + 1).Se o numero lido n ´ ao for maior do que zero, o programa terminar ˜ a com a ´" +
                                   "\tmensagem “Numero inv ´ alido \n");

                Console.WriteLine("5- . Fac¸a um programa para verificar se um determinado numero inteiro e divis ´ ´ıvel por 3 ou" +
                                    "\t5, mas nao simultaneamente pelos dois.\n ");

                Console.WriteLine("6- Determine se um determinado ano lido e bissexto\n");
                Console.WriteLine("7- Calcule as raizes da equação de segundo grau \n");
                Console.WriteLine("8- Calcula a geometia, ponderada harmonica e aritmetica");
                Console.WriteLine("9- Prova de matematica aonde mostra o quanto o aluno errou e acertou inclusive a resposta certa caso erre !!");
                Console.WriteLine("Escolha qual exercicio você quer fazer -> ");
                byte escolha = byte.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1- Faça um programa que receba a altura e o sexo de uma pessoa e calcule e mostre seu " +
                                               "peso ideal, utilizando as seguintes formulas(H é  altura):" +
                                               "• Homens: (72.7 ∗ h) − 58" +
                                               "• Mulheres: (62, 1 ∗ h) − 44, 7");
                        Console.WriteLine("Infore o sexo da pessoa [H/M] -> ");
                        string sexo = Console.ReadLine();
                        float peso, altura;
                        if (sexo.ToUpper() == "H")
                        {
                            Console.WriteLine("Informe o peso da pessoa -> ");
                            peso = float.Parse(Console.ReadLine());
                            Console.WriteLine("Informe a autura da pessoa -> ");
                            altura = float.Parse(Console.ReadLine());
                            float resp = Exercicio1(peso, altura, sexo);


                            Console.WriteLine($"O peso ideal da pessoa é {resp}");

                        }
                        else if (sexo.ToUpper() == "M")
                        {
                            Console.WriteLine("Informe o peso da pessoa -> ");
                            peso = float.Parse(Console.ReadLine());
                            Console.WriteLine("Informe a autura da pessoa -> ");
                            altura = float.Parse(Console.ReadLine());
                            float resp = Exercicio1(peso, altura, sexo);

                            Console.WriteLine($"O peso ideal da pessoa é {resp}");
                        }
                        else
                            Console.WriteLine("Sexo Invalido !!");

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Leia um numero real. Se o numero for positivo imprima a raiz quadrada. Do contrario," +
                                   "imprima o numero ao quadrado.\n");
                        Console.WriteLine("Informe um numero qualquer -> ");
                        float num = int.Parse(Console.ReadLine());
                        if (num >= 1)
                        {
                            Console.WriteLine($"A Raiz quadrada de {num} é {Math.Sqrt(num).ToString("F")}");
                        }
                        else if (num < 0)
                        {
                            Console.WriteLine($"O quadrado de {num} é {num * num}");
                        }
                        else if (num == 0)
                        {
                            Console.WriteLine($"O resultado é {num}");
                        }

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Vericica se o numero é impar ou par ");
                        Console.WriteLine("Informe um numero -> ");
                        int num1 = int.Parse(Console.ReadLine());
                        if (num1 % 2 == 0)
                            Console.WriteLine($"O número {num1} é par");
                        else
                            Console.WriteLine($"O número {num1} é par");
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Calcula a soma dos algarismo dos numeros");
                        
                        Console.WriteLine("Informe um numero qualquer -> ");
                        int numero = int.Parse(Console.ReadLine());
                        if (numero <= 0)
                        {
                            Console.WriteLine("Número invalido");
                        }
                        else
                        {
                            int Resp = soma_algoritmos(numero);
                            Console.WriteLine($"A soma de todos os algoritmos do numero {numero} é {Resp}");
                        }
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("5- . Fac¸a um programa para verificar se um determinado numero inteiro e divisıvel por 3 ou" +
                                    "\t5, mas nao simultaneamente pelos dois.\n ");
                        Console.WriteLine("Informe um numero -> ");
                        int numero_5 = int.Parse(Console.ReadLine());
                        if ((numero_5 % 3 == 0) && (numero_5 % 5 == 0))
                        {
                            Console.WriteLine($"Numero {numero_5} é divisivel por 3 e por 5");
                        }
                        else if ((numero_5 % 3 == 0) && (numero_5 % 5 >= 1))
                        {
                            Console.WriteLine($"Numero {numero_5} é divisivel apenas por 3  ");
                        }
                        else if ((numero_5 % 5 == 0) && (numero_5 % 3 >= 1))
                        {
                            Console.WriteLine($"Numero {numero_5} é divisivel apenas por 5  ");
                        }
                        else
                            Console.WriteLine("Numero invalido !! ");

                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("Determine se um determinado ano lido e bissexto");
                        Console.WriteLine("Informe um ano !!");
                        int ano = int.Parse(Console.ReadLine());
                        if((ano % 4 ==0) && (ano % 100 !=0))
                            Console.WriteLine($"O ano {ano} é bissexto");
                        else
                            Console.WriteLine($"O ano {ano} não é bissexto");
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("Calcule as raizes da equação de segundo grau");
                        Console.WriteLine("Informe A ->");
                        int a = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe B ->");
                        int b = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe C ->");
                        int c = int.Parse(Console.ReadLine());

                        double delta = Math.Pow(b, 2) - (4 * a * c);
                        if(delta < 0)
                        {
                            Console.WriteLine("Não existe raiz ");
                            Console.WriteLine($"{delta}"); 
                        }else if(delta == 0)
                        {
                            Console.WriteLine("Exit uma raiz real ");
                            Console.WriteLine($"Raiz única {delta}");
                        }else if(delta > 0)
                        {
                            double raiz_delta = Math.Sqrt(delta);
                            double x1, x2;
                            x1 = ((-(b)) + raiz_delta) / (2 * a);
                            x2 = ((-(b)) - raiz_delta) / (2 * a);

                            Console.WriteLine("As duas raizes reais");
                            Console.WriteLine($"Valor de +X : {Math.Round(x1, 2)}");
                            Console.WriteLine($"Valor de -X : {Math.Round(x1, 2)}");
                        }
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Informe um numero ->");
                        int num1_exercicio8= int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe outro numero ->");
                        int num2_exercicio8 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe outro numero ->");
                        int num3_exercicio8 = int.Parse(Console.ReadLine());

                        Console.WriteLine("'Escolhar qual pção voce quer ver '");
                        Console.WriteLine("1 -Geometria 2- ponderado 3- harmonico 4-aritimetica");
                        byte escolhar = byte.Parse(Console.ReadLine());
                        if(escolhar == 1)
                        {
                            float geometria = Geometria(num1_exercicio8, num2_exercicio8, num3_exercicio8);
                            Console.WriteLine($"O valor da Geometira é {geometria}");
                            Console.WriteLine($"{Math.Pow((num1_exercicio8 * num2_exercicio8 * num3_exercicio8), 1.0 / 3.0)}");
                        }
                        else if(escolhar == 2)
                        {
                            float ponderado = Ponderado(num1_exercicio8, num2_exercicio8, num3_exercicio8);
                            Console.WriteLine($"O valor de ponderado é {ponderado}");
                        }
                        else if(escolhar == 3)
                        {
                            float Harmonico = harmonico(num1_exercicio8, num2_exercicio8, num3_exercicio8);
                            Console.WriteLine($"O valor da Geometira é {Harmonico}");
                        }
                        else if(escolhar == 4)
                        {
                            float Aritimetica = aritimetica(num1_exercicio8, num2_exercicio8, num3_exercicio8);
                            Console.WriteLine($"O valor da Geometira é {Aritimetica}");
                        }                             
                        else
                            Console.WriteLine("Valor invalido !!");
                        break;

                    case 9:
                        Console.Clear();
                        int cont = 0, acertou = 0, errou = 0;
                        while (cont < 5)
                        {
                            int quest_1 =0, quest_1_1 =0;
                            Random random = new Random();
                            quest_1 = random.Next(0, 100);
                            quest_1_1 = random.Next(0, 100);
                            
                            Console.WriteLine("Qual a resposta certa ? ");
                            Console.WriteLine($"{quest_1} + {quest_1_1} = ");
                            int res = int.Parse(Console.ReadLine());
                            if (res == (quest_1 + quest_1_1))
                            {
                                Console.WriteLine($"Voce acertou {quest_1} + {quest_1_1} = {quest_1 + quest_1_1}");
                                acertou += 1;
                            }
                            else
                            {
                                Console.WriteLine($"Voce errou  !!\n" +
                                    $"Sua resposta foi {res}\n" +
                                    $"{quest_1} + {quest_1_1} = {quest_1 + quest_1_1}");
                                errou += 1;
                            }
                            cont += 1;
                            CriaLinha(); 
                            
                        }
                        Console.WriteLine($"Voce acertou {acertou} vezes\n" +
                                $"E errou {errou} vezes ");
                        break;
                }
                Console.WriteLine("Você quer fechar o programa [N/S] ? ");
                sair = Console.ReadLine().ToUpper();
                Console.Clear(); 
            }

        }
        static void CriaLinha()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=");
        }
        // Exercicio 1 calculando o peso da pesoa e o IMC 
        static float Exercicio1(float peso, float altura, string sexo)
        {
            
            if(sexo == "M")
            {
                float resp = (float)((72.7 * altura) - 58);
                return resp; 
            }
            else
            {
                float resp = (float)((62.1 * altura) - 44.7);
                return resp; ; 
            }

        }
        
        //Soma os algoritmos dos numeros 
        static int soma_algoritmos(int numero)
        {
            int soma = 0 ; 
            while (numero > 0)
            {
               soma += (numero % 10);
                numero /= 10;                

            }
            return soma; 
        }

        static float Geometria(float num1, float num2, float num3)
        {
            float bruto_8 = num1 * num2 * num3;
            float geometrica = (float) Math.Pow(bruto_8, 1.0 / 3.0);
            return geometrica; 
        }
        static float Ponderado(float num1, float num2, float num3)
        {
            float ponderador = (num1 +2 * num2 + 3 * num3 )/ 6;
            return ponderador; 
        }
        static float harmonico(float num1, float num2, float num3)
        {
            float harmonicor = 1 / 1 / num1 + 1 / num2 + 1 / num3;
            return harmonicor; 
        }
        static float aritimetica(float num1, float num2, float num3)
        {
            float aritimeticas = (num1 + num2 + num3 )/ 3;
            return aritimeticas; 
        }

        static int Numeros_aletorios(int num1, int num2)
        {
            Random random = new Random();
            return random.Next(0, 100);
        }

    }
}
