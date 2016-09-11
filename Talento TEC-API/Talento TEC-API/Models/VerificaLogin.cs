using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Talento_TEC_API.Models
{
    /* Modelo para pasar el parametro de verificar login como json */
    public class VerificaLogin
    {
        public string username { get; set; }

        public string password { get; set; }

    }
}