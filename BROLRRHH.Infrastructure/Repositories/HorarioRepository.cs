using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.HorarioRequest;
using BROLRRHH.Core.Responses.HorarioResponse;
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
            usp_ConsultarHorario_Response res = new usp_ConsultarHorario_Response();

            try
            {
                var parameters = new object[] {
                    new SqlParameter("@codHorario",obj.codigo)
                };
                var strParams = "@codHorario";
                var query = await _context.Database.SqlQueryRaw<usp_ConsultarHorario_Response>($"usp_ConsultarHorario {strParams}",parameters).ToListAsync();

                res = query.FirstOrDefault();
            }
            catch (Exception ex)
            {

            }
            return res;
        }
    }
}
