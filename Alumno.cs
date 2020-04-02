using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Alumno:Persona
    {
        public double Calificacion { get; set; }
        public string Carrera { get; set; }

        public void calcularPromedio()
        {
            int calificaciones=0;
            double promedio=0;
            
                Console.WriteLine("Ingresa Numero de control:");
                NoControl = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa nombre:");
                Nombre = Console.ReadLine();
                 Console.WriteLine("Ingresa cuantas calificaciónes son:");
                calificaciones = int.Parse(Console.ReadLine());
                 for (int x = 0; x < calificaciones; x++)
                 {
                   Console.WriteLine("Ingresa calificación:");
                   Calificacion = Convert.ToDouble(Console.ReadLine());
                   promedio = promedio + Calificacion;
                 }
                Console.WriteLine("Ingresa carrera:");
                Carrera = Console.ReadLine();

            
            promedio = promedio / calificaciones;
            Imprimir(promedio);
        }

        public void Imprimir(double promedio)
        {
            Console.WriteLine("Nombre:"+Nombre);
            Console.WriteLine("No.Control"+NoControl);
            Console.WriteLine("Promedio:"+promedio);
            Console.ReadLine();
            Console.Clear();
            Program program = new Program();
            program.Bienvenida();
        }
    }
}
