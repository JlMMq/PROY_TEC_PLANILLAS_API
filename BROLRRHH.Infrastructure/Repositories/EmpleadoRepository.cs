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
using System.Diagnostics.Contracts;
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


        public async Task<usp_ConsultarEmpleado_response> ConsultarEmpleadoCodDoc(usp_ConsultarEmpleadoCodDoc_Request obj)
        {
            usp_ConsultarEmpleado_response res;
            try
            {
                var parameters = new object[] {
                    new SqlParameter("@codEmpleado",obj.codigo),
                    new SqlParameter("@numroDoc",obj.numroDoc)
                };
                var strParams = "@codEmpleado , @numroDoc";
                var query = await _context.Database.SqlQueryRaw<usp_ConsultarEmpleado_response>($"usp_ConsultarEmpleadoCodDoc {strParams}", parameters).ToListAsync();

                res = query.FirstOrDefault();
                if (res == null)
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

        public async Task<List<usp_ListarEmpleadoView_response>> ListarEmpleadoView()
        {
            List<usp_ListarEmpleadoView_response> res;
            try
            {
                var parameters = new object[] { };
                var strParams = "";
                var query = await _context.Database.SqlQueryRaw<usp_ListarEmpleadoView_response>($"usp_ListarEmpleadosView {strParams}", parameters).ToListAsync();
                res = query;
            }
            catch(Exception ex)
            {
                res = new List<usp_ListarEmpleadoView_response> { };
            }
            return res;
        }
        public async Task<bool> InsertarEmpleado(usp_InsertarEmpleado_Request obj)
        {
            try
            {
                var parameters = new object[]
                {
                    new SqlParameter("@numroDoc", obj.numroDoc),
                    new SqlParameter("@tipoDoc", obj.tipoDoc),
                    new SqlParameter("@apellidos", obj.apellidos),
                    new SqlParameter("@nombres", obj.nombres),
                    new SqlParameter("@fecNacimiento", obj.fecNacimiento),
                    new SqlParameter("@genero", obj.genero),
                    new SqlParameter("@correo", obj.correo),
                    new SqlParameter("@direccion", obj.direccion),
                    new SqlParameter("@telefono", obj.telefono),
                    new SqlParameter("@fecIngreso", obj.fecIngreso),
                    new SqlParameter("@codCargo", obj.codCargo),
                    new SqlParameter("@codArea", obj.codArea),
                    new SqlParameter("@codSede", obj.codSede),
                    new SqlParameter("@codHorario", obj.codHorario),
                    new SqlParameter("@foto", obj.foto),
                    new SqlParameter("@usu_Reg", obj.usu_Reg),
                    new SqlParameter("@estado", obj.estado)
                };
                var strParams = "@numroDoc ,@tipoDoc, @apellidos, @nombres, @fecNacimiento, @genero, @correo, @direccion, @telefono, @fecIngreso, @codCargo, @codArea, @codSede, @codHorario, @foto, @usu_Reg, @estado";
                var result = await _context.Database.ExecuteSqlRawAsync($"usp_InsertarEmpleado {strParams}",parameters);
                return result > 0;
            }
            catch(Exception ex)
            {
                return false;   
            }
        }

        public async Task<bool> ActualizarEmpleado(usp_ActualizarEmpleado_Request obj)
        {
            try
            {
                var parameters = new object[]
                {
                    new SqlParameter("@codEmpleado", obj.codEmpleado),
                    new SqlParameter("@numroDoc", obj.numroDoc),
                    new SqlParameter("@tipoDoc", obj.tipoDoc),
                    new SqlParameter("@apellidos", obj.apellidos),
                    new SqlParameter("@nombres", obj.nombres),

                    new SqlParameter("@fecNacimiento", obj.fecNacimiento),
                    new SqlParameter("@genero", obj.genero),
                    new SqlParameter("@correo", obj.correo),
                    new SqlParameter("@direccion", obj.direccion),
                    new SqlParameter("@telefono", obj.telefono),
                    new SqlParameter("@fecIngreso", obj.fecIngreso),
                    new SqlParameter("@codCargo", obj.codCargo),
                    new SqlParameter("@codArea", obj.codArea),
                    new SqlParameter("@codSede", obj.codSede),
                    new SqlParameter("@codHorario", obj.codHorario),
                    new SqlParameter("@foto", obj.foto),
                    new SqlParameter("@usu_UltMod", obj.usu_UltMod),
                    new SqlParameter("@estado", obj.estado)
                };
                var strParams = "@codEmpleado,@numroDoc ,@tipoDoc, @apellidos, @nombres, @fecNacimiento, @genero, @correo, @direccion, @telefono, @fecIngreso, @codCargo, @codArea, @codSede, @codHorario, @foto, @usu_UltMod, @estado";
                var result = await _context.Database.ExecuteSqlRawAsync($"usp_ActualizarEmpleado {strParams}", parameters);
                return result > 0;

            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> EliminarEmpleado(usp_EliminarEmpleado_Request obj)
        {
            try
            {
                var parameters = new object[]
                {
                   new SqlParameter("@codEmpleado", obj.codEmpleado)
                };
                var result = await _context.Database.ExecuteSqlRawAsync("usp_EliminarEmpleado @codEmpleado", parameters);
                return result > 0;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
