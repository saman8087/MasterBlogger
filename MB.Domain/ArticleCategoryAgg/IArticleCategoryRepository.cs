using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArticleCategoryAgg
{
	public interface IArticleCategoryRepository
	{
		ArticleCategory Get(long id);
		List<ArticleCategory> GetAll();
		void Add(ArticleCategory Entity);
		void Save();
		bool Exists(string title);
	}
}
