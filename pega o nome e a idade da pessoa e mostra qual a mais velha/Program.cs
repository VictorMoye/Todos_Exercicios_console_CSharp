using System;

namespace exercicio_curso_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           NomeIdade Pessoa2 = new NomeIdade();
           NomeIdade Pessoa1 = new NomeIdade(); 
            
            Console.WriteLine("Informe o nome da pessoa: ");
            Pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Informe a nome e a idade da(o) {0}: ",Pessoa1.Nome);
            Pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome da outra pessoa: ");
            Pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Informe a nome e a idade da(o) {0}: ", Pessoa2.Nome);
            Pessoa2.idade = int.Parse(Console.ReadLine()); 

            if(Pessoa1.idade >Pessoa2.idade )
            {
                Console.WriteLine("A pessoa {0} é mais velha que a {1}",Pessoa1.Nome,Pessoa2.Nome);
            } else
                Console.WriteLine("A pessoa {0} é mais velha que a {1}",Pessoa2.Nome,Pessoa1.Nome);
        }

    }
}
