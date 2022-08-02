using System;

namespace ale_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese otro numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero");
            int num2 = int.Parse(Console.ReadLine());
            var multiplicacion = num1 * num2;

            Console.WriteLine("la multipliacion de los numeros es : {0}", multiplicacion);

        }
    }
}
