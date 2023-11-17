using Microsoft.EntityFrameworkCore;
using TestedeBanco.Models;

namespace TestedeBanco.Context
{
	public class DbContextAplicacao : DbContext
	{
		public DbContextAplicacao(DbContextOptions<DbContextAplicacao>options)
			: base(options)
		{

		}

		public DbSet<Usuario> alunos { get; set; }
	}
}
