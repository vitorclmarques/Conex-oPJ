using System.ComponentModel.DataAnnotations;

namespace TestedeBanco.Models
{
	public class Usuario
	{
		[Key]
		public int mat { get; set; }

		public string nome { get; set; } = null!;


	}
}
