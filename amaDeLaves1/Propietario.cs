namespace amaDeLaves
{
    public class Inventario
    {
        public string Codigo { get; set; }
        public List<Habitacion> Habitaciones { get; set; }

        public IList<Habitacion> MostrarLista()
        {
            return this.Habitaciones;
        }

        public Habitacion BuscarHabitacion(Habitacion habitacion)
        {
            return Habitaciones.Find(a => a.Codigo == habitacion.Codigo);
        }
    }
}