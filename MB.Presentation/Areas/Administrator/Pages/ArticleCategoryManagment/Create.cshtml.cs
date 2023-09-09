using MB.Application.Contracs.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Administrator.Pages.ArticleCategoryManagment
{
    public class CreateModel : PageModel
    {
        private readonly IArticleCategoryApplication _ArticleCategoryapplication;

        public CreateModel(IArticleCategoryApplication articleCategoryapplication)
        {
            _ArticleCategoryapplication = articleCategoryapplication;
        }

        public void OnGet()
        {
        }
        public RedirectToPageResult OnPost(CreateArticleCategory command) 
        { 
            _ArticleCategoryapplication.Create(command);
            return RedirectToPage("./List");
        }
    }
}
