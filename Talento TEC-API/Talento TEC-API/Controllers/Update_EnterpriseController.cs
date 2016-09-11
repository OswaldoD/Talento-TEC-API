using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalentoTECDataAccess;
using Talento_TEC_API.Models.empresa;

namespace Talento_TEC_API.Controllers.empresa
{
    public class Update_EnterpriseController : ApiController
    {
        public void Get()
        {

        }

        public HttpResponseMessage Post([FromBody] ActualizaEmpresa empresa)
        {
            /* Método que obtiene la información de la cuenta */
            /* {"Id":1,"TipoCuenta":"empresa"} */
            try
            {
                using (TalentoTECEntities connect = new TalentoTECEntities())
                {
                    connect.Configuration.ProxyCreationEnabled = false;

                    var item = connect.ActualizarEmpresa(empresa.IDEmpresa,
                                                         empresa.nombreEmpresa,
                                                         empresa.cedulaJurídica,
                                                         empresa.direccion,
                                                         empresa.provincia,
                                                         empresa.nombrePais,
                                                         empresa.telefonoEmpresa,
                                                         empresa.emailEmpresa,
                                                         empresa.URL_Empresa,
                                                         empresa.nombreContactoEmpresa,
                                                         empresa.emailContacto,
                                                         empresa.puestoContacto,
                                                         empresa.telefonoEmpresa,
                                                         empresa.descripcionActividades,
                                                         empresa.nombreUsuario,
                                                         empresa.passwordUsuario,
                                                         empresa.nombreSectores);
                    if (item != null)
                    {
                        /* return Request.CreateResponse(HttpStatusCode.OK, item);*/
                        var message = Request.CreateResponse(HttpStatusCode.Created, empresa);
                        message.Headers.Location = new Uri(Request.RequestUri + empresa.nombreEmpresa);
                        return message;
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
