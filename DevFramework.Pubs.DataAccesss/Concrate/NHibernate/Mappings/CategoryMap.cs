using DevFramework.Pubs.Entities.Concrate;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Pubs.DataAccess.Concrate.NHibernate.Mappings
{
    public class CategoryMap:ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Categories");

            LazyLoad();

            Id(x => x.CategoryId).Column("CategoryId");

            Map(x => x.CategoryName).Column("CategoryName");
        }
    }
}
