using System.ComponentModel.DataAnnotations;

namespace CantinaGestao.Models
{
	public class Prato
	{
		public int Id { get; set; }

		[Required]
		public string Nome { get; set; }

		[Required]
		public DateTime DataDisponibilidade { get; set; }
	}
}
