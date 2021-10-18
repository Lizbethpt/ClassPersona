using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassPersona
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona a = new Persona();
            Alumno b = new Alumno();
            Console.WriteLine("Ingresar Datos de Persona");
            Console.WriteLine("Ingresar Nombre:");
            a.Nombre = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingresar Fecha de nacimiento");
            a.Fechadenacimiento = Console.ReadLine();

            Console.WriteLine("Ingresar Datos de Alumno");
            Console.WriteLine("Ingresar Nombre");
            b.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresar Fecha de Nacimiento");
            b.Fechadenacimiento = Console.ReadLine();
            Console.WriteLine("Ingresar Matricula");
            b.Matricula = Console.ReadLine();
            Console.WriteLine(" Ingresar Carrera:");
            b.Carrera = Console.ReadLine();

            Console.WriteLine("DATOS DE LA PERSONA= " + a.ToString());
            Console.WriteLine("DATOS DEL ALUMNO= " + b.ToString());
            Console.ReadKey();




        }
    }
}
