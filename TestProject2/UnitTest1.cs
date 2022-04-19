using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleChapter14Demo;
namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student myStudent = new Student();
            myStudent.Gpa = 4.21;
            Assert.AreEqual(myStudent.Gpa, 0);
            //Fixed Test!
        }
    }
}
