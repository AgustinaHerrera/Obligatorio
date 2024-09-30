using System;
using Dominio;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            Sistema sistema = new Sistema(); // Instancia de la clase Sistema

            while (opcion != "0")
            {
                MostrarMenu();
                opcion = PedirPalabras("Ingrese una opción -> ");

                switch (opcion)
                {
                    case "1":
                        ListadoDeClientes(sistema);
                        break;
                    case "2":
                        Categorias(sistema);
                        break;
                    case "3":
                        AltaDeArticulos(sistema);
                        break;
                    case "4":
                        PublicacionesPorFecha(sistema);
                        break;
                    case "0":
                        Console.Clear();
                        CambioDeColor("Saliendo del sistema...", ConsoleColor.Yellow);
                        break;
                    default:
                        MostrarError("Debe ingresar una opción válida");
                        PressToContinue();
                        break;
                }
            }
        }

        #region METODOS DE MENU

        static void MostrarMenu()
        {
            Console.Clear();
            CambioDeColor("**************", ConsoleColor.Cyan);
            CambioDeColor("     MENU     ", ConsoleColor.Cyan);
            CambioDeColor("**************", ConsoleColor.Cyan);
            Console.WriteLine();
            Console.WriteLine("1 - Listado de clientes");
            Console.WriteLine("2 - Categorías");
            Console.WriteLine("3 - Alta de artículos");
            Console.WriteLine("4 - Publicaciones por fecha");
            Console.WriteLine("0 - Salir");
        }

 static void ListadoDeClientes(Sistema sistema)
        {
            Console.Clear();
            CambioDeColor("OPCIÓN: Listado de clientes", ConsoleColor.Yellow);
            Console.WriteLine();

            var clientes = sistema.ObtenerClientes(); 
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.Id}, Nombre: {cliente.Nombre}, Saldo: {cliente.Saldo}");
            }

            PressToContinue();
        }

        static void Categorias(Sistema sistema)
        {
            Console.Clear();
            CambioDeColor("OPCIÓN: Categorías", ConsoleColor.Yellow);
            Console.WriteLine("Mostrar categorías disponibles...");

            var articulos = sistema.ObtenerArticulos(); 
            foreach (var articulo in articulos)
            {
                Console.WriteLine($"Categoría: {articulo.Categoria}");
            }

            PressToContinue();
        }

        static void AltaDeArticulos(Sistema sistema)
        {
            Console.Clear();
            CambioDeColor("OPCIÓN: Alta de artículos", ConsoleColor.Yellow);
            Console.Write("Ingrese el nombre del artículo: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la categoría del artículo: ");
            string categoria = Console.ReadLine();
            Console.Write("Ingrese el precio de venta del artículo: ");
            double precioVenta = PedirNumeros("Precio: ");

            Articulo nuevoArticulo = new Articulo(nombre, categoria, precioVenta);
            sistema.AgregarArticulo(nuevoArticulo); 
            MostrarExito("Artículo agregado correctamente.");
            PressToContinue();
        }

        static void PublicacionesPorFecha(Sistema sistema)
        {
            Console.Clear();
            CambioDeColor("OPCIÓN: Publicaciones por fecha", ConsoleColor.Yellow);
            Console.WriteLine("Ingrese la fecha de inicio (formato: dd/MM/yyyy):");
            DateTime fechaInicio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de fin (formato: dd/MM/yyyy):");
            DateTime fechaFin = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Publicaciones entre {fechaInicio.ToShortDateString()} y {fechaFin.ToShortDateString()}:");
            var publicaciones = sistema.ObtenerPublicacionesPorFecha(fechaInicio, fechaFin);

            foreach (var publicacion in publicaciones)
            {
                Console.WriteLine($"ID: {publicacion.Id}, Nombre: {publicacion.Nombre}, Estado: {publicacion.estado}, Fecha: {publicacion.FechaPublicacion}");
            }

            PressToContinue();
        }

        static void PressToContinue()
        {
            Console.WriteLine();
            CambioDeColor("Presione una tecla para continuar ...", ConsoleColor.Cyan);
            Console.ReadKey();
        }

        #endregion


        #region METODOS AUXILIARES

        static string PedirPalabras(string mensaje)
        {
            Console.Write(mensaje);
            string datosPedidos = Console.ReadLine();
            return datosPedidos;
        }

        static int PedirNumeros(string mensaje)
        {
            bool exito = false;
            int numero = 0;
            while (exito == false)
            {
                Console.Write(mensaje);
                exito = int.TryParse(Console.ReadLine(), out numero);

                if (exito == false)
                {
                    MostrarError("ERROR: Debe ingresar solo números.");
                }
            }

            return numero;
        }

        static void MostrarError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void MostrarExito(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void CambioDeColor(string mensaje, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        #endregion

    }
}
