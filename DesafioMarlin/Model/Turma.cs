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

        public void NãoExcluirClasse()
        {
            if (AlunoId != 0)
            {
                throw new Exception("Não é possivel excluir a classe já associado a uma Aluno");
            }
        }

        internal void AdicionarApenasCinco()
        {
            if (AlunoId > 5)
            {
                throw new Exception("Não é possivel adicionar mais do que 5 alunos em uma classe");
            }
        }
        public void AlunoCadastro()
        {
            if (string.IsNullOrEmpty(Classe))
            {
                throw new Exception("É obrigatório o aluno estar vinculado no mínimo a uma Turma");
            }
        }
    }
}
