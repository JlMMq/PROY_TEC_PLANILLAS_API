using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.DocumentoRequest;
using BROLRRHH.Core.Responses.DocumentoResponse;
using BROLRRHH.Core.Responses.HorarioResponse;
using BROLRRHH.Core.Responses.SedeResponse;
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
            usp_ConsultarDocumento_Response res; 
            try
            {
                var parameters = new object[] {
                    new SqlParameter("@codDoc",obj.codDoc)
                };
                var strParams = "@codDoc";
                var query = await _context.Database.SqlQueryRaw<usp_ConsultarDocumento_Response>($"usp_ConsultarDocumento {strParams}", parameters).ToListAsync();

                res = query.FirstOrDefault();
                if(res == null)
                {
                    res = new usp_ConsultarDocumento_Response {
                        codDoc = ""
                    };
                }
            }
            catch (Exception ex)
            {
                res = new usp_ConsultarDocumento_Response
                {
                    codDoc = ""
                };
            }
            return res;
        }

        public async Task<List<usp_ListarDocumentos_Response>> ListarDocumentos()
        {
            List<usp_ListarDocumentos_Response> res;
            try
            {
                var parameters = new object[] { };
                var strParams = "";
                var query = await _context.Database.SqlQueryRaw<usp_ListarDocumentos_Response>($"usp_ListarDocumentos {strParams}", parameters).ToListAsync();
                res = query;
            }
            catch (Exception ex)
            {
                res = new List<usp_ListarDocumentos_Response> { };
            }
            return res;
        }
    }
}
