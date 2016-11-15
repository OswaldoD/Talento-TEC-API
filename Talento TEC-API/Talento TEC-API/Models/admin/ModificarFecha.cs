using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talento_TEC_API.Models.admin
{
    public class ModificarFecha
    {
        public int idFecha { get; set; }
        public string fecha { get; set; }
        public string nombreActividad { get; set; }
        public string descripcion { get; set; }
    }
}