using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Vendedor : Persona
    {
        public override string DNI()
        {
            return identidad;
        }

        public override string Nombre()
        {
            return PNombre + " " + PApellido;
        }

        public bool AccesoInventario()
        {
            return true;
        }

        public void Imprimir()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("## DATOS EMPLEADO VENDEDOR ##");
            Console.WriteLine("\n");
            Console.WriteLine($"Nombre empleado: {Nombre()}");
            Console.WriteLine($"DNI: {DNI()}");
            Console.WriteLine($"Acceso a inventario: {AccesoInventario()}");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("## ULTIMA LINEA ##");
            Console.WriteLine("\n");
        }
    }
}
