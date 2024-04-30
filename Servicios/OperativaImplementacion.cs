using jalvugo4Eva.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jalvugo4Eva.Servicios
{
    /// <summary>
    /// Clase que se encarga de la operativa de la aplicacion
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public string dniCompleto(int numDni)
        {
            string dniCompleto=" ";

            switch (numDni % 23)
            {
                case 0:
                    dniCompleto = string.Concat(numDni, "T");
                    
                    break;

                case 1:
                    dniCompleto = string.Concat(numDni, "R");
                    
                    break;

                case 2:
                    dniCompleto = string.Concat(numDni, "W");
                    
                    break;

                case 3:
                    dniCompleto = string.Concat(numDni, "A");
                    
                    break;

                case 4:
                    dniCompleto = string.Concat(numDni, "G");
                    
                    break;

                case 5:
                    dniCompleto = string.Concat(numDni, "M");
                    
                    break;

                case 6:
                    dniCompleto = string.Concat(numDni, "Y");
                    
                    break;

                case 7:
                    dniCompleto = string.Concat(numDni, "F");
                    
                    break;

                case 8:
                    dniCompleto = string.Concat(numDni, "P");
                    
                    break;

                case 9:
                    dniCompleto = string.Concat(numDni, "D");
                    
                    break;

                case 10:
                    dniCompleto = string.Concat(numDni, "X");
                    
                    break;

                case 11:
                    dniCompleto = string.Concat(numDni, "B");
                    
                    break;

                case 12:
                    dniCompleto = string.Concat(numDni, "N");
                    
                    break;

                case 13:
                    dniCompleto = string.Concat(numDni, "J");
                    
                    break;

                case 14:
                    dniCompleto = string.Concat(numDni, "Z");
                    
                    break;

                case 15:
                    dniCompleto = string.Concat(numDni, "S");
                    
                    break;

                case 16:
                    dniCompleto = string.Concat(numDni, "Q");
                    
                    break;

                case 17:
                    dniCompleto = string.Concat(numDni, "V");
                    
                    break;

                case 18:
                    dniCompleto = string.Concat(numDni, "H");
                    
                    break;

                case 19:
                    dniCompleto = string.Concat(numDni, "L");
                    
                    break;

                case 20:
                    dniCompleto = string.Concat(numDni, "C");
                    
                    break;

                case 21:
                    dniCompleto = string.Concat(numDni, "K");
                    
                    break;

                case 22:
                    dniCompleto = string.Concat(numDni, "E");
                    
                    break;

                 default:
                    Console.WriteLine("Error numero no valido");
                    break;

                    
            }

            return dniCompleto;
        }

        

        public void registroLlegada(List<PacienteDto> listAntPaciente)
        {

            Console.WriteLine("Introduzca su dni: ");
            string dni = Console.ReadLine();
           

            foreach(PacienteDto paciente in listAntPaciente)
            {
                if (dni.Equals(paciente.Dni)&&DateTime.Now<paciente.FechaCita)
                {
                    Console.WriteLine("Espere su turno para la consulta de Psicología en la sala de espera. Su especialista le avisará.)");
                    break;
                }
                               
            }
                                                            

        }

        public void listadoConsultas(List<PacienteDto> listAntPaciente)
        {
            int opcion,opcionEsp;
            bool cerrarMenuCons = false;
            bool cerrarMenuEsp = false;
            MenuInterfaz mi = new MenuImplementacion();

            while(!cerrarMenuCons)
            {
                opcion = mi.mostrarMenuYSeleccionCons();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Volver al menu principal");
                        cerrarMenuCons=true;
                        break;

                    case 1:
                        Console.WriteLine("Se mostraran las consultas.");
                        opcionEsp = mi.mostrarMenuYSeleccioneSp();

                        while (!cerrarMenuEsp)
                        {
                            switch (opcionEsp)
                            {
                                case 0:
                                    Console.WriteLine("Se volvera al menu anterior.");
                                    cerrarMenuEsp = true;
                                    break;


                                case 1:
                                    Console.WriteLine("Se  motraran las consultas de psicologia.");
                                    mostrarPacientesEsp();
                                    break;

                                case 2:
                                    break;

                                case 3:
                                    break;

                                default:
                                    Console.WriteLine("Opcion introducida no valida.");
                                    break;
                            }
                        }
                        
                        break;

                    case 2:
                        break;

                    default:
                        Console.WriteLine("Opcion introducida no valida.");
                        break;
                }
            }
            
        }

        private void mostrarPacientesEsp()
        {
            string fecha;
            PacienteDto paciente = new PacienteDto();
            DateTime fechaConv;
            do
            {
                Console.WriteLine("Introduce una fecha: (dd-MM-yyyy) ");
                fecha = Console.ReadLine();
                 fechaConv = Convert.ToDateTime(fecha);
                
            } while (paciente.FechaCita.Date != fechaConv.Date);

            string[] arrayNombre = { paciente.Nombre, paciente.Apellidos };
            string nombreEntero = string.Concat(arrayNombre);
            Console.WriteLine("Nombre completo: {0}, Hora: {1}",nombreEntero,paciente.FechaCita);




        }
    }
}
