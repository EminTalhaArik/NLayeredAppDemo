using Northwind.DataAcces.Concrete;
using Northwind.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager
    {
        ProductDal _productDal = new ProductDal();
        public List<Product> GetAll()
        {
            //Business Code
            return _productDal.GetAll();
        }
    }
}
