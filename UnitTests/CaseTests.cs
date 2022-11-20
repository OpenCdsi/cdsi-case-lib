using OpenCdsi.Cases;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenCdsi.UnitTests
{
    [TestClass]
    public class CaseTests
    {
        const string TID = "2013-0083";
        const int NUM_TESTS = 928;

        [TestMethod]
        public void CanGetANamedTestcase()
        {
            var sut = Library.Cases[TID];
            Assert.IsInstanceOfType(sut, typeof(testcase));
            Assert.AreEqual(sut.CdcTestId,TID);
        }

        [TestMethod]
        public void ThereAreNumTestcases()
        {
            Assert.AreEqual(NUM_TESTS, Library.Cases.Count);
        }
    }
}
