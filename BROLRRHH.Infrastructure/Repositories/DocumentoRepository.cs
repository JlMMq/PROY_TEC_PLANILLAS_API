using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.DocumentoRequest;
using BROLRRHH.Core.Responses.DocumentoResponse;
using BROLRRHH.Core.Responses.HorarioResponse;
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
    public class DocumentoRepository : IDocumentoRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly string _connectionString;

        public DocumentoRepository(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<usp_ConsultarDocumento_Response> ConsultarDocumento(usp_ConsultarDocumento_Request obj)
        {
            usp_ConsultarDocumento_Response res = new usp_ConsultarDocumento_Response();
            try
            {
                var parameters = new object[] {
                    new SqlParameter("@codDoc",obj.codDoc)
                };
                var strParams = "@codDoc";
                var query = await _context.Database.SqlQueryRaw<usp_ConsultarDocumento_Response>($"usp_ConsultarDocumento {strParams}", parameters).ToListAsync();

                res = query.FirstOrDefault();
            }
            catch (Exception ex)
            {

            }
            return res;
        }
    }
}
