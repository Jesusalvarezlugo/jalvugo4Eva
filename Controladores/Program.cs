using jalvugo4Eva.Dtos;
using jalvugo4Eva.Servicios;

namespace jalvugo4Eva.Controladores
{
    /// <summary>
    /// Clase por la que entra el flujo de la aplicacion
    /// </summary>
    class Program
    {
        /// <summary>
        /// Clase por el que se accede a los metodos externos
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            FicheroInterfaz fi=new FicheroImplementacion();
            string rutaArchivo = "citas.txt";
            List<PacienteDto> listaPacientes = new List<PacienteDto>();
            int opcion;
            bool cerrarMenu = false;

            fi.leerFichero(rutaArchivo, listaPacientes);

            while (!cerrarMenu)
            {
                opcion = mi.mostrarMenuYSeleccionPrin();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Se saldra de la aplicacion.");
                        cerrarMenu=true;
                        break;

                    case 1:
                        Console.WriteLine("Registro de llegada.");
                        oi.registroLlegada(listaPacientes);
                        break;

                    case 2:
                        Console.WriteLine("Listado de consultas");
                        foreach(PacienteDto paciente in listaPacientes)
                        {
                            
                        }
                        mi.mostrarMenuYSeleccionCons();
                        break;
                }
            }
            
        }
    }
}
