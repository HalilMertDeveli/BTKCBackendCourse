using DevFramework.Core.Aspects.Postsharp;
using DevFramework.Core.Aspects.Postsharp.CacheAspects;
using DevFramework.Core.Aspects.Postsharp.LogAspects;
using DevFramework.Core.Aspects.Postsharp.TransacationAspects;
using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using DevFramework.Core.CrossCuttingConcers.Caching.Microsoft;
using DevFramework.Core.CrossCuttingConcers.Logging.Log4Net.Loggers;
using DevFramework.Core.CrossCuttingConcers.validation.FluentValidation;
using DevFramework.Core.DataAccess;
using DevFramework.Pubs.Businness.Abstract;
using DevFramework.Pubs.Businness.ValidationRules.FluentValidation;
using DevFramework.Pubs.DataAccess.Abstract;
using DevFramework.Pubs.Entities.Concrate;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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
        [CacheRemoveAspects(typeof(MemoryCacheManager))]
        public Product Add(Product product)
        {

            //ValidatorTool.FluentValidate(new ProductValidator(), product);//we can use like this but we will chose above
            return _productDal.Add(product);
            
        }

        [CacheAspect(typeof(MemoryCacheManager),120)]
        [LogAspect(typeof(DatabaseLogger))]
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
        [TransactionScopeAspect]
        public void TransactionalOperation(Product product1, Product product2)
        {
            using(TransactionScope scope = new TransactionScope())
            {
                
                    _productDal.Add(product1);
                    _productDal.Update(product2);
                    scope.Complete();
                
               
            }
        }
    }
}

