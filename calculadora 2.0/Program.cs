using System;

namespace calculadora_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            char tipodecalculo;
            int valor;
            int valor2;
            Console.WriteLine("informe um valor:");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine("informe uma acao:");
            tipodecalculo = char.Parse(Console.ReadLine());
            Console.WriteLine("informe um valor:");
            valor2 = int.Parse(Console.ReadLine());

            switch (tipodecalculo)
            {
                case '+':Somar(valor, valor2); break;
                case '-':Subitrair(valor, valor2); break;
                case '*':Multiplicar(valor, valor2); break;
                case '/':Dividir(valor, valor2); break;
                default: Console.WriteLine(); break;
            }            
            //last main line
        }
        //main end
        static void Somar(int valor, int valor2)
        {
            valor = valor + valor2;
            Console.WriteLine("resultado:" + valor);
        }
        //somar end
        static void Subitrair(int valor, int valor2)
        {
            valor = valor - valor2;
            Console.WriteLine("resultado:" + valor);
        }
        //subitrair end
        static void Multiplicar(int valor, int valor2)
        {
            valor = valor * valor2;
            Console.WriteLine("resultado:" + valor);
        }
        //multiplicar end
        static void Dividir(int valor, int valor2)
        {
            valor = valor / valor2;
            Console.WriteLine("resultado:" + valor);
        }
        //dividir end
        //method end
    }
    //class end
}
//namespace end