using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletosApp.Domain.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        // Otras propiedades comunes a todas las entidades.
    }

}
