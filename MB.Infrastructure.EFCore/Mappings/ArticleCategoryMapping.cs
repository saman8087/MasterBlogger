﻿using MB.Domain.ArticleCategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.EFCore.Mappings
{
	public class ArticleCategoryMapping : IEntityTypeConfiguration<ArticleCategory>
	{
		public void Configure(EntityTypeBuilder<ArticleCategory> builder)
		{
			builder.ToTable("ArticleCategory");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Title);
			builder.Property(x => x.CreationDate);
			builder.Property(x => x.IsDeleted);
			builder.HasMany(x=>x.Articles).WithOne(x=>x.ArticleCategory).HasForeignKey(x=>x.ArticleCategoryId);
		}
	}
}
