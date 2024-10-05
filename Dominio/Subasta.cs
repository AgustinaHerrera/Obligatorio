namespace Dominio
{
    public class Subasta : Publicacion
    {
        private List<Oferta> _oferta = new List<Oferta>();
        private Administrador _usuarioFinalizador;

        public Subasta(string nombre, List<Articulo> articulos, DateTime fechaPublicacion, Cliente comprador, DateTime fechaFinalizacion, Administrador usuarioFinalizador) 
            : base(nombre, Estado.ABIERTA, articulos, fechaPublicacion, comprador, fechaFinalizacion)// Inicializa en estado ABIERTA
        {
            _oferta = new List<Oferta>();
            
        }

        public List<Oferta> ObtenerOfertas()
        {
            return _oferta;
        }

        //NO VA PRIMERA ENTREGA
        public void RealizarOferta(Oferta oferta)
        {
            if (estado != Estado.ABIERTA)
            {
                throw new Exception("No se pueden realizar ofertas en una subasta cerrada o cancelada.");
            }

            oferta.Validar();  
            _oferta.Add(oferta);
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

        
        public void AltaOferta(Oferta o)
        {
            if (o == null) throw new Exception("La oferta no puede ser nula");
            if (_oferta.Contains(o)) throw new Exception("Ya existe la oferta en la subasta");
    
            _oferta.Add(o); 
        }
    }
}

