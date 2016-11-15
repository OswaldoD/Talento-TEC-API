using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalentoTECDataAccess;
using Talento_TEC_API.Models.talentotec;


namespace Talento_TEC_API.Controllers
{
    public class CoordinatorsController : ApiController
    {

        public HttpResponseMessage Post([FromBody] school escuela)
        {
            /* Método que obtiene la lista de carreras */
            /*{"user":"any", "password":"any2"}*/
            try
            {
                using (TalentoTECEntities connect = new TalentoTECEntities())
                {
                    connect.Configuration.ProxyCreationEnabled = false;

                    var item = connect.ObtenerListaCoordinadoresXEscuela(escuela.nombreEscuela).ToList();
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
