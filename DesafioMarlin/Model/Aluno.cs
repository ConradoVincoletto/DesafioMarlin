using System.ComponentModel.DataAnnotations;

namespace DesafioMarlin.Model
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Mínimo de 3 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [RegularExpression(@"^[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}$", ErrorMessage = "CPF inválido")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "O email é inválido")]
        public string Email { get; set; }

        public void CpfDuplicidade()
        {
            var cpfdup = Cpf.Distinct();

            foreach (var item in cpfdup)
            {
                if (item == item)
                {
                    throw new Exception("Classe não poder conter duplicidade de Alunos");
                }
            }
        }
    }
}
