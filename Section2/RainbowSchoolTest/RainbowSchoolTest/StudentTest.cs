using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchoolTest
{
    [TestFixture]
    public class StudentTest
    {
        [Test]
        public void TestStudent()
        {
            Student student = new Student();
            student.Id = 501;
            student.Name = "Anu";
            student.Class = 5;
            int studentId = student.Id;
            string studentName = student.Name;
            int studentClass = student.Class;
            Assert.AreEqual(501, studentId);
            Assert.AreEqual("Anu", studentName);
            Assert.AreEqual(5, studentClass);

        }
        [Test]
        public void StudentExists()
        {
            Student student = new Student();
            Assert.NotNull(student);
        }
    }
}
