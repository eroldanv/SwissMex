using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SwissMex.RazorPages.Data;
using SwissMex.RazorPages.Models;

namespace SwissMex.RazorPages.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext databaseCtx;


        public Category Category { get; set; } = null!;
        ///public int? Id { get; set; }

        public DeleteModel(ApplicationDbContext ctx)
        {
            this.databaseCtx = ctx;
        }

        public IActionResult OnGet(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            this.Category = databaseCtx.Categories.FirstOrDefault(x => x.Id == id)!;

            return Page();

        }

        public IActionResult OnPost()
        {
            Category? category = databaseCtx.Categories.FirstOrDefault(x => Category.Id == x.Id);

            if (category is null)
            {
                return NotFound();
            }
            this.databaseCtx.Categories.Remove(category);
            databaseCtx.SaveChanges();


            TempData["success"] = "Categoría borrada correctamente!";
            return RedirectToPage("Index");

        }
    }
}
