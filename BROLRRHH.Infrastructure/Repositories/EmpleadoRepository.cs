using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.DiarioRequest;
using BROLRRHH.Core.Requests.EmpleadoRequest;
using BROLRRHH.Core.Responses.DiarioResponse;
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
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly string _connectionString;
        public EmpleadoRepository(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<usp_ConsultarEmpleado_response> ConsultarEmpleado(usp_ConsultarEmpleado_Request obj)
        {
            usp_ConsultarEmpleado_response res;
            try
            {
                var parameters = new object[] {
                    new SqlParameter("@codEmpleado",obj.codigo)
                };
                var strParams = "@codEmpleado";
                var query = await _context.Database.SqlQueryRaw<usp_ConsultarEmpleado_response>($"usp_ConsultarEmpleado {strParams}", parameters).ToListAsync();

                res = query.FirstOrDefault();
                if(res == null)
                {
                    res = new usp_ConsultarEmpleado_response();
                }
            }
            catch (Exception ex)
            {
                    res = new usp_ConsultarEmpleado_response();
            }
            return res;
        }
    }
}
