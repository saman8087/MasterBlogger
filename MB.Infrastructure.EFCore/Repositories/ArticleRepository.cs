using MB.Domain.ArticleAgg;
using System;
using System.Collections.Generic;
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

       
    }
}
