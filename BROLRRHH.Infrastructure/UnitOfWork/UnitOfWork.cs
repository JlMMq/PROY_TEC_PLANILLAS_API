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
        public UnitOfWork(ApplicationDbContext context, IConfiguration configuration)
        {
            _configuration = configuration;
            _context = context;
        }


        public ILoginRepository LoginRepository
        {
            get { return _loginRepository ??= new LoginRepository(_context,_configuration); }
        }
        
    }
}
