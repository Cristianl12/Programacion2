using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletosApp.Domain.Result
{
    public class OperationResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        // Detalles adicionales sobre el resultado.
    }

}
