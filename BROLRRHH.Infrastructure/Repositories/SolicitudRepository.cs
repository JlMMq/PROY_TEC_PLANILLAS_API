using BROLRRHH.Core.Interfaces;
using BROLRRHH.Core.Requests.SolicitudRequest;
using BROLRRHH.Core.Responses.SolicitudResponse;
using BROLRRHH.Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BROLRRHH.Infrastructure.Repositories
{
    public class SolicitudRepository : ISolicitudRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly string _connectionString;
        public SolicitudRepository(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<usp_InsertarSolicitud_Response> InsertarSolicitud(usp_InsertarSolicitud_Request obj)
        {
            usp_InsertarSolicitud_Response msm = new usp_InsertarSolicitud_Response
            {
                CODIGO = 0,
                MENSAJE = "No se logro procesar la solicitud",
            };

            try
            {

                var parameters = new object[]
                {
                    new SqlParameter("@codSolicitante",obj.codSolicitante),
                    new SqlParameter("@codSupervisor",obj.codSupervisor),
                    new SqlParameter("@tipoSolic",obj.tipoSolic),
                    new SqlParameter("@tipoAsunto", obj.tipoAsunto),
                    new SqlParameter("@asunto", obj.asunto),
                    new SqlParameter("@descrip" , obj.descrip),
                    new SqlParameter("@fechaIni", obj.fechaIni),
                    new SqlParameter("@fechaFin", obj.fechaFin),
                    new SqlParameter("@horaSalida", obj.horaSalida),
                    new SqlParameter("@horaEntrada", obj.horaEntrada),
                    new SqlParameter("@archivo", obj.archivo),
                    new SqlParameter("@usuario", obj.usuario)
                };

                var strParams = "@codSolicitante, @codSupervisor, @tipoSolic, @tipoAsunto, @asunto, @descrip, @fechaIni, @fechaFin, @horaSalida, @horaEntrada, @archivo, @usuario";
                var result = await _context.Database.SqlQueryRaw<usp_InsertarSolicitud_Response>($"usp_InsertarSolicitud {strParams}",parameters).ToListAsync();
                msm = result.FirstOrDefault();
            }
            catch (Exception ex)
            {
                msm.CODIGO = -1;
                msm.MENSAJE = "Error al procesar la solicitud.";
            }

            return msm;
        }

        public async Task<usp_ProcesarSolicitud_Response> ProcesarSolicitud (usp_ProcesarSolicitud_Request obj)
        {
            usp_ProcesarSolicitud_Response msm = new usp_ProcesarSolicitud_Response {
                CODIGO = 0,
                MENSAJE = "No se logro procesar la solicitud"
            };

            try
            {
                var parameters = new object[]
                {
                    new SqlParameter("@codSolicitud",obj.codSolicitud),
                    new SqlParameter("@estado", obj.estado),
                    new SqlParameter("@usuario",obj.usuario)
                };

                var strParams = "@codSolicitud, @estado, @usuario";
                var result = await _context.Database.SqlQueryRaw<usp_ProcesarSolicitud_Response>($"usp_ProcesarSolicitud {strParams}", parameters).ToListAsync();
                msm = result.FirstOrDefault();

            }
            catch(Exception ex)
            {
                msm.CODIGO = -1;
                msm.MENSAJE = "Error al procesar la solicitud.";
            }
            return msm;
        }

        public async Task<IEnumerable<usp_ListarSolicitudesView_Response>> ListarSolicitudView(usp_ListarSolicitudesView_Request obj)
        {
            List<usp_ListarSolicitudesView_Response> list = new List<usp_ListarSolicitudesView_Response> ();
            try
            {
                var parameters = new object[]
                {
                    new SqlParameter("@codSupervisor", obj.codSupervisor),
                    new SqlParameter("@codSolcitante", obj.codSolicitante)
                };

                var strParams = "@codSupervisor, @codSolicitante";
                var result = await _context.Database.SqlQueryRaw<usp_ListarSolicitudesView_Response>($"usp_ListarSolicitudesView {strParams}",parameters).ToListAsync();
                list = result;
            }
            catch(Exception ex)
            {
                list = new List<usp_ListarSolicitudesView_Response> { };
            }

            return list;
        }

        public async Task<usp_ConsultarArchivoSolicitud_Response> ConsultarArchivoSolicitud(usp_ConsultarArchivoSolicitud_Request obj)
        {
            usp_ConsultarArchivoSolicitud_Response arch = new usp_ConsultarArchivoSolicitud_Response();
            try
            {
                var parameters = new object[] { 
                    new SqlParameter("@codSolicitud",obj.codSolicitud)
                };
                var strParams = "@codSolicitud";
                var result = await _context.Database.SqlQueryRaw<usp_ConsultarArchivoSolicitud_Response>($"usp_ConsultarArchivoSolicitud {strParams}", parameters).ToListAsync();
                arch = result.FirstOrDefault();
            }
            catch(Exception ex)
            {

            }

            return arch;
        }
    }
}
