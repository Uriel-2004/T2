using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace exment2
{
        public class exment2
        {
            public static void Iniciar()

            {

                while (true)

                {

                    Console.WriteLine("SISTEMA DE MATRICULA Y ASISTENCIA");

                    Console.WriteLine("[A] - Matricula de empresas");

                    Console.WriteLine("[B] - Matricula de personas");

                    Console.WriteLine("[C] - Registrar asistencia");

                    Console.WriteLine("[S] - Salir del sistema");

                    Console.Write("Seleccione una opción: ");

                    string opcion = Console.ReadLine().ToUpper();



                    switch (opcion)

                    {

                        case "A":

                            MatEmpresas();

                            break;

                        case "B":

                            MatPersonas();

                            break;

                        case "C":

                            RegistrarAsistencia();

                            break;

                        case "S":

                            Console.WriteLine("Saliendo del sistema...");

                            return;

                        default:

                            Console.WriteLine("Opción no válida. Intente nuevamente.");

                            break;

                    }

                }

            }



            static void MatEmpresas()

            {

                Console.WriteLine("\n--- Matricula de Empresas ---");

                Console.Write("RUC de la Empresa: ");

                string ruc = Console.ReadLine();

                Console.Write("Nombre de la Empresa: ");

                string nombre = Console.ReadLine();

                Console.Write("Cantidad de participantes: ");

                int cantidad = int.Parse(Console.ReadLine());

                Console.Write("Curso a matricularse: ");

                string curso = Console.ReadLine();

                Console.Write("Costo por participante: ");

                double costoPorParticipante = double.Parse(Console.ReadLine());

                double costoTotal = cantidad * costoPorParticipante;



                Console.WriteLine($"\nResumen de la matrícula:");

                Console.WriteLine($"RUC: {ruc}");

                Console.WriteLine($"Empresa: {nombre}");

                Console.WriteLine($"Participantes: {cantidad}");

                Console.WriteLine($"Curso: {curso}");

                Console.WriteLine($"Costo total: {costoTotal:C}");

            }



            static void MatPersonas()

            {

                Console.WriteLine("\n--- Matricula de Personas ---");

                Console.Write("Cantidad de personas a matricular (5-15): ");

                int cantidad = int.Parse(Console.ReadLine());



                if (cantidad < 5 || cantidad > 15)

                {

                    Console.WriteLine("La cantidad debe estar entre 5 y 15.");

                    return;

                }



                Console.WriteLine($"Matriculando a {cantidad} personas...");

                // Aquí podrías agregar más lógica para registrar a cada persona.

            }



            static void RegistrarAsistencia()

            {

                Console.WriteLine("\n--- Registrar Asistencia ---");

                Console.WriteLine("Funcionalidad en desarrollo...");

                // Aquí podrías agregar la lógica para registrar la asistencia.

            }

        }
    
}
