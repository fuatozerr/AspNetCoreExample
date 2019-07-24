using Project.Business.Abstract;
using Project.DataAccess.Abstract;
using Project.Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concreate
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

         public List<Category> GetAll()
        {

            return _categoryDal.GetList();
        }
    }
}
