namespace Dominio
{
    public class Subasta : Publicacion
    {
        private List<Oferta> _ofertas;

        public Subasta(string nombre, List<Articulo> articulos)
            : base(nombre, Estado.ABIERTA, articulos) // Inicializa en estado ABIERTA
        {
            _ofertas = new List<Oferta>();
        }

        public List<Oferta> Ofertas
        {
            get { return _ofertas; }
        }

        public void RealizarOferta(Oferta oferta)
        {
            if (estado != Estado.ABIERTA)
            {
                throw new Exception("No se pueden realizar ofertas en una subasta cerrada o cancelada.");
            }

            oferta.Validar();
            _ofertas.Add(oferta);
        }

        public double CalcularPrecio()
        {
            throw new NotImplementedException();
        }

        public void FinalizarCompra(Cliente cliente, Administrador administrador)
        {
            throw new NotImplementedException();
        }
    }
}
