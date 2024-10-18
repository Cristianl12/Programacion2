using BoletosApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletosApp.Domain.Entities
{
    public class Bus : BaseEntity
    {
        public string Modelo { get; set; }
        public int Capacidad { get; set; }
        // Otros detalles relevantes.
    }

}
