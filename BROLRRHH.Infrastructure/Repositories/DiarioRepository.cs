using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.DiarioRequest;
using BROLRRHH.Core.Responses.DiarioResponse;
using BROLRRHH.Core.Responses.DocumentoResponse;
using BROLRRHH.Core.Responses.EmpleadoResponse;
using BROLRRHH.Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Infrastructure.Repositories
{
    public class DiarioRepository : IDiarioRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly string _connectionString;
        public DiarioRepository(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
    
        public async Task<usp_ConsultarDiario_Response> ConsultarDiario(usp_ConsultarDiario_Request obj)
        {
            usp_ConsultarDiario_Response res;
            try
            {
                var parameters = new object[] {
                    new SqlParameter("@codDiar",obj.codigo)
                };
                var strParams = "@codDiar";
                var query = await _context.Database.SqlQueryRaw<usp_ConsultarDiario_Response>($"usp_ConsultarDiario {strParams}", parameters).ToListAsync();

                res = query.FirstOrDefault();
                if (res == null)
                {
                    res = new usp_ConsultarDiario_Response { 
                        codDiar = 0,
                    };
                }
            }
            catch (Exception ex)
            {
                res = new usp_ConsultarDiario_Response
                {
                    codDiar = 0,
                };
            }
            return res;
        }

        public async Task<usp_ConsultarDiario_Response> ConsultarDiarioFecEmpl(usp_ConsultarDiarioFecEmpl_Request obj)
        {
            usp_ConsultarDiario_Response res;
            try
            {
                var parameters = new object[] {
                    new SqlParameter("@fecha",obj.fecha),
                    new SqlParameter("@empleado",obj.empleado)
                };
                var strParams = "@fecha, @empleado";
                var query = await _context.Database.SqlQueryRaw<usp_ConsultarDiario_Response>($"usp_ConsultarDiarioFecEmpl {strParams}", parameters).ToListAsync();

                res = query.FirstOrDefault();
                if (res == null)
                {
                    res = new usp_ConsultarDiario_Response
                    {
                        codDiar = 0,
                    };
                }
            }
            catch (Exception ex)
            {
                res = new usp_ConsultarDiario_Response
                {
                    codDiar = 0,
                };
            }
            return res;
        }

        public async Task<IEnumerable<usp_ListarDiario_Response>>ListarDiario()
        {
            List<usp_ListarDiario_Response> list = new List<usp_ListarDiario_Response>();
            try
            {
                var parameters = new object[] { };
                var strParams = "";
                var query = await _context.Database.SqlQueryRaw<usp_ListarDiario_Response>($"usp_ListarDiario {strParams}", parameters).ToListAsync();
                list = query;
            }
            catch (Exception ex)
            {

            }

            return list;
        }
    }
}
