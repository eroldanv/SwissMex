using SwissMex.DataAccess.Data;
using SwissMex.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissMex.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }

        private readonly ApplicationDbContext context;

        public UnitOfWork(ApplicationDbContext appCtx, ICategoryRepository categoryRepository,
                                                       IProductRepository productRepository)
        {
            this.context = appCtx;
            this.Category = categoryRepository;
            this.Product = productRepository;
        }

        public void Save()
        {
            this.context.SaveChanges();
        }
    }
}
