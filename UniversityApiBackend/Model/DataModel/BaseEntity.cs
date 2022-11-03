using System.ComponentModel.DataAnnotations;
namespace UniversityApiBackend.Model.DataModel
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Createdby { get; set; } =string.Empty;
        public DateTime CreatedAt  { get; set; } = DateTime.Now;
        public string Updatedby { get; set; } = string.Empty;
        public DateTime ?UpdatedAt { get; set; } = DateTime.Now;
        public string Deletedby { get; set; } = string.Empty;
        public DateTime ?DeletedAt { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
