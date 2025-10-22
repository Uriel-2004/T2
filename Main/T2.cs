using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioMatriculas;
using BiblioAsistencia;

namespace Main
{
    internal class T2
    {
        static void Main(string[] args)
        {
            string opcion = "";
            do
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("      SISTEMA DE MATRICULA Y ASISTENCIA");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("\n[A] - Matricula de empresas\n");
                Console.WriteLine("[B] - Matricula de personas\n");
                Console.WriteLine("[C] - Registrar asistencia\n");
                Console.WriteLine("[S] - Salir del sistema\n");
                Console.WriteLine("------------------------------------------------");
                Console.Write("Seleccione una opción: ");

                opcion = Console.ReadLine().ToUpper();

                switch (opcion)
                {
                    case "A":
                        BiblioMatriculas.ClassMatricula.MatEmpresas();
                        break;
                    case "B":
                        BiblioMatriculas.ClassMatricula.MatPersonas();
                        break;
                    case "C":
                        BiblioAsistencia.ClassAsistencia.RegAsistencia();
                        break;
                    case "S":
                        Console.WriteLine("\nSaliendo del sistema...");
                        return;
                    default:
                        Console.WriteLine("\nOpción no válida. Intente nuevamente.\n");
                        break;
                }

            } while (opcion != "A" && opcion != "B" && opcion != "C" && opcion != "S");
        }
    }
}

