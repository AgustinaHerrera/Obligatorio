namespace Dominio
{
    public class Subasta : Publicacion
    {
        private List<Oferta> _ofertas;
        private Administrador _usuarioFinalizador;


        public Subasta(string nombre, List<Articulo> articulos, DateTime fechaPublicacion, Cliente comprador, DateTime fechaFinalizacion, Administrador usuarioFinalizador) 
            : base(nombre, Estado.ABIERTA, articulos, fechaPublicacion, comprador, fechaFinalizacion)// Inicializa en estado ABIERTA
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
        

    }
}