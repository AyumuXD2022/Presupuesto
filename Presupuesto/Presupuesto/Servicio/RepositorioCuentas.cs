using Dapper;
using Microsoft.Data.SqlClient;
using Presupuesto.Models;

namespace Presupuesto.Servicio
{
    public class RepositorioCuentas : IRepositorioCuentas
    {
        private readonly string connectionString;

        public RepositorioCuentas(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task Crear(Cuenta cuenta)
        {
            using var connection = new SqlConnection(connectionString);
            var id = await connection.QuerySingleAsync<int>(@"INSERT INTO Cuentas(Nombre, TipoCuentaId, Balance, Descripcion)
                VALUES (@Nombre, @TipoCuentaId, @Balance, @Descripcion);
                SELECT SCOPE_IDENTITY();",cuenta);
            cuenta.Id = id;
        }
    }
}
