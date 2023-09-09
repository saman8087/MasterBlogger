using MB.Domain.ArticleAgg;
using MB.Domain.ArticleCategoryAgg;
using MB.Infrastructure.EFCore.Mappings;
using MB.Infrastructure.EFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace MB.Infrastructure.EFCore
{

	public class MasterBloggerContext : DbContext
	{
		public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public MasterBloggerContext(DbContextOptions options) : base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.ApplyConfiguration(new ArticleMapping());
            modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
			base.OnModelCreating(modelBuilder);
		}
      
       
    }
}
