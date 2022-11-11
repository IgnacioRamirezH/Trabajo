using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreAlumno, primerApellido, segundoApellido, matriculaAlumno;
            double califU1, califU2, califU3, califU4, CalifU5, califTotal;
            int edadAlumno;


            Console.WriteLine("Ingresa tu nombre, despúes presiona ENTER");
            nombreAlumno = Console.ReadLine();

            Console.WriteLine("Ingresa tu segundo apellido");
            primerApellido = Console.ReadLine();

            Console.WriteLine("Ingresa tu segundo apellido");
            segundoApellido = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad");
            edadAlumno = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Ingresa tu matricula porfavor");
            matriculaAlumno = Console.ReadLine();

            Console.WriteLine("Ingresa la calificacion de la unidad 1");
            califU1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa tu calificacion de la unidad 2");
            califU2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa Tu calificacion de la unidad 3");
            califU3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa tu calificacion de la unidad 4");
            califU4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingresa tu calificacion de la unidad 5");
            CalifU5 = Convert.ToDouble(Console.ReadLine());

            //Aqui ira la operacion a realizar
            califTotal = (califU1 + califU2 + califU3 + califU4 + CalifU5) / 5;

            if (califTotal > 70)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Clear();

                Console.WriteLine("Felicitaciones si aprovo");

                Console.WriteLine("\n Nombre:{0} \n Primer apellido: {1} \n Segundo apellido: {2}" +
                           " \n Edad: {3}  \n Matricula: {4} \n Telefono: {5} \n", nombreAlumno, primerApellido, segundoApellido, edadAlumno, matriculaAlumno, califTotal);

            }

            else

            {
                Console.WriteLine("Lamentablemente no aprovo la materia, ni modo");
            }

            Console.ReadKey();
        }
    }
}