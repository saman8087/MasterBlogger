using MB.Application.Contracs.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace MB.Presentation.MVCCore.Areas.Administrator.Pages.ArticleCategoryManagment
{
    public class ListModel : PageModel
    {
        public List<ArticleCategoryViewModel> ArticleCategories { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;


        public ListModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;

        }

        public void OnGet()
        {
            ArticleCategories = _articleCategoryApplication.list();
        }
        public RedirectToPageResult OnpostRemove(long id)
        {
            _articleCategoryApplication.Remove(id);
            return RedirectToPage("./list");
         }
        public RedirectToPageResult OnpostActivate(long id)
        {
            _articleCategoryApplication.Activate(id);
            return RedirectToPage("./list");
        }
    }
      
}
