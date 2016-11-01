using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalentoTECDataAccess;
using Talento_TEC_API.Models.empresa;

namespace Talento_TEC_API.Controllers
{
    public class Get_Offer_EnterpriseController : ApiController
    {
        // GET: api/Get_Offer_Enterprise/5
        public HttpResponseMessage Get(int id)
        {
            try
            {
                using (TalentoTECEntities connect = new TalentoTECEntities())
                {
                    connect.Configuration.ProxyCreationEnabled = false;

                    var item = connect.ObtenerDatosOfertas(id).ToList(); // cambiar el ""
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

        // POST: api/Get_Offer_Enterprise
        public HttpResponseMessage Post([FromBody] GetOfertaEmpresa parametros)
        {
            try
            {
                using (TalentoTECEntities connect = new TalentoTECEntities())
                {
                    connect.Configuration.ProxyCreationEnabled = false;

                    var item = connect.ObtenerOfertasXEmpresa(parametros.IDEmpresa).ToList();
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
