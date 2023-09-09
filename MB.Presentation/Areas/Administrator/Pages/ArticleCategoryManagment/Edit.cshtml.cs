using MB.Application;
using MB.Application.Contracs.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Administrator.Pages.ArticleCategoryManagment
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public RenameArticleCategory ArticleCategory { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public EditModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet(long id)
        {
            ArticleCategory = _articleCategoryApplication.Get(id);
        }
        public RedirectToPageResult Onpost()
        {
            _articleCategoryApplication.Rename(ArticleCategory);
            return RedirectToPage("./list");
        }
    }
}
