namespace cedimat_api.Model
{
    public class Medico
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Especialidad_Id { get; set; }
        public int? Horario_Id { get; set; }
    }
}