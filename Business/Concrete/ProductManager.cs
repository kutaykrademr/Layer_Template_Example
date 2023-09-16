using Business.Abstract;
using DataAccess_Layer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDataAccessLayer _productDataAccessLayer;

        public ProductManager(IProductDataAccessLayer productDal)
        {
            _productDataAccessLayer = productDal;
        }


        public List<Product> GetAll()
        {
           return _productDataAccessLayer.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDataAccessLayer.GetList(x => x.CategoryId == categoryId);
        }

        public void Add(Product product)
        {
            _productDataAccessLayer.Add(product);
        }

        public void Delete(int productId)
        {
            _productDataAccessLayer.Delete(new Product { ProductId = productId});
        }

        public void Update(Product product)
        {
            _productDataAccessLayer.Update(product);
        }
    }
}
