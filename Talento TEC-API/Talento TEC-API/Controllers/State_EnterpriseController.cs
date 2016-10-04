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
        // GET: api/State_Enterprise
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/State_Enterprise/5
        public string Get(int id)
        {
            return "value";
        }

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

        // PUT: api/State_Enterprise/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/State_Enterprise/5
        public void Delete(int id)
        {
        }
    }
}
