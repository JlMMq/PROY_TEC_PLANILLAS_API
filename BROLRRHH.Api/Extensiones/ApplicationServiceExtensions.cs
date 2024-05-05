using BROLRRHH.Core.Interfaces;
using BROLRRHH.Infrastructure.UnitOfWork;

namespace BROLRRHH.Api.Extensiones
{
    public static class ApplicationServiceExtensions
    {
        public static void AddAplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static void ConfigurateCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => {
                    builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                });
            });
        }
    }
}
