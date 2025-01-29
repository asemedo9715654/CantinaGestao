namespace CantinaGestao.Models
{
	public class Senha
	{
		public int Id { get; set; }
		public int UsuarioId { get; set; }
		public Usuario Usuario { get; set; }
		public int PratoId { get; set; }
		public Prato Prato { get; set; }
		public DateTime DataEscolha { get; set; }
		public int Quantidade { get; set; }
		public decimal PrecoTotal { get; set; }
	}
}
