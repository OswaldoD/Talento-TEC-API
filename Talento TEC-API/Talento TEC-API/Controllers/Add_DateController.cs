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
    public class Add_DateController : ApiController
    {
        public HttpResponseMessage Post([FromBody] NuevaFecha fecha)
        {
            try
            {
                using (TalentoTECEntities connect = new TalentoTECEntities())
                {
                    connect.Configuration.ProxyCreationEnabled = false;

                    var item = connect.AgregarFechaImportante(fecha.fecha, fecha.nombreActividad).ToList();

                    if (item.Count > 0)
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
