using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendYhuli.Models
{
    public class Cuadrillas
    {
        [Key]
        public int codigo_cuadrilla { get; set; }
        public string nombre_cuadrilla { get; set; }
        public string localizacion { get; set; }

    }
}
