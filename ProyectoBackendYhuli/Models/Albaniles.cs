using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendYhuli.Models
{
    public class Albaniles
    {
        [Key]
        public int numero_seguridad_social { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string numero_telefonico { get; set; }
        public string categoria_profesional { get; set; }
        public int codigo_cuadrilla { get; set; }

    }
}
