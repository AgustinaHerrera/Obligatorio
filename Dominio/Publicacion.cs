using Dominio.Interfases;

namespace Dominio
{
    public abstract class Publicacion: IValidable
    {
        private int _id;
        private static int s_ultId = 1;
        private string _nombre;
        private Estado _estado;
        private DateTime _fechaPublicacion;
        internal List<Articulo> _articulos;
        private Cliente _comprador;
        private DateTime _fechaFinalizacion;

        public Publicacion(string nombre, Estado estado, List<Articulo> articulos, DateTime fechaPublicacion, Cliente comprador, DateTime fechaFinalizacion)
        {
            _id = s_ultId++;
            _nombre = nombre;
            _fechaPublicacion = fechaPublicacion;
            _articulos = articulos;
            _estado = estado;
        }

        public Estado estado
        {
            get { return _estado; }
        }
        
        public DateTime FechaPublicacion
        {
            get { return _fechaPublicacion; }
        }
        

        public int Id
        {
            get { return _id; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Estado: {estado}, Fecha: {FechaPublicacion}";
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(_nombre)) throw new Exception("El nombre no puede ser vacío");
            
        }
    }
}