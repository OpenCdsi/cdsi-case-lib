using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCdsi.Cases;

namespace OpenCdsi.UnitTests
{
    [TestClass]
    public class CaseTests
    {
        const string TESTCASE_RESOURCE_VERSION = "4.28";
        const string TID = "2013-0083";
        const int NUM_TESTS = 928;

        [TestMethod]
        public void CheckResourceVersionNumber()
        {
            Assert.AreEqual(TESTCASE_RESOURCE_VERSION, Metadata.ResourceVersion);
        }

        [TestMethod]
        public void CanGetANamedTestcase()
        {
            var sut = CaseLibrary.Cases[TID];
            Assert.IsInstanceOfType(sut, typeof(testcase));
            Assert.AreEqual(sut.CdcTestId, TID);
        }

        [TestMethod]
        public void ThereAreNumTestcases()
        {
            Assert.AreEqual(NUM_TESTS, CaseLibrary.Cases.Count);
        }
    }
}
