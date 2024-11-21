using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SwissMex.RazorPages.Data;
using SwissMex.RazorPages.Models;

namespace SwissMex.RazorPages.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext databaseCtx;

       
        public Category Category { get; set; } = null!;

        public CreateModel(ApplicationDbContext ctx)
        {
            this.databaseCtx = ctx;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost() 
        {
            if (Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("", "El Nombre no puede llamarse igual que la Prioridad");
            }

            if (ModelState.IsValid)
            {
                databaseCtx.Categories.Add(Category);

                databaseCtx.SaveChanges();

                TempData["success"] = "Categoría agregada correctamente!";
                return RedirectToPage("Index");
            }
            return Page();
        }

    }
}
