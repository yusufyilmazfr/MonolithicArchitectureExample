using MonolithicArchitecture.Business.Abstract;
using MonolithicArchitecture.DataAccess.Abstract;
using MonolithicArchitecture.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonolithicArchitecture.Business.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            if (category == null 
                || String.IsNullOrEmpty(category.Name)
                || String.IsNullOrEmpty(category.Description))
            {
                return;
            }

            _categoryDal.Add(category);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetList();
        }
    }
}
