namespace Dominio
{
    public class Administrador : Usuario
    {
        public Administrador(string nombre, string apellido, string email, string contrasenia) 
            : base(nombre, apellido, email, contrasenia)
        {
        }

        // Método para cerrar una subasta
        public void CerrarSubasta(Subasta subasta, Cliente cliente)
        {
            // Verifica si el comprador tiene saldo suficiente para realizar la compra
            double precioFinal = subasta.CalcularPrecio();
            if (cliente.SaldoDisponible < precioFinal)
            {
                throw new Exception("El comprador no tiene saldo suficiente.");
            }

            // Finaliza la compra
            subasta.FinalizarCompra(cliente, this);
            cliente.SaldoDisponible -= precioFinal; // Descuenta el saldo del comprador
        }
        
    }
}