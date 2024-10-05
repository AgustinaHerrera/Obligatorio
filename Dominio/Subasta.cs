namespace Dominio
{
    public class Subasta : Publicacion
    {
        private List<Oferta> _ofertas;
        private List<OfertaSubasta> _ofertaSubastas = new List<OfertaSubasta>();
        private Administrador _usuarioFinalizador;

        public Subasta(string nombre, List<Articulo> articulos, DateTime fechaPublicacion) 
            : base(nombre, Estado.ABIERTA, articulos, fechaPublicacion)// Inicializa en estado ABIERTA
        {
            _ofertas = new List<Oferta>();
            
        }

        public List<Oferta> ObtenerOfertas()
        {
            return _ofertas;
        }

        //NO VA PRIMERA ENTREGA
        public void RealizarOferta(Oferta oferta)
        {
            if (estado != Estado.ABIERTA)
            {
                throw new Exception("No se pueden realizar ofertas en una subasta cerrada o cancelada.");
            }

            oferta.Validar();  
            _ofertas.Add(oferta);
        }
        
        //NO VA PRIMERA ENTREGA
        public double CalcularPrecio()
        {
            throw new NotImplementedException();
        }
        
        //NO VA PRIMERA ENTREGA
        public void FinalizarCompra(Cliente cliente, Administrador administrador)
        {
            throw new NotImplementedException();
        }

        //NO VA PRIMERA ENTREGA
        public void AltaOferta(OfertaSubasta os)
        {
            if (os == null) throw new Exception("La oferta no puede ser nula");
            if (_ofertas.Contains(os)) throw new Exception("Ya existe la oferta en la subasta");
    
            _ofertas.Add(os); 
        }
    }
}

