using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _inMemoryProductDal;

        public ProductManager(IProductDal inMemoryProductDal)
        {
            _inMemoryProductDal = inMemoryProductDal;
        }

        public List<Product> GetAll()
        {
            return _inMemoryProductDal.GetAll();
        }
    }
}
