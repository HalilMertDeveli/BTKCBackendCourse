using DevFramework.Core.DataAccess;
using DevFramework.Pubs.Entities.ComplexTypes;
using DevFramework.Pubs.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Pubs.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetail();

    }
}
