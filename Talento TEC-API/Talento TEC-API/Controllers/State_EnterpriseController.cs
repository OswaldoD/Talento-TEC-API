using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalentoTECDataAccess;
using Talento_TEC_API.Models.admin;

namespace Talento_TEC_API.Controllers
{
    public class State_EnterpriseController : ApiController
    {
        // POST: api/State_Enterprise
        public HttpResponseMessage Post([FromBody]EstadoEmpresa parametros)
        {
            try
            {
                using(TalentoTECEntities connect = new TalentoTECEntities())
                {
                    connect.Configuration.ProxyCreationEnabled = false;
                    var item = connect.ObtenerEmpresasXEstado(parametros.NombreEstado).ToList();
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
            catch(Exception error)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, error);
            }
        }
    }
}
