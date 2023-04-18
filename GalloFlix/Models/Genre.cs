using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloFlix.Models;

[Table("Genre")]
    public class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage ="O nome é obrigatório")]
        [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres", MinimumLength = 5)]
        public string Name { get; set; }
    }
