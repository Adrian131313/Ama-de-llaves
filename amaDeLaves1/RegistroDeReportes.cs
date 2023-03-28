namespace amaDeLaves
{
    public class RegistroDeReportes
    {
        public string Codigo { get; set; }
        public string TipoReporte { get; set; }
        public string TipoDeHabitacion { get; set; }
        public int NumeroDeHabitacion { get; set; }

        public void RegistrarReporte()
        { }

        public RegistroDeReportes BuscarReporte(IList<RegistroDeReportes> registro, RegistroDeReportes reporte)
        {
            return registro.FirstOrDefault(r => r.Codigo == reporte.Codigo) ?? null;
        }
        
    }
}