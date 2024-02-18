using System.ComponentModel.DataAnnotations;

namespace ComponenteGenerico.Models;

public class Aportes
{
	[Key]
	public int AporteId { get; set; }

	[DataType(DataType.Date)]
	public DateTime Fecha { get; set; } = DateTime.Today;

    [Required(ErrorMessage = "Debe ingresar un nombre")]
    [RegularExpression(@"^[A-Za-z ]+$",ErrorMessage ="El nombre no debe contener números ni carecteres especiales")]
    public string Persona { get; set; }

    [Required(ErrorMessage = "Debe ingresar una observación")]
    public string Observacion { get; set; }

    [Range(1, 10000000,ErrorMessage = "El monto debe ser mayor a 0 y menor a 10,000,000")]
    public decimal Monto { get; set; }
}
