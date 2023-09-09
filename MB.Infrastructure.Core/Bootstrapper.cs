using MB.Application;
using MB.Application.Contracs.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Infrastructure.EFCore;
using MB.Infrastructure.EFCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using MB.Application.Contracs.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Infrastructure.EFCore.Repositories;
using MB.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Core
{
	public class Bootstrapper
	{
		public static void Config(IServiceCollection services, string connectionstring)
		{
			services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
			services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
			services.AddDbContext<MasterBloggerContext>(options =>
			options.UseSqlServer(connectionstring));
		}
        
    }
}
