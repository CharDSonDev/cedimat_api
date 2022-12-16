namespace cedimat_api.Model
{
    public class Paciente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Cedula { get; set; }
        public string? Seguro { get; set; }
        public string? Telefono { get; set; }
    }
}