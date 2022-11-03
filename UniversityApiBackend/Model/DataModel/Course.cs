using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Model.DataModel
{
    public enum level
    {
        Basico,
        Intermedio,
        Avanzado
    }
    public class Course : BaseEntity

    {

        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string Descriptionshort { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;

        public string PublicObjetive { get; set; } = string.Empty;
        public string Objetivos { get; set; } = string.Empty;
        public string Requisitos { get; set; } = string.Empty;
        public level level { get; set; } = level.Basico;


    }
}
