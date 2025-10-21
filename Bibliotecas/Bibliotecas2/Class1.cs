using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas2
{
    public class Bibliotecas2
    {
        public static void Iniciar()
        {
            string DNI, resp;
            bool continuar = true;

            Console.WriteLine("Ingrese su número de DNI: ");
            DNI = Console.ReadLine();

            do
            {
                if (DNI.Length == 8)
                {

                    Console.WriteLine("Ingrese sus nombres: ");
                    string nombres = Console.ReadLine();

                    Console.WriteLine("Ingrese sus apellidos: ");
                    string apellidos = Console.ReadLine();

                    Console.WriteLine("Ingrese el curso al que desea matricularse: ");
                    string cursos = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Ha ingresado valores incorrectos, vuelva a ingresar su DNI correctamente.");
                }
                Console.WriteLine("¿Desea continuar? [s] [n]");
                resp = Console.ReadLine();
                if (resp == "s")
                {
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }
            } while (continuar);

            Console.ReadKey();

        }
    }
}
    
