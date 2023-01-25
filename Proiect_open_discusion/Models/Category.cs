using System.ComponentModel.DataAnnotations;

namespace Proiect_open_discusion.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Numele este obligatoriu")]
        [StringLength(40, ErrorMessage = "Numele nu poate avea mai mult de 40 de caractere")]
        [MinLength(4, ErrorMessage = "Numele trebui sa aiva cel putin 4 caractere")]
        public string Name { get; set; }
        //FKs
        public virtual ICollection<Subject>? Subjects { get; set; } = new List<Subject>();
    }
}
