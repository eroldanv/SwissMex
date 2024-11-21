using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SwissMex.RazorPages.Data;
using SwissMex.RazorPages.Models;

namespace SwissMex.RazorPages.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext databaseCtx;
        public List<Category> Categories { get; set; } = null!;

        public IndexModel(ApplicationDbContext ctx)
        {
            this.databaseCtx = ctx;
            
        }
        public void OnGet()
        {
            Categories = databaseCtx.Categories.ToList();
        }
    }
}
