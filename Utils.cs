using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionArreglos1
{
    public static class Utils
    {
        public static void RenderizarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("***                 BIENVENIDO AL SISTEMA RRHH                  ***");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("***                       MENU DE OPCIONES                      ***");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("*** [1] Crear Empleado - [2] Consultar Datos                    ***");
            Console.WriteLine("*** [0] Salir                                                   ***");
            Console.WriteLine("-------------------------------------------------------------------");
        }

        public static void RenderizarMenuCrearEmpleado()
        {
            Console.Clear();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("***                 BIENVENIDO AL SISTEMA RRHH                  ***");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("***                        CREAR EMPLEADO                       ***");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Presiona [Enter] para regresar al menú principal.");
        }
        public static void RenderizarMenuConsultas()
        {
            Console.Clear();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("***                 BIENVENIDO AL SISTEMA RRHH                  ***");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("***                     CONSULTAR EMPLEADOS                     ***");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Presiona [Enter] para regresar al menú principal.");
        }

        public static string RenderizarEspacios(int cantidad)
        {
            string espacios = "";
            for (int i = 0; i < cantidad; i++) 
            {
                espacios += " ";
            }
            return espacios;
        }
    }
}
