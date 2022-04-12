using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kreta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Models.Tests
{
    [TestClass()]
    public class SchollClassToStringTests
    {
        [TestMethod()]
        public void pont1_GradeToStringTest()
        {
            int grade = 11;
            char gradeType = 'c';
            SchoolClass schoolClass = new SchoolClass(1,grade, gradeType,1);

            string a = schoolClass.ToString();
            bool result = schoolClass.ToString().Contains(grade.ToString()); ;
            Assert.IsTrue(result,"Az évfolyam nem szerepel a kimenetben.");
        }

        [TestMethod()]
        public void pont1_GradeTypeToStringTest()
        {
            int grade = 11;
            char gradeType = 'c';
            SchoolClass schoolClass = new SchoolClass(1, grade, gradeType, 1);

            bool result = schoolClass.ToString().Contains(gradeType.ToString()); ;
            Assert.IsTrue(result,"Az osztály kódja nem szerepel a kimenetbe!");
        }
    }
}