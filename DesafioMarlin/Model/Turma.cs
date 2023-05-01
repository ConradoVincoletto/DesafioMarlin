using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey(nameof(AlunoId))]
        public int AlunoId { get; set; }

        public ICollection<Aluno> aluno { get; set; }
    }
}
