using SwissMex.DataAccess.Data;
using SwissMex.DataAccess.Repository.IRepository;
using SwissMex.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissMex.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category> ,ICategoryRepository
    {
        private readonly ApplicationDbContext context;

        public CategoryRepository(ApplicationDbContext appCtx) : base(appCtx)
        {
            this.context = appCtx;
        }

        public void Save()
        {
            this.context.SaveChanges();
        }

        public void Update(Category category)
        {
            this.context.Update(category);
        }
    }
}
