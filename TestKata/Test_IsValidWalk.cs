using ArrayKata.IsValidWalk;
using NUnit.Framework;

namespace TestKata
{
    [TestFixture]
    public class Test_IsValidWalk
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, Array_IsValidWalk.IsValidWalk(new string[] {"n","s","n","s","n","s","n","s","n","s"}), "should return true");
            Assert.AreEqual(false, Array_IsValidWalk.IsValidWalk(new string[] {"w","e","w","e","w","e","w","e","w","e","w","e"}), "should return false");
            Assert.AreEqual(false, Array_IsValidWalk.IsValidWalk(new string[] {"w"}), "should return false");
            Assert.AreEqual(false, Array_IsValidWalk.IsValidWalk(new string[] {"n","n","n","s","n","s","n","s","n","s"}), "should return false");
        }

        [Test]
        public void Test_IsValidWalk_v2()
        {
            // Assert.AreEqual(true, Array_IsValidWalk.IsValidWalk_v2(new string[] {"n","s","n","s","n","s","n","s","n","s"}), "should return true");
            // Assert.AreEqual(false, Array_IsValidWalk.IsValidWalk_v2(new string[] {"w","e","w","e","w","e","w","e","w","e","w","e"}), "should return false");
            Assert.AreEqual(false, Array_IsValidWalk.IsValidWalk_v2(new string[] {"w"}), "should return false"); 
            Assert.AreEqual(false, Array_IsValidWalk.IsValidWalk_v2(new string[] {"n","n","n","s","n","s","n","s","n","s"}), "should return false");
        }
    }
}