using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Leandro_Polano
{
   public class Program
    {
                   public static List<Empleado> listaEmpleados = new List<Empleado>();
                   public static List<Directivo> directivos = new List<Directivo>();
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Proveedor> proveedores = new List<Proveedor>();
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    List<string> sectores = new List<string>();


                    Console.WriteLine("Ingrese la cantidad de sectores");
                    int cantidad = int.Parse(Console.ReadLine());

                    for (int i = 0; i < cantidad; i++)
                    {
                        AgregarSector(sectores);

                    }

                    Cliente cliente = CrearCliente();

                    clientes.Add(cliente);

                    Proveedor proveedor = CrearProveedor();

                    proveedores.Add(proveedor);

                    foreach (var s in sectores)
                    {
                        Console.WriteLine(s);
                        foreach (var e in listaEmpleados)
                        {
                            if (e.Sector == s)
                            {
                                Console.WriteLine(e.ToString());
                            }
                        }
                    }

                    Console.WriteLine(cliente.ToString());
                    Console.WriteLine(proveedor.ToString());
                    Console.ReadLine();



                }
                catch (Exception)
                {

                    Console.WriteLine(" Error ");
                }




            } while (true);
        }

        private static Proveedor CrearProveedor()
        {
            Console.WriteLine("Ingrese el el nombre de un proveedor");
            var nombreProveedor = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido de un proveedor");
            var apellidoProveedor = Console.ReadLine();

            Console.WriteLine("Ingrese el telefono de un proveedor");
            var telefonoProveedor = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre de fantasia de un proveedor");
            var nombreFantasia = Console.ReadLine();

            Persona persona = new Persona(nombreProveedor, apellidoProveedor, telefonoProveedor);
            Proveedor proveedor = new Proveedor(nombreFantasia, persona);
            return proveedor;
        }

        private static Cliente CrearCliente()
        {
            Console.WriteLine("Ingrese el el nombre de un cliente");
            var nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido de un cliente");
            var apellido = Console.ReadLine();

            Console.WriteLine("Ingrese el telefono de un cliente");
            var telefono = Console.ReadLine();

            Console.WriteLine("Ingrese el mail de un cliente");
            var mail = Console.ReadLine();


            Cliente cliente = new Cliente(nombre, apellido, telefono, mail);
            return cliente;
        }

        public static void AgregarSector(List<string> sectores)
        {
            Console.WriteLine("Ingrese un Sector:");

            var sector = Console.ReadLine();
            sectores.Add(sector);
            Console.WriteLine("Ingrese La cantidad de Empleados");
            int cantidad = int.Parse(Console.ReadLine());
            for (int d = 0; d < cantidad; d++)
            {
                Console.WriteLine("Ingrese el nombre de un empleado");
                string nombreEmpleado = Console.ReadLine();

                Console.WriteLine("Ingrese el apellido de un empleado");
                string apellidoEmpleado = Console.ReadLine();

                Console.WriteLine("Ingrese la edad de un empleado");
                int edadEmpleado = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el telefono de un empleado");
                string telefonoEmpleado = Console.ReadLine();

                Console.WriteLine("Ingrese el sueldo de un empleado");
                decimal sueldoEmpleado = decimal.Parse(Console.ReadLine());

                Empleado empleado = new Empleado(edadEmpleado, sector, nombreEmpleado, apellidoEmpleado, telefonoEmpleado);

                listaEmpleados.Add(empleado);
            }

            Console.WriteLine("Ingrese el nombre de un directivo");
            var nombreDirectivo = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido de un directivo");
            var apellidoDirectivo = Console.ReadLine();

            Console.WriteLine("Ingrese la edad de un directivo");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el telefono de un directivo");
            var telefonoDirectivo = Console.ReadLine();

            Console.WriteLine("Ingrese el sueldo de un directivo");
            var sueldo = Console.ReadLine();

            Console.WriteLine("Ingrese la categoria de un directivo");
            var categoria = Console.ReadLine();

            Directivo directivo = new Directivo(categoria, edad, sector, nombreDirectivo, apellidoDirectivo, telefonoDirectivo);

            directivos.Add(directivo);
        }

      
        
    }
}
