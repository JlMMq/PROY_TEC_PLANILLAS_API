using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.PagoRequest;
using BROLRRHH.Core.Responses.PagoResponse;
using BROLRRHH.Core.Responses.SolicitudResponse;
using BROLRRHH.Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Infrastructure.Repositories
{
    public class PagoRepository : IPagoRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly string _connectionString;
        public PagoRepository(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<PagoGeneric_Response> InsertarSueldo(usp_InsertarSueldo_Request obj)
        {
            PagoGeneric_Response msm = new PagoGeneric_Response
            {
                CODIGO = 0,
                MENSAJE = "Proceso no ejecutado."
            };
            try
            {
                var parameters = new object[]
               {
                    new SqlParameter("@empleado",obj.empleado),
                    new SqlParameter("@sueldo",obj.sueldo),
                    new SqlParameter("@flag_essalud",obj.flag_essalud),
                    new SqlParameter("@flag_onp", obj.flag_onp),
                    new SqlParameter("@flag_afp", obj.flag_afp),
                    new SqlParameter("@usuario", obj.usuario)
               };

                var strParams = "@empleado, @sueldo, @flag_essalud, @flag_onp, @flag_afp, @usuario";
                var result = await _context.Database.ExecuteSqlRawAsync($"usp_InsertarSueldo {strParams}", parameters);
                if (result > 0)
                {
                    msm.CODIGO = 1;
                    msm.MENSAJE = "Se registro correctamente.";
                }
                else
                {
                    msm.CODIGO = -1;
                    msm.MENSAJE = "No se registro correctamente.";
                }
            }
            catch (Exception ex)
            {
                msm.CODIGO = -1;
                msm.MENSAJE = "Error al procesar la solicitud.";
            }
            return msm;
        }

        public async Task<PagoGeneric_Response> ActualizarSueldo(usp_ActualizarSueldo_Request obj)
        {
            PagoGeneric_Response msm = new PagoGeneric_Response
            {
                CODIGO = 0,
                MENSAJE = "Proceso no ejecutado."
            };
            try
            {
                var parameters = new object[]
                {
                    new SqlParameter("@empleado",obj.empleado),
                     new SqlParameter("@sueldo",obj.sueldo),
                    new SqlParameter("@flag_essalud",obj.flag_essalud),
                    new SqlParameter("@flag_onp",obj.flag_onp),
                    new SqlParameter("@flag_afp",obj.flag_afp),
                    new SqlParameter("@usuario",obj.usuario)
                };

                var strParams = "@empleado, @sueldo, @flag_essalud, @flag_onp, @flag_afp, @usuario";
                var result = await _context.Database.ExecuteSqlRawAsync($"usp_ActualizarSueldo {strParams}", parameters);
                if (result > 0)
                {
                    msm.CODIGO = 1;
                    msm.MENSAJE = "Se actualizo correctamente.";
                }
                else
                {
                    msm.CODIGO = 0;
                    msm.MENSAJE = "No se actualizo correctamente.";
                }

            }
            catch (Exception ex)
            {
                msm.CODIGO = 0;
                msm.MENSAJE = "Error al procesar la solicitud.";
            }
            return msm;
        }

        public async Task<IEnumerable<usp_ListarRecibosEmpleado_Response>> ListarRecibosEmpleado(usp_ListarRecibosEmpleado_Request obj)
        {
            List<usp_ListarRecibosEmpleado_Response> list = new List<usp_ListarRecibosEmpleado_Response> ();
            try
            {
                var parameters = new object[]
                {
                    new SqlParameter("@empleado",obj.empleado)
                };
                var strParams = "@empleado";
                var result = await _context.Database.SqlQueryRaw<usp_ListarRecibosEmpleado_Response>($"usp_ListarRecibosEmpleado {strParams}", parameters).ToListAsync();
                list = result.ToList();

            }
            catch (Exception ex)
            {
                list = new List<usp_ListarRecibosEmpleado_Response>();
            }
            return list;
        }
        
        public async Task<usp_ConsultarSueldoCod_Response> ConsultarSueldoCod(usp_ConsultarSueldoCod_Request obj)
        {
            usp_ConsultarSueldoCod_Response res = new usp_ConsultarSueldoCod_Response();
            try
            {
                var parameters = new object[]
                {
                    new SqlParameter("@empleado",obj.empleado)
                };
                var strParams = "@empleado";
                var result = await _context.Database.SqlQueryRaw<usp_ConsultarSueldoCod_Response>($"usp_ConsultarSueldoCod {strParams}", parameters).ToListAsync();
                res = result.FirstOrDefault();
            }
            catch (Exception ex)
            {
                res.codEmpleado = -1;

            }
            return res;
        }
    }
}
