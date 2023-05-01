using DesafioMarlin.Model;
using Microsoft.EntityFrameworkCore;

namespace DesafioMarlin.Context
{
    public class EscolaContexto : DbContext
    {
        public EscolaContexto()
        {
        }

        public EscolaContexto(DbContextOptions<EscolaContexto> options) : base(options)
        {
        }
        public DbSet<Aluno> Alunos { get; set; }
    {
    }
}
