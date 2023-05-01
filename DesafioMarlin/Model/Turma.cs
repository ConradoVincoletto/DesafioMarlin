using System.ComponentModel.DataAnnotations;

namespace DesafioMarlin.Model
{
    public class Turma
    {
        public int Id { get; set; }

        [Required]

        public string Classe { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime AnoLetivo { get; set; }
    }
}
