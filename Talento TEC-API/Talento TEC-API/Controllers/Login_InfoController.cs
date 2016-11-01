using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalentoTECDataAccess;
using Talento_TEC_API.Models;

namespace Talento_TEC_API.Controllers
{
    public class Login_InfoController : ApiController
    {
        public HttpResponseMessage Post([FromBody] InformacionCuenta cuenta)
        {
            /* Método que obtiene la información de la cuenta */
            /* {"Id":1,"TipoCuenta":"empresa"} */
            try
            {
                using (TalentoTECEntities login = new TalentoTECEntities())
                {
                    login.Configuration.ProxyCreationEnabled = false;

                    var item = login.ObtenerNombreUsuario(cuenta.Id, cuenta.TipoCuenta).ToList();
                    if (item != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, item);

                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound, item);
                    }
                    /*para cuando inserte*/
                    /* var message = Request.CreateResponse(HttpStatusCode.Created, parametros);
                    message.Headers.Location = new Uri(Request.RequestUri + parametros.username);*/
                }
            }
            catch (Exception error)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, error);
            }
        }
    }
}
