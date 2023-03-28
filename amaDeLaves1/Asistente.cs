namespace amaDeLaves
{
    internal class Asistente : Personal
    {
        public void ControlDeInventario(Inventario inv)
        {
            
        }

        public RegistroDeReportes GenerarReportes()
        {
            return new RegistroDeReportes();
        }

        public Producto GenerarSolicitudesYPedidos()
        { 
            return new Producto();
        }
    }
}
//mensaje de pruebas