using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web.Http;
using TalentoTECDataAccess;
using Talento_TEC_API.Models.admin;

namespace Talento_TEC_API.Controllers
{
    public class LoginAdminController : ApiController
    {

        // Inicio de sesion de admin
        public HttpResponseMessage Post([FromBody] LoginAdmin parametros)
        {
            try
            {
                using(TalentoTECEntities connection = new TalentoTECEntities())
                {
                    connection.Configuration.ProxyCreationEnabled = false;
                    var item = connection.VerificarLoginAdministrador(parametros.Nombre_Usuario, parametros.Password_Usuario).ToList();
                    if(item != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, item);
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound, item);
                    }
                }
            }
            catch (Exception error)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, error);
            }
        }
    }
}
