using Business.Contexts;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Business.Repositories
{
    public class ProdutosRepository : GenericRepository<Produto>
    {

        public ProdutosRepository() : base(new WebApiContext())
        {
            DbContext.Configuration.ProxyCreationEnabled = false;

        }
        public void Insert(Produto prod)
        {

            using (DbContextTransaction t = base.DbContext.Database.BeginTransaction())
            {
                DbContext.Set<Produto>().Add(prod);
                DbContext.SaveChanges();
                t.Commit();
            }
        }
        public void Update(Produto prod)
        {

            using (DbContextTransaction t = base.DbContext.Database.BeginTransaction())
            {
                DbContext.Entry(prod).State = EntityState.Modified;
                DbContext.SaveChanges();

                t.Commit();

            }
        }

        internal List<Produto> GetAll()
        {

            WebApiContext context = (WebApiContext)base.DbContext;

            List<Produto> lstprod = null;
            lstprod = (from o in context.Produtos select o)
                        .ToList();

            return lstprod;
        }
    }
}