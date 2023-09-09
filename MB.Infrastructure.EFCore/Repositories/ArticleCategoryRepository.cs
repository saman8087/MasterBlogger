using MB.Domain.ArticleCategoryAgg;
using System.Collections.Generic;
using System.Linq;

namespace MB.Infrastructure.EFCore.Repositories
{
	public class ArticleCategoryRepository : IArticleCategoryRepository
	{
		private readonly MasterBloggerContext _context;

		public ArticleCategoryRepository(MasterBloggerContext context) 
		{
			_context = context;
		}

		public void Add(ArticleCategory Entity)
		{
			_context.ArticleCategories.Add(Entity);
			Save();
		}

        public ArticleCategory Get(long id)
        {
            return _context.ArticleCategories.FirstOrDefault(x => x.Id == id);	
        }

        public List<ArticleCategory> GetAll()
		{
			return _context.ArticleCategories.ToList();

		}

        public void Save()
        {
			_context.SaveChanges();
        }
		public void Create(ArticleCategory Entity) 
		{
			_context.ArticleCategories.Add(Entity);
			Save();
		}

        public bool Exists(string title)
        {
           return  _context.ArticleCategories.Any(x => x.Title == title);
        }
    }
}
