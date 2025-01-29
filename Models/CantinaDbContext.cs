using Microsoft.EntityFrameworkCore;

namespace CantinaGestao.Models
{
	public class CantinaDbContext : DbContext
	{
		public CantinaDbContext(DbContextOptions<CantinaDbContext> options) : base(options) { }

		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Prato> Pratos { get; set; }
		public DbSet<Senha> Senhas { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Senha>()
				.HasOne(s => s.Usuario)
				.WithMany()
				.HasForeignKey(s => s.UsuarioId);

			modelBuilder.Entity<Senha>()
				.HasOne(s => s.Prato)
				.WithMany()
				.HasForeignKey(s => s.PratoId);
		}
	}
}
