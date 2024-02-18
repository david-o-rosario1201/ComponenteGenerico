using System.ComponentModel.DataAnnotations;
using System.Data.Common;

namespace ComponenteGenerico.Models;

public class Prioridades
{
	[Key]
	public int PrioridadId { get; set; }

    [Required(ErrorMessage = "Debe ingresar una decripción")]
    public string Descripcion { get; set; }

    [Range(1, 30, ErrorMessage = "Los días deben ser mayor a 0 y menor a 31")]
    public int DiasCompromiso { get; set; }
}
