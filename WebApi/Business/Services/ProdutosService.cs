using Business.Entities;
using Business.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace Business.Services
{
    public class ProdutosService
    {

        public HttpStatusCode Insert(Produto prod)
        {
      
            using (Repositories.ProdutosRepository repository = new Repositories.ProdutosRepository())
            {
                repository.Insert(prod);
            }

            return HttpStatusCode.OK;


        }

        public List<Produto> GetAll()
        {
            List<Produto> prod = new List<Produto>();
            using (ProdutosRepository repository = new ProdutosRepository())
            {
                prod = repository.GetAll();
            }

            return prod;
        }
    }
}