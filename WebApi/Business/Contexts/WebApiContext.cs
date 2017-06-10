using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Business.Contexts
{
    public class WebApiContext : ProjectContext
    {
        public DbSet<Produto> Produtos { get; set; }

    }
}