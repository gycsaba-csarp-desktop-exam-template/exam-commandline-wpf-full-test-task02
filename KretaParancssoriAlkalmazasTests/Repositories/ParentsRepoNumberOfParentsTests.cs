using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kreta.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Repositories.Tests
{
    [TestClass()]
    public class ParentsRepoNumberOfParentsTests
    {
        [TestMethod()]
        public void pont1_ParentsRepoTest()
        {
            ParentsRepo parentsRepo = new ParentsRepo();
            int expected = 4;
            int actual = parentsRepo.NumberOfParents;
            Assert.AreEqual(expected, actual,"Nem jól határozta meg a szülők számát!");
        }
    }
}