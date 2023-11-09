using DevFramework.Core.DataAccess;
using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Core.DataAccess.NHibernate;
using DevFramework.Pubs.Businness.Abstract;
using DevFramework.Pubs.Businness.Concrate.Managers;
using DevFramework.Pubs.DataAccess.Abstract;
using DevFramework.Pubs.DataAccess.Concrate.EntityFramework;
using DevFramework.Pubs.DataAccess.Concrate.NHibernate.Helpers;
using DevFramework.Pubs.Entities.Concrate;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Pubs.Businness.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<PubsContext>();

            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }
}
