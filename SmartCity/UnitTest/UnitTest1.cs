using System;
using System.Data.Entity;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Setup()
        {
            Database.SetInitializer(new DbInitializer());
            using (Context context = GetContext())
            {
                context.Database.Initialize(true);
            }
        }
        [TestMethod]
        public void InsertionFonctionnelle()
        {
            using (var context = GetContext())
            {
                Assert.AreEqual(1, context.Users.ToList().Count);
                Assert.AreEqual(2, context.CategoryInfrastructures.ToList().Count);
                Assert.AreEqual(0, context.CurrentLocations.ToList().Count);
                Assert.AreEqual(1, context.Infrastructures.ToList().Count);
                Assert.AreEqual(0, context.Likes.ToList().Count);
                Assert.AreEqual(1, context.TypeInfrastructures.ToList().Count);
            }
        }

        public Context GetContext()
        {
            return new Context();
        }



    }
}
