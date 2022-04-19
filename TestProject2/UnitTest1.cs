using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student newStu = new Student();
            newStu.Gpa = 4.21;
            Assert.AreEqual(newStu.Gpa, 4.00);
        }
    }
}
