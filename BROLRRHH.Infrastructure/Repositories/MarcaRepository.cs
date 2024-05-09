using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.MarcaRequest;
using BROLRRHH.Core.Responses.MarcaResponse;
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
        public async Task<usp_InsertarMarca_Response>  InsertarMarca(usp_InsertarMarca_Request obj)
        {
            usp_InsertarMarca_Response res = new usp_InsertarMarca_Response
            {
                valor = false
            };
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
                        cmd.Parameters.Add(new SqlParameter("@usu_Reg", obj.usu_Reg));
                        cmd.Parameters.Add(new SqlParameter("@fecha", obj.fecha));
                        cmd.Parameters.Add(new SqlParameter("@tipo", obj.tipo));

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        if(rowsAffected > 0)
                        {
                            res.valor = true;
                            return res;
                        }
                        else
                        {
                            res.valor = false;
                            return res;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.valor = false;
                return res;
            }
        }
    }
}
