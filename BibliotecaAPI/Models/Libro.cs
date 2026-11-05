
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaAPI.Models
{
    [Table("libro")]
    public class Libro
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string titulo { get; set; } = string.Empty;

        public int? edicion { get; set; }

        [StringLength(100)]
        public string? editorial { get; set; }

        [Required]
        public int id_genero { get; set; }

        [Required]
        public int id_autor { get; set; }

        public int? anio_publicacion { get; set; }
    }
}
