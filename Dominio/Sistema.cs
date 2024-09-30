using System.Collections;

namespace Dominio
{
    public class Sistema
    {
        private List<Cliente> _clientes = new List<Cliente>();
        private List<Administrador> _administradores = new List<Administrador>();
        private List<Articulo> _articulos = new List<Articulo>();
        private List<Venta> _ventas = new List<Venta>();
        private List<Subasta> _subastas = new List<Subasta>();
        private List<Publicacion> _publicaciones = new List<Publicacion>();

    public Sistema()
        {
            PrecargaClientes();
            precargaAdministradores();
            PrecargaArticulos();
            precargaVentas();
            precargaSubastas();
        }
        
        // Artículos
        public void AgregarArticulo(Articulo articulo)
        {
            articulo.Validar();
            _articulos.Add(articulo);
        }

        // Obtener todos los artículos
        public List<Articulo> ObtenerArticulos()
        {
            return _articulos;
        }
        private void  PrecargaArticulos()
        { 
        AgregarArticulo(new Articulo("Camiseta", "Ropa", 100));
        AgregarArticulo(new Articulo("Pantalón", "Ropa", 250));
        AgregarArticulo(new Articulo("Chaqueta", "Ropa", 300));
        AgregarArticulo(new Articulo("Zapatos", "Calzado", 200));
        AgregarArticulo(new Articulo("Gorra", "Accesorios", 120));
        AgregarArticulo(new Articulo("Bufanda", "Accesorios", 150));
        AgregarArticulo(new Articulo("Reloj", "Accesorios", 400));
        AgregarArticulo(new Articulo("Bolso", "Accesorios", 250));
        AgregarArticulo(new Articulo("Lentes de sol", "Accesorios", 180));
        AgregarArticulo(new Articulo("Camisa", "Ropa", 160));
        AgregarArticulo(new Articulo("Shorts", "Ropa", 130));
        AgregarArticulo(new Articulo("Vestido", "Ropa", 320));
        AgregarArticulo(new Articulo("Chaqueta de cuero", "Ropa", 500));
        AgregarArticulo(new Articulo("Botines", "Calzado", 350));
        AgregarArticulo(new Articulo("Zapatillas", "Calzado", 280));
        AgregarArticulo(new Articulo("Cinturón", "Accesorios", 110));
        AgregarArticulo(new Articulo("Bañador", "Ropa", 130));
        AgregarArticulo(new Articulo("Sombrero", "Accesorios", 140));
        AgregarArticulo(new Articulo("Jersey", "Ropa", 200));
        AgregarArticulo(new Articulo("Pijama", "Ropa", 180));
        AgregarArticulo(new Articulo("Saco", "Ropa", 450));
        AgregarArticulo(new Articulo("Botas", "Calzado", 400));
        AgregarArticulo(new Articulo("Sandalias", "Calzado", 220));
        AgregarArticulo(new Articulo("Tirantes", "Accesorios", 70));
        AgregarArticulo(new Articulo("Monedero", "Accesorios", 90));
        AgregarArticulo(new Articulo("Chaleco", "Ropa", 250));
        AgregarArticulo(new Articulo("Pantalón corto", "Ropa", 150));
        AgregarArticulo(new Articulo("Camisa de cuadros", "Ropa", 210));
        AgregarArticulo(new Articulo("Leggings", "Ropa", 160));
        AgregarArticulo(new Articulo("Sudadera", "Ropa", 270));
        AgregarArticulo(new Articulo("Bolsillo", "Accesorios", 80));
        AgregarArticulo(new Articulo("Abrigo", "Ropa", 550));
        AgregarArticulo(new Articulo("Kimonos", "Ropa", 350));
        AgregarArticulo(new Articulo("Sandalias planas", "Calzado", 120));
        AgregarArticulo(new Articulo("Guantes", "Accesorios", 90));
        AgregarArticulo(new Articulo("Bufanda de lana", "Accesorios", 150));
        AgregarArticulo(new Articulo("Zapatos de vestir", "Calzado", 480));
        AgregarArticulo(new Articulo("Tacones", "Calzado", 500));
        AgregarArticulo(new Articulo("Camisón", "Ropa", 200));
        AgregarArticulo(new Articulo("Sudadera con capucha", "Ropa", 250));
        AgregarArticulo(new Articulo("Pantalones deportivos", "Ropa", 210));
        AgregarArticulo(new Articulo("Chaleco acolchado", "Ropa", 300));
        AgregarArticulo(new Articulo("Chaleco de mezclilla", "Ropa", 250));
        AgregarArticulo(new Articulo("Zapatillas deportivas", "Calzado", 350));
        AgregarArticulo(new Articulo("Ropa interior", "Ropa", 90));
        AgregarArticulo(new Articulo("Abrigo de lluvia", "Ropa", 400));
        AgregarArticulo(new Articulo("Traje", "Ropa", 800));
        AgregarArticulo(new Articulo("Calcetines", "Accesorios", 30));
        AgregarArticulo(new Articulo("Corbata", "Accesorios", 120));
        AgregarArticulo(new Articulo("Ropa de deporte", "Ropa", 350));
        AgregarArticulo(new Articulo("Pantalón de vestir", "Ropa", 320));
        AgregarArticulo(new Articulo("Camiseta sin mangas", "Ropa", 100));
        AgregarArticulo(new Articulo("Mono", "Ropa", 400));
        AgregarArticulo(new Articulo("Pantalones cargo", "Ropa", 250));
        AgregarArticulo(new Articulo("Bolso de mano", "Accesorios", 300));
        AgregarArticulo(new Articulo("Portafolios", "Accesorios", 450));
        AgregarArticulo(new Articulo("Mochila", "Accesorios", 200));
        AgregarArticulo(new Articulo("Bañador de dos piezas", "Ropa", 200));
        AgregarArticulo(new Articulo("Mono de baño", "Ropa", 250));
        }
        
        //Clientes
        private void AgregarCliente(Cliente cliente)
        {
            cliente.Validar();
            _clientes.Add(cliente);
        }
        
        public List<Cliente> ObtenerClientes()
        {
            return _clientes;
        }

        public void PrecargaClientes()
        {
            {
                AgregarCliente(new Cliente("Agustina", "Herrera", "agustina.herrera@gmail.com", "contrasenia123", 1000));
                AgregarCliente(new Cliente("Juan", "Pérez", "juan.perez@hotmail.com", "contrasenia456", 2000));
                AgregarCliente(new Cliente("María", "González", "maria.gonzalez@yahoo.com", "contrasenia789", 1500));
                AgregarCliente(new Cliente("Carlos", "Martínez", "carlos.martinez@live.com", "contrasenia321", 2500));
                AgregarCliente(new Cliente("Lucía", "Rodríguez", "lucia.rodriguez@gmail.com", "contrasenia654", 1200));
                AgregarCliente(new Cliente("Pedro", "Sánchez", "pedro.sanchez@hotmail.com", "contrasenia987", 3000));
                AgregarCliente(new Cliente("Sofía", "Fernández", "sofia.fernandez@yahoo.com", "contrasenia135", 800));
                AgregarCliente(new Cliente("Diego", "López", "diego.lopez@live.com", "contrasenia246", 4000));
                AgregarCliente(new Cliente("Isabella", "Mendoza", "isabella.mendoza@gmail.com", "contrasenia369", 900));
                AgregarCliente(new Cliente("Gabriel", "Torres", "gabriel.torres@hotmail.com", "contrasenia258", 1800));
            }
        }

        //Administradores
        public void AgregarAdministrador(Administrador administrador)
        {
            administrador.Validar();
            _administradores.Add(administrador);
        }

        private void precargaAdministradores()
        {
            {
                AgregarAdministrador(new Administrador("Laura", "Salazar", "laura.salazar@gmail.com", "admin123"));
                AgregarAdministrador(new Administrador("Felipe", "Jiménez", "felipe.jimenez@hotmail.com", "admin456"));
            }
        }
        
        //Ventas
        public void AgregarVenta(Venta venta)
        {
            _ventas.Add(venta);
        }

        private void precargaVentas()
        {
            var articulosVenta1 = new List<Articulo> { _articulos[0], _articulos[1] }; // Camiseta y Pantalón
            var articulosVenta2 = new List<Articulo> { _articulos[2], _articulos[3] }; // Chaqueta y Zapatos
            var articulosVenta3 = new List<Articulo> { _articulos[4], _articulos[5] }; // Gorra y Bufanda
            var articulosVenta4 = new List<Articulo> { _articulos[6], _articulos[7] }; // Reloj y Bolso
            var articulosVenta5 = new List<Articulo> { _articulos[8], _articulos[9] }; // Lentes de sol y Camisa
            var articulosVenta6 = new List<Articulo> { _articulos[10], _articulos[11] }; // Shorts y Vestido
            var articulosVenta7 = new List<Articulo> { _articulos[12], _articulos[13] }; // Chaqueta de cuero y Botines
            var articulosVenta8 = new List<Articulo> { _articulos[14], _articulos[15] }; // Zapatillas y Cinturón
            var articulosVenta9 = new List<Articulo> { _articulos[16], _articulos[17] }; // Bañador y Sombrero
            var articulosVenta10 = new List<Articulo> { _articulos[18], _articulos[19] }; // Jersey y Pijama

            AgregarVenta(new Venta("Venta 1", articulosVenta1, false));
            AgregarVenta(new Venta("Venta 2", articulosVenta2, true));
            AgregarVenta(new Venta("Venta 3", articulosVenta3, false));
            AgregarVenta(new Venta("Venta 4", articulosVenta4, true));
            AgregarVenta(new Venta("Venta 5", articulosVenta5, false));
            AgregarVenta(new Venta("Venta 6", articulosVenta6, true));
            AgregarVenta(new Venta("Venta 7", articulosVenta7, false));
            AgregarVenta(new Venta("Venta 8", articulosVenta8, true));
            AgregarVenta(new Venta("Venta 9", articulosVenta9, false));
            AgregarVenta(new Venta("Venta 10", articulosVenta10, true));
        
        }
        
        //Subastas
        
        public void AgregarSubastas(Subasta subasta)
        {
            _subastas.Add(subasta);
        }

        private void precargaSubastas()
        {
            var articulosSubasta1 = new List<Articulo> { _articulos[0], _articulos[1] };
            var articulosSubasta2 = new List<Articulo> { _articulos[2], _articulos[3] };
            var articulosSubasta3 = new List<Articulo> { _articulos[4], _articulos[5] };
            var articulosSubasta4 = new List<Articulo> { _articulos[6], _articulos[7] };
            var articulosSubasta5 = new List<Articulo> { _articulos[8], _articulos[9] };
            var articulosSubasta6 = new List<Articulo> { _articulos[0], _articulos[2] };
            var articulosSubasta7 = new List<Articulo> { _articulos[1], _articulos[3] };
            var articulosSubasta8 = new List<Articulo> { _articulos[4], _articulos[6] };
            var articulosSubasta9 = new List<Articulo> { _articulos[5], _articulos[7] };
            var articulosSubasta10 = new List<Articulo> { _articulos[8], _articulos[9] };
            
            AgregarSubastas(new Subasta("Subasta 1", articulosSubasta1));
            AgregarSubastas(new Subasta("Subasta 2", articulosSubasta2)); 
            AgregarSubastas(new Subasta("Subasta 3", articulosSubasta3));
            AgregarSubastas(new Subasta("Subasta 4", articulosSubasta4)); 
            AgregarSubastas(new Subasta("Subasta 5", articulosSubasta5));
            AgregarSubastas(new Subasta("Subasta 6", articulosSubasta6)); // Con oferta
            AgregarSubastas(new Subasta("Subasta 7", articulosSubasta7));
            AgregarSubastas(new Subasta("Subasta 8", articulosSubasta8)); // Con oferta
            AgregarSubastas(new Subasta("Subasta 9", articulosSubasta9));
            AgregarSubastas(new Subasta("Subasta 10", articulosSubasta10));
        }
        
        
        public List<Publicacion> ObtenerPublicacionesPorFecha(DateTime inicio, DateTime fin)
        {
            var publicaciones = new List<Publicacion>();
        
            // Agregar las ventas a la lista de publicaciones
            publicaciones.AddRange(_ventas);
            // Agregar las subastas a la lista de publicaciones
            publicaciones.AddRange(_subastas);
        
            // Filtrar las publicaciones por la fecha proporcionada
            return _publicaciones
                .Where(p => p.FechaPublicacion >= inicio && p.FechaPublicacion <= fin)
                .ToList();
        }
        
    }
    
}
