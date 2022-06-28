using Microsoft.AspNetCore.Mvc.Rendering;

namespace Presupuesto.Models
{
    public class CuentasCreacionViewModel : Cuenta
    {
        public IEnumerable<SelectListItem> TiposCuentas { get; set; }
    }
}
