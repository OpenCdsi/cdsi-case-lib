using OpenCdsi.Cases;

namespace OpenCdsi
{
    public static partial class Library
    {
        public static IDictionary<string, testcase> Cases = Factories.CreateTestcaseMap();
    }
}
