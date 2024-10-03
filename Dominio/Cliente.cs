using Dominio.Interfases;

namespace Dominio
{
    public class Cliente : Usuario
    {
        private double _saldoDisponible;

        public Cliente(string nombre, string apellido, string email, string contrasenia, double saldo) 
            : base(nombre, apellido, email, contrasenia)
        {
            _saldoDisponible = saldo;
        }


        public double SaldoDisponible
        {
            get { return _saldoDisponible; }
            set { _saldoDisponible = value; }
        }

        public int Id
        {
            get{ return _id; }
        }
        public string Nombre
        {
            get{ return _nombre; }
        }

        public double Saldo
        {
            get{ return _saldoDisponible; }
        }
        public override void Validar()
        {
            base.Validar();
            if (_saldoDisponible < 0) throw new Exception("El saldo no puede ser negativo");
        }
        
        public override string ToString()
        {
            return $"ID: {_id}, Nombre: {_nombre}, Saldo: {_saldoDisponible}"; 
        }
        
    }
    
}