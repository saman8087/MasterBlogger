using MB.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.EFCore.Mappings
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        void IEntityTypeConfiguration<Article>.Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title);
            builder.Property(x => x.ShortDescription);
            builder.Property(x => x.Content);
            builder.Property(x => x.CreationDate);
            builder.Property(x => x.IsDeleted);
            builder.Property(x => x.Title);
            builder.HasOne(x => x.ArticleCategory).WithMany(x => x.Articles).HasForeignKey(x => x.ArticleCategoryId);
        }
    }
}