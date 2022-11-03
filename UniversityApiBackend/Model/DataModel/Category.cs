
using System.ComponentModel.DataAnnotations;
using UniversityApiBackend.Model.DataModel;


namespace UniversityApiBackend.Model.DataModel
{
    public class Category : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
       
    }
}
