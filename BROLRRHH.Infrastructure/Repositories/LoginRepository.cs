using BROLRRHH.Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BROLRRHH.Core.Requests.LoginRequest;
using BROLRRHH.Core.Responses.LoginResponse;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data;
using BROLRRHH.Core.Interfaces;

namespace BROLRRHH.Infrastructure.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly string _connectionString;

        public LoginRepository(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<usp_ValidarUserSystem_Result> ValidarUsuarioSistema(usp_ValidarUserSystem_Request obj)
        {
            usp_ValidarUserSystem_Result res = new usp_ValidarUserSystem_Result();
            try
            {
                var parameters = new object[]
                {
                    new SqlParameter("@nomUser",obj.nomUser),
                    new SqlParameter("@passUser",obj.passUser)
                };
                var strParams = "@nomUser, @passUser";
                var query = await _context.Database.SqlQueryRaw<usp_ValidarUserSystem_Result>($"usp_ValidarUserSystem {strParams}",parameters).ToListAsync();

                res = query.FirstOrDefault();
            }
            catch (Exception ex)
            {
                res.estadoTrans = false;
                res.codUser = -1;
                res.permiso = -1;
            }
            return res;
        }

    }
}
