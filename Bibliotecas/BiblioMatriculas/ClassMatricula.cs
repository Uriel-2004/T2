using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioMatriculas
{
    public class ClassMatricula
    {
        public static void MatEmpresas()
        {
            bool ruc_erroneo, curso_erroneo;
            long ruc = 0;
            int eleccion;
            string curso = "";
            double costoPorParticipante = 0;

            do
            {
                Console.WriteLine("\n--- Matricula de Empresas ---");
                Console.Write("RUC de la Empresa: ");
                ruc = long.Parse(Console.ReadLine());

                if (ruc < 10000000000 || ruc > 99999999999)
                {
                    Console.Write("\nEl número del RUC no cuenta con 11 dígitos, vuelva a intentarlo.\n");
                    ruc_erroneo = true;
                    Console.ReadKey();
                }
                else
                {
                    ruc_erroneo = false;
                }
            } while (ruc_erroneo);

            Console.Write("Nombre de la Empresa: ");
            string nombre = Console.ReadLine();
            Console.Write("Cantidad de participantes: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("\n-----------------------");
            Console.WriteLine("         CURSOS");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" [1] Ms. Excel ");
            Console.WriteLine(" [2] Ms. Access ");
            Console.WriteLine(" [3] Ms. Word  ");
            Console.WriteLine(" [4] Ms. Powerpoint ");
            Console.WriteLine(" [5] AutoCAD ");
            Console.WriteLine(" [6] Diseño Gráfico");
            Console.WriteLine("-----------------------");

            do
            {
                Console.Write("\nCurso a matricularse (1-6): ");
                eleccion = int.Parse(Console.ReadLine());

                if (eleccion < 1 || eleccion > 6)
                {
                    Console.Write("Número incorrecto, vuelva a intentarlo.");
                    curso_erroneo = true;
                    Console.ReadKey();
                }
                else
                {
                    curso_erroneo = false;
                }
            } while (curso_erroneo);

            switch (eleccion)
            {
                case 1: costoPorParticipante = 220.00; curso = "Ms. Excel"; break;
                case 2: costoPorParticipante = 300.00; curso = "Ms. Access"; break;
                case 3: costoPorParticipante = 130.00; curso = "Ms. Word"; break;
                case 4: costoPorParticipante = 120.00; curso = "Ms. Powerpoint"; break;
                case 5: costoPorParticipante = 250.00; curso = "AutoCAD"; break;
                case 6: costoPorParticipante = 200.00; curso = "Diseño Gráfico"; break;
            }

            Console.WriteLine("\nCosto por participante: S/" + costoPorParticipante);
            double costoTotal = cantidad * costoPorParticipante;
            Console.WriteLine("\n----------------------------");
            Console.WriteLine($"Resumen de la matrícula:");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"RUC: {ruc}");
            Console.WriteLine($"Empresa: {nombre}");
            Console.WriteLine($"Participantes: {cantidad}");
            Console.WriteLine($"Curso: {curso}");
            Console.WriteLine($"Costo total: {costoTotal:C}");
            Console.WriteLine("\nRegistro completo.");
            Console.ReadKey();
        }

        public static void MatPersonas()
        {
            bool dni_erroneo, curso_erroneo;
            long dni = 0;
            int eleccion, contador = 0;
            string curso = "", nueva_matricula = "";
            double costoPorParticipante = 0;

            do
            {
                do
                {
                    Console.WriteLine("\n--- Matricula de Personas ---");
                    Console.Write("DNI de la persona: ");
                    dni = long.Parse(Console.ReadLine());

                    if (dni < 10000000 || dni > 99999999)
                    {
                        Console.Write("\nEl número del DNI no cuenta con 8 dígitos, vuelva a intentarlo.");
                        dni_erroneo = true;
                        Console.ReadKey();
                    }
                    else
                    {
                        dni_erroneo = false;
                    }
                } while (dni_erroneo);

                Console.Write("Nombres: ");
                string nombre = Console.ReadLine();
                Console.Write("Apellidos: ");
                string apellido = Console.ReadLine();
                Console.WriteLine("\n-----------------------");
                Console.WriteLine("         CURSOS");
                Console.WriteLine("-----------------------");
                Console.WriteLine(" [1] Ms. Excel ");
                Console.WriteLine(" [2] Ms. Access ");
                Console.WriteLine(" [3] Ms. Word  ");
                Console.WriteLine(" [4] Ms. Powerpoint ");
                Console.WriteLine(" [5] AutoCAD ");
                Console.WriteLine(" [6] Diseño Gráfico");
                Console.WriteLine("-----------------------");

                do
                {
                    Console.Write("\nCurso a matricularse (1-6): ");
                    eleccion = int.Parse(Console.ReadLine());

                    if (eleccion < 1 || eleccion > 6)
                    {
                        Console.Write("Número incorrecto, vuelva a intentarlo.");
                        curso_erroneo = true;
                        Console.ReadKey();
                    }
                    else
                    {
                        curso_erroneo = false;
                    }
                } while (curso_erroneo);

                switch (eleccion)
                {
                    case 1: costoPorParticipante = 250.00; curso = "Ms. Excel"; break;
                    case 2: costoPorParticipante = 270.00; curso = "Ms. Access"; break;
                    case 3: costoPorParticipante = 150.00; curso = "Ms. Word"; break;
                    case 4: costoPorParticipante = 140.00; curso = "Ms. Powerpoint"; break;
                    case 5: costoPorParticipante = 280.00; curso = "AutoCAD"; break;
                    case 6: costoPorParticipante = 230.00; curso = "Diseño Gráfico"; break;
                }

                Console.WriteLine("\nCosto por participante: S/" + costoPorParticipante);
                Console.WriteLine("\n----------------------------");
                Console.WriteLine($"Resumen de la matrícula:");
                Console.WriteLine("----------------------------");
                Console.WriteLine($"DNI: {dni}");
                Console.WriteLine($"Nombres: {nombre}");
                Console.WriteLine($"Apellidos: {apellido}");
                Console.WriteLine($"Curso: {curso}");
                Console.WriteLine($"Costo por participante: {costoPorParticipante:C}");

                Console.WriteLine("\nRegistro completo.");

                ++contador;

                do
                {
                    Console.WriteLine("\n¿Desea hacer una nueva matrícula?(máx 15)");
                    Console.WriteLine("(Y/N)");
                    nueva_matricula = Console.ReadLine().ToUpper();

                    if (nueva_matricula != "Y" && nueva_matricula != "N")
                    {
                        Console.WriteLine("\nElección incorrecta. Vuelva a intentarlo.");
                    }  

                } while (nueva_matricula != "Y" && nueva_matricula != "N");

            } while (nueva_matricula == "Y" && contador < 16);
        }
    }
}
