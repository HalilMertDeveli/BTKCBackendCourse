using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.Pubs.DataAccess.Abstract;
using DevFramework.Pubs.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Pubs.DataAccess.Concrate.NHibernate
{
    public class NhProductDal: NHibernateRepositoryBase<Product>,IProductDal
    {
        public NhProductDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
        {
            
        }
    }
}
