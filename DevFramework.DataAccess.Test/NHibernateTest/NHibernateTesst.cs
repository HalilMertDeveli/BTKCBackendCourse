using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.DataAccess.Test.NHibernateTest
{
    
    [TestClass]
    public class NHibernateTesst
    {
        [TestClass]
        public class EntityFrameworkTest
        {
            [TestMethod]
            public void Get_all_returns_all_product()
            {
                NhProductDal efProductDal = new NhProductDal(new SqlServerHelper());


                var result = efProductDal.GetList();
                Assert.AreEqual(77, result.Count);
            }
            [TestMethod]
            public void Get_all_with_parameter_returns_filtered_products()
            {
                NhProductDal efProductDal = new NhProductDal(new SqlServerHelper());


                var result = efProductDal.GetList(p => p.ProductName.Contains("ab"));
                Assert.AreEqual(77, result.Count);
            }
        }
    }
}
