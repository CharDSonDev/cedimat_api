namespace cedimat_api.Model
{
    public class Horario
    {
        public int Id { get; set; }
        public string? Dia { get; set; }
        public DateTime? Hora_ingreso { get; set; }
        public DateTime? Hora_salida { get; set; }
    }
}