using System;
using System.Dynamic;

namespace mesmos_exercicios_de_python_escrito_em_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string resp = "";
            while (resp != "s")
            {
                Console.WriteLine("1- Exercicios de Condicionais");
                Console.WriteLine("2- Exercicios de laços de repetição");
                Console.WriteLine("Qual desses você quer fazer ? ");
                Byte exercicios = byte.Parse(Console.ReadLine());
                switch (exercicios)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Seja bem vindo ao exercicios de condiiconais ");
                        CriarLinha();
                        Enuciado_Condicional();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Seja bem vindo ao exercicios de Repetições e Loops ");
                        CriarLinha();
                        Enuciado_Repeticoes();
                        break;
                }
                Console.WriteLine("Voce quer sair do programa [S/N]? ");
                resp = Console.ReadLine();
            }

        }        
        static void CriarLinha()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-");
        }
        //Enuciado dos exercicios de condicionais 
        static int Enuciado_Condicional()
        {
            Console.WriteLine("1- Mostra o maior numero entre eles ");
            Console.WriteLine("2- Se for positivo informa a raiz quadrada e se for negativo dizer que é invalido");
            Console.WriteLine("3- Receba a altura e o sexo de uma pessoa e calcule o peso ideal e usando a seguinte formula" +
                                "\thomens = (72.7 * h) - 58 " +
                                "\tmulheres = (62.1 * h) - 44, 7 " +
                                " \th == altura ");
            Console.WriteLine("4- Lendo uma velocidade em m/s e convertendo em k/m e o inverso tambem ");

            Console.WriteLine("Qual programa voce quer fazer ?");

            int escolha = int.Parse(Console.ReadLine());
            return Lista_De_Exercicios(escolha) ;

        }

        //Os exercicios escolhidos 
        static int Lista_De_Exercicios(int exercicio)
        {
            switch (exercicio)
            {
                case 1:
                    Exercicio_01();
                    Console.Clear();
                    break;
                case 2:
                    Exxercicio_02();
                    Console.Clear();
                    break;
                case 3:
                    Exercicio_03();
                    Console.Clear();
                    break;
                case 4:
                    Exercicio_04();
                    Console.Clear();
                    break;


            }
            return exercicio;

        }

        //Exercicio 2 se for positivo informa a raiz quadrada e se for negativo dizer que é invalido
        static void Exxercicio_02()
        {
            Console.WriteLine("Informe um numero: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = Convert.ToInt32(Math.Sqrt(num1));
            if (num1 >= 1)
            {
                Console.WriteLine($"A raiz quadrada de {num1} é {num2}");
            }
            else
            Console.WriteLine("Numero invalido");
        }
        static int Maior(int numA, int numB,int numC)
        {
            int maior;
            if (numA > numB && numA > numB) {
                maior = numA;
            }
            else if (numB > numC)
            {
                maior = numB;
            }
            else
                maior = numC;

            return maior;
        }
        //Mostra o maior numero entre eles 
        static void Exercicio_01()
        {
            int num1, num2, num3;
            Console.WriteLine("Informe o numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe outro numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe outro numero");
            num3 = int.Parse(Console.ReadLine());

            int resultado = Maior(num1, num2, num3);

            Console.WriteLine("Resultado = " + resultado);
        }

        static void Exercicio_03()
        {
            Double altura;
            Console.WriteLine("Informe a altura da pessoa: ");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Favor responder só com H/M o sexo da pessoa: ");
            string resp = Console.ReadLine();
            if(resp == "H")
            {
                Double pesoideal = IdealHomem(altura);
                Console.WriteLine($"O peso ideal do homem é {pesoideal}");
            }
            else
            {                
                Double pesoideal = IdealMulher(altura);
                Console.WriteLine($"O peso ideal da mulher é {pesoideal}");
            }
        }
        static Double IdealHomem( Double alturaH)
        {
            Double homens = (double)(72.7 * alturaH) - 58;
            return homens;
        }
        static Double IdealMulher(double alturaM)
        {
            Double mulher =  (62.1 * alturaM) - 44.7;
            return mulher;
        }
        static void Exercicio_04()
        {
            Console.WriteLine("Voce deseja receber sua velocidade em \nM/S, metros por segundo: Digite 1 \nOU \nK/M kilometros por hora: Digite 2");
            byte resp = byte.Parse(Console.ReadLine());
            if(resp == 1)
            {
                Console.WriteLine("Digite a sua velocidade Kilometros pro hora: ");
                float velocidade = float.Parse(Console.ReadLine());
                Double velocidade2 = velocidade / 3.6;
                Console.WriteLine($"Sua velocidade é {velocidade}K/M  e conertidad  é {velocidade2} M/S");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Digite a sua velocidade Metros por segundo: ");
                float velocidade = float.Parse(Console.ReadLine());
                double velocidade2 = velocidade * 3.6;
                Console.WriteLine($"Sua velocidade é {velocidade}K/M  e conertidad  é {velocidade2} M/S");
                Console.ReadKey();
            }
        }

        //Exercicios de repetições a parti daqui

        static int Enuciado_Repeticoes()
        {
            Console.WriteLine("1- Calcula os multiplos de qualquer numero");
            Console.WriteLine("2- Imprimir os numeros de 1 a 100");
            Console.WriteLine("3- Contagem de expoente ate o numero que voce quer ver");
            Console.WriteLine("4- Contagem regressiva começando de onde voce quiser indo ate 0 zero");
            Console.WriteLine("5- Digite 5 valores e some eles");
            Console.WriteLine("6- Programa que ler 10 numeros e entrega a media e mediana e media harmonica dos numeros // Melhorar esse meu codigo quando entender de mediana e vetores em c#");
            Console.WriteLine("7- Programa que mostra o maior e o menor numero lido");
            Console.WriteLine("8- Programa que ler um numero N e imprimi os 3 primeiros numeros naturais impares");
            Console.WriteLine("9- Programa que calcula os 50 primeiros numeros pares");
            Console.WriteLine("10-Imprimi todos os numeros naturais de 0 a N em ordem crescente e decrescente");
            Console.WriteLine("11-Algoitmo que mostra todos os numeros pares de 0 ate N e mostre eles em ordem crescente e decrescente");
            Console.WriteLine("\n\nEscolha qual exercicios voce quer fazer? ");
            byte escolha = byte.Parse(Console.ReadLine());
            return Exercicios_Escolhido_Loops(escolha);
        }

        //Exercicios escolhidos Loops
        static int Exercicios_Escolhido_Loops(int exercicio)
        {
            switch (exercicio)
            {
                case 1:
                    Exercicio_Loop_1();
                    Console.Clear();
                    break;
                case 2:
                    Exercicio_Loop_2();
                    Console.Clear();
                    break;
                case 3:
                    Exercicio_Loop_3();
                    Console.Clear();
                    break;
                case 4:
                    Exercicio_Loop_4();
                    Console.Clear();
                    break;
                case 5:
                    Exercicio_Loop_5();
                    Console.Clear();
                    break;
                case 6:
                    Exercicio_Loop_6();
                    Console.Clear();
                    break;
                case 7:
                    Exercicio_Loop_7();
                    Console.Clear();
                    break;
                case 8:
                    Exercicio_Loop_8();
                    Console.Clear();
                    break;
                case 9:
                    Exercicio_Loop_9();
                    Console.Clear();
                    break;
                case 10:
                    Exercicio_Loop_10();
                    Console.Clear();
                    break;
                case 11:
                    Exercicio_Loop_11();
                    Console.Clear();
                    break;
            }
            return exercicio;
        }
        //Descobridno os multiplos dos numeros
        static void Exercicio_Loop_1()
        {
            Console.WriteLine("Informe um numero qualquer saber os multiplos: ");
            int mult , qtd;
            mult =int.Parse(Console.ReadLine());
            Console.WriteLine("Até quanto: ");
            qtd = int.Parse(Console.ReadLine());
            for (int i =0; i <= qtd; i +=mult )
            {
                Console.WriteLine(i);
            }
            
            Console.ReadKey();
        }

        //Imprimnir numeros de 1 a 100
        static void Exercicio_Loop_2()
        {
            Console.WriteLine("\n");
            int cont = 0;
            while (cont <= 100)
            {
                Console.WriteLine(cont);
                cont += 1;
            }
            Console.ReadKey();
        }

        //Contagem de expoente ate o numer oque voce quer ver ou parar
        static void Exercicio_Loop_3()
        {
            int inicio, parada = 0;
            Console.WriteLine("Informe o numero de inicio: ");
            inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero de parada: ");
            parada = int.Parse(Console.ReadLine());
            while (inicio <= parada)
            {
                Console.WriteLine(inicio);
                inicio += inicio ;
            }
            Console.ReadKey();
        }

        //Contagem regressiva do numero que voce quiser até o 0 
        static void Exercicio_Loop_4()
        {
            int inicio;
            Console.WriteLine("Informe um numero: ");
            inicio = int.Parse(Console.ReadLine());
            while(inicio >= 1)
            {
                inicio -= 1;
                Console.WriteLine(inicio);
                
            }
            Console.ReadKey();
        }

        //Recebe 5  e retorna a soma
        static void Exercicio_Loop_5()
        {
            int num1=0, soma=0 , escolha,cont =0;
            Console.WriteLine("Quantos numeros voce quer somar: ");
            escolha = int.Parse(Console.ReadLine());
            while (cont <= escolha)
            {
                Console.WriteLine("Infomre o numero pra soma: ");
                num1 = int.Parse(Console.ReadLine());
                soma += num1;
                cont += 1;
            }
            Console.WriteLine($"A soma de todos os números é {soma}");
            Console.ReadKey();
        }

        // Programa que ler 10 numeros e entrega a media e mediana e media harmonica dos numeros
        static void Exercicio_Loop_6()
        {
            int media,med=0,Cont =0,num;
            while(Cont <= 10)
            {
                Console.WriteLine("Entre com o valor");
                num = int.Parse(Console.ReadLine());
                med += num;
                Cont += 1;
                /*static public void exemplo()
        {
            
            double[] vetorNumeros = new double[] {10,9,8,12,11};

            double media = calcularMedia(vetorNumeros);
            // Resultado: 10
            // Também existe a função nativa que retona o valor médio:
            // media = vetorNumeros.Average();

            double minimo = obterMinimo(vetorNumeros);
            // Resultado: 8
            // Também existe a função nativa que retona o menor valor:
            minimo = vetorNumeros.Min();

            double maximo = obterMaximo(vetorNumeros);
            // Resultado: 12
            // Também existe a função nativa que retona o maior valor:
            maximo = vetorNumeros.Max();

            double devioPadrao = calcularDesvioPadrao(vetorNumeros);
            //Resultado: 2.0

            double mediana = calcularMediana(vetorNumeros);
            //Resultado: 10

        }

        //Calcula e retorna a média aritmética de uma lista de valores
        static public double calcularMedia(double[] listaValores)
        {
            double resultadoMedia = 0.0;
            double somatorio = 0.0;
            int tamanhoVetor = listaValores.Length;

            for (int i = 0; i < tamanhoVetor; i++)
            {
                somatorio = somatorio + listaValores[i];
            }

            resultadoMedia = somatorio / tamanhoVetor;

            return resultadoMedia;
        }

        //Procura e retorna o menor valor de uma lista de valores
        static public double obterMinimo(double[] listaValores)
        {
            // É inicializado com o maior valor possivel,
            // para qualquer valor que vier seja menor que esse.
            double valorMinimo = double.PositiveInfinity;

            for (int i = 0; i <= listaValores.Length - 1; i++)
            {
                if (listaValores[i] < valorMinimo)
                    valorMinimo = listaValores[i];
            }
            return valorMinimo;
        }

        //Procura e retorna o maior valor de uma lista de valores
        static public double obterMaximo(double[] listaValores)
        {
            // É inicializado com o menor valor possivel,
            // para que qualquer valor que vier seja maior que esse.
            double valorMaximo = double.NegativeInfinity;

            for (int i = 0; i <= listaValores.Length - 1; i++)
            {
                if (listaValores[i] > valorMaximo)
                    valorMaximo = listaValores[i];
            }
            return valorMaximo;
        }

        //Calcula e retorna o desvio padrão de um vetor de números
        static public double calcularDesvioPadrao(double[] listaValores)
        {
            double mediaAritimetica = listaValores.Average();
            double somatorio = 0.0;
            int tamanhoVetor = listaValores.Length;

            for (int i = 0; i < tamanhoVetor; i++)
            {
                somatorio = somatorio + Math.Pow(listaValores[i] - mediaAritimetica, 2);
            }

            double valorVariancia = 0.0;
            double valorDesvioPadrao = 0.0;

            // soma dos quadrados da diferença entre cada valor e
            // a média aritmética, dividida pela quantidade de elementos observados.
            valorVariancia = somatorio / tamanhoVetor;

            // Desvio padrão é a raiz quadrada da variância.
            valorDesvioPadrao = valorVariancia;

            return valorDesvioPadrao;
        }

        // Calcula e retorna o valor da Mediana (estatística)
        static public double calcularMediana(double[] listaValores)
        {
            //Ordena o vetor
            double[] listaValoresOrdenada = listaValores.ToArray();
            Array.Sort(listaValoresOrdenada);

            double valorMediana = 0.0; 

            bool numElementosImpar = (listaValoresOrdenada.Length % 2 != 0);
            if (numElementosImpar)
            // Caso a lista tenha numero impar de elementos, 
            // o resultado será o valor da posição do meio
            {
                int posicao = (listaValoresOrdenada.Length + 1 ) / 2;
                valorMediana = listaValoresOrdenada[posicao -1];
            }

            else
            // Caso a lista tenha número par de elementos,
            // o resultado será a média dos valores do meio
            { 
                int posicao1 = (listaValoresOrdenada.Length / 2);
                int posicao2 = (listaValoresOrdenada.Length / 2) + 1;

                valorMediana = (listaValoresOrdenada[posicao1 - 1] + listaValoresOrdenada[posicao2 - 1]) / 2;
            }

            return valorMediana;
        }*/
            }
            media = med / 10;
            Console.WriteLine(media);
            Console.ReadKey();
        }

        //Programa que mostra o maior e o menor numero lido
        static void Exercicio_Loop_7()
        {
            int num1=0 , maior=0,menor =0 , cont=0, valor;
            Console.WriteLine("Quantos numeros voce quer testar: ");
            valor = int.Parse(Console.ReadLine());
            while(cont <= valor)
            {
                Console.WriteLine("Informe os numeros-> ");
                num1 = int.Parse(Console.ReadLine());
                if(cont == 0)
                {
                    menor = maior = num1;
                }
                else
                {
                    if (num1 > maior)
                        maior = num1;
                    else if (num1 < menor)
                        menor = num1;
                }
                cont += 1;
            }
            Console.WriteLine($"O maior numero é {maior}");
            Console.WriteLine($"O menor numero é {menor}");
            Console.ReadKey();
        }

        // Programa que ler um numero N e imprimi os 3 primeiros numeros naturais impares
        static void Exercicio_Loop_8()
        {
            int numero,cont=0;
            Console.WriteLine("Informe um numero -> ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Seus 3 proximos impares são: ");
            while(cont <= 3)
            {
                if(numero % 2 == 0)
                {
                    numero += 1;
                    Console.WriteLine(numero);
                }
                else
                {
                    numero += 2;
                    Console.WriteLine(numero);

                }
                cont += 1;
            }
            Console.ReadKey();
        }

        // Programa que calcula os 50 primeiros numeros pares
        static void Exercicio_Loop_9()
        {
            int numero,cont=0,soma_par =0;
            Console.WriteLine("Informe o numero: ");
            numero = int.Parse(Console.ReadLine());
            while(cont <= 50)
            {
                if(numero % 2 == 0)
                {
                    numero += 2;
                    Console.WriteLine($"{cont}º = {soma_par}");
                }
                else
                {
                    numero += 1;
                    Console.WriteLine($"{cont}º = {soma_par}");
                }
                cont += 1;
                soma_par += numero;
            }
            Console.WriteLine($"A soma de todos os numeros pares é {soma_par}");
            Console.ReadKey();
        }

        //Imprimi todos os numeros naturais de 0 a N em ordem crescente e decrescente
        static void Exercicio_Loop_10()
        {
            int cont=0, num;
            Console.WriteLine("Todos os numeros naturais de 0 N, Informe N-> ");
            num = int.Parse(Console.ReadLine());
            while(cont <= num)
            {
                Console.WriteLine(cont);
                cont += 1; 
            }
            Console.WriteLine("Agora de N a 0");
            while (cont >= 0)
            {
                Console.WriteLine(cont);
                cont -= 1;
            }
            Console.ReadKey();
        }

        //Algoitmo que mostra todos os numeros pares de 0 ate N e mostre eles em ordem crescente e decrescente
        static void Exercicio_Loop_11()
        {
            int par=0, impar = 0, num,cont=0;
            Console.WriteLine("Informe um numero: ");
            num = int.Parse(Console.ReadLine());
            while(cont <= num)
            {
                if(cont % 2 == 0)
                {
                    par += cont;
                    Console.WriteLine(par);
                }
                else
                {
                    impar += cont;
                    Console.WriteLine(impar);
                }
                cont += 1;
            }
            Console.ReadKey();
        }





        //= int.Parse(Console.ReadLine());
    }
}
