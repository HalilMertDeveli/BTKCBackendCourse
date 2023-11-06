using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Pubs.DataAccess.Abstract;
using DevFramework.Pubs.Entities.ComplexTypes;
using DevFramework.Pubs.Entities.Concrate;

namespace DevFramework.Pubs.DataAccess.Concrate.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, PubsContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetail()
        {
            using (PubsContext pubsContext = new PubsContext())
            {
                var result = from p in pubsContext.Products
                             join c in pubsContext.Categories on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }
        }
    }



}
 
