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
            newStu.Gpa = 4.21;
            Assert.AreEqual(newStu.Gpa, 0);
        }
    }
}