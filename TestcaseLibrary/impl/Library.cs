using Cdsi.Testcases;

namespace Cdsi
{
    public static class Library
    {
        public static IDictionary<string, testcase> Testcases = Factories.CreateTestcaseMap();
    }
}
