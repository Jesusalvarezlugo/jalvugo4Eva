using jalvugo4Eva.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jalvugo4Eva.Servicios
{
    /// <summary>
    /// Clase que se encarga de los ficheros
    /// </summary>
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void crearFichero(string ruta, List<PacienteDto> listaPaciente)
        {
            StreamReader sr = new StreamReader(ruta);

            foreach (PacienteDto paciente in listaPaciente)
            {
                string contenido;
            }
        }

        public void leerFichero(string ruta, List<PacienteDto> listaPaciente)
        {
            try
            {
                string[] lineas = File.ReadAllLines(ruta);

                foreach (string linea in lineas)
                {
                    string[] paciente = linea.Split(";");
                    PacienteDto elPaciente = new PacienteDto();
                    elPaciente.Dni = paciente[0];
                    elPaciente.Nombre = paciente[1];
                    elPaciente.Apellidos = paciente[2];
                    elPaciente.Especialidad = paciente[3];
                    elPaciente.FechaCita = Convert.ToDateTime(paciente[4]);
                    //elPaciente.AsistenciaCita = Convert.ToBoolean(paciente[5]);

                    listaPaciente.Add(elPaciente);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer las listas");
                Console.WriteLine(ex.Message);
                    
            }
           
        }
    }
}
