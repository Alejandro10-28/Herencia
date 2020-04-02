using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Bienvenida();
        }
        public void Bienvenida()
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Elige una opción:\n1-.Alumno\n2-.Empleado\n3-.Docente");
            Alumno alumno = new Alumno();
            Docente docente = new Docente();
            Empleado empleado = new Empleado();
            switch (Console.ReadLine())
            {
                case "1":
                    alumno.calcularPromedio();
                    break;
                case "2":
                    empleado.CalcularSueldo();
                    break;
                case "3":
                    docente.CalcularSueldo();
                    break;

            }

        }
    }
}
