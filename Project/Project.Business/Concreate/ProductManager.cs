using Project.Business.Abstract;
using Project.DataAccess.Abstract;
using Project.Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concreate
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal; 
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(productId);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(x => x.CategoryId == categoryId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
