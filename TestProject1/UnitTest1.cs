using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleChapter14Demo;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Try_To_Skirt_LowGPA()
        {
            Student newStu = new Student();
            newStu.Gpa = 4.21;
            //Assert.AreEqual(newStu.Gpa, 4.00);
            Assert.AreEqual(newStu.Gpa, 0);
        }
    }
}