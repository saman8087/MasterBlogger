using MB.Application;
using MB.Application.Contracs.Artcle;
using MB.Application.Contracs.ArticleCategory;
using MB.Domain.ArticleAgg;
using MB.Domain.ArticleCategoryAgg;
using MB.Infrastructure.EFCore;
using MB.Infrastructure.EFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrastructure.Core
{
	public class Bootstrapper
	{
		public static void Config(IServiceCollection services, string connectionstring)
		{
			//ArticleCategory
			services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
			services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
			//Article
            services.AddTransient<IArticleApplication, ArticleApplication>();
            services.AddTransient<IArticleRepository, ArticleRepository>();


            services.AddDbContext<MasterBloggerContext>(options =>
			options.UseSqlServer(connectionstring));

		}
        
    }
}
