using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioAsistencia
{
    public class ClassAsistencia
    {
        public static void RegAsistencia()
        {
            int curso, opciones, parar = 0;
            int asistio = 0, falto = 0, tarde = 0, contador = 0;

            do
            {
                Console.WriteLine(" \n [1] Ms. Excel ");
                Console.WriteLine(" [2] Ms. Access ");
                Console.WriteLine(" [3] Ms. Word  ");
                Console.WriteLine(" [4] Ms. Powerpoint ");
                Console.WriteLine(" [5] AutoCAD ");
                Console.WriteLine(" [6] Diseño Gráfico");
                Console.Write("\nCurso que se tomará asistencia: ");
                curso = int.Parse(Console.ReadLine());

                if (curso < 1 || curso > 6)
                {
                    Console.WriteLine("\nOpción incorrecta. Vuelva a intentarlo.\n");
                }
            } while (curso < 0 || curso > 6);

            do
            {
                Console.WriteLine("\n[1] - Asistió");
                Console.WriteLine("\n[2] - Faltó");
                Console.WriteLine("\n[3] - Tarde");
                Console.Write("\nIngrese una de las opciones mostradas: ");
                opciones = Convert.ToInt32(Console.ReadLine());

                switch (opciones)
                {
                    case 0:
                        Console.WriteLine("Parando el programa.");
                        break;
                    case 1:
                        asistio++;
                        contador++; break;
                    case 2:
                        falto++;
                        contador++; break;
                    case 3:
                        tarde++;
                        contador++; break;
                    default:
                        Console.WriteLine("\nError. Ingrese el número correcto...\n");
                        Console.ReadKey();
                        break; ;
                }
                Console.WriteLine("Pulse (0) para parar - Máx (15)");
                if (opciones == 0)
                {
                    parar++;
                }
            } while (parar != 1 && contador < 16);

            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("\nCantidad de estudiantes que asistieron: " + asistio);
            Console.WriteLine("Cantidad de estudiantes que faltaron: " + falto);
            Console.WriteLine("Cantidad de estudiantes tardíos: " + tarde);
            Console.ReadKey();
        }
    }
}
