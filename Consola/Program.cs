﻿using System;
using Dominio;

namespace Menu
{
    
    internal class Program
    {
        private static Sistema miSistema;

        static void Main(string[] args)
        {
            string opcion = "";
            miSistema = new Sistema();
            
            while (opcion != "0")
            {
                MostrarMenu();
                opcion = PedirPalabras("Ingrese una opción -> ");

                switch (opcion)
                {
                    case "1":
                        ListadoDeClientes();
                        break;
                    case "2":
                        Categorias();
                        break;
                    case "3":
                        AltaDeArticulos();
                        break;
                    case "4":
                        PublicacionesPorFecha();
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
            Console.WriteLine("2 - Listar articulos de una categoria");
            Console.WriteLine("3 - Alta de artículos");
            Console.WriteLine("4 - Publicaciones por fecha");
            Console.WriteLine("0 - Salir");
        }

        static void ListadoDeClientes()
        {
            Console.Clear();
            CambioDeColor("OPCIÓN: Listado de clientes", ConsoleColor.Yellow);
            Console.WriteLine();

            List<Cliente> clientes = miSistema.ObtenerClientes();
            try
            {
                if (clientes.Count == 0) throw new Exception("No se encontraron clientes");
                foreach (Cliente c in clientes)
                {
                    Console.WriteLine(c);
                }
            }
            catch (Exception ex)
            {
                MostrarError (ex.Message);
            }
            
            PressToContinue();
        }

        static void Categorias()
        {
            Console.Clear();
            CambioDeColor("OPCIÓN: Listar articulos de una categoria: ", ConsoleColor.Yellow);
            string buscado = PedirPalabras("Ingrese el categoria: ");

            List<Articulo> articulos = miSistema.ObtenerArticulos();
            try
            {
                foreach (Articulo a in articulos)
                {
                    if(a.Categoria.ToLower() == buscado.ToLower()) Console.WriteLine(a);
                }
            }
            catch (Exception ex)
            {
                MostrarError (ex.Message);
            }

            PressToContinue();
        }

        private static void AltaDeArticulos()
        {
            Console.Clear();
            CambioDeColor("OPCIÓN: Alta de artículos", ConsoleColor.Yellow);
            string nombre = PedirPalabras("Ingrese el nombre del artículo: ");
            string categoria = PedirPalabras("Ingrese la categoría del artículo: ");
            double precioVenta = PedirNumeros("Ingrese el precio de venta del artículo: ");
            try
            {
                if (string.IsNullOrEmpty(nombre)) throw new Exception("El nombre no puede estar vacio");
                if (string.IsNullOrEmpty(categoria)) throw new Exception("La categoria no puede estar vacia");
                if (precioVenta <= 0) throw new Exception("El precio debe ser mayor a 0");
                Articulo nuevoArticulo = new Articulo(nombre, categoria, precioVenta);
                miSistema.AgregarArticulo(nuevoArticulo); 
                MostrarExito("Artículo agregado correctamente.");
            }
            catch (Exception ex)
            {
                MostrarError (ex.Message);
            }
            PressToContinue();
        }

        static void PublicacionesPorFecha()
        {
            Console.Clear();
            CambioDeColor("OPCIÓN: Publicaciones por fecha", ConsoleColor.Yellow);
            Console.WriteLine("Ingrese la fecha de inicio (formato: dd/MM/yyyy):");
            DateTime fechaInicio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de fin (formato: dd/MM/yyyy):");
            DateTime fechaFin = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Publicaciones entre {fechaInicio.ToShortDateString()} y {fechaFin.ToShortDateString()}:");
            List<Publicacion> publicaciones = miSistema.ObtenerPublicacionesPorFecha(fechaInicio, fechaFin);
            try
            {
                if(publicaciones.Count==0) CambioDeColor("No hay publicaciones en el rango de fechas", ConsoleColor.Red);
                foreach (Publicacion p in publicaciones)
                {
                  if(p!=null)  Console.WriteLine(p);
                } 
            }
            catch (Exception ex)
            {
                MostrarError (ex.Message);
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
