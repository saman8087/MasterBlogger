using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArticleCategoryAgg.Services
{
    public interface IArticleCategoryValidatorService
    {
        void CheckthatthisRecordAlreadyExists(string title);
    }
    public class ArticleCategoryValidatorService : IArticleCategoryValidatorService
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository1;
        public ArticleCategoryValidatorService(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository1 = articleCategoryRepository;
        }
        public void CheckthatthisRecordAlreadyExists(string title)
        {
            if (_articleCategoryRepository1.Exists(title))
                throw new Exception();

        }


    }
}
