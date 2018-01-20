using System;

namespace bll
{
    public class Operacao
    {
        public void Somar(int a, int b){
            Console.WriteLine($"Resultado: {a+b}");
        }

        public void Subtrair(int a, int b){
            Console.WriteLine($"Resultado: {a-b}");
        }

        public void Multiplicar(int a, int b){
            Console.WriteLine($"Resultado: {a*b}");
        }

        public void Dividir(int a, int b){
            Console.WriteLine($"Resultado: {a/b}");
        }
    }
}
