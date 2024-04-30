using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jalvugo4Eva.Dtos
{
    /// <summary>
    /// Clase donde estara la entidad paciente
    /// </summary>
    internal class PacienteDto
    {
        //Atributos

        string dni = "aaaaa";
        string nombre = "aaaaa";
        string apellidos = "aaaaa";
        string especialidad = "aaaaa";
        DateTime fechaCita;
        bool asistenciaCita;

        

        //Getters y setters
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public bool AsistenciaCita { get => asistenciaCita; set => asistenciaCita = value; }


        //Constructores

        public PacienteDto()
        {

        }
        public PacienteDto(string dni, string nombre, string apellidos, string especialidad, DateTime fechaCita, bool asistenciaCita)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.especialidad = especialidad;
            this.fechaCita = fechaCita;
            this.asistenciaCita = asistenciaCita;
        }

        /// <summary>
        /// Metodo toString
        /// </summary>
        /// <returns> texto creado</returns>
        override
        
            
        public string ToString()
        {
            string texto = "Nombre: " + this.nombre;

            return texto;
        }
    }
}
