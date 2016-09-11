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
    public class Add_OfferController : ApiController
    {
        public HttpResponseMessage Post([FromBody] InsertarOfertaLaboral oferta)
        {
            /* Método que obtiene la información de la cuenta */
            /* {"Id":1,"TipoCuenta":"empresa"} */
            try
            {
                using (TalentoTECEntities connect = new TalentoTECEntities())
                {
                    connect.Configuration.ProxyCreationEnabled = false;

                    var item = connect.Insertar_OfertasLaborales(oferta.IDEmpresa,
                                                                 oferta.nombrePuesto,
                                                                 oferta.descripcionPuesto,
                                                                 oferta.RequisitosPuesto,
                                                                 oferta.montoSalario,
                                                                 oferta.nombreTipoMoneda,
                                                                 oferta.fechaInicioOferta,
                                                                 oferta.fechaFinalOferta,
                                                                 oferta.nombreTipoOferta,
                                                                 oferta.nombreContacto,
                                                                 oferta.emailContacto,
                                                                 oferta.telefonoContacto,
                                                                 oferta.estadoOferta,
                                                                 oferta.estadoConfidencialidad,
                                                                 oferta.cantidadPlazas,
                                                                 oferta.carrerasProfesionales);
                    if (item != null)
                    {
                        /* return Request.CreateResponse(HttpStatusCode.OK, item);*/
                        var message = Request.CreateResponse(HttpStatusCode.Created, oferta);
                        message.Headers.Location = new Uri(Request.RequestUri + oferta.nombrePuesto);
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
