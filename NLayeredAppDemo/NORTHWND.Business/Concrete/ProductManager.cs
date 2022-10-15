using NORTHWND.Business.Abstract;
using NORTHWND.Business.Utilities;
using NORTHWND.Business.ValidationRules.FluentValidation;
using NORTHWND.DataAccess.Abstract;
using NORTHWND.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWND.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        //ProductManager newlendiğinde bana bir IproductDal TÜRÜNDE NESNE VER

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Business Code

            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }
        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch
            {

                throw new Exception("Silme İşlemi Gerçekleşemedi");
            }

        }
    }
}
