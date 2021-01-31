using System;

namespace Comandos_de_repetições
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string resp = "";
            CriarLinha();
            Console.WriteLine("Seja bem vindo aos exercicios de repetições !!");
            while(resp != "S")
            {
                Console.WriteLine("1- Fac¸a um programa que determine o mostre os cinco primeiros multiplos de 3, considerando numeros maiores que 0 \n");
                Console.WriteLine("2- Programa que calcula os multiplos de qualquer numero \n");
                Console.WriteLine("3- Escreva um programa que escreva na tela, de 1 ate 100, de 1 em 1, 2 vezes. A primeira " +
                                    " vez deve usar a estrutura de repetic¸ao˜ for e a segunda while regredindo ate 0 \n");
                Console.WriteLine("4- Fac¸a um programa que pec¸a ao usuario para digitar 10 valores e some-os.\n");
                Console.WriteLine("5- Fac¸a um programa que leia 10 inteiros e imprima sua media\n");
                Console.WriteLine("6- Fac¸a um programa que leia 10 inteiros positivos, ignorando nao positivos, e imprima sua media \n");
                Console.WriteLine("7- Escreva um programa que leia 10 numeros e escreva o menor valor lido e o maior valor lido. \n");
                Console.WriteLine("8- Fac¸a um programa que leia um numero inteiro ´ N e depois imprima os N primeiros numeros naturais ´ ´ımpares.\n");
                Console.WriteLine("9- Fac¸a um programa que leia um numero inteiro positivo ´ n e calcule a soma dos n primeiros numeros naturais\n");
                Console.WriteLine("10- Escreva um algoritmo que leia certa quantidade de numeros e imprima o maior deles e ´"+
                                       "quantas vezes o maior numero foi lido.A quantidade de n ´ umeros a serem lidos deve ser ´" +
                                       "fornecida pelo usuario.\n");
                //Pintar o 11 de ver melhor pois ja tem exerciios de condicionais feitos so pra isso !! 
                Console.BackgroundColor = ConsoleColor.Red; 
                Console.WriteLine("11- Soma os algoritmos de qualquer numero\n ");
                Console.ResetColor();
                Console.WriteLine("12- Fac¸a um programa que receba dois numeros. Calcule e mostre:" +
                                    "• a soma dos numeros pares desse intervalo de n ´ umeros, incluindo os n ´ umeros digi - ´tados;"+
                                    "• a multiplicac¸ao dos n ˜ umeros ´ ´ımpares desse intervalo, incluindo os digitados");
                Console.WriteLine("13- . Faca um algoritmo que leia um numero positivo e imprima seus divisores");
                Console.WriteLine("14- Escreva um programa que leia um numero inteiro e calcule a soma de todos os divisores ´ " +
                                    "desse numero, com excec¸ ´ ao dele pr ˜ oprio.Ex: a soma dos divisores do n ´ umero 66 ´ e´" +
                                   " 1 + 2 + 3 + 6 + 11 + 22 + 33 = 78");
                Console.WriteLine("Qual programa voce quer ver em ação");
                byte escolha = byte.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Fac¸a um programa que determine o mostre os cinco primeiros multiplos de 3, considerando numeros maiores que 0 \n");
                        int cont = 1;
                        while (cont < 6)
                        {
                            Console.WriteLine($"Os multiplos de 3 são {3 * cont}");
                            cont += 1;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Programa que calcula os multiplos de qualquer numero \n");
                        Console.WriteLine("Qual multiplos voce quer saber ?");
                        int multiplo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ate quanto ? ");
                        int qtd = int.Parse(Console.ReadLine());
                        int cont2 = 1;
                        while (cont2 < (qtd + 1))
                        {
                            Console.WriteLine($"Os  multiplos de {multiplo} são {multiplo * cont2}");
                            cont2 += 1;
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Faça um laço que vai de um ate 100 e de 100 ate um usando while e for ");
                        byte cont3 = 0;
                        while (cont3 <= 100)
                        {
                            Console.WriteLine($"{cont3}");
                            cont3 += 1;
                        }
                        Console.WriteLine("Regredindo !!");
                        CriarLinha();
                        for (int i = cont3; i > 1; i--)
                        {
                            Console.WriteLine($"{i}");
                        }
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Fac¸a um programa que pec¸a ao usuario para digitar 10 valores e some-os.");
                        int soma = 0;
                        for (byte i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Informe um numero ");
                            int num = int.Parse(Console.ReadLine());
                            soma += num;
                        }
                        Console.WriteLine($"A soma de todos os numeros é {soma}");
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Fac¸a um programa que leia 10 inteiros e imprima sua media");
                        int cont5 = 0, soma5 = 0;
                        while (cont5 < 10)
                        {
                            Console.WriteLine("Informe um numero qualquer - > ");
                            int num2 = int.Parse(Console.ReadLine());
                            soma5 += num2;
                            cont5 += 1;
                        }
                        Console.WriteLine($"A media dos numeros é {soma5 / cont5}");
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Fac¸a um programa que leia 10 inteiros positivos, ignorando nao positivos, e imprima sua media");
                        int cont6 = 0, soma6 = 0;
                        while (cont6 < 10)
                        {
                            Console.WriteLine("Informe um numero -> ");
                            int num6 = int.Parse(Console.ReadLine());
                            if (num6 >= 0)
                                num6 -= 0;
                            soma6 += num6;
                            cont6 += 1;
                        }
                        Console.WriteLine($"A media dos numeros é {soma6 / cont6}");
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Escreva um programa que leia 10 numeros e escreva o menor valor lido e o maior valor lido.");
                        int menor = 0, maior = 0, cont7 = 0;
                        while (cont7 < 5)
                        {
                            Console.WriteLine("Informe um numero -> ");
                            int num7 = int.Parse(Console.ReadLine());
                            if (cont7 == 1)
                            {
                                menor = num7;
                                maior = num7;
                            }
                            else
                            {
                                if (num7 > maior)
                                    maior = num7;
                                if (num7 < menor)
                                    menor = num7;
                            }
                            cont7 += 1;
                        }
                        Console.WriteLine($"O maior numero digitado foi {maior}\n" +
                            $"E o menor numero é {menor}");
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Fac¸a um programa que leia um numero inteiro ´ N e depois imprima os N primeiros numeros naturais ´ ´ımpares.");
                        Console.WriteLine("Informe um numero -> ");
                        int num8 = int.Parse(Console.ReadLine());
                        int cont8 = num8 / 2;
                        double[] numeros_par = new double[cont8];
                        double[] numeros_impar = new double[cont8];

                        for (int i = 0; i < num8; i++)
                        {
                            if (i % 2 == 0)
                            {
                                numeros_par[i / 2] = i;
                            }
                            else
                            {
                                numeros_impar[i / 2] = i;
                            }
                        }
                        for (int i = 0; i < cont8; i++)
                            Console.WriteLine($"Os números pares são -> {numeros_par[i]}");
                        Console.WriteLine("\n");
                        for (int i = 0; i < cont8; i++)
                            Console.WriteLine($"Os números impares são -> {numeros_impar[i]}");
                        CriarLinha();
                        Console.WriteLine("Imprimindo os vetores de ordem inversa ");
                        int x = 1, y = cont8;
                        while (x <= cont8)
                        {
                            Console.WriteLine($"Os números impares são -> {numeros_impar[cont8 - 1]}");
                            cont8 -= 1;
                        }
                        Console.WriteLine("\n");
                        while (x <= y)
                        {
                            Console.WriteLine($"Os números pares são -> {numeros_par[y - 1]}");
                            y -= 1;
                        }
                        break;

                    case 9:
                        Console.Clear();
                        Console.WriteLine(". Fac¸a um programa que leia um numero inteiro positivo ´ n e calcule a soma dos n primeiros numeros naturais");
                        Console.WriteLine("Informe um numero -> ");
                        int num9 = int.Parse(Console.ReadLine());
                        int cont9 = 0, soma9 = 0;
                        while (cont9 <= num9)
                        {
                            soma9 += cont9;
                            cont9 += 1;
                        }
                        Console.WriteLine($"A soma de 0 até {num9} é = {soma9}");
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("10- Escreva um algoritmo que leia certa quantidade de numeros e imprima o maior deles e ´" +
                                       "quantas vezes o maior numero foi lido.A quantidade de n ´ umeros a serem lidos deve ser ´" +
                                       "fornecida pelo usuario.");
                        Console.WriteLine("Informe quantos numeros voce quer testar -> ");
                        int num10 = int.Parse(Console.ReadLine());
                        int menor10 = 0, maior10 = 0, ContMen = 0, ContMai = 0;
                        int[] vetor10 = new int[num10];
                        for (int i = 0; i < num10; i++)
                        {
                            Console.WriteLine("Informe um numero -> ");
                            int aux10 = int.Parse(Console.ReadLine());
                            vetor10[i] = aux10;
                            if (i == 0)
                            {
                                menor10 = maior10 = vetor10[i];
                            }
                            else
                            {
                                if (maior10 < aux10)
                                    maior10 = vetor10[i];
                                if (menor10 > aux10)
                                    menor10 = vetor10[i];
                            }

                        }
                        for (int x10 = 0; x10 < num10; x10++)
                        {
                            if (vetor10[x10] == menor10)
                                ContMen += 1;
                            if (vetor10[x10] == maior10)
                                ContMai += 1;
                        }
                        Console.WriteLine($"O Maior número foi {maior10} digitado {ContMai} vezes \n" +
                                          $"O Menor número foi {menor10} digitado {ContMen} vezes");
                        break;
                    case 11:
                        Console.Clear();
                        //fazer um chamado pra condicionais pq lá tem o mesmo exercicios 
                        break;
                    case 12:
                        Console.Clear();
                        Console.WriteLine("12- Fac¸a um programa que receba dois numeros. Calcule e mostre:" +
                                    "• a soma dos numeros pares desse intervalo de n ´ umeros, incluindo os n ´ umeros digi - ´tados;" +
                                    "• a multiplicac¸ao dos n ˜ umeros ´ ´ımpares desse intervalo, incluindo os digitados");
                        Console.WriteLine("Informe um numero -> ");
                        int num12 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe outro numero maior que o primeiro -> ");
                        int num12_2 = int.Parse(Console.ReadLine());
                        int aux12 = 0, auxmult12 = 1;
                        Console.WriteLine($"A diferença entre os numeros {num12} e {num12_2} é { num12_2 - num12}\n");
                        if (num12_2 > num12 || num12_2 == num12)
                            Console.WriteLine($"Invalido {num12} é maior ou igual a {num12} por tando a esposta é zero !!");
                        else { 
                                while (num12 <= num12_2)
                                {
                                    if (num12 % 2 == 0)
                                    {
                                        aux12 += num12;
                                        Console.WriteLine($"{num12} par -> aux ->{aux12}");
                                    }
                                    else if (num12 % 2 == 1)
                                    {
                                        auxmult12 *= num12;
                                        Console.WriteLine($"{num12} impar -> aux ->{auxmult12}");
                                    }
                                    num12 += 1;
                                }
                                Console.WriteLine($"A soma de todos os numeros pares contidos nessa diferença é {aux12} \n " +
                                    $"A multiplicação contida nos numeros impares dentro da diferença é {auxmult12}");
                }
                        break;
                    case 13:
                        Console.Clear();
                        Console.WriteLine("Faca um algoritmo que leia um numero positivo e imprima seus divisores");
                        Console.WriteLine("Informe outro numero maior que o primeiro -> ");
                        int num13 = int.Parse(Console.ReadLine());
                        int cont13 = 0;
                        cont13 = Divisores(num13);
                        Console.WriteLine(cont13);
                        break;

                    case 14:
                        Console.Clear();
                        Console.WriteLine("14- Escreva um programa que leia um numero inteiro e calcule a soma de todos os divisores ´ " +
                                    "desse numero, com excec¸ ´ ao dele pr ˜ oprio.Ex: a soma dos divisores do n ´ umero 66 ´ e´" +
                                   " 1 + 2 + 3 + 6 + 11 + 22 + 33 = 78");
                        Console.WriteLine("Informe um numero ->  ");
                        int num14 = int.Parse(Console.ReadLine());
                        int aux14 = Divisores(num14);
                        int cont14 = 1,somadiv = 0;
                        while (cont14 <= num14)
                        {
                            if(num14 % cont14  == 0)
                            {
                                somadiv += cont14;
                            }
                            cont14 += 1;
                        }
                        Console.WriteLine($"Soma dos divisores {somadiv}");
                        Console.WriteLine($"aux -> {aux14}");
                        break;
                }











                Console.WriteLine("Voce quer sair do programa [S/N] ? ");
                resp = Console.ReadLine().ToUpper();
            }
        }
        static void CriarLinha()
        {
            Console.WriteLine("=-=-=-=-=-=-=-");
        }
        static int Divisores(int num)
        {
            for (int i = 1;i < num / 2 + 1; i++)
            {
                if (num % i == 0)
                    Console.WriteLine(i); 
            
            }
            return num; 
                
        }
        

        
    }
}
