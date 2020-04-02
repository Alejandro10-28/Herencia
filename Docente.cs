using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Docente:Persona
    {
        public string NivelAcademico { get; set; }
        public int Horas { get; set; }
        public double Faltas { get; set; }
        public void CalcularSueldo()
        {
            double sueldo=0;
            double faltas;
            Console.WriteLine("Ingresa Numero de control:");
            NoControl = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa nombre:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa horas trabajadas:");
            Horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa faltas:");
            Faltas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nivel academico:");
            NivelAcademico = Console.ReadLine();


            if (NivelAcademico == "Bachiller")
            {
                sueldo = Horas * 30;
                if (Faltas > 0)
                {
                    faltas = Faltas * 0.30;
                    sueldo = sueldo - faltas;
                }

            }
            else if (NivelAcademico == "Licenciado")
            {
                sueldo = Horas * 50;
                if (Faltas > 0)
                {
                    faltas = Faltas * 0.30;
                    sueldo = sueldo - faltas;
                }

            }
            else if (NivelAcademico == "Maestria")
            {
                sueldo = Horas * 80;
                if (Faltas > 0)
                {
                    faltas = Faltas * 0.80;
                    sueldo = sueldo - faltas;
                }
            }
            else if (NivelAcademico == "Doctorado")
            {
                sueldo = Horas * 100;
                if (Faltas > 0)
                {
                    faltas = Faltas * 0.10;
                    sueldo = sueldo - faltas;
                }
            }
            imprimir(sueldo);
        }
        public void imprimir( double Sueldo)
        {
            Console.WriteLine("Nombre:"+Nombre);
            Console.WriteLine("Nocontrol:"+NoControl);
            Console.WriteLine("Horas:"+Horas);
            Console.WriteLine("Faltas:"+Faltas);
            Console.WriteLine("Nivel Academico:"+NivelAcademico);
            Console.WriteLine("Total a pagar:"+ Sueldo);
            Console.ReadLine();
            Console.Clear();
            Program program = new Program();
            program.Bienvenida();
        }
    }
}
