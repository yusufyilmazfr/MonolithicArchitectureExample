using MonolithicArchitecture.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonolithicArchitecture.Business.Abstract
{
    public interface ICategoryManager
    {
        void Add(Category category);
        List<Category> GetList();
        void TransactionOperation();
    }
}
