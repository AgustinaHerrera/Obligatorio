using Dominio.Interfases;

namespace Dominio
{
    public class Articulo : IValidable
    {
        private int _id;
        private static int s_ultId = 1;
        private string _nombre;
        private string _categoria;
        private double _precioVenta;

        public Articulo(string nombre, string categoria, double precioVenta)
        {
            _id = s_ultId;
            s_ultId++;
            _nombre = nombre;
            _categoria = categoria;
            _precioVenta = precioVenta;
        }

        public double PrecioVenta
        {
            get { return _precioVenta; }
        }

        public string Categoria
        {
            get { return _categoria; }
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(_nombre)) throw new Exception("El nombre no puede ser vacío");
            if (string.IsNullOrEmpty(_categoria)) throw new Exception("La categoría no puede ser vacía");
            if (_precioVenta <= 0) throw new Exception("El precio debe ser mayor que cero");
        }
    }
}