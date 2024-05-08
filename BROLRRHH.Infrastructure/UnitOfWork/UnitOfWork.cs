using BROLRRHH.Infrastructure.Data;
using BROLRRHH.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BROLRRHH.Infrastructure.Repositories;

namespace BROLRRHH.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IConfiguration _configuration;

        private ILoginRepository _loginRepository;
        private IDiarioRepository _diarioRepository;
        private IDocumentoRepository _documentoRepository;
        private IEmpleadoRepository _empleadoRepository;
        private IHorarioRepository _horarioRepository;
        private IMarcaRepository _marcaRepository;

        public UnitOfWork(ApplicationDbContext context, IConfiguration configuration)
        {
            _configuration = configuration;
            _context = context;
        }


        public ILoginRepository LoginRepository
        {
            get { return _loginRepository ??= new LoginRepository(_context,_configuration); }
        }
        
        public IDiarioRepository DiarioRepository
        {
            get { return _diarioRepository ??= new DiarioRepository(_context,_configuration); }
        }
        public IDocumentoRepository DocumentoRepository
        {
            get { return _documentoRepository ??= new DocumentoRepository(_context, _configuration); }
        }
        public IEmpleadoRepository EmpleadoRepository
        {
            get { return _empleadoRepository ??= new EmpleadoRepository(_context, _configuration); }
        }
        public IHorarioRepository HorarioRepository
        {
            get { return _horarioRepository ??= new HorarioRepository(_context, _configuration); }
        }
        public IMarcaRepository MarcaRepository
        {
            get { return _marcaRepository ??= new MarcaRepository(_context, _configuration); }
        }
    }
}
