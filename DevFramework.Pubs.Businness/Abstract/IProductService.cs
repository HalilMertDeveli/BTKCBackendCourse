using DevFramework.Pubs.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Pubs.Businness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        Product GetById(int id);

        Product Add(Product product);
        Product Update(Product product);
    }
}
