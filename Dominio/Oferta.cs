namespace Dominio
{
    public class Oferta
    {
        private int _id;
        private static int s_ultId = 1;
        private Cliente _cliente;
        private double _monto;
        private DateTime _fechaOferta;

        public Oferta(Cliente cliente, double monto)
        {
            _id = s_ultId++;
            _cliente = cliente;
            _monto = monto;
            _fechaOferta = DateTime.Now;
        }

        public double Monto
        {
            get { return _monto; }
        }


        public void Validar()
        {
            if (_monto <= 0) throw new Exception("El monto debe ser mayor que cero.");
        }
    }
}