using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Pubs.DataAccess.Abstract;
using DevFramework.Pubs.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Pubs.DataAccess.Concrate.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,PubsContext>,ICategoryDal
    {

    }
}
