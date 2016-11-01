using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Talento_TEC_API.Models.admin;
using TalentoTECDataAccess;

namespace Talento_TEC_API.Controllers
{
    public class Modify_DateController : ApiController
    {
        public HttpResponseMessage Post([FromBody] ModificarFecha fecha)
        {
            try
            {
                using (TalentoTECEntities connect = new TalentoTECEntities())
                {
                    connect.Configuration.ProxyCreationEnabled = false;

                    var item = connect.ModificarFechaImportante(fecha.idFecha, fecha.fecha, fecha.nombreActividad).ToString();

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
