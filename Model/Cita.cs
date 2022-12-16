namespace cedimat_api.Model
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public int? Paciente_Id { get; set; }
        public int? Medico_Id { get; set; }
    }
}