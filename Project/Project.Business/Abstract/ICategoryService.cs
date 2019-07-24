using Project.Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();



    }
}
