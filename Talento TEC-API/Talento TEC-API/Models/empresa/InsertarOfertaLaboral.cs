using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talento_TEC_API.Models.empresa
{
    public class InsertarOfertaLaboral
    {
        public int IDEmpresa { get; set; }
        public string nombrePuesto { get; set; }
        public string descripcionPuesto { get; set; }
        public string RequisitosPuesto { get; set; }
        public float montoSalario { get; set; }
        public string nombreTipoMoneda { get; set; }
        public string fechaInicioOferta { get; set; }
        public string fechaFinalOferta { get; set; }
        public string nombreTipoOferta { get; set; }
        public string nombreContacto { get; set; }
        public string emailContacto { get; set; }
        public string telefonoContacto { get; set; }
        public string estadoOferta { get; set; }
        public string estadoConfidencialidad { get; set; }
        public int cantidadPlazas { get; set; }
        public string carrerasProfesionales { get; set; }

    }
}