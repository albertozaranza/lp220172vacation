using System;

using bll;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, o;

            Console.WriteLine("Digite um numero:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            o = Convert.ToInt32(Console.ReadLine());

            Operacao operacao = new Operacao();

            if(o == 1){
                operacao.Somar(a,b);
            }else if(o == 2){
                operacao.Subtrair(a,b);
            }else if(o == 3){
                operacao.Multiplicar(a,b);
            }else if(o == 4){
                operacao.Dividir(a,b);
            }else {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}
