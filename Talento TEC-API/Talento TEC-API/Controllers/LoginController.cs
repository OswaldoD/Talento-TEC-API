using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using TalentoTECDataAccess;
using Talento_TEC_API.Models;

namespace Talento_TEC_API.Controllers
{
    public class LoginController : ApiController
    {
        public HttpResponseMessage Get()
        {
            using(TalentoTECEntities login = new TalentoTECEntities())
            {
                login.Configuration.ProxyCreationEnabled = false;

                var item = login.Verificacion_Login("sa", "as").ToString();
                //var item = login.ObtenerIDTipoOferta("Estudiante").ToList();

                return Request.CreateResponse(HttpStatusCode.OK, item);
                //return login.Verificacion_Login("asd","asd").ToString();
            }
        }
        public TipoOferta Get(int id)
        {
            using(TalentoTECEntities login = new TalentoTECEntities())
            {
                login.Configuration.ProxyCreationEnabled = false;

                return login.TipoOfertas.FirstOrDefault(e => e.ID_TIPO_OFERTA == id);
            }
        }
        public HttpResponseMessage Post([FromBody] VerificaLogin parametros)
        {
            /* Método que obtiene la información de inicio de sesion */
            /*{"user":"any", "password":"any2"}*/
            try
            {
                using (TalentoTECEntities login = new TalentoTECEntities())
                {
                    login.Configuration.ProxyCreationEnabled = false;
                    var item = login.Verificacion_Login(parametros.username, parametros.password).ToList();

                    if (item.Count > 0)
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
