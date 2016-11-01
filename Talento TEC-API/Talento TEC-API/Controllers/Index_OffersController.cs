using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalentoTECDataAccess;
using Talento_TEC_API.Models.oferta;

namespace Talento_TEC_API.Controllers
{
    public class Index_OffersController : ApiController
    {
        public HttpResponseMessage Post([FromBody] IndexOferta oferta)
        {
            try
            {
                using (TalentoTECEntities connect = new TalentoTECEntities())
                {
                    connect.Configuration.ProxyCreationEnabled = false;
                    var item = connect.BuscarOfertas(oferta.idAplicante, 
                                                     oferta.tipoCuenta, 
                                                     oferta.carreraSeleccionada, 
                                                     oferta.tipoBusqueda).ToList();

                    if(item.Count > 0)
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
