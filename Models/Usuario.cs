using System.ComponentModel.DataAnnotations;

namespace CantinaGestao.Models
{
	public class Usuario
	{
		public int Id { get; set; }

		[Required]
		public string Nome { get; set; }

		[Required, EmailAddress]
		public string Email { get; set; }

		[Required]
		public PerfilUsuario Perfil { get; set; }
	}

	public enum PerfilUsuario
	{
		Gestor,
		Cliente
	}
}
