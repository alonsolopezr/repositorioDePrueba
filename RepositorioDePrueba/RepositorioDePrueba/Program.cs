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
            //pedimos operandos
            Console.WriteLine("Captura el operando 1");
            op1 = double.Parse( Console.ReadLine() );
            Console.WriteLine("Captura el operando 2");
            op2 = double.Parse( Console.ReadLine() );
            //procesar la opcion pàra saber que operacion hacver
            if (opcion == "a")
            {
                res = op1 + op2;
                operacion = "SUMA";
            }
            else if (opcion == "b")
            {
                res = op1 - op2;
                operacion = "RESTA";
            }
            else if (opcion == "c")
            {
                res = op1 * op2;
                operacion = "MULTIPLICACION";
            }
            else if (opcion == "d")
            {
                res = op1 % op2;
                operacion = "MODULUS";
            }
            else if (opcion == "x")
                Console.WriteLine("SALIDA--- adios :(...");
            else {
                Console.WriteLine(opcion+" ES UNA OPCION NO VÁLIDA");
            }

            /// imprimir el resultado
            Console.WriteLine("La operacion que elegiste "+operacion+" con los números op1="+op1+", y op2="+op2+" = "+res);
            //cuialquier tecla para trerminar
            Console.WriteLine( "Presiona cualquier tecla para terminar");
            Console.ReadKey();
        }
                
    }
}
