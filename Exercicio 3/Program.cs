using System;

namespace Excercicio_3_de_segunda_feira
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício de Segunda-feira 23/11


            Console.WriteLine("Digite o nome do produto.");
            string nome = Console.ReadLine();


            Console.WriteLine("Digite a quantidade:");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço");
            float preco = float.Parse(Console.ReadLine());

            float resultado = TotalAPagar(quantidade,preco);

            if(resultado >100){
                Console.WriteLine("Receber brinde");

            }else{
                Console.WriteLine("Receber adesivos para juntar");
            }



            float TotalAPagar(int quantidade, float preco)
            {
                float total = quantidade * preco; //50
                float desconto;
                if(quantidade<=5){
                    desconto = 0.02f;

                }else if(quantidade <=10){
                    desconto = 0.03f;
                }else{
                    desconto = 0.05f;
                }
                float valorDoDesconto = total * desconto;
                float totalComDesconto = total - valorDoDesconto;

                    Console.WriteLine($"O valor total é de: {total}");
                    Console.WriteLine($"Você recebera R${valorDoDesconto} de desconto");
                    Console.WriteLine($"Sua compra com desconto fica R${totalComDesconto}");
                return totalComDesconto;

            }//fim total a pagar














        }//fim do main
    }
}
