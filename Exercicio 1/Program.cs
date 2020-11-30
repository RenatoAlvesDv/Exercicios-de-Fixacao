using System;

namespace ExerD23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios 1");
            //Entrada
            Console.WriteLine("Digite o ano atual");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu ano de nascimento");
            int anoNascimento = int.Parse(Console.ReadLine());

            //Processamento
            int idade = anoAtual-anoNascimento;

            Console.WriteLine(idade);

            //Saída
            if(idade>=16){
                Console.WriteLine("Você pode ir votar!");
            }else{
                Console.WriteLine("Você não pode votar ainda.");
            }
        }
    }
}
