using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.MarcaRequest;
using BROLRRHH.Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BROLRRHH.Infrastructure.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly string _connectionString;
        public MarcaRepository(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public async Task<bool>  InsertarMarca(usp_InsertarMarca_Request obj)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "usp_InsertarMarca";

                        cmd.Parameters.Add(new SqlParameter("@empleado", obj.empleado));
                        cmd.Parameters.Add(new SqlParameter("@horario", obj.horario));
                        cmd.Parameters.Add(new SqlParameter("@usu_reg", obj.usu_Reg));
                        cmd.Parameters.Add(new SqlParameter("@fecha", obj.fecha));
                        cmd.Parameters.Add(new SqlParameter("@tipo", obj.tipo));

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        if(rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
