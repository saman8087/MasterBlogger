using MB.Domain.ArticleAgg;
using MB.Domain.ArticleCategoryAgg.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArticleCategoryAgg
{
	public class ArticleCategory
	{
		public long Id { get; private set; }
		public string Title { get; private set; }
		public bool IsDeleted { get; private set; }
		public DateTime CreationDate { get; private set; }
		public ICollection<Article> Articles { get; private set; }
		public ArticleCategory(string title,IArticleCategoryValidatorService validatorservice)
		{
			validatorservice.CheckthatthisRecordAlreadyExists(title);
			Title = title;
			CreationDate = DateTime.Now;
			IsDeleted = false;
			Articles = new List<Article>();
		}
		public void Rename(string title)
		{
			Title = title;
		}
		public void Remove() 
		{
			IsDeleted = true;
		}
		public void Activate() 
		{
			IsDeleted = false;
		}
	}
}
