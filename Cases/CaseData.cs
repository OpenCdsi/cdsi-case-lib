using OpenCdsi.Cases;

namespace System
{
    public partial class Cdsi
    {
        private static IDictionary<string, testcase> _cases = Factories.CreateTestcaseMap();
        public static IDictionary<string, testcase> Cases => _cases;
    }
}
