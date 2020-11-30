using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excercício 2");

            Console.WriteLine("Selecione um tipo de combustível");
            Console.WriteLine("A - Álcool");
            Console.WriteLine("G -Gasolina");
            string combustivel = Console.ReadLine();


            Console.WriteLine("Digite a quantidade de combustível");
            float quanridadeCombustivel = float.Parse(Console.ReadLine());

            float percDesconto, desconto, valorTotal;
            float precAlcool = 4.9f;
            float precoGasolina = 5.3f;

            switch (combustivel.ToLower())
            {
                case "a":
                    if(quanridadeCombustivel>20){
                        percDesconto = 0.03f;
                    }else{
                        percDesconto = 0.05f;
                    }
                    valorTotal = (quanridadeCombustivel * precAlcool);
                    desconto = (quanridadeCombustivel * precAlcool)* percDesconto;
                    Console.WriteLine($"Valors a ser pago{valorTotal}");
                    Console.WriteLine($"Valors a ser pago{desconto}");
                    break;
                case "g":
                    if(quanridadeCombustivel>20)
                    {
                      percDesconto = 0.6f;
                    }else{
                        percDesconto = 0.04f; 
                    }
                    valorTotal= (quanridadeCombustivel * precoGasolina);
                    desconto =(quanridadeCombustivel * precoGasolina)* percDesconto;
                    Console.WriteLine($"Valors a ser pago{valorTotal}");
                    Console.WriteLine($"Valors a ser pago{desconto}");
                    


                    break;
                default:
                    Console.WriteLine("opção Invalida");
                    break;
            }









        }
    }
}
