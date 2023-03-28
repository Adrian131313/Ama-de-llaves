namespace amaDeLaves
{
    public class Supervisor : Personal
    {
        public void ConfigurarSistema()
        { }

        public void GenerarAutorizacion()
        { }

        public void DarAltaOBaja()
        { }

        public OrdenDeCompra GenerarOrdenes()
        {
            return new OrdenDeCompra();
        }
    }
}