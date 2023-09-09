using MB.Application.Contracs.Artcle;
using MB.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.EFCore.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly MasterBloggerContext _masterBloggerContext;

        public ArticleRepository(MasterBloggerContext masterBloggerContext)
        {
            _masterBloggerContext = masterBloggerContext;
        }

        public List<ArticleViewModel> GetList()
        {
            return _masterBloggerContext.Articles.Include(x=>x.ArticleCategory)
                .Select(x=> new ArticleViewModel
                {
                    Id = x.Id,
                    Title= x.Title,
                    ArticleCategory= x.ArticleCategory.Title ,
                    IsDeleted = x.IsDeleted,
                    CreationDate= x.CreationDate.ToString(CultureInfo.InvariantCulture)

                }).ToList();
        }
    }
}
