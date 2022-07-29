using System;

namespace ale_2
{
    class Program
    {
        static void Main(string[] args)

        {
            string firstname = "rafael";
            String lastname = "alessandro";
            int edad = 18;
            var name = firstname + " " + lastname;

            Console.WriteLine("Su nombre es: {1} y su edad es:{0} ", edad,name);
        }
    }
}
