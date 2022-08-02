using System;

namespace ale_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese otro numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero");
            int num2 = int.Parse(Console.ReadLine());
            var resta = num1 + num2;

            Console.WriteLine("la resta de los numeros es : {0}", resta);
        }
    }   
}