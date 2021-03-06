﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalentoTECDataAccess;
using Talento_TEC_API.Models.admin;


namespace Talento_TEC_API.Controllers
{
    public class Change_State_EnterpriseController : ApiController
    {
        // GET: api/Change_State_Enterprise
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Change_State_Enterprise/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Change_State_Enterprise
        public HttpResponseMessage Post([FromBody]IDEnterprise parametros)
        {
            try
            {
                using (TalentoTECEntities connect = new TalentoTECEntities())
                {
                    connect.Configuration.ProxyCreationEnabled = false;

                    var item = connect.CambiarEstadoEmpresa(parametros.IDEmpresa, parametros.NuevoEstado).ToString();
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

        // PUT: api/Change_State_Enterprise/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Change_State_Enterprise/5
        public void Delete(int id)
        {
        }
    }
}
