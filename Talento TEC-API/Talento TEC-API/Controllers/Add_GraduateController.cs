using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using TalentoTECDataAccess;
using Talento_TEC_API.Models.graduado;
using System.Web.Http;

namespace Talento_TEC_API.Controllers
{
    public class Add_GraduateController : ApiController
    {

        //POST Nuevo Graduado/Estudiante
        public HttpResponseMessage Post([FromBody] NewGraduate graduate)
        {
            try
            {
                using (TalentoTECEntities connect = new TalentoTECEntities())
                {
                    connect.Configuration.ProxyCreationEnabled = false;

                    var item = connect.AgregarAplicante(graduate.primerApellido,
                                                        graduate.segundoApellido,
                                                        graduate.nombre,
                                                        graduate.fechaNacimiento,
                                                        graduate.paisNacimiento,
                                                        graduate.nacionalidad,
                                                        graduate.tipoIdentificacion,
                                                        graduate.identificacion,
                                                        graduate.genero,
                                                        graduate.carne,
                                                        graduate.paisResidencia,
                                                        graduate.provincia,
                                                        graduate.direccionExacta,
                                                        graduate.telefono,
                                                        graduate.email,
                                                        graduate.password,
                                                        graduate.infoTitulos,
                                                        graduate.infoIdiomas,
                                                        graduate.infoExperienciaLaboral,
                                                        graduate.infoCapacitaciones,
                                                        graduate.conocimientos,
                                                        graduate.infoReferencias,
                                                        graduate.tipoAplicante);

                    if(item != null)
                    {
                        /* return Request.CreateResponse(HttpStatusCode.OK, item);*/
                        var message = Request.CreateResponse(HttpStatusCode.Created, graduate);
                        message.Headers.Location = new Uri(Request.RequestUri + graduate.primerApellido + " " + graduate.segundoApellido + " " + graduate.nombre);
                        return message;
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