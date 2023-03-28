namespace amaDeLaves
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public int Cantidad { get; set; }

        public Producto Mostrar()
        {
            return this;
        }
    }
}