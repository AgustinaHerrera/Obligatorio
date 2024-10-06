using System.Collections;

namespace Dominio
{
    public class Sistema
    {
        private List<Cliente> _clientes = new List<Cliente>();
        private List<Administrador> _administradores = new List<Administrador>();
        private List<Articulo> _articulos = new List<Articulo>();
        private List<Subasta> _subastas = new List<Subasta>();
        private List<Publicacion> _publicaciones = new List<Publicacion>();
        private List<Oferta> _ofertas = new List<Oferta>();

        public Sistema()
        {
            PrecargaClientes();
            PrecargaAdministradores();
            PrecargaArticulos();
            // PrecargaVentas();
            // PrecargaSubastas();
            // PrecargaOfertas();
        }

        // Artículos
        public void AgregarArticulo(Articulo articulo)
        {
            if (articulo == null) throw new Exception("El articulo no puede ser nulo");
            articulo.Validar();
            _articulos.Add(articulo);
        }

        // Obtener todos los artículos
        public List<Articulo> ObtenerArticulos()
        {
            return _articulos;
        }

        private void PrecargaArticulos()
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
            if (cliente == null) throw new Exception("El cliente no puede ser nulo");
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
                AgregarCliente(new Cliente("Agustina", "Herrera", "agustina.herrera@gmail.com", "contrasenia123",
                    1000));
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
            if (administrador == null) throw new Exception("El administrador no puede ser nulo");
            administrador.Validar();
            _administradores.Add(administrador);
        }

        private void PrecargaAdministradores()
        {
            {
                AgregarAdministrador(new Administrador("Laura", "Salazar", "laura.salazar@gmail.com", "admin123"));
                AgregarAdministrador(new Administrador("Felipe", "Jiménez", "felipe.jimenez@hotmail.com", "admin456"));
            }
        }
        
        

        //Ventas
        public void AgregarPublicacion(Publicacion publicacion)
        {
            
            if (publicacion == null) throw new Exception("La publicacion no puede ser nula");
            publicacion.Validar();
            _publicaciones.Add(publicacion);
            if (publicacion is Subasta subasta)
            {
                _subastas.Add(subasta);
            }
        }

        // private void PrecargaVentas()
        // {
        //      List<Articulo> articulosVenta1 = new List<Articulo> { _articulos[0], _articulos[1] }; // Camiseta y Pantalón
        //      List<Articulo> articulosVenta2 = new List<Articulo> { _articulos[2], _articulos[3] }; // Chaqueta y Zapatos
        //      List<Articulo> articulosVenta3 = new List<Articulo> { _articulos[4], _articulos[5] }; // Gorra y Bufanda
        //      List<Articulo> articulosVenta4 = new List<Articulo> { _articulos[6], _articulos[7] }; // Reloj y Bolso
        //      List<Articulo> articulosVenta5 = new List<Articulo> { _articulos[8], _articulos[9] }; // Lentes de sol y Camisa
        //      List<Articulo> articulosVenta6 = new List<Articulo> { _articulos[10], _articulos[11] }; // Shorts y Vestido
        //      List<Articulo> articulosVenta7 = new List<Articulo> { _articulos[12], _articulos[13] }; // Chaqueta de cuero y Botines
        //      List<Articulo> articulosVenta8 = new List<Articulo> { _articulos[14], _articulos[15] }; // Zapatillas y Cinturón
        //      List<Articulo> articulosVenta9 = new List<Articulo> { _articulos[16], _articulos[17] }; // Bañador y Sombrero
        //      List<Articulo> articulosVenta10 = new List<Articulo> { _articulos[18], _articulos[19] }; // Jersey y Pijama
        //
        //     AgregarPublicacion(new Venta("Venta 1", articulosVenta1, true, new DateTime(2024, 09, 15)));
        //     AgregarPublicacion(new Venta("Venta 2", articulosVenta2, true, new DateTime(2024, 09, 16)));
        //     AgregarPublicacion(new Venta("Venta 3", articulosVenta3, true, new DateTime(2024, 09, 17)));
        //     AgregarPublicacion(new Venta("Venta 4", articulosVenta4, true, new DateTime(2024, 09, 18)));
        //     AgregarPublicacion(new Venta("Venta 5", articulosVenta5, true, new DateTime(2024, 09, 19)));
        //     AgregarPublicacion(new Venta("Venta 6", articulosVenta6, true, new DateTime(2024, 09, 20)));
        //     AgregarPublicacion(new Venta("Venta 7", articulosVenta7, true, new DateTime(2024, 09, 21)));
        //     AgregarPublicacion(new Venta("Venta 8", articulosVenta8, true, new DateTime(2024, 09, 22)));
        //     AgregarPublicacion(new Venta("Venta 9", articulosVenta9, true, new DateTime(2024, 09, 23)));
        //     AgregarPublicacion(new Venta("Venta 10", articulosVenta10, true, new DateTime(2024, 09, 24)));
        //
        // }
        //
        // //Subastas
        // private void PrecargaSubastas()
        // {
        //     
        //     List<Articulo> articulosSubasta1 = new List<Articulo> { _articulos[0], _articulos[1] };
        //     List<Articulo> articulosSubasta2 = new List<Articulo> { _articulos[2], _articulos[3] };
        //     List<Articulo> articulosSubasta3 = new List<Articulo> { _articulos[4], _articulos[5] };
        //     List<Articulo> articulosSubasta4 = new List<Articulo> { _articulos[6], _articulos[7] };
        //     List<Articulo> articulosSubasta5 = new List<Articulo> { _articulos[8], _articulos[9] };
        //     List<Articulo> articulosSubasta6 = new List<Articulo> { _articulos[0], _articulos[2] };
        //     List<Articulo> articulosSubasta7 = new List<Articulo> { _articulos[1], _articulos[3] };
        //     List<Articulo> articulosSubasta8 = new List<Articulo> { _articulos[4], _articulos[6] };
        //     List<Articulo> articulosSubasta9 = new List<Articulo> { _articulos[5], _articulos[7] };
        //     List<Articulo> articulosSubasta10 = new List<Articulo> { _articulos[8], _articulos[9] };
        //     
        //
        //     AgregarPublicacion(new Subasta("Subasta 1", articulosSubasta1, new DateTime(2024, 09, 15)));
        //     AgregarPublicacion(new Subasta("Subasta 2", articulosSubasta2, new DateTime(2024, 09, 16)));
        //     AgregarPublicacion(new Subasta("Subasta 3", articulosSubasta3, new DateTime(2024, 09, 17)));
        //     AgregarPublicacion(new Subasta("Subasta 4", articulosSubasta4, new DateTime(2024, 09, 18)));
        //     AgregarPublicacion(new Subasta("Subasta 5", articulosSubasta5, new DateTime(2024, 09, 19)));
        //     AgregarPublicacion(new Subasta("Subasta 6", articulosSubasta6, new DateTime(2024, 09, 20)));
        //     AgregarPublicacion(new Subasta("Subasta 7", articulosSubasta7, new DateTime(2024, 09, 21)));
        //     AgregarPublicacion(new Subasta("Subasta 8", articulosSubasta8, new DateTime(2024, 09, 22)));
        //     AgregarPublicacion(new Subasta("Subasta 9", articulosSubasta9, new DateTime(2024, 09, 23)));
        //     AgregarPublicacion(new Subasta("Subasta 10", articulosSubasta10, new DateTime(2024, 09, 24)));
        // }
        
        public Subasta ObtenerSubastaPorId(int id)
        {
            foreach (Subasta s in _subastas)
            {
        
                if (s.Id == id) // Compara los IDs
                {
                    return s;
                }
            }
            return null; // Si no encuentra, regresa null
        }
        
        
        //NO VA PARA ESTA ENTREGA
            public Oferta ObtenerOfertaPorId(int id)
        {
            Oferta buscado = null;
            int i = 0;
            while(i < _ofertas.Count && buscado == null)
            {
                if (_ofertas[i].Id == id) buscado = _ofertas[i];
                i++;
            }

            return buscado;
        }
            
            

            //NO VA PARA ESTA ENTREGA
        public void AgregarOfertaASubasta(int idSubasta, int idOferta, double montoOferta)
        {
            Subasta subastaBuscada = ObtenerSubastaPorId(idSubasta);
            if (subastaBuscada == null) throw new Exception("El id de subasta no corresponde a ninguna subasta del sistema");

            Oferta ofertaBuscada = ObtenerOfertaPorId(idOferta);
    
            if (ofertaBuscada == null) throw new Exception("La oferta no se encontró");
            
            Oferta o = new Oferta(ofertaBuscada.Cliente, montoOferta);
            subastaBuscada.AltaOferta(o); 
        }

        private void PrecargaOfertas()
        {
            // Crear las ofertas
            Oferta oferta1 = new Oferta(_clientes[0], 100);
            Oferta oferta2 = new Oferta(_clientes[2], 150);
    
            // Agregar las ofertas al sistema antes de usarlas
            _ofertas.Add(oferta1);
            _ofertas.Add(oferta2);
    
            // Agregar las ofertas a las subastas
            AgregarOfertaASubasta(12, oferta1.Id, oferta1.Monto); 
            AgregarOfertaASubasta(14, oferta2.Id, oferta2.Monto);
        }

        public List<Publicacion> ObtenerPublicacionesPorFecha(DateTime inicio, DateTime fin)
        {
            List<Publicacion> buscadas = new List<Publicacion>();
        
            // Filtrar las publicaciones por la fecha proporcionada
            foreach(Publicacion p in _publicaciones)
            {
                if(p.FechaPublicacion >= inicio && p.FechaPublicacion <= fin) buscadas.Add(p);
            }

            return buscadas;
        }
        
    }
    
}
