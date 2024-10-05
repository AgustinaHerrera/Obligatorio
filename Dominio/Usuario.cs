using Dominio.Interfases;

namespace Dominio
{
    public abstract class Usuario : IValidable
    {
        public int _id;
        private static int s_ultId = 1;
        public string _nombre;
        private string _apellido;
        private string _email;
        private string _contrasenia;

        public Usuario(string nombre, string apellido, string email, string contrasenia)
        {
            _id = s_ultId++;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _contrasenia = contrasenia;
        }

        public virtual void Validar()
        {
            if (string.IsNullOrEmpty(_nombre)) throw new Exception("El nombre no puede ser vacío");
            if (string.IsNullOrEmpty(_apellido)) throw new Exception("El apellido no puede ser vacío");
            if (string.IsNullOrEmpty(_email)) throw new Exception("El email no puede ser vacío");
            if (string.IsNullOrEmpty(_contrasenia)) throw new Exception("La contraseña no puede ser vacía");
        }

    }
}