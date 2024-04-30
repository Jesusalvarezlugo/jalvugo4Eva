using jalvugo4Eva.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jalvugo4Eva.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de la operativa de la aplicacion
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo que genera el dni completo
        /// </summary>
        /// <param name="numDni"></param>
        /// <returns></returns>
        public string dniCompleto(int numDni);

        /// <summary>
        /// Metodo que lleva la operativa de registro
        /// </summary>
        /// <param name="listAntPaciente"></param>
        public void registroLlegada(List<PacienteDto> listAntPaciente);

        /// <summary>
        /// Metodo que lleva la operativa de consultas
        /// </summary>
        /// <param name="listAntPaciente"></param>
        public void listadoConsultas(List<PacienteDto> listAntPaciente);
    }
}
