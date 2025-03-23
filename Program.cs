
namespace AsignacionArreglos1
{
    internal class Program
    {
        public static string[] empleados = [];

        public static string[] departamentos = [];

        public static string[] empleadoDepartamento = [];
        static void Main(string[] args)
        {
            bool salirSistema = true;
            while (salirSistema)
            {
                int opcionMenu = 0;
                Utils.RenderizarMenuPrincipal();
                Console.Write("Digite el número de opción del Menú:> ");

                int.TryParse(Console.ReadLine(), out opcionMenu);

                //opciones del menu
                switch (opcionMenu)
                {
                    case 1:
                        CrearEmpleado();
                       break;
                    case 2:
                        Consultar();
                        break;
                    case 0:
                        salirSistema = false;
                        break;

                }
            }
            Console.WriteLine("Saliendo del sistema...");
            Console.ReadKey();
        }

        private static void Consultar()
        {
            bool operacionenCurso = true;
            while (operacionenCurso)
            {
                if (empleadoDepartamento.Length > 0)
                {
                    Console.Clear();
                    //Utils.RenderizarMenuConsultas();
                    Console.WriteLine("Listado General de Empleados");
                    Console.WriteLine("------------------------------------------------------------------");
                    int contador = 1;
                    for (int i = 0; i < empleadoDepartamento.Length; i++)
                    {
                        Console.WriteLine("["+ contador + "] - " + empleadoDepartamento[i]);
                        contador++;
                    }
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine("Total registros: " + empleadoDepartamento.Length);
                    Console.WriteLine();
                    Console.Write("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    operacionenCurso = false;
                }
                else
                {
                    Utils.RenderizarMenuConsultas();
                    Console.WriteLine();
                    Console.WriteLine("ERROR: Debe existir por lo menos un empleado y un departamento, vuelva a intentarlo.");
                    Console.Write("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    operacionenCurso = false;
                }
            }
        }

        private static void CrearEmpleado()
        {
            bool operacionenCurso = true;

            while (operacionenCurso)
            {
                Utils.RenderizarMenuCrearEmpleado();
                Console.Write("Ingrese el nombre del Empleado:> ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el nombre del Departamento:> ");
                string departamento = Console.ReadLine();

                Utils.RenderizarMenuCrearEmpleado();

                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(departamento))
                {
                    operacionenCurso = false;

                    Array.Resize(ref empleados, empleados.Length + 1);
                    empleados[empleados.Length - 1] = nombre;

                    Array.Resize(ref departamentos, departamentos.Length + 1);
                    departamentos[departamentos.Length - 1] = departamento;

                    Array.Resize(ref empleadoDepartamento, empleadoDepartamento.Length + 1);
                    empleadoDepartamento[empleadoDepartamento.Length - 1] = nombre + " - " + departamento;

                    Console.WriteLine("> El empleado: " + nombre + " y el departamento: " + departamento + ", han sido creado con exito.");
                    Console.Write("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("ERROR: No se han ingresado los datos de forma correcta, vuelva a intentarlo.");
                    Console.Write("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
