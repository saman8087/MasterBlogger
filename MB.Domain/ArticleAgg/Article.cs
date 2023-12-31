﻿using MB.Domain.ArticleCategoryAgg;
using System;


namespace MB.Domain.ArticleAgg
{
    public class Article
    {
        public long Id { get;  private set; }
        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string Image { get; private set; }
        public string Content { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }
        public long ArticleCategoryId { get; private set; }
        public ArticleCategory ArticleCategory { get; private set; }
        protected  Article()
        {
            
        }

        public Article(long articleCategoryID, string title, string shortDescription, string image, string content, long articleCategoryId, ArticleCategory articleCategory)
        {
            Title = title;
            ShortDescription = shortDescription;
            Image = image;
            Content = content;
            ArticleCategoryId = articleCategoryId;
            ArticleCategory = articleCategory;
            IsDeleted = false;
            CreationDate =DateTime.Now;
            articleCategoryID = articleCategoryId;
        }
    }
}
