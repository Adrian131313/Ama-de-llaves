namespace amaDeLaves
{
    public class Habitacion
    {
        public string Codigo { get; set; }
        public string Carateristicas { get; set; }
        public string TipoDeHabitacion { get; set; }
        public int NumeroDeHabitacion { get; set; }
        public List<Producto> Productos { get; set; }
        public bool EstaOcupado { get; set; } = false;

        public void RegistrarDatos(string cod, string caracteristicas, string tipo, int nro)
        { 
            Codigo = cod;
            Carateristicas = caracteristicas;
            TipoDeHabitacion= tipo;
            NumeroDeHabitacion= nro;
        }

        public bool VerificarHabitacion()
        {
            return EstaOcupado;
        }

        public void ActtualizarHabitacion(Habitacion habitacion)
        {
            Codigo = habitacion.Codigo;
            Carateristicas = habitacion.Carateristicas;
            TipoDeHabitacion = habitacion.TipoDeHabitacion;
            NumeroDeHabitacion = habitacion.NumeroDeHabitacion;
        }

        public void AgregarProducto(Producto accesorio)
        {
            Productos.Add(accesorio);
        }

        public void RetirarProducto(Producto accesorio)
        {
            Productos.Remove(accesorio);
        }
    }
}