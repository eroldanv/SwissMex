using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SwissMex.RazorPages.Data;
using SwissMex.RazorPages.Models;

namespace SwissMex.RazorPages.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext databaseCtx;


        public Category? Category { get; set; } = null!;
        ///public int? Id { get; set; }

        public EditModel(ApplicationDbContext ctx)
        {
            this.databaseCtx = ctx;
        }

        public IActionResult OnGet(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }            

            this.Category = databaseCtx.Categories.FirstOrDefault(x => x.Id == id);

            return Page();

        }

        public IActionResult OnPost() 
        {
            if (ModelState.IsValid && Category != null)
            {
                databaseCtx.Categories.Update(Category);

                databaseCtx.SaveChanges();

                TempData["success"] = "Categoría actualizada correctamente!";
                return RedirectToPage("/Categories/Index");

            }
            return Page();

        }
    }
}
