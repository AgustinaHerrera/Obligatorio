namespace Dominio
{
    public abstract class Publicacion
    {
        private int _id;
        private static int s_ultId = 1;
        private string _nombre;
        private Estado _estado;
        private DateTime _fechaPublicacion;
        internal List<Articulo> _articulos;
        private Cliente _comprador;  
        private Usuario _usuarioFinalizador; 
       

        public Publicacion(string nombre, Estado estado, List<Articulo> articulos)
        {
            _id = s_ultId++;
            _nombre = nombre;
            _fechaPublicacion = DateTime.Now;
            _articulos = articulos;
            _estado = Dominio.Estado.ABIERTA;
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
    }
}