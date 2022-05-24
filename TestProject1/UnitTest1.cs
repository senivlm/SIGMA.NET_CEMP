using NUnit.Framework;
using lerncs;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public void Test(string str, bool result)
        {
            Assert.AreEqual(result, Program.IsStringCorrect(str));
        }
        [Test]
        public void Test1()
        {
            Test("<<<}", false);
            Test("<<<}", true);
        }
        [Test]
        public void Test2()
        {
            Test("<<<>>>", true);
        }
        [Test]
        public void Test3()
        {
            Test("{AB(<>)C}", true);
        }
    }
}