using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Responses.AreaResponse;
using BROLRRHH.Core.Responses.EmpleadoResponse;
using BROLRRHH.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Infrastructure.Repositories
{
    public class AreaRepository : IAreaRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly string _connectionString;
        public AreaRepository(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<List<usp_ListarArea_Response>> ListarArea()
        {
            List<usp_ListarArea_Response> res;
            try
            {
                var parameters = new object[] { };
                var strParams = "";
                var query = await _context.Database.SqlQueryRaw<usp_ListarArea_Response>($"usp_ListarArea {strParams}", parameters).ToListAsync();
                res = query;
            }
            catch (Exception ex)
            {
                res = new List<usp_ListarArea_Response> { };
            }
            return res;
        }
    }
}
