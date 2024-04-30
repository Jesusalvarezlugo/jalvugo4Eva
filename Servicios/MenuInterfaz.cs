using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jalvugo4Eva.Servicios
{
    /// <summary>
    /// Interfaz que se encarga del menu
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu principal
        /// </summary>
        /// <returns>opcion seleccionada</returns>
        public int mostrarMenuYSeleccionPrin();

        /// <summary>
        /// Metodo que muestra el menu de consultas
        /// </summary>
        /// <returns>opcion seleccionada</returns>
        public int mostrarMenuYSeleccionCons();

        /// <summary>
        /// Metodo que muestra el menu especialidades
        /// </summary>
        /// <returns>opcion seleccionada</returns>
        public int mostrarMenuYSeleccioneSp();
    }
}
