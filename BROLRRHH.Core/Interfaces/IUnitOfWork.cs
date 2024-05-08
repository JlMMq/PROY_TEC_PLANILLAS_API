using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Interfaces
{
    public interface IUnitOfWork
    {
        ILoginRepository LoginRepository { get; }

        IDocumentoRepository DocumentoRepository { get; }
        IEmpleadoRepository EmpleadoRepository { get; }
        IHorarioRepository HorarioRepository { get; }
        IMarcaRepository MarcaRepository {  get; }
        IDiarioRepository DiarioRepository { get; }

    }
}
