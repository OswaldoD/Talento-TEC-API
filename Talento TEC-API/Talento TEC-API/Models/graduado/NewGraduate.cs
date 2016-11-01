using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talento_TEC_API.Models.graduado
{
    public class NewGraduate
    {
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string nombre { get; set; }
        public string fechaNacimiento { get; set; }
        public string paisNacimiento { get; set; }
        public string nacionalidad { get; set; }
        public string tipoIdentificacion { get; set; }
        public string identificacion { get; set; }
        public string genero { get; set; }
        public string carne { get; set; }
        public string paisResidencia { get; set; }
        public string provincia { get; set; }
        public string direccionExacta { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string infoTitulos { get; set; }
        public string infoIdiomas { get; set; }
        public string infoExperienciaLaboral { get; set; }
        public string infoCapacitaciones { get; set; }
        public string conocimientos { get; set; }
        public string infoReferencias { get; set; }
        public string tipoAplicante { get; set; }

    }
}