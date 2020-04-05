using MonolithicArchitecture.Business.Abstract;
using MonolithicArchitecture.Business.Concrete;
using MonolithicArchitecture.DataAccess.Concrete.EntityFramework;
using MonolithicArchitecture.Entities;
using System;

namespace MonolithicArchitecture.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var categoryManager = new CategoryManager(new EfCategoryDal());

            var category = new Category
            {
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Description = "Bu bir kategori",
                Name = "Telefon"
            };

            categoryManager.Add(category);
        }
    }
}
