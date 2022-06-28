using Presupuesto.Models;

namespace Presupuesto.Servicio
{
    public interface IRepositorioCuentas
    {
        Task Crear(Cuenta cuenta);
    }
}
