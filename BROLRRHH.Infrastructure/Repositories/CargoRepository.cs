using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Responses.AreaResponse;
using BROLRRHH.Core.Responses.CargoResponse;
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
    public class CargoRepository : ICargoRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly string _connectionString;
        public CargoRepository(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<List<usp_ListarCargo_Response>> ListarCargo()
        {
            List<usp_ListarCargo_Response> res;
            try
            {
                var parameters = new object[] { };
                var strParams = "";
                var query = await _context.Database.SqlQueryRaw<usp_ListarCargo_Response>($"usp_ListarCargo {strParams}", parameters).ToListAsync();
                res = query;
            }
            catch (Exception ex)
            {
                res = new List<usp_ListarCargo_Response> { };
            }
            return res;
        }
    }
}
