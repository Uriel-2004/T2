using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA3
{
    public class BIBLIOTECA3
    {
        public static void Iniciar1()
        {
            string curso;
           int opciones, asistio = 0, falto = 0, tarde = 0, contador = 0;


            Console.Write("Curso que se tomará asistencia: ");
            curso = Console.ReadLine();

            do
            {
                Console.WriteLine("\n[1] - Asistió");
                Console.WriteLine("\n[2] - Faltó");
                Console.WriteLine("\n[3] - Tarde");
                Console.Write("\nIngrese una de las opciones mostradas: ");
                opciones = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{contador + 1}");

                switch (opciones )
                {
                    case 1:
                        asistio++;
                        contador++; break;
                    case 2:
                        falto++;
                        contador++; break;
                    case 3:
                        tarde++;
                        contador++; break;
                    default: Console.WriteLine("Error. Ingrese el número correcto...");
                        break; ;
                }
} while (contador < 15) ;

Console.WriteLine("Se llego al número máx. de intentos (15)\n");
Console.WriteLine("Cantidad de estudiantes que asistieron: " + asistio);
Console.WriteLine("Cantidad de estudiantes que faltaron: " + falto);
Console.WriteLine("Cantidad de estudiantes tardíos: " + tarde);

Console.ReadKey();
        }
    }
}
