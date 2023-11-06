using DevFramework.Core.Aspects.Postsharp;
using DevFramework.Core.CrossCuttingConcers.validation.FluentValidation;
using DevFramework.Pubs.Businness.Abstract;
using DevFramework.Pubs.Businness.ValidationRules.FluentValidation;
using DevFramework.Pubs.DataAccess.Abstract;
using DevFramework.Pubs.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Pubs.Businness.Concrate.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;//we are using for communicate other layers

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [FluentValidationAspects(typeof(ProductValidator))]
        public Product Add(Product product)
        {

            //ValidatorTool.FluentValidate(new ProductValidator(), product);//we can use like this but we will chose above
            return _productDal.Add(product);
            
        }
        [FluentValidationAspects(typeof(ProductValidator))]

        public List<Product> GetAll()
        {
            return _productDal.GetList();

        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
