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
using BROLRRHH.Core.Requests.EmpleadoRequest;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;
using BROLRRHH.Core.Responses.EmpleadoResponse;
using BROLRRHH.Core.Responses.UserSystemResponse;
using BROLRRHH.Core.Requests.UserSystemRequest;

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
                res.str_nombres = "";
                res.str_apellidos = "";
                res.correoUser = "";
            }
            return res;
        }

        public async Task<bool> ActualizarCorreo(usp_ActualizarCorreo_Request obj)
        {
            try
            {
                var parameters = new object[]
                {
                    new SqlParameter("@codUser", obj.codUser),
                    new SqlParameter("@correo", obj.correo)
                };
                var strParams = "@codUser, @correo";
                var result = await _context.Database.ExecuteSqlRawAsync($"usp_ActualizarCorreo {strParams}", parameters);
                return result > 0; ;

            }catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> CambiarPassword(usp_CambiarPassword_Request obj)
        {
            try
            {
                var parameters = new object[]
                {
                    new SqlParameter("@codUser", obj.codUser),
                    new SqlParameter("@passUser", obj.passUser),  
                };
                var strParams = "@codUser, @passUser";
                var result = await _context.Database.ExecuteSqlRawAsync($"usp_CambiarPassword {strParams}", parameters);
                return result > 0; 
            }
            catch(Exception ex) 
            {
                return false;
            }
        }


        //MOMENTANEO
        public async Task<List<usp_ListarUserSystem_Response>> ListarUsuarios()
        {
            List<usp_ListarUserSystem_Response> res;
            try
            {
                var parameters = new object[] { };
                var strParams = "";
                var query = await _context.Database.SqlQueryRaw<usp_ListarUserSystem_Response>($"usp_ListarUserSystem {strParams}", parameters).ToListAsync();
                res = query;
            }
            catch (Exception ex)
            {
                res = new List<usp_ListarUserSystem_Response> { };
            }
            return res;
        }

        public async Task<bool> ActualizarPermisosUser(usp_UpdPermisosUserSystem_Request obj)
        {
            try
            {
                var parameters = new object[]
               {
                    new SqlParameter("@codUser", obj.codUser),
                    new SqlParameter("@permiso", obj.permiso),
                    new SqlParameter("@estado", obj.estado)
               };
                var strParams = "@codUser, @permiso, @estado";
                var result = await _context.Database.ExecuteSqlRawAsync($"usp_UpdPermisosUserSystem {strParams}", parameters);
                return result > 0;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
