using Cdsi.Testcases;

namespace Cdsi
{
    public static partial class Library
    {
        public static IDictionary<string, testcase> Testcases = Factories.CreateTestcaseMap();
    }
}
