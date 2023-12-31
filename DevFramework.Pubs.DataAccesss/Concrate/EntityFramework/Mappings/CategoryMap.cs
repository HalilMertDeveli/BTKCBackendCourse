﻿using DevFramework.Pubs.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Pubs.DataAccess.Concrate.EntityFramework.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Categories", @"dbo");
            HasKey(x => x.CategoryId);


            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.CategoryName).HasColumnName("CategoryName");

        }
    }
}
