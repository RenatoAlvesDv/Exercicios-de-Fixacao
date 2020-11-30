using System;

namespace Excercicio_5_de_segunda_feira
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 5 de Segunda-feira 23//11
    
            Console.WriteLine("Tabuada do 1 até 10 !");

            for (var e = 1; e <= 10; e++)   //Primeiro laço executa
            {
                for (var d = 1; d <= 10; d++)
                {
                    Console.WriteLine(+e+ " x " +d+ " = " +e * d);              
                }                        
             Console.WriteLine();
            }

           
        }
    }
}
