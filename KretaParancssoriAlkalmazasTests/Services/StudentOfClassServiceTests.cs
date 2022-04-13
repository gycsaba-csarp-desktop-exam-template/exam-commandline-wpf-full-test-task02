using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kreta.Services;
using Kreta.Models;

namespace Kreta.Services.Tests
{
    [TestClass()]
    public class StudentOfClassServiceTests
    {
        [TestMethod()]
        public void pont3_GetStudentOfClassTest()
        {
            StudentOfClassService studentOfClassService = new StudentOfClassService();
            List<int> expected = new List<int> { 1,10,6};
            SchoolClass schoolClass = new SchoolClass(2, 9, 'b', 0);
            List<Student> actual = studentOfClassService.GetStudentOfClass(schoolClass);
            int index = 0;
            foreach (int id in expected)
            {
                if (actual.ElementAt(index).Id != id)
                    Assert.Fail("Nem jól határozta meg az osztály diákjait vagy nem rendezte");
                index = index + 1;
            }
        }
    }
}