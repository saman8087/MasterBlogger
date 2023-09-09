using MB.Application.Contracs.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.ArticleCategoryAgg.Services;
using MB.Infrastructure.EFCore.Repositories;
using System.Collections.Generic;
using System.Globalization;

namespace MB.Application
{
	public class ArticleCategoryApplication : IArticleCategoryApplication
	{
		private readonly IArticleCategoryRepository _articleCategoryRepository;
        private readonly IArticleCategoryValidatorService _articleCategoryValidatorService;	
		public void Rename(RenameArticleCategory command)
        {
            var articlecategory = _articleCategoryRepository.Get(command.Id);
			articlecategory.Rename(command.Title);
			_articleCategoryRepository.Save();
        }
        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository)
		{
			_articleCategoryRepository = articleCategoryRepository;
		}

        public void Create(CreateArticleCategory command)
        {
			var _articleCategory = new ArticleCategory(command.Title, _articleCategoryValidatorService);
			_articleCategoryRepository.Add(_articleCategory);
        }

        public List<ArticleCategoryViewModel> list()
		{
			var articlecategories = _articleCategoryRepository.GetAll();
			var result = new List<ArticleCategoryViewModel>();
			foreach (var articlecategory in articlecategories)
			{
				result.Add(new ArticleCategoryViewModel
				{
					Id = articlecategory.Id,
					Title = articlecategory.Title,
					IsDeleted = articlecategory.IsDeleted,
					CreationDate = articlecategory.CreationDate.ToString(CultureInfo.InvariantCulture),


				});
			}
			return result;
		}

        public RenameArticleCategory Get(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
			return new RenameArticleCategory
			{
				Id = articleCategory.Id,
				Title = articleCategory.Title
			};
        }
        public void Remove(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id); 
			articleCategory.Remove();
			_articleCategoryRepository.Save();
		}

        public void Activate(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Activate();
            _articleCategoryRepository.Save();
        }

      
    }
}
