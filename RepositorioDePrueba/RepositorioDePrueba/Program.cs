using System;

namespace RepositorioDePrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----Def Vars----------
            double op1 = 0;
            double op2 = 0;
            double res = 0;
            string opcion = "";
            string operacion = "";
            //-----MENU----------
            Console.WriteLine("Bienvenido al menu de opciones de operaciones");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("a) Suma");
            Console.WriteLine("b) Resta");
            Console.WriteLine("c) Multi");
            Console.WriteLine("d) Modulus");
            Console.WriteLine("x) Salir");
            Console.WriteLine("--------------------------------------");
            //leer la opcion
            opcion = Console.ReadLine();

        }
    }
}
