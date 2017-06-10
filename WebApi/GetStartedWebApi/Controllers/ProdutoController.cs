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
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                Business.Services.ProdutosService service = new Business.Services.ProdutosService();
                Produto produto = new Produto();
                produto.Descricao = "Teste";
                produto.Preco = 3;
                service.Insert(produto);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }
    }
}
