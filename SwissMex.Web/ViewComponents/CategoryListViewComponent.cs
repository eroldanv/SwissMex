using Microsoft.AspNetCore.Mvc;
using SwissMex.DataAccess.Repository.IRepository;

namespace SwissMex.Web.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryListViewComponent(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoriesList = await _unitOfWork.Category.GetAllAsync();
            return View(categoriesList);
        }

    }
}
