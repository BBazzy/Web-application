using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_open_discusion.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Titlul este obligatoriu")]
        [StringLength(100, ErrorMessage = "Titlul nu poate avea mai mult de 100 caractere")]
        [MinLength(5, ErrorMessage = "Titlul trebuie sa aiva cel putin 5 caractere")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Continutul este obligatoriu")]
        [StringLength(1000, ErrorMessage = "Continutul nu poate avea mai mult de 1000 caractere")]
        [MinLength(5, ErrorMessage = "Continutul trebuie sa aiva cel putin 5 caractere")]
        public string Text { get; set; }
        public DateTime TimePosted { get; set; }
        [Required(ErrorMessage = "Categoria este obligatorie")]
        public int? CategoryId { get; set; }
        public string? UserId { get; set; }
        //FKs
        public virtual ApplicationUser? User { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
        public virtual Category? Category { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? Categ { get; set; }
    }
}
