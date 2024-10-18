using BoletosApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletosApp.Domain.Entities.Configuration
{
    public class Asiento : BaseEntity
    {
        public string Numero { get; set; }
        public bool Disponible { get; set; }
        // Otros detalles relevantes.
    }

}
