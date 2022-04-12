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
    public class SchoolClassesRepoTests
    {
        [TestMethod()]
        public void pont2_SchoolClassesRepoGetSchoolClassIdTest()
        {
            SchoolClassesRepo schoolClassesRepo = new SchoolClassesRepo();
            int expected = 4;
            int actaul = schoolClassesRepo.GetSchoolClassId(10, 'b');

            Assert.AreEqual(expected, actaul, "Nem jól határozta meg az osztály id-jét!");
           
        }
    }
}