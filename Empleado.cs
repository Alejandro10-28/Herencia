using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
   public class Empleado:Persona
    {
        public string puesto { get; set; }
        public double faltas { get; set; }
        public double HorasTrabajo { get; set; }
        public void CalcularSueldo()
        {
            double sueldo;
            Console.WriteLine("Ingresa Numero de control:");
            NoControl = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa nombre:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa Puesto:");
            puesto = Console.ReadLine();
            Console.WriteLine("Ingresa Horas de trabajo:");
            HorasTrabajo = Convert.ToDouble(Console.ReadLine());
            sueldo = HorasTrabajo * 70;
            if (faltas > 0)
            {

                faltas = faltas * 0.70;
                sueldo = sueldo - faltas;
            }
            imprimir(sueldo);


        }

        public void imprimir(double sueldo)
        {
            Console.WriteLine("Nombre:"+Nombre);
            Console.WriteLine("No.Control:" + NoControl);
            Console.WriteLine("Puesto:" + puesto);
            Console.WriteLine("Horas de trabajo:" + HorasTrabajo);
            Console.WriteLine("Sueldo:" + sueldo);
            Console.ReadLine();
            Console.Clear();
            Program program = new Program();
            program.Bienvenida();

        }
    }
}
