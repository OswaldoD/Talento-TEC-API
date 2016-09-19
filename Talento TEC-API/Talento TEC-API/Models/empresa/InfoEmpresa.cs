using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talento_TEC_API.Models
{
    public class InfoEmpresa
    {   /* Clase para que coincida el sp con Json */
        public string nombreEmpresa { get; set; }

        public string cedulaJuridica { get; set; }

        public string direccion { get; set; }

        public string provincia { get; set; }

        public string nombrePais { get; set; }

        public string telefonoEmpresa { get; set; }

        public string emailEmpresa { get; set; }

        public string URL_Empresa { get; set; }

        public string nombreContactoEmpresa { get; set; }

        public string emailContacto { get; set; }

        public string puestoContacto { get; set; }

        public string telefonoContacto { get; set; }

        public string descripcionActividades{ get; set; }

        public string nombreUsuario { get; set; }

        public string passwordUsuario { get; set; }

        public string nombreSectores { get; set; }

    }
}