using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jalvugo4Eva.Servicios
{
    /// <summary>
    /// clase que se encarga de los menus
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccionCons()
        {
            int opcion;

            Console.WriteLine("#######################");
            Console.WriteLine("0. Salir de la aplicacion");
            Console.WriteLine("1. Mostrar Consultas");
            Console.WriteLine("2. Imprimir Consultas");
            Console.WriteLine("#######################");
            Console.WriteLine("Introduzca una opcion: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }

        

        public int mostrarMenuYSeleccionPrin()
        {
            int opcion;

            Console.WriteLine("#######################");
            Console.WriteLine("0. Salir de la aplicacion");
            Console.WriteLine("1. Registros de llegada");
            Console.WriteLine("2. Listado de consultas");
            Console.WriteLine("#######################");
            Console.WriteLine("Introduzca una opcion: ");
            opcion=Console.ReadKey(true).KeyChar-('0');

            return opcion;
        }


        public int mostrarMenuYSeleccioneSp()
        {
            int opcion;

            Console.WriteLine("#######################");
            Console.WriteLine("0. Volver al menu anterior");
            Console.WriteLine("1. Psicologia");
            Console.WriteLine("2. Traumatologia");
            Console.WriteLine("2. Fisioterapia");
            Console.WriteLine("#######################");
            Console.WriteLine("Introduzca una opcion: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }


    }
}
