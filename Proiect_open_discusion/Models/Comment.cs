using System.ComponentModel.DataAnnotations;

namespace Proiect_open_discusion.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Continutul este obligatoriu")]
        [StringLength(1000, ErrorMessage = "Comentariul nu poate avea mai mult de 1000 caractere")]
        [MinLength(5, ErrorMessage = "Comentariul trebuie sa aiva cel putin 5 caractere")]
        public string Text { get; set; }
        public DateTime TimePosted { get; set; }
        public string? ReplyFor { get; set; }
        public string? UserName { get; set; }
        public string? UserId { get; set; }
        public int? SubjectId { get; set; }
        //FKs
        public virtual ApplicationUser? User { get; set; }
        public virtual Subject? Subject { get; set; }
    }
}
