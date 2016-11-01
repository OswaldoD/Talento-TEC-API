using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talento_TEC_API.Models.oferta
{
    public class IndexOferta
    {
        public int idAplicante { get; set; }

        public string tipoCuenta { get; set; }

        public string carreraSeleccionada { get; set; }

        public int tipoBusqueda { get; set; }
    }
}