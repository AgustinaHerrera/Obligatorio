namespace Dominio
{
    public class Venta : Publicacion
    {
        private bool _ofertaRelampago;

        public Venta(string nombre, List<Articulo> articulos, bool ofertaRelampago) 
            : base(nombre, Dominio.Estado.ABIERTA, articulos)
        {
            _ofertaRelampago = ofertaRelampago;
        }

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