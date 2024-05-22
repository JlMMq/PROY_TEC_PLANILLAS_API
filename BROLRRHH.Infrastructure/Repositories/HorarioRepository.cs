using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.HorarioRequest;
using BROLRRHH.Core.Responses.HorarioResponse;
using BROLRRHH.Core.Responses.SedeResponse;
using BROLRRHH.Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Infrastructure.Repositories
{
    public class HorarioRepository : IHorarioRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly string _connectionString;

        public HorarioRepository(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<usp_ConsultarHorario_Response> ConsultarHorario (usp_ConsultarHorario_Request obj)
        {
            usp_ConsultarHorario_Response res;

            try
            {
                var parameters = new object[] {
                    new SqlParameter("@codHorario",obj.codigo)
                };
                var strParams = "@codHorario";
                var query = await _context.Database.SqlQueryRaw<usp_ConsultarHorario_Response>($"usp_ConsultarHorario {strParams}",parameters).ToListAsync();

                res = query.FirstOrDefault();
                if (res == null)
                {
                    res = new usp_ConsultarHorario_Response
                    {
                        codHorario = 0
                    };
                }
            }
            catch (Exception ex)
            {
                res = new usp_ConsultarHorario_Response {
                    codHorario = 0
                };
            }
            return res;
        }

        public async Task<List<usp_ListarHorarios_Response>> ListarHorarios()
        {
            List<usp_ListarHorarios_Response> res;
            try
            {
                var parameters = new object[] { };
                var strParams = "";
                var query = await _context.Database.SqlQueryRaw<usp_ListarHorarios_Response>($"usp_ListarHorarios {strParams}", parameters).ToListAsync();
                res = query;
            }
            catch (Exception ex)
            {
                res = new List<usp_ListarHorarios_Response> { };
            }
            return res;
        }
    }
}
