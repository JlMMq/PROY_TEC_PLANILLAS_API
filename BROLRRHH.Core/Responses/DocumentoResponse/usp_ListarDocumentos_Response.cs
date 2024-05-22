using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BROLRRHH.Core.Responses.DocumentoResponse
{
    public class usp_ListarDocumentos_Response
    {
        public string codDoc {  get; set; }
        public string descrCorta { get; set; }
        public string descrLarga { get; set; }
        public int longitud {  get; set; }
    }
}
