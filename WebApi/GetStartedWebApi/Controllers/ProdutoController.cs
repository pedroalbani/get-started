using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GetStartedWebApi.Controllers
{
     public class ProdutoController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Insert(Produto prod)
        {
            try
            {
                Business.Services.ProdutosService service = new Business.Services.ProdutosService();
                
                service.Insert(prod);
                return Ok(prod);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpGet]
        public IHttpActionResult ListAll()
        {
            try
            {
                Business.Services.ProdutosService service = new Business.Services.ProdutosService();
                return Ok(service.GetAll());
            }
            catch (Exception e)
            {

                return InternalServerError(e);
            }
        }

        [HttpPut]
        public IHttpActionResult Update(Produto prod)
        {
            try
            {
                Business.Services.ProdutosService service = new Business.Services.ProdutosService();
               

                service.Update(prod);
                return Ok(prod);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
