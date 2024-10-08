namespace Dominio
{
    public class Oferta
    {
        private int _id;
        private static int s_ultId = 1;
        private Cliente _cliente;
        private double _monto;
        private DateTime _fechaOferta;
        private Subasta _subasta;

        public Oferta(Subasta subasta, Cliente cliente, double monto)
        {
            _id = s_ultId++;
            _cliente = cliente;
            _monto = monto;
            _fechaOferta = DateTime.Now;
            _subasta = subasta;
        }

        public double Monto
        {
            get { return _monto; }
        }

        public int Id
        {
            get { return _id; }
        }

        public Cliente cliente
        {
            get {return _cliente;}
            
        }

        public Subasta Subasta
        {
            get { return _subasta; }
        }

        public override string ToString()
        {
            return $"Cliente: {_cliente.Nombre}, Oferta: {Monto}";
        }
        public void Validar()
        {
            if (_monto <= 0) throw new Exception("El monto debe ser mayor que cero.");
        }
        
    }
}