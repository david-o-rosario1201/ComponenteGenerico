using System.ComponentModel.DataAnnotations;

namespace ComponenteGenerico.Models;

public class Metas
{
	[Key]
	public int MetaId { get; set; }

	[DataType(DataType.Date)]
	public DateTime Fecha { get; set; } = DateTime.Today;

	[Required(ErrorMessage = "Debe ingresar un nombre")]
	public string Nombre { get; set; }

	[Required(ErrorMessage = "Debe ingresar una observación")]
	public string Observacion { get; set; }
}
