using System;

namespace ConversaoeCasting
{
    class Program
    {
        static void Main(string[] args)
        {

            double a;
            float b;
            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);

            
            a = 5.1;
            b = (int)a;
            Console.WriteLine(b);

            a = 5;
            b = 2;
            double resultado = (double)a / b;
            Console.WriteLine(resultado);



        }
    }
}
