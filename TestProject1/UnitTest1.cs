using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleChapter14Demo;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Try_To_Set_HighGPA()
        {
            Student newStu = new Student();
            newStu.Gpa = 4.20;
            Assert.AreEqual(newStu.Gpa, 0);
        }

        [TestMethod]
        public void Try_To_Set_LowGPA()
        {
            Student newStu = new Student();
            newStu.Gpa = -1.0;
            Assert.AreEqual(newStu.Gpa, 0);
        }
    }
}