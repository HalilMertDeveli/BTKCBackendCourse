using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Pubs.DataAccess.Abstract;
using DevFramework.Pubs.Entities.Concrate;


namespace DevFramework.Pubs.DataAccess.Concrate.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,PubsContext>,IProductDal
    {
        
    }



}
 
