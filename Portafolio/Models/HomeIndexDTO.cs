namespace Portafolio.Models
{
    public class HomeIndexDTO
    {
        public IEnumerable<ProyectoDTO> Proyectos { get; set; }

        public string? Nombre { get; set; }

        public int? Edad { get; set; }
    }
}
