namespace Dominio
{
    public class Venta : Publicacion
    {
        private bool _ofertaRelampago;
        private Cliente _usuarioFinalizador;

        public Venta(string nombre, List<Articulo> articulos, bool ofertaRelampago, DateTime fechaPublicacion, Cliente comprador, DateTime fechaFinalizacion, Cliente usuarioFinalizador) 
            : base(nombre, Estado.ABIERTA, articulos, fechaPublicacion, comprador, fechaFinalizacion)
        {
            _ofertaRelampago = ofertaRelampago;
        }
        
//NO VA PARA LA PRIMER ENTREGA
        public virtual double CalcularPrecio()
        {
            double total = 0;
            foreach (Articulo articulo in _articulos)
            {
                total += articulo.PrecioVenta;
            }

            if (_ofertaRelampago)
            {
                double descuento = total * 0.2;
                total -= descuento; 
            }
            
            return total;
        }
        
    }
}