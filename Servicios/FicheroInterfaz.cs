using jalvugo4Eva.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jalvugo4Eva.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de los servicios de la aplicacion
    /// </summary>
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Metodo para crear ficheros
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="listaPaciente"></param>
        public void crearFichero(string ruta,List<PacienteDto> listaPaciente);

        /// <summary>
        /// Metodo para leer ficheros y cargar las listas
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="listaPaciente"></param>
        public void leerFichero(string ruta, List<PacienteDto> listaPaciente);
    }
}
