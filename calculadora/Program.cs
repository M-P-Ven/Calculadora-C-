using System;

namespace calculadora
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

            if (tipodecalculo == '+')
            {
                Somar(valor, valor2);
            }
            else{
                if (tipodecalculo == '-')
                {
                    Subitrair(valor, valor2);
                }
                else
                {
                    if (tipodecalculo == '/')
                    {
                        Dividir(valor, valor2);
                    }
                    else
                    {
                        if (tipodecalculo == '*')
                        {
                            Multiplicar(valor, valor2);
                        }
                        else
                        {
                            Console.WriteLine("wrong action");
                        }
                    }
                }
            }
          //last main line
        }
        //main end
        static void Somar(int valor, int valor2)
        {
            valor = valor + valor2;
            Console.WriteLine("resultado:"+valor);
        }
        //somar end
        static void Subitrair(int valor, int valor2)
        {
            valor = valor - valor2;
            Console.WriteLine("resultado:"+valor);
        }
        //subitrair end
        static void Multiplicar(int valor, int valor2)
        {
            valor = valor * valor2;
            Console.WriteLine("resultado:"+valor);
        }
        //multiplicar end
        static void Dividir(int valor, int valor2)
        {
            valor = valor / valor2;
            Console.WriteLine("resultado:"+valor);
        }
        //dividir end
        //method end
    }
    //class end
}
//namespace end
